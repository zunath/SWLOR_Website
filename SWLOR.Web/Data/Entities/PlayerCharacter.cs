using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PlayerCharacter
    {
        public PlayerCharacter()
        {
            AreasNortheastOwnerNavigation = new HashSet<Area>();
            AreasNorthwestOwnerNavigation = new HashSet<Area>();
            AreasSoutheastOwnerNavigation = new HashSet<Area>();
            AreasSouthwestOwnerNavigation = new HashSet<Area>();
            ChatLogReceiverPlayer = new HashSet<ChatLog>();
            ChatLogSenderPlayer = new HashSet<ChatLog>();
            ClientLogEvents = new HashSet<ClientLogEvent>();
            PCBasePermissions = new HashSet<PCBasePermission>();
            PCBaseStructurePermissions = new HashSet<PCBaseStructurePermission>();
            PCBases = new HashSet<PCBase>();
            PCCooldowns = new HashSet<PCCooldown>();
            PCCustomEffects = new HashSet<PCCustomEffect>();
            PCImpoundedItems = new HashSet<PCImpoundedItem>();
            PCKeyItems = new HashSet<PCKeyItem>();
            PCMapPins = new HashSet<PCMapPin>();
            PCOverflowItems = new HashSet<PCOverflowItem>();
            PCPerks = new HashSet<PCPerk>();
            PCQuestKillTargetProgress = new HashSet<PCQuestKillTargetProgress>();
            PCQuestStatus = new HashSet<PCQuestStatus>();
            PCRegionalFame = new HashSet<PCRegionalFame>();
            PCSearchSiteItems = new HashSet<PCSearchSiteItem>();
            PCSearchSites = new HashSet<PCSearchSite>();
            PCSkills = new HashSet<PCSkill>();
        }

        public string PlayerID { get; set; }
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
        public int? PrimaryResidencePCBaseStructureID { get; set; }

        public PCBaseStructure PrimaryResidencePCBaseStructure { get; set; }
        public PCOutfit PCOutfit { get; set; }
        public ICollection<Area> AreasNortheastOwnerNavigation { get; set; }
        public ICollection<Area> AreasNorthwestOwnerNavigation { get; set; }
        public ICollection<Area> AreasSoutheastOwnerNavigation { get; set; }
        public ICollection<Area> AreasSouthwestOwnerNavigation { get; set; }
        public ICollection<ChatLog> ChatLogReceiverPlayer { get; set; }
        public ICollection<ChatLog> ChatLogSenderPlayer { get; set; }
        public ICollection<ClientLogEvent> ClientLogEvents { get; set; }
        public ICollection<PCBasePermission> PCBasePermissions { get; set; }
        public ICollection<PCBaseStructurePermission> PCBaseStructurePermissions { get; set; }
        public ICollection<PCBase> PCBases { get; set; }
        public ICollection<PCCooldown> PCCooldowns { get; set; }
        public ICollection<PCCustomEffect> PCCustomEffects { get; set; }
        public ICollection<PCImpoundedItem> PCImpoundedItems { get; set; }
        public ICollection<PCKeyItem> PCKeyItems { get; set; }
        public ICollection<PCMapPin> PCMapPins { get; set; }
        public ICollection<PCOverflowItem> PCOverflowItems { get; set; }
        public ICollection<PCPerk> PCPerks { get; set; }
        public ICollection<PCQuestKillTargetProgress> PCQuestKillTargetProgress { get; set; }
        public ICollection<PCQuestStatus> PCQuestStatus { get; set; }
        public ICollection<PCRegionalFame> PCRegionalFame { get; set; }
        public ICollection<PCSearchSiteItem> PCSearchSiteItems { get; set; }
        public ICollection<PCSearchSite> PCSearchSites { get; set; }
        public ICollection<PCSkill> PCSkills { get; set; }
    }
}
