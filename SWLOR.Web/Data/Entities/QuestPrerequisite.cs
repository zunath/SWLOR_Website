namespace SWLOR.Web.Data.Entities
{
    public partial class QuestPrerequisite
    {
        public int ID { get; set; }
        public int QuestID { get; set; }
        public int RequiredQuestID { get; set; }

        public Quest Quest { get; set; }
        public Quest RequiredQuest { get; set; }
    }
}
