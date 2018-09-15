using System;

namespace SWLOR.Web.Data.Entities
{
    public class GrowingPlant
    {
        public int GrowingPlantID { get; set; }
        public int PlantID { get; set; }
        public int RemainingTicks { get; set; }
        public string LocationAreaTag { get; set; }
        public string LocationX { get; set; }
        public string LocationY { get; set; }
        public string LocationZ { get; set; }
        public string LocationOrientation { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? IsActive { get; set; }
        public int TotalTicks { get; set; }
        public int WaterStatus { get; set; }
        public int LongevityBonus { get; set; }

        public Plant Plant { get; set; }
    }
}
