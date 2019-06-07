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
            Message = new HashSet<Message>();
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
            PCMarketListingBuyerPlayer = new HashSet<PCMarketListing>();
            PCMarketListingSellerPlayer = new HashSet<PCMarketListing>();
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
            PCSkillPool = new HashSet<PCSkillPool>();
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
        public int XPBonus { get; set; }
        public int LeaseRate { get; set; }
        public Guid? LocationInstanceID { get; set; }
        public int GoldTill { get; set; }
        public int RoleplayPoints { get; set; }
        public int RoleplayXP { get; set; }
        public int ClusterID { get; set; }
        public int SpecializationID { get; set; }
        public int? ActiveConcentrationPerkID { get; set; }
        public int ActiveConcentrationTier { get; set; }

        public virtual Perk ActiveConcentrationPerk { get; set; }
        public virtual Association Association { get; set; }
        public virtual PCBase PrimaryResidencePCBase { get; set; }
        public virtual PCBaseStructure PrimaryResidencePCBaseStructure { get; set; }
        public virtual Specialization Specialization { get; set; }
        public virtual PCOutfit PCOutfit { get; set; }
        public virtual ICollection<Area> AreaNortheastOwnerNavigation { get; set; }
        public virtual ICollection<Area> AreaNorthwestOwnerNavigation { get; set; }
        public virtual ICollection<Area> AreaSoutheastOwnerNavigation { get; set; }
        public virtual ICollection<Area> AreaSouthwestOwnerNavigation { get; set; }
        public virtual ICollection<BankItem> BankItem { get; set; }
        public virtual ICollection<BugReport> BugReport { get; set; }
        public virtual ICollection<ChatLog> ChatLogReceiverPlayer { get; set; }
        public virtual ICollection<ChatLog> ChatLogSenderPlayer { get; set; }
        public virtual ICollection<ClientLogEvent> ClientLogEvent { get; set; }
        public virtual ICollection<Message> Message { get; set; }
        public virtual ICollection<PCBase> PCBase { get; set; }
        public virtual ICollection<PCBasePermission> PCBasePermission { get; set; }
        public virtual ICollection<PCBaseStructurePermission> PCBaseStructurePermission { get; set; }
        public virtual ICollection<PCCooldown> PCCooldown { get; set; }
        public virtual ICollection<PCCraftedBlueprint> PCCraftedBlueprint { get; set; }
        public virtual ICollection<PCCustomEffect> PCCustomEffect { get; set; }
        public virtual ICollection<PCImpoundedItem> PCImpoundedItem { get; set; }
        public virtual ICollection<PCKeyItem> PCKeyItem { get; set; }
        public virtual ICollection<PCMapPin> PCMapPin { get; set; }
        public virtual ICollection<PCMapProgression> PCMapProgression { get; set; }
        public virtual ICollection<PCMarketListing> PCMarketListingBuyerPlayer { get; set; }
        public virtual ICollection<PCMarketListing> PCMarketListingSellerPlayer { get; set; }
        public virtual ICollection<PCObjectVisibility> PCObjectVisibility { get; set; }
        public virtual ICollection<PCOverflowItem> PCOverflowItem { get; set; }
        public virtual ICollection<PCPerk> PCPerk { get; set; }
        public virtual ICollection<PCPerkRefund> PCPerkRefund { get; set; }
        public virtual ICollection<PCQuestItemProgress> PCQuestItemProgress { get; set; }
        public virtual ICollection<PCQuestKillTargetProgress> PCQuestKillTargetProgress { get; set; }
        public virtual ICollection<PCQuestStatus> PCQuestStatus { get; set; }
        public virtual ICollection<PCRegionalFame> PCRegionalFame { get; set; }
        public virtual ICollection<PCSearchSite> PCSearchSite { get; set; }
        public virtual ICollection<PCSearchSiteItem> PCSearchSiteItem { get; set; }
        public virtual ICollection<PCSkill> PCSkill { get; set; }
        public virtual ICollection<PCSkillPool> PCSkillPool { get; set; }
    }
}