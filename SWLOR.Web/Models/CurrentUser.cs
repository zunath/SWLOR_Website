using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using SWLOR.Web.Constants;
using SWLOR.Web.Data;
using SWLOR.Web.Models.Contracts;

namespace SWLOR.Web.Models
{
    public class CurrentUser: ICurrentUser
    {
        private readonly ClaimsPrincipal _user;

        public CurrentUser(DataContext db,
            IHttpContextAccessor httpAccessor)
        {
            _user = httpAccessor.HttpContext.User;

            if (IsAuthenticated)
            {
                var dbUser = db.Users.Single(x => x.DiscordUserID == DiscordUserID);
                UserID = dbUser.UserID;
                Role = (RoleType) dbUser.RoleID;
            }
            else
            {
                UserID = -1;
                Role = RoleType.Unknown;
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return _user.HasClaim(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
            }
        }

        public long UserID { get; }
        public string Username => _user.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name");
        public string DiscordUserID => _user.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
        public string Email => _user.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress");
        public string Discriminator => _user.FindFirstValue("Discriminator");
        public string AvatarHash => _user.FindFirstValue("Avatar");
        public RoleType Role { get; }
    }
}
