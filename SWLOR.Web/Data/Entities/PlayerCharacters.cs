using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PlayerCharacters
    {
        public PlayerCharacters()
        {
            ChatLogReceiverPlayer = new HashSet<ChatLog>();
            ChatLogSenderPlayer = new HashSet<ChatLog>();
            ClientLogEvents = new HashSet<ClientLogEvents>();
            ConstructionSites = new HashSet<ConstructionSites>();
            PcabilityCooldowns = new HashSet<PCAbilityCooldowns>();
            Pcbadges = new HashSet<PCBadges>();
            Pcblueprints = new HashSet<PCBlueprints>();
            Pccrafts = new HashSet<PCCrafts>();
            PccustomEffects = new HashSet<PCCustomEffects>();
            PckeyItems = new HashSet<PCKeyItems>();
            PclearnedAbilities = new HashSet<PCLearnedAbilities>();
            PcoverflowItems = new HashSet<PCOverflowItems>();
            PcquestKillTargetProgress = new HashSet<PCQuestKillTargetProgress>();
            PcquestStatus = new HashSet<PCQuestStatus>();
            PcregionalFame = new HashSet<PCRegionalFame>();
            PcsearchSiteItems = new HashSet<PCSearchSiteItems>();
            PcsearchSites = new HashSet<PCSearchSites>();
            PcterritoryFlags = new HashSet<PCTerritoryFlags>();
            PcterritoryFlagsPermissions = new HashSet<PCTerritoryFlagsPermissions>();
            PlayerProgressionSkills = new HashSet<PlayerProgressionSkills>();
        }

        public string PlayerId { get; set; }
        public string CharacterName { get; set; }
        public int HitPoints { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public int InfectionCap { get; set; }
        public int CurrentInfection { get; set; }
        public int InfectionRemovalTick { get; set; }
        public int MaxHunger { get; set; }
        public int CurrentHunger { get; set; }
        public int CurrentHungerTick { get; set; }
        public int UnallocatedSp { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public DateTime? NextSpresetDate { get; set; }
        public int NumberOfSpresets { get; set; }
        public int ResetTokens { get; set; }
        public DateTime? NextResetTokenReceiveDate { get; set; }
        public int HpregenerationAmount { get; set; }
        public int InventorySpaceBonus { get; set; }
        public int RegenerationTick { get; set; }
        public int RegenerationRate { get; set; }
        public int ZombieKillCount { get; set; }
        public int VersionNumber { get; set; }
        public int MaxMana { get; set; }
        public int CurrentMana { get; set; }
        public int CurrentManaTick { get; set; }
        public int ProfessionId { get; set; }
        public int RevivalStoneCount { get; set; }
        public string RespawnAreaTag { get; set; }
        public double RespawnLocationX { get; set; }
        public double RespawnLocationY { get; set; }
        public double RespawnLocationZ { get; set; }
        public double RespawnLocationOrientation { get; set; }
        public DateTime? DateLastForcedSpreset { get; set; }
        public DateTime DateSanctuaryEnds { get; set; }
        public bool IsSanctuaryOverrideEnabled { get; set; }

        public ProfessionsDomain Profession { get; set; }
        public PCEquippedAbilities PcEquippedAbilities { get; set; }
        public PCOutfits PcOutfits { get; set; }
        public ICollection<ChatLog> ChatLogReceiverPlayer { get; set; }
        public ICollection<ChatLog> ChatLogSenderPlayer { get; set; }
        public ICollection<ClientLogEvents> ClientLogEvents { get; set; }
        public ICollection<ConstructionSites> ConstructionSites { get; set; }
        public ICollection<PCAbilityCooldowns> PcabilityCooldowns { get; set; }
        public ICollection<PCBadges> Pcbadges { get; set; }
        public ICollection<PCBlueprints> Pcblueprints { get; set; }
        public ICollection<PCCrafts> Pccrafts { get; set; }
        public ICollection<PCCustomEffects> PccustomEffects { get; set; }
        public ICollection<PCKeyItems> PckeyItems { get; set; }
        public ICollection<PCLearnedAbilities> PclearnedAbilities { get; set; }
        public ICollection<PCOverflowItems> PcoverflowItems { get; set; }
        public ICollection<PCQuestKillTargetProgress> PcquestKillTargetProgress { get; set; }
        public ICollection<PCQuestStatus> PcquestStatus { get; set; }
        public ICollection<PCRegionalFame> PcregionalFame { get; set; }
        public ICollection<PCSearchSiteItems> PcsearchSiteItems { get; set; }
        public ICollection<PCSearchSites> PcsearchSites { get; set; }
        public ICollection<PCTerritoryFlags> PcterritoryFlags { get; set; }
        public ICollection<PCTerritoryFlagsPermissions> PcterritoryFlagsPermissions { get; set; }
        public ICollection<PlayerProgressionSkills> PlayerProgressionSkills { get; set; }
    }
}
