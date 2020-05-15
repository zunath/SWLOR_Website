using System.Collections.Generic;
using System.Linq;
using DotNetify;
using SWLOR.Web.Data;
using SWLOR.Web.Data.Entities;
using SWLOR.Web.Data.Entities.Data;
using SWLOR.Web.Data.Entities.Data.Entities;

namespace SWLOR.Web.ViewModels
{
    public class LoreViewModel : BaseVM
    {
        public string TopicList_itemkey => nameof(GameTopic.ID);
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

        public LoreViewModel(DataContext db)
        {
            TopicList = db.GameTopic.Where(x => x.GameTopicCategoryID == 2).OrderBy(o => o.Sequence);
            SelectedTopicID = TopicList.First().ID;
        }

        private void LoadTopic()
        {
            SelectedTopic = TopicList.Single(x => x.ID == SelectedTopicID);
        }

    }
}
