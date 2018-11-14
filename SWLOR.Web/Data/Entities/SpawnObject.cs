namespace SWLOR.Web.Data.Entities
{
    public partial class SpawnObject
    {
        public int ID { get; set; }
        public int SpawnID { get; set; }
        public string Resref { get; set; }
        public int Weight { get; set; }
        public string SpawnRule { get; set; }
        public int? NPCGroupID { get; set; }
        public string BehaviourScript { get; set; }
        public int DeathVFXID { get; set; }

        public NPCGroup NPCGroup { get; set; }
        public Spawn Spawn { get; set; }
    }
}
