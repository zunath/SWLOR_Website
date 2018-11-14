using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class User
    {
        public int ID { get; set; }
        public string DiscordUserID { get; set; }
        public string Username { get; set; }
        public string AvatarHash { get; set; }
        public string Discriminator { get; set; }
        public string Email { get; set; }
        public int RoleID { get; set; }
        public DateTime DateRegistered { get; set; }

        public DMRole Role { get; set; }
    }
}
