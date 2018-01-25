namespace SWLOR.Web.Data.Entities
{
    public partial class QuestPrerequisites
    {
        public int QuestPrerequisiteId { get; set; }
        public int QuestId { get; set; }
        public int RequiredQuestId { get; set; }

        public Quests Quest { get; set; }
        public Quests RequiredQuest { get; set; }
    }
}
