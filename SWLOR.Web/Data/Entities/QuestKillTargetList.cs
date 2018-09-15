namespace SWLOR.Web.Data.Entities
{
    public class QuestKillTargetList
    {
        public int QuestKillTargetListID { get; set; }
        public int QuestID { get; set; }
        public int NPCGroupID { get; set; }
        public int Quantity { get; set; }
        public int QuestStateID { get; set; }

        public NPCGroup NPCGroup { get; set; }
        public Quests Quest { get; set; }
        public QuestState QuestState { get; set; }
    }
}
