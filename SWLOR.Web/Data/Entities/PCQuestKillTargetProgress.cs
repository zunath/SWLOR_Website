namespace SWLOR.Web.Data.Entities
{
    public partial class PCQuestKillTargetProgress
    {
        public int PcquestKillTargetProgressId { get; set; }
        public string PlayerId { get; set; }
        public int PcquestStatusId { get; set; }
        public int NpcgroupId { get; set; }
        public int RemainingToKill { get; set; }

        public NPCGroups NpcGroup { get; set; }
        public PCQuestStatus PcQuestStatus { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
