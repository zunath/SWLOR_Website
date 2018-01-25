namespace SWLOR.Web.Data.Entities
{
    public partial class QuestKillTargetList
    {
        public int QuestKillTargetListId { get; set; }
        public int QuestId { get; set; }
        public int NpcgroupId { get; set; }
        public int Quantity { get; set; }
        public int QuestStateId { get; set; }

        public NPCGroups NpcGroup { get; set; }
        public Quests Quest { get; set; }
        public QuestStates QuestState { get; set; }
    }
}
