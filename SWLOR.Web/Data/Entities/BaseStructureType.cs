using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class BaseStructureType
    {
        public BaseStructureType()
        {
            BaseStructures = new HashSet<BaseStructure>();
        }

        public int BaseStructureTypeID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool CanPlaceInside { get; set; }
        public bool CanPlaceOutside { get; set; }

        public ICollection<BaseStructure> BaseStructures { get; set; }
    }
}
