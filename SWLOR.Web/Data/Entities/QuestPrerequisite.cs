namespace SWLOR.Web.Data.Entities
{
    public class QuestPrerequisite
    {
        public int QuestPrerequisiteID { get; set; }
        public int QuestID { get; set; }
        public int RequiredQuestID { get; set; }

        public Quests Quest { get; set; }
        public Quests RequiredQuest { get; set; }
    }
}
