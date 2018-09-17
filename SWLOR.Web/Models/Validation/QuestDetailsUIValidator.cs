using FluentValidation;
using SWLOR.Web.Models.UI.QuestEditor;

namespace SWLOR.Web.Models.Validation
{
    public class QuestDetailsUIValidator: AbstractValidator<QuestDetailsUI>
    {
        public QuestDetailsUIValidator()
        {
            RuleFor(x => x.QuestID)
                .NotNull()
                .GreaterThanOrEqualTo(-1);

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(x => x.JournalTag)
                .NotNull()
                .NotEmpty()
                .MaximumLength(32);

            RuleFor(x => x.FameRegionID)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.RequiredFameAmount)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.AllowRewardSelection)
                .NotNull();

            RuleFor(x => x.IsRepeatable)
                .NotNull();

            RuleFor(x => x.MapNoteTag)
                .NotNull()
                .MaximumLength(32);

            RuleFor(x => x.StartKeyItemID)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(-1);

            RuleFor(x => x.RemoveStartKeyItemAfterCompletion)
                .NotNull();

            RuleFor(x => x.OnAcceptRule)
                .NotNull()
                .MaximumLength(32);
            
            RuleFor(x => x.OnAdvanceRule)
                .NotNull()
                .MaximumLength(32);
            
            RuleFor(x => x.OnCompleteRule)
                .NotNull()
                .MaximumLength(32);

            RuleFor(x => x.OnKillTargetRule)
                .NotNull()
                .MaximumLength(32);

            RuleForEach(x => x.PrerequisiteQuestIDs)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(1);

            RuleFor(x => x.Rewards)
                .SetValidator(new QuestRewardsUIValidator());

            RuleForEach(x => x.QuestStates)
                .SetValidator(new QuestStateUIValidator());
        }
    }
}
