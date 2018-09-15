using FluentValidation;
using SWLOR.Web.Data.Entities;

namespace SWLOR.Web.Models.Validation
{
    public class LootTableValidator: AbstractValidator<LootTable>
    {
        public LootTableValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(64);

            RuleForEach(x => x.LootTableItems)
                .SetValidator(new LootTableItemValidator());
        }

    }
}
