using System.Collections.Generic;
using System.Linq;
using DotNetify;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;

namespace SWLOR.Web.ViewModels.BaseViewModels
{
    public abstract class GameTopicBaseVM : BaseVM
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

        protected GameTopicBaseVM(DataContext db)
        {
            TopicList = db.GameTopics.Where(x => x.GameTopicCategoryID == CategoryID && x.IsActive).OrderBy(o => o.Sequence);
            
            var topic = TopicList.FirstOrDefault();

            if (topic != null)
            {
                SelectedTopicID = topic.GameTopicID;
            }

        }

        private void LoadTopic()
        {
            SelectedTopic = TopicList.Single(x => x.GameTopicID == SelectedTopicID);
        }

        protected abstract int CategoryID { get; }
    }
}
