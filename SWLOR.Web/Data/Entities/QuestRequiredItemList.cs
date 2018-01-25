namespace SWLOR.Web.Data.Entities
{
    public partial class QuestRequiredItemList
    {
        public int QuestRequiredItemListId { get; set; }
        public int QuestId { get; set; }
        public string Resref { get; set; }
        public int Quantity { get; set; }
        public int QuestStateId { get; set; }

        public Quests Quest { get; set; }
        public QuestStates QuestState { get; set; }
    }
}
