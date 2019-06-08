using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class GameTopicCategory
    {
        public GameTopicCategory()
        {
            GameTopic = new HashSet<GameTopic>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GameTopic> GameTopic { get; set; }
    }
}