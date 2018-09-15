using FluentValidation;
using SWLOR.Web.Models.UI.QuestEditor;

namespace SWLOR.Web.Models.Validation
{
    public class QuestRewardsUIValidator: AbstractValidator<QuestRewardsUI>
    {
        public QuestRewardsUIValidator()
        {
            RuleFor(x => x.Gold)
                .NotNull()
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(9999);

            RuleFor(x => x.XP)
                .NotNull()
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(9999);

            RuleFor(x => x.KeyItemID)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(-1);

            RuleFor(x => x.Fame)
                .NotNull()
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(999);

            RuleForEach(x => x.RewardItems)
                .SetValidator(new QuestRewardItemUIValidator());
        }
    }
}
