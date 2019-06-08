using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class BaseStructureType
    {
        public BaseStructureType()
        {
            BaseStructure = new HashSet<BaseStructure>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool CanPlaceInside { get; set; }
        public bool CanPlaceOutside { get; set; }

        public virtual ICollection<BaseStructure> BaseStructure { get; set; }
    }
}