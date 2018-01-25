using System.Collections.Generic;
using System.Linq;
using DotNetify;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;

namespace SWLOR.Web.ViewModels
{
    public class FeaturesViewModel: BaseVM
    {
        public string Skills_itemkey => nameof(ProgressionSkills.SkillId);
        public IEnumerable<dynamic> Skills
        {
            get => Get<IEnumerable<dynamic>>();
            set => Set(value);
        }

        public string Abilities_itemkey => nameof(Data.Entities.Abilities.AbilityId);
        public IEnumerable<dynamic> Abilities
        {
            get => Get<IEnumerable<dynamic>>();
            set => Set(value);
        }

        public string Professions_itemkey => nameof(ProfessionsDomain.ProfessionId);

        public IEnumerable<dynamic> Professions
        {
            get => Get<IEnumerable<dynamic>>();
            set => Set(value);
        }


        public FeaturesViewModel(DataContext db)
        {
            Skills = db.ProgressionSkills.Where(x => !x.IsDisabled).OrderBy(x => x.Name)
                .Select(x => new
                {
                    SkillID = x.SkillId,
                    x.Name,
                    x.Description
                }).ToList();

            Abilities = db.Abilities.Where(x => x.IsActive).OrderBy(x => x.Name)
                .Select(x => new
                {
                    AbilityID = x.AbilityId,
                    x.Name,
                    x.Description,
                    ManaCost = x.BaseManaCost,
                    CategoryName = x.AbilityCategory.Name
                }).ToList();

            Professions = db.ProfessionsDomain.Where(x => x.IsActive).OrderBy(x => x.Name)
                .Select(x => new
                {
                    x.Name,
                    ProfessionID = x.ProfessionId,
                    x.Bonuses,
                    x.Description
                });
        }
    }
}
