namespace SWLOR.Web.Data.Entities
{
    public class QuestRewardItem
    {
        public int QuestRewardItemID { get; set; }
        public int QuestID { get; set; }
        public string Resref { get; set; }
        public int Quantity { get; set; }

        public Quests Quest { get; set; }
    }
}
