﻿using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;

namespace SWLOR.Web.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly DataContext _db;
        
        public AuthorizationController(DataContext db)
        {
            _db = db;
        }

        public IActionResult Login()
        {
            return Challenge(new AuthenticationProperties {RedirectUri = "/Authorization/Authorized"}, "Discord");
        }

        public IActionResult Logout()
        {
            return SignOut(new AuthenticationProperties { RedirectUri = "/" },
                CookieAuthenticationDefaults.AuthenticationScheme);
        }

        public IActionResult Authorized()
        {
            var claims = User.Claims.ToList();

            User user = new User
            {
                Username = claims.Where(x => x.Type == ClaimTypes.Name).Select(x => x.Value).Single(),
                DiscordUserID = claims.Where(x => x.Type == ClaimTypes.NameIdentifier).Select(x => x.Value).Single(),
                Email = claims.Where(x => x.Type == ClaimTypes.Email).Select(x => x.Value).Single(),
                Discriminator = claims.Where(x => x.Type == "Discriminator").Select(x => x.Value).Single(),
                AvatarHash = claims.Where(x => x.Type == "Avatar").Select(x => x.Value).SingleOrDefault()
            };

            if (user.AvatarHash == null)
                user.AvatarHash = string.Empty;

            User existingUser = _db.User.SingleOrDefault(x => x.DiscordUserID == user.DiscordUserID);
            if (existingUser == null)
            {
                user.RoleID = 3;
                _db.User.Add(user);
            }
            else
            {
                existingUser.Username = user.Username;
                existingUser.Discriminator = user.Discriminator;
                existingUser.Email = user.Email;
                existingUser.DiscordUserID = user.DiscordUserID;
                existingUser.AvatarHash = user.AvatarHash;

                user.ID = existingUser.ID;
            }

            _db.SaveChanges();

            return Redirect("/");
        }
    }
}