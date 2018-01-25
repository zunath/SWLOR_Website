namespace SWLOR.Web.Data.Entities
{
    public partial class QuestRequiredKeyItemList
    {
        public int QuestRequiredKeyItemId { get; set; }
        public int QuestId { get; set; }
        public int KeyItemId { get; set; }
        public int QuestStateId { get; set; }

        public KeyItems KeyItem { get; set; }
        public Quests Quest { get; set; }
        public QuestStates QuestState { get; set; }
    }
}
