using System.Collections.Generic;
using System.Linq;
using DotNetify;
using SWLOR.Web.Data;
using SWLOR.Web.Models.UI.Skills;

namespace SWLOR.Web.ViewModels
{
    public class SkillsViewModel: BaseVM
    {
        private readonly DataContext _db;

        public string SkillList_itemkey => nameof(SkillUI.SkillCategoryID);
        public IEnumerable<SkillUI> SkillList
        {
            get => Get<IEnumerable<SkillUI>>();
            set => Set(value);
        }

        public string SkillCategoryList_itemkey => nameof(SkillCategoryUI.SkillCategoryID);
        public IEnumerable<SkillCategoryUI> SkillCategoryList
        {
            get => Get<IEnumerable<SkillCategoryUI>>();
            set => Set(value);
        }

        public int SelectedCategoryID
        {
            get => Get<int>();
            set
            {
                Set(value);
                LoadSkillList();
            }
        }

        public int SelectedSkillID
        {
            get => Get<int>();
            set
            {
                Set(value); 
                LoadSkill();
            }
        }

        public SkillUI SelectedSkill
        {
            get => Get<SkillUI>();
            set => Set(value);
        }

        public SkillsViewModel(DataContext db)
        {
            _db = db;

            SkillCategoryList = db.SkillCategory
                .Where(x => x.IsActive)
                .OrderBy(o => o.Sequence)
                .Select(o => new SkillCategoryUI
                {
                    SkillCategoryID = o.ID,
                    Name = o.Name,
                    IsActive = o.IsActive
                })
                .ToList();

            SelectedCategoryID = SkillCategoryList.First().SkillCategoryID;
            SelectedSkillID = SkillList.First().SkillID;
        }


        private void LoadSkillList()
        {
            SkillList = _db.Skill
                .Where(x => x.IsActive &&
                            x.SkillCategoryID == SelectedCategoryID)
                .OrderBy(o => o.ID)
                .Select(o => new SkillUI
                {
                    SkillID = o.ID, 
                    SkillCategoryID = o.SkillCategoryID, 
                    Name = o.Name,
                    Description = o.Description,
                    MaxRank = o.MaxRank,
                    PrimaryName = o.PrimaryAttribute.Name,
                    SecondaryName = o.SecondaryAttribute.Name,
                    TertiaryName = o.TertiaryAttribute.Name
                })
                .ToList();

            SelectedSkillID = SkillList.First().SkillID;
        }

        private void LoadSkill()
        {
            if (SelectedSkillID <= 0) return;

            SelectedSkill = SkillList
                .Single(x => x.SkillID == SelectedSkillID);
        }
    }
}
