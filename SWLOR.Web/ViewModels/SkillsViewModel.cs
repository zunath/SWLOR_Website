using System;
using System.Collections.Generic;
using System.Linq;
using DotNetify;
using Microsoft.EntityFrameworkCore;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;
using SWLOR.Web.Models.UI.Skills;

namespace SWLOR.Web.ViewModels
{
    public class SkillsViewModel: BaseVM
    {
        private readonly DataContext _db;

        public string SkillList_itemkey => nameof(Skill.SkillCategoryID);
        public IEnumerable<SkillModel> SkillList
        {
            get => Get<IEnumerable<SkillModel>>();
            set => Set(value);
        }

        public string SkillCategoryList_itemkey => nameof(SkillCategory.SkillCategoryID);
        public IEnumerable<dynamic> SkillCategoryList
        {
            get => Get<IEnumerable<dynamic>>();
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

        public SkillModel SelectedSkill
        {
            get => Get<dynamic>();
            set => Set(value);
        }

        public SkillsViewModel(DataContext db)
        {
            _db = db;

            SkillCategoryList = db.SkillCategories
                .Where(x => x.IsActive)
                .OrderBy(o => o.Sequence)
                .Select(o => new
                {
                    o.SkillCategoryID,
                    o.Name,
                    o.IsActive
                })
                .ToList();

            SelectedCategoryID = SkillCategoryList.First().SkillCategoryID;
            SelectedSkillID = SkillList.First().SkillID;
        }


        private void LoadSkillList()
        {
            SkillList = _db.Skills
                .Where(x => x.IsActive &&
                            x.SkillCategoryID == SelectedCategoryID)
                .OrderBy(o => o.SkillID)
                .Select(o => new SkillModel
                {
                    SkillID = o.SkillID, SkillCategoryID = o.SkillCategoryID, Name = o.Name,
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
