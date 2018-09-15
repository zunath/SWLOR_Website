namespace SWLOR.Web.Models.UI.QuestEditor
{
    public class QuestInfoUI
    {
        public int QuestID { get; set; }
        public string Name { get; set; }

        public QuestInfoUI()
        {
            QuestID = 0;
            Name = string.Empty;
        }
    }

}
