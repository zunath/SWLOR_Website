using System;
using System.Collections.Generic;
using System.Linq;
using DotNetify;
using Microsoft.EntityFrameworkCore;
using SWLOR.Web.Data;
using SWLOR.Web.Models.UI.Perks;

namespace SWLOR.Web.ViewModels
{
    public class PerksViewModel: BaseVM
    {
        private readonly DataContext _db;

        public string PerkList_itemkey => nameof(PerkUI.PerkCategoryID);
        public IEnumerable<PerkUI> PerkList
        {
            get => Get<IEnumerable<PerkUI>>();
            set => Set(value);
        }

        public string PerkCategoryList_itemkey => nameof(PerkCategoryUI.PerkCategoryID);
        public IEnumerable<PerkCategoryUI> PerkCategoryList
        {
            get => Get<IEnumerable<PerkCategoryUI>>();
            set => Set(value);
        }

        public int SelectedCategoryID
        {
            get => Get<int>();
            set
            {
                Set(value);
                LoadPerkList();
            }
        }

        public int SelectedPerkID
        {
            get => Get<int>();
            set
            {
                Set(value);
                LoadPerk();
            }
        }

        public bool IsInitialized
        {
            get => Get<bool>();
            set => Set(value);
        }

        public PerkUI SelectedPerk
        {
            get => Get<PerkUI>();
            set => Set(value);
        }

        public PerksViewModel(DataContext db)
        {
            _db = db;

            PerkCategoryList = db.PerkCategories
                .Where(x => x.IsActive)
                .OrderBy(o => o.Name)
                .Select(o => new PerkCategoryUI
                {
                    PerkCategoryID = o.PerkCategoryID,
                    Name = o.Name,
                })
                .ToList();

            SelectedCategoryID = PerkCategoryList.First().PerkCategoryID;
            SelectedPerkID = PerkList.First().PerkID;

            IsInitialized = true;
        }

        private void LoadPerkList()
        {
            PerkList = _db.Perks
                .Include(i => i.ExecutionType)
                .Include(i => i.CooldownCategory)
                .Include(i => i.PerkLevels)
                .ThenInclude(i => i.PerkLevelSkillRequirements)
                .ThenInclude(i => i.Skill)
                .Where(x => x.IsActive &&
                            x.PerkCategoryID == SelectedCategoryID)
                .OrderBy(o => o.Name)
                .Select(o => new PerkUI
                {
                    Name = o.Name,
                    PerkCategoryID = o.PerkCategoryID,
                    PerkLevels = o.PerkLevels.Select(pl => new PerkLevelUI
                    {
                        SkillRequirements = pl.PerkLevelSkillRequirements.Select(req => new PerkSkillRequirementUI
                        {
                            PerkLevelSkillRequirementID = req.PerkLevelSkillRequirementID,
                            SkillName = req.Skill.Name,
                            RequiredRank = req.RequiredRank
                        }),
                        Description = pl.Description,
                        Level = pl.Level,
                        PerkLevelID = pl.PerkLevelID,
                        Price = pl.Price
                    }),
                    Description = o.Description,
                    BaseActivationTime = Convert.ToSingle(o.BaseCastingTime),
                    BaseCooldownTime = o.CooldownCategory == null ? 0.0f : Convert.ToSingle(o.CooldownCategory.BaseCooldownTime),
                    BaseFPCost = o.BaseFPCost,
                    ExecutionTypeName = o.ExecutionType.Name,
                    PerkID = o.PerkID
                })
                .ToList();

            SelectedPerkID = PerkList.First().PerkID;
        }

        private void LoadPerk()
        {
            SelectedPerk = PerkList.Single(x => x.PerkID == SelectedPerkID);
        }
    }
}
