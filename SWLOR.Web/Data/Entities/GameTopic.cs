namespace SWLOR.Web.Data.Entities
{
    public partial class GameTopic
    {
        public int GameTopicID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public int GameTopicCategoryID { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }
        public string Icon { get; set; }

        public GameTopicCategory GameTopicCategory { get; set; }
    }
}
