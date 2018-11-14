namespace SWLOR.Web.Data.Entities
{
    public partial class QuestRequiredKeyItem
    {
        public int ID { get; set; }
        public int QuestID { get; set; }
        public int KeyItemID { get; set; }
        public int QuesttateID { get; set; }

        public KeyItem KeyItem { get; set; }
        public Quest Quest { get; set; }
        public QuestState Questtate { get; set; }
    }
}
