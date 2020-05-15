using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;
using SWLOR.Web.Data.Entities.Data;
using SWLOR.Web.ViewModels.BaseViewModels;

namespace SWLOR.Web.ViewModels
{
    public class CharacterBackgroundViewModel : GameTopicBaseVM
    {
        public CharacterBackgroundViewModel(DataContext db)
            : base(db)
        {
        }

        protected override int CategoryID => 3;
    }
}
