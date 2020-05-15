using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities.Data;
using SWLOR.Web.Models.UI.Perks;

namespace SWLOR.Web.Controllers
{
    public class DataExportController : Controller
    {
        private readonly DataContext _db;

        public DataExportController(DataContext db)
        {
            _db = db;
        }

        public IActionResult Skills()
        {
            var skills = _db.Skill
                .Where(x => x.IsActive)
                .Select(s => new
                {
                    s.ID,
                    s.SkillCategoryID,
                    SkillCategory = s.SkillCategory.Name,
                    s.Name,
                    s.MaxRank,
                    s.Description,
                    PrimaryAttribute = s.Primary,
                    SecondaryAttribute = s.Secondary,
                    TertiaryAttribute = s.Tertiary,
                    s.ContributesToSkillCap
                });
            string json = JsonConvert.SerializeObject(skills, Formatting.Indented);

            return File(Encoding.UTF8.GetBytes(json),
                "application/json", 
                "SkillsExport.json");
        }

        public IActionResult Perks()
        {
            var perks = _db.Perk
                .Include(i => i.ExecutionType)
                .Include(i => i.CooldownCategory)
                .Include(i => i.PerkLevel)
                .ThenInclude(i => i.PerkLevelSkillRequirement)
                .ThenInclude(i => i.Skill)
                .Where(x => x.IsActive)
                .OrderBy(o => o.Name)
                .Select(o => new PerkUI
                {
                    Name = o.Name,
                    PerkCategoryID = o.PerkCategoryID,
                    PerkLevels = o.PerkLevel.Select(pl => new PerkLevelUI
                    {
                        SkillRequirements = pl.PerkLevelSkillRequirement.Select(req => new PerkSkillRequirementUI
                        {
                            PerkLevelSkillRequirementID = req.ID,
                            SkillName = req.Skill.Name,
                            RequiredRank = req.RequiredRank
                        }),
                        Description = pl.Description,
                        Level = pl.Level,
                        PerkLevelID = pl.ID,
                        Price = pl.Price
                    }),
                    Description = o.Description,
                    ExecutionTypeName = o.ExecutionType.Name,
                    PerkID = o.ID
                })
                .ToList();


            var settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.Indented;
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            string json = JsonConvert.SerializeObject(perks, Formatting.Indented);

            return File(Encoding.UTF8.GetBytes(json),
                "application/json",
                "PerksExport.json");
        }
    }
}