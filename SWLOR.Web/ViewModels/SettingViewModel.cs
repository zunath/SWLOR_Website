using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities.Data;
using SWLOR.Web.ViewModels.BaseViewModels;

namespace SWLOR.Web.ViewModels
{
    public class SettingViewModel : GameTopicBaseVM
    {
        public SettingViewModel(DataContext db)
            : base(db)
        {
        }

        protected override int CategoryID => 1;
    }
}
