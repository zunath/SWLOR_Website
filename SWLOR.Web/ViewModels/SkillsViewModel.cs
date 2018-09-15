using System.Collections.Generic;
using System.Linq;
using DotNetify;
using Microsoft.EntityFrameworkCore;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;

namespace SWLOR.Web.ViewModels
{
    public class SkillsViewModel: BaseVM
    {
        private readonly DataContext _db;

        public string SkillList_itemkey => nameof(Skill.SkillCategoryID);
        public IEnumerable<Skill> SkillList
        {
            get => Get<IEnumerable<Skill>>();
            set => Set(value);
        }

        public string SkillCategoryList_itemkey => nameof(SkillCategory.SkillCategoryID);
        public IEnumerable<SkillCategory> SkillCategoryList
        {
            get => Get<IEnumerable<SkillCategory>>();
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

        public Skill SelectedSkill
        {
            get => Get<Skill>();
            set => Set(value);
        }

        public SkillsViewModel(DataContext db)
        {
            _db = db;

            SkillCategoryList = db.SkillCategories
                .Where(x => x.IsActive)
                .OrderBy(o => o.Sequence)
                .ToList();

            SelectedCategoryID = SkillCategoryList.First().SkillCategoryID;
            SelectedSkillID = SkillList.First().SkillID;
        }

        private void LoadSkillList()
        {
            SkillList = _db.Skills
                .Include(i => i.Primary)
                .Include(i => i.Secondary)
                .Include(i => i.Tertiary)
                .Where(x => x.IsActive &&
                            x.SkillCategoryID == SelectedCategoryID)
                .OrderBy(o => o.SkillID)
                .ToList();

            SelectedSkillID = SkillList.First().SkillID;
        }

        private void LoadSkill()
        {
            SelectedSkill = SkillList.Single(x => x.SkillID == SelectedSkillID);
        }
    }
}
