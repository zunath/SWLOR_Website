using System.Collections.Generic;
using System.Linq;
using DotNetify;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;

namespace SWLOR.Web.ViewModels
{
    public class SurvivalViewModel: BaseVM
    {
        public string TopicList_itemkey => nameof(GameTopic.GameTopicID);
        public IEnumerable<GameTopic> TopicList
        {
            get => Get<IEnumerable<GameTopic>>();
            set => Set(value);
        }
        
        public int SelectedTopicID
        {
            get => Get<int>();
            set
            {
                Set(value);
                LoadTopic();
            }
        }

        public GameTopic SelectedTopic
        {
            get => Get<GameTopic>();
            set => Set(value);
        }

        public SurvivalViewModel(DataContext db)
        {
            TopicList = db.GameTopics.Where(x => x.GameTopicCategoryID == 1).OrderBy(o => o.Sequence); 
            SelectedTopicID = TopicList.First().GameTopicID;
        }
        
        private void LoadTopic()
        {
            SelectedTopic = TopicList.Single(x => x.GameTopicID == SelectedTopicID);
        }
    }
}
