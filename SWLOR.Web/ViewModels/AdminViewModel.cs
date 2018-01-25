using DotNetify;
using SWLOR.Web.Attributes;
using SWLOR.Web.Constants;
using SWLOR.Web.Models.Contracts;

namespace SWLOR.Web.ViewModels
{
    [RoleRequired(RoleType.Admin, RoleType.DM)]
    public class AdminViewModel: BaseVM
    {
        public AdminViewModel(ICurrentUser currentUser)
        {
            Role = currentUser.Role;
        }

        public RoleType Role
        {
            get => Get<RoleType>();
            set => Set(value);
        }
    }
}
