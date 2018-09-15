using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class GameTopicCategory
    {
        public GameTopicCategory()
        {
            GameTopics = new HashSet<GameTopic>();
        }

        public int GameTopicCategoryID { get; set; }
        public string Name { get; set; }

        public ICollection<GameTopic> GameTopics { get; set; }
    }
}
