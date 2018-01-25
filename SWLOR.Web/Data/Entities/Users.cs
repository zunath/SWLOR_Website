
namespace SWLOR.Web.Data.Entities
{
    public partial class Users
    {

        public long UserId { get; set; }
        public string DiscordUserId { get; set; }
        public string Username { get; set; }
        public string AvatarHash { get; set; }
        public string Discriminator { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }

        public DmroleDomain Role { get; set; }
    }
}
