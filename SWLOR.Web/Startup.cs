using System.Linq;
using System.Threading.Tasks;
using DotNetify;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;
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
            services.AddDistributedMemoryCache();
            services.AddSignalR();
            services.AddDotNetify();

            services.AddDbContext<DataContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")),
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
            
            services.AddMvc();

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
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true,
                    ReactHotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                //var rewriterOptions = new RewriteOptions()
                //    .AddRedirectToHttps();
                //app.UseRewriter(rewriterOptions);
            }

            // MVC / Routing / Authentication
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            
            app.MapWhen(x => !x.Request.Path.Value.StartsWith("/dotnetify") &&
                             !x.Request.Path.Value.StartsWith("/forums"), builder =>
            {
                builder.UseMvc(routes =>
                {
                    routes.MapSpaFallbackRoute(
                        name: "spa-fallback",
                        defaults: new { controller = "Home", action = "Index" });
                });
            });
            
            // Dotnetify / SignalR / WebSockets
            app.UseWebSockets();
            app.UseSignalR(routes => routes.MapDotNetifyHub());
            app.UseDotNetify(config =>
            {
                config.UseMiddleware<AuthorizationMiddleware>();
            });
        }
    }
}
