namespace SWLOR.Web.Data.Entities
{
    public partial class QuestKillTarget
    {
        public int ID { get; set; }
        public int QuestID { get; set; }
        public int NPCGroupID { get; set; }
        public int Quantity { get; set; }
        public int QuestStateID { get; set; }

        public NPCGroup NPCGroup { get; set; }
        public Quest Quest { get; set; }
        public QuestState QuestState { get; set; }
    }
}
