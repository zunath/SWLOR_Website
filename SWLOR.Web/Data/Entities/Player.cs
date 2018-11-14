using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Player
    {
        public Player()
        {
            AreaNortheastOwnerNavigation = new HashSet<Area>();
            AreaNorthwestOwnerNavigation = new HashSet<Area>();
            AreaSoutheastOwnerNavigation = new HashSet<Area>();
            AreaSouthwestOwnerNavigation = new HashSet<Area>();
            BankItem = new HashSet<BankItem>();
            BugReport = new HashSet<BugReport>();
            ChatLogReceiverPlayer = new HashSet<ChatLog>();
            ChatLogSenderPlayer = new HashSet<ChatLog>();
            ClientLogEvent = new HashSet<ClientLogEvent>();
            PCBase = new HashSet<PCBase>();
            PCBasePermission = new HashSet<PCBasePermission>();
            PCBaseStructurePermission = new HashSet<PCBaseStructurePermission>();
            PCCooldown = new HashSet<PCCooldown>();
            PCCraftedBlueprint = new HashSet<PCCraftedBlueprint>();
            PCCustomEffect = new HashSet<PCCustomEffect>();
            PCImpoundedItem = new HashSet<PCImpoundedItem>();
            PCKeyItem = new HashSet<PCKeyItem>();
            PCMapPin = new HashSet<PCMapPin>();
            PCMapProgression = new HashSet<PCMapProgression>();
            PCObjectVisibility = new HashSet<PCObjectVisibility>();
            PCOverflowItem = new HashSet<PCOverflowItem>();
            PCPerk = new HashSet<PCPerk>();
            PCPerkRefund = new HashSet<PCPerkRefund>();
            PCQuestItemProgress = new HashSet<PCQuestItemProgress>();
            PCQuestKillTargetProgress = new HashSet<PCQuestKillTargetProgress>();
            PCQuestStatus = new HashSet<PCQuestStatus>();
            PCRegionalFame = new HashSet<PCRegionalFame>();
            PCSearchSite = new HashSet<PCSearchSite>();
            PCSearchSiteItem = new HashSet<PCSearchSiteItem>();
            PCSkill = new HashSet<PCSkill>();
        }

        public Guid ID { get; set; }
        public string CharacterName { get; set; }
        public int HitPoints { get; set; }
        public string LocationAreaResref { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public int UnallocatedSP { get; set; }
        public int HPRegenerationAmount { get; set; }
        public int RegenerationTick { get; set; }
        public int RegenerationRate { get; set; }
        public int VersionNumber { get; set; }
        public int MaxFP { get; set; }
        public int CurrentFP { get; set; }
        public int CurrentFPTick { get; set; }
        public string RespawnAreaResref { get; set; }
        public double RespawnLocationX { get; set; }
        public double RespawnLocationY { get; set; }
        public double RespawnLocationZ { get; set; }
        public double RespawnLocationOrientation { get; set; }
        public DateTime DateSanctuaryEnds { get; set; }
        public bool IsSanctuaryOverrideEnabled { get; set; }
        public int STRBase { get; set; }
        public int DEXBase { get; set; }
        public int CONBase { get; set; }
        public int INTBase { get; set; }
        public int WISBase { get; set; }
        public int CHABase { get; set; }
        public int TotalSPAcquired { get; set; }
        public bool? DisplayHelmet { get; set; }
        public Guid? PrimaryResidencePCBaseStructureID { get; set; }
        public DateTime? DatePerkRefundAvailable { get; set; }
        public int AssociationID { get; set; }
        public bool? DisplayHolonet { get; set; }
        public bool? DisplayDiscord { get; set; }
        public Guid? PrimaryResidencePCBaseID { get; set; }
        public bool IsUsingNovelEmoteStyle { get; set; }
        public bool IsDeleted { get; set; }

        public Association Association { get; set; }
        public PCBase PrimaryResidencePCBase { get; set; }
        public PCBaseStructure PrimaryResidencePCBaseStructure { get; set; }
        public PCOutfit PCOutfit { get; set; }
        public ICollection<Area> AreaNortheastOwnerNavigation { get; set; }
        public ICollection<Area> AreaNorthwestOwnerNavigation { get; set; }
        public ICollection<Area> AreaSoutheastOwnerNavigation { get; set; }
        public ICollection<Area> AreaSouthwestOwnerNavigation { get; set; }
        public ICollection<BankItem> BankItem { get; set; }
        public ICollection<BugReport> BugReport { get; set; }
        public ICollection<ChatLog> ChatLogReceiverPlayer { get; set; }
        public ICollection<ChatLog> ChatLogSenderPlayer { get; set; }
        public ICollection<ClientLogEvent> ClientLogEvent { get; set; }
        public ICollection<PCBase> PCBase { get; set; }
        public ICollection<PCBasePermission> PCBasePermission { get; set; }
        public ICollection<PCBaseStructurePermission> PCBaseStructurePermission { get; set; }
        public ICollection<PCCooldown> PCCooldown { get; set; }
        public ICollection<PCCraftedBlueprint> PCCraftedBlueprint { get; set; }
        public ICollection<PCCustomEffect> PCCustomEffect { get; set; }
        public ICollection<PCImpoundedItem> PCImpoundedItem { get; set; }
        public ICollection<PCKeyItem> PCKeyItem { get; set; }
        public ICollection<PCMapPin> PCMapPin { get; set; }
        public ICollection<PCMapProgression> PCMapProgression { get; set; }
        public ICollection<PCObjectVisibility> PCObjectVisibility { get; set; }
        public ICollection<PCOverflowItem> PCOverflowItem { get; set; }
        public ICollection<PCPerk> PCPerk { get; set; }
        public ICollection<PCPerkRefund> PCPerkRefund { get; set; }
        public ICollection<PCQuestItemProgress> PCQuestItemProgress { get; set; }
        public ICollection<PCQuestKillTargetProgress> PCQuestKillTargetProgress { get; set; }
        public ICollection<PCQuestStatus> PCQuestStatus { get; set; }
        public ICollection<PCRegionalFame> PCRegionalFame { get; set; }
        public ICollection<PCSearchSite> PCSearchSite { get; set; }
        public ICollection<PCSearchSiteItem> PCSearchSiteItem { get; set; }
        public ICollection<PCSkill> PCSkill { get; set; }
    }
}
