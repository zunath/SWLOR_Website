namespace SWLOR.Web.Data.Entities
{
    public class QuestRequiredItemList
    {
        public int QuestRequiredItemListID { get; set; }
        public int QuestID { get; set; }
        public string Resref { get; set; }
        public int Quantity { get; set; }
        public int QuestStateID { get; set; }

        public Quests Quest { get; set; }
        public QuestState QuestState { get; set; }
    }
}
