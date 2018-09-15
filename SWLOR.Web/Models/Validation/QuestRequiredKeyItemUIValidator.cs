using FluentValidation;
using SWLOR.Web.Models.UI.QuestEditor;

namespace SWLOR.Web.Models.Validation
{
    public class QuestRequiredKeyItemUIValidator: AbstractValidator<QuestRequiredKeyItemUI>
    {
        public QuestRequiredKeyItemUIValidator()
        {
            RuleFor(x => x.RequiredKeyItemID)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(-1);
        }
    }
}
