using System.Threading.Tasks;
using DotNetify;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Newtonsoft.Json;
using SWLOR.Web.Data;
using SWLOR.Web.Middleware;
using SWLOR.Web.Models;
using SWLOR.Web.Models.Contracts;

namespace SWLOR.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration,
            IHostingEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            HostingEnvironment = hostingEnvironment;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment HostingEnvironment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            services.AddMemoryCache();
            services.AddSignalR();
            services.AddDotNetify();
           
            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });

            services.AddDbContext<DataContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                },
                ServiceLifetime.Transient,
                ServiceLifetime.Transient);

            services.AddAuthentication(options =>
                {
                    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                })
                .AddCookie(options =>
                {
                    options.LoginPath = "/Authorization/Login";
                    options.LogoutPath = "/Authorization/Logout";
                })
                .AddDiscord(options =>
                {
                    options.ClientId = Configuration.GetValue<string>("DiscordOAuthClientID");
                    options.ClientSecret = Configuration.GetValue<string>("DiscordOAuthClientSecret");
                    options.CallbackPath = "/Authorization/Authenticated";
                    options.Scope.Add("identify email");
                    options.ClaimActions.Add(new JsonKeyClaimAction("Discriminator", typeof(string).ToString(), "discriminator"));
                    options.ClaimActions.Add(new JsonKeyClaimAction("Avatar", typeof(string).ToString(), "avatar"));

                    options.Events.OnRemoteFailure = (context) =>
                    {
                        if (context.Failure.Message.Contains("access_denied"))
                        {
                            context.Response.Redirect("/");
                        }

                        context.HandleResponse();
                        return Task.FromResult(0);
                    };
                });


            if (HostingEnvironment.IsProduction())
            {
                services.Configure<MvcOptions>(options =>
                {
                    //options.Filters.Add(new RequireHttpsAttribute());
                });
            }


            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ICurrentUser, CurrentUser>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Dev / Prod specific options.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            // Dotnetify / SignalR / WebSockets
            app.UseWebSockets();
            app.UseSignalR(routes => routes.MapDotNetifyHub());
            app.UseDotNetify(config =>
            {
                config.UseMiddleware<AuthorizationMiddleware>();
            });

            // MVC / Routing / Authentication
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
            
        }
    }
}
