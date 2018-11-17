using SWLOR.Web.Data;
using SWLOR.Web.ViewModels.BaseViewModels;

namespace SWLOR.Web.ViewModels
{
    public class RulesViewModel: GameTopicBaseVM
    {
        public RulesViewModel(DataContext db) 
            : base(db)
        {
        }

        protected override int CategoryID => 7;
    }
}
