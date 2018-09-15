namespace SWLOR.Web.Models.UI.QuestEditor
{
    public class QuestRewardItemUI
    {
        public string Resref { get; set; }
        public int Quantity { get; set; }

        public QuestRewardItemUI()
        {
            Resref = string.Empty;
            Quantity = 0;
        }
    }
}
