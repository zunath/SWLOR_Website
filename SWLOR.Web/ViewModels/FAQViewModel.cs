using SWLOR.Web.Data;
using SWLOR.Web.ViewModels.BaseViewModels;

namespace SWLOR.Web.ViewModels
{
    public class FAQViewModel: GameTopicBaseVM
    {
        public FAQViewModel(DataContext db) 
            : base(db)
        {
        }

        protected override int CategoryID => 4;
    }
}
