using System;

namespace SWLOR.Web.Data.Entities
{
    public class PlayerCharacter
    {
        public string PlayerID { get; set; }
        public string CharacterName { get; set; }
        public int HitPoints { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public int MaxHunger { get; set; }
        public int CurrentHunger { get; set; }
        public int CurrentHungerTick { get; set; }
        public int UnallocatedSP { get; set; }
        public DateTime? NextSPResetDate { get; set; }
        public int NumberOfSPResets { get; set; }
        public int ResetTokens { get; set; }
        public DateTime? NextResetTokenReceiveDate { get; set; }
        public int HPRegenerationAmount { get; set; }
        public int RegenerationTick { get; set; }
        public int RegenerationRate { get; set; }
        public int VersionNumber { get; set; }
        public int MaxMana { get; set; }
        public int CurrentMana { get; set; }
        public int CurrentManaTick { get; set; }
        public int RevivalStoneCount { get; set; }
        public string RespawnAreaTag { get; set; }
        public double RespawnLocationX { get; set; }
        public double RespawnLocationY { get; set; }
        public double RespawnLocationZ { get; set; }
        public double RespawnLocationOrientation { get; set; }
        public DateTime? DateLastForcedSPReset { get; set; }
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
    }
}
