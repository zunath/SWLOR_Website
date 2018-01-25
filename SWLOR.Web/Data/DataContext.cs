using Microsoft.EntityFrameworkCore;
using SWLOR.Web.Data.Entities;

namespace SWLOR.Web.Data
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Abilities> Abilities { get; set; }
        public virtual DbSet<AbilityCategories> AbilityCategories { get; set; }
        public virtual DbSet<AbilityCooldownCategories> AbilityCooldownCategories { get; set; }
        public virtual DbSet<ActivePlayers> ActivePlayers { get; set; }
        public virtual DbSet<AuthorizedDMs> AuthorizedDMs { get; set; }
        public virtual DbSet<Badges> Badges { get; set; }
        public virtual DbSet<BaseItemTypes> BaseItemTypes { get; set; }
        public virtual DbSet<BuildPrivacyDomain> BuildPrivacyDomain { get; set; }
        public virtual DbSet<ChatChannelsDomain> ChatChannelsDomain { get; set; }
        public virtual DbSet<ChatLog> ChatLog { get; set; }
        public virtual DbSet<ClientLogEvents> ClientLogEvents { get; set; }
        public virtual DbSet<ClientLogEventTypesDomain> ClientLogEventTypesDomain { get; set; }
        public virtual DbSet<ConstructionSites> ConstructionSites { get; set; }
        public virtual DbSet<CraftBlueprintCategories> CraftBlueprintCategories { get; set; }
        public virtual DbSet<CraftBlueprintComponents> CraftBlueprintComponents { get; set; }
        public virtual DbSet<CraftBlueprints> CraftBlueprints { get; set; }
        public virtual DbSet<CraftLevels> CraftLevels { get; set; }
        public virtual DbSet<Crafts> Crafts { get; set; }
        public virtual DbSet<CustomEffects> CustomEffects { get; set; }
        public virtual DbSet<DmroleDomain> DMRoleDomain { get; set; }
        public virtual DbSet<Downloads> Downloads { get; set; }
        public virtual DbSet<FameRegions> FameRegions { get; set; }
        public virtual DbSet<ForcedSPResetDates> ForcedSPResetDates { get; set; }
        public virtual DbSet<ItemCombinations> ItemCombinations { get; set; }
        public virtual DbSet<KeyItemCategories> KeyItemCategories { get; set; }
        public virtual DbSet<KeyItems> KeyItems { get; set; }
        public virtual DbSet<LootTableItems> LootTableItems { get; set; }
        public virtual DbSet<LootTables> LootTables { get; set; }
        public virtual DbSet<NPCGroups> NPCGroups { get; set; }
        public virtual DbSet<PCAbilityCooldowns> PCAbilityCooldowns { get; set; }
        public virtual DbSet<PCAuthorizedCDKeys> PCAuthorizedCDKeys { get; set; }
        public virtual DbSet<PCBadges> PCBadges { get; set; }
        public virtual DbSet<PCBlueprints> PCBlueprints { get; set; }
        public virtual DbSet<PCCorpseItems> PCCorpseItems { get; set; }
        public virtual DbSet<PCCorpses> PCCorpses { get; set; }
        public virtual DbSet<PCCrafts> PCCrafts { get; set; }
        public virtual DbSet<PCCustomEffects> PCCustomEffects { get; set; }
        public virtual DbSet<PCEquippedAbilities> PCEquippedAbilities { get; set; }
        public virtual DbSet<PCKeyItems> PCKeyItems { get; set; }
        public virtual DbSet<PCLearnedAbilities> PCLearnedAbilities { get; set; }
        public virtual DbSet<PCMigrationItems> PCMigrationItems { get; set; }
        public virtual DbSet<PCMigrations> PCMigrations { get; set; }
        public virtual DbSet<PCOutfits> PCOutfits { get; set; }
        public virtual DbSet<PCOverflowItems> PCOverflowItems { get; set; }
        public virtual DbSet<PCQuestKillTargetProgress> PCQuestKillTargetProgress { get; set; }
        public virtual DbSet<PCQuestStatus> PCQuestStatus { get; set; }
        public virtual DbSet<PCRegionalFame> PCRegionalFame { get; set; }
        public virtual DbSet<PCSearchSiteItems> PCSearchSiteItems { get; set; }
        public virtual DbSet<PCSearchSites> PCSearchSites { get; set; }
        public virtual DbSet<PCTerritoryFlags> PCTerritoryFlags { get; set; }
        public virtual DbSet<PCTerritoryFlagsPermissions> PCTerritoryFlagsPermissions { get; set; }
        public virtual DbSet<PCTerritoryFlagsStructures> PCTerritoryFlagsStructures { get; set; }
        public virtual DbSet<PCTerritoryFlagsStructuresItems> PCTerritoryFlagsStructuresItems { get; set; }
        public virtual DbSet<PCTerritoryFlagsStructuresResearchQueues> PCTerritoryFlagsStructuresResearchQueues { get; set; }
        public virtual DbSet<PlayerCharacters> PlayerCharacters { get; set; }
        public virtual DbSet<PlayerProgressionSkills> PlayerProgressionSkills { get; set; }
        public virtual DbSet<Portraits> Portraits { get; set; }
        public virtual DbSet<ProfessionsDomain> ProfessionsDomain { get; set; }
        public virtual DbSet<ProgressionLevels> ProgressionLevels { get; set; }
        public virtual DbSet<ProgressionSkills> ProgressionSkills { get; set; }
        public virtual DbSet<QuestKillTargetList> QuestKillTargetList { get; set; }
        public virtual DbSet<QuestPrerequisites> QuestPrerequisites { get; set; }
        public virtual DbSet<QuestRequiredItemList> QuestRequiredItemList { get; set; }
        public virtual DbSet<QuestRequiredKeyItemList> QuestRequiredKeyItemList { get; set; }
        public virtual DbSet<QuestRewardItems> QuestRewardItems { get; set; }
        public virtual DbSet<Quests> Quests { get; set; }
        public virtual DbSet<QuestStates> QuestStates { get; set; }
        public virtual DbSet<QuestTypeDomain> QuestTypeDomain { get; set; }
        public virtual DbSet<ResearchBlueprints> ResearchBlueprints { get; set; }
        public virtual DbSet<ServerConfiguration> ServerConfiguration { get; set; }
        public virtual DbSet<SpawnTableCreatures> SpawnTableCreatures { get; set; }
        public virtual DbSet<SpawnTables> SpawnTables { get; set; }
        public virtual DbSet<StorageContainers> StorageContainers { get; set; }
        public virtual DbSet<StorageItems> StorageItems { get; set; }
        public virtual DbSet<StructureBlueprints> StructureBlueprints { get; set; }
        public virtual DbSet<StructureCategories> StructureCategories { get; set; }
        public virtual DbSet<StructureQuickBuildAudit> StructureQuickBuildAudit { get; set; }
        public virtual DbSet<TerritoryFlagPermissions> TerritoryFlagPermissions { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ZombieClothes> ZombieClothes { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abilities>(entity =>
            {
                entity.HasKey(e => e.AbilityId);

                entity.HasIndex(e => e.FeatId)
                    .HasName("uq_Abilities_FeatID")
                    .IsUnique();

                entity.Property(e => e.AbilityId)
                    .HasColumnName("AbilityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbilityCategoryId).HasColumnName("AbilityCategoryID");

                entity.Property(e => e.AbilityCooldownCategoryId).HasColumnName("AbilityCooldownCategoryID");

                entity.Property(e => e.BaseCastingTime).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.BaseManaCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FeatId)
                    .HasColumnName("FeatID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JavaScriptName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.AbilityCategory)
                    .WithMany(p => p.Abilities)
                    .HasForeignKey(d => d.AbilityCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Abilities_AbilityCategoryID");

                entity.HasOne(d => d.AbilityCooldownCategory)
                    .WithMany(p => p.Abilities)
                    .HasForeignKey(d => d.AbilityCooldownCategoryId)
                    .HasConstraintName("fk_Abilities_AbilityCooldownCategoryID");
            });

            modelBuilder.Entity<AbilityCategories>(entity =>
            {
                entity.HasKey(e => e.AbilityCategoryId);

                entity.Property(e => e.AbilityCategoryId)
                    .HasColumnName("AbilityCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AbilityCooldownCategories>(entity =>
            {
                entity.HasKey(e => e.AbilityCooldownCategoryId);

                entity.Property(e => e.AbilityCooldownCategoryId)
                    .HasColumnName("AbilityCooldownCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseCooldownTime).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActivePlayers>(entity =>
            {
                entity.HasKey(e => e.ActivePlayerId);

                entity.Property(e => e.ActivePlayerId).HasColumnName("ActivePlayerID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuthorizedDMs>(entity =>
            {
                entity.HasKey(e => e.AuthorizedDmid);

                entity.ToTable("AuthorizedDMs");

                entity.Property(e => e.AuthorizedDmid).HasColumnName("AuthorizedDMID");

                entity.Property(e => e.Cdkey)
                    .IsRequired()
                    .HasColumnName("CDKey")
                    .HasMaxLength(20);

                entity.Property(e => e.Dmrole).HasColumnName("DMRole");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Badges>(entity =>
            {
                entity.HasKey(e => e.BadgeId);

                entity.Property(e => e.BadgeId).HasColumnName("BadgeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<BaseItemTypes>(entity =>
            {
                entity.HasKey(e => e.BaseItemTypeId);

                entity.Property(e => e.BaseItemTypeId)
                    .HasColumnName("BaseItemTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<BuildPrivacyDomain>(entity =>
            {
                entity.HasKey(e => e.BuildPrivacyTypeId);

                entity.Property(e => e.BuildPrivacyTypeId)
                    .HasColumnName("BuildPrivacyTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<ChatChannelsDomain>(entity =>
            {
                entity.HasKey(e => e.ChatChannelId);

                entity.Property(e => e.ChatChannelId)
                    .HasColumnName("ChatChannelID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ChatLog>(entity =>
            {
                entity.Property(e => e.ChatLogId).HasColumnName("ChatLogID");

                entity.Property(e => e.ChatChannelId).HasColumnName("ChatChannelID");

                entity.Property(e => e.DateSent).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceiverAccountName).HasMaxLength(1024);

                entity.Property(e => e.ReceiverCdkey)
                    .HasColumnName("ReceiverCDKey")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceiverDmname)
                    .HasColumnName("ReceiverDMName")
                    .HasMaxLength(60);

                entity.Property(e => e.ReceiverPlayerId)
                    .HasColumnName("ReceiverPlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.SenderAccountName)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderCdkey)
                    .IsRequired()
                    .HasColumnName("SenderCDKey")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderDmname)
                    .HasColumnName("SenderDMName")
                    .HasMaxLength(60);

                entity.Property(e => e.SenderPlayerId)
                    .HasColumnName("SenderPlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.ChatChannel)
                    .WithMany(p => p.ChatLog)
                    .HasForeignKey(d => d.ChatChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ChatLog_ChatChannelID");

                entity.HasOne(d => d.ReceiverPlayer)
                    .WithMany(p => p.ChatLogReceiverPlayer)
                    .HasForeignKey(d => d.ReceiverPlayerId)
                    .HasConstraintName("fk_ChatLog_ReceiverPlayerID");

                entity.HasOne(d => d.SenderPlayer)
                    .WithMany(p => p.ChatLogSenderPlayer)
                    .HasForeignKey(d => d.SenderPlayerId)
                    .HasConstraintName("fk_ChatLog_SenderPlayerID");
            });

            modelBuilder.Entity<ClientLogEvents>(entity =>
            {
                entity.HasKey(e => e.ClientLogEventId);

                entity.Property(e => e.ClientLogEventId).HasColumnName("ClientLogEventID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.Cdkey)
                    .IsRequired()
                    .HasColumnName("CDKey")
                    .HasMaxLength(20);

                entity.Property(e => e.ClientLogEventTypeId).HasColumnName("ClientLogEventTypeID");

                entity.Property(e => e.DateOfEvent).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.ClientLogEventType)
                    .WithMany(p => p.ClientLogEvents)
                    .HasForeignKey(d => d.ClientLogEventTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientLogEvents_ClientLogEventTypeID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.ClientLogEvents)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientLogEvents_PlayerID");
            });

            modelBuilder.Entity<ClientLogEventTypesDomain>(entity =>
            {
                entity.HasKey(e => e.ClientLogEventTypeId);

                entity.Property(e => e.ClientLogEventTypeId)
                    .HasColumnName("ClientLogEventTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ConstructionSites>(entity =>
            {
                entity.HasKey(e => e.ConstructionSiteId);

                entity.Property(e => e.ConstructionSiteId).HasColumnName("ConstructionSiteID");

                entity.Property(e => e.IronRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PcterritoryFlagId).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.StructureBlueprintId).HasColumnName("StructureBlueprintID");

                entity.HasOne(d => d.PcTerritoryFlag)
                    .WithMany(p => p.ConstructionSites)
                    .HasForeignKey(d => d.PcterritoryFlagId)
                    .HasConstraintName("fk_ConstructionSites_PCTerritoryFlagID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.ConstructionSites)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ConstructionSites_PlayerID");

                entity.HasOne(d => d.StructureBlueprint)
                    .WithMany(p => p.ConstructionSites)
                    .HasForeignKey(d => d.StructureBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ConstructionSites_StructureBlueprintID");
            });

            modelBuilder.Entity<CraftBlueprintCategories>(entity =>
            {
                entity.HasKey(e => e.CraftBlueprintCategoryId);

                entity.Property(e => e.CraftBlueprintCategoryId)
                    .HasColumnName("CraftBlueprintCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<CraftBlueprintComponents>(entity =>
            {
                entity.HasKey(e => e.CraftComponentId);

                entity.Property(e => e.CraftComponentId).HasColumnName("CraftComponentID");

                entity.Property(e => e.CraftBlueprintId).HasColumnName("CraftBlueprintID");

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.CraftBlueprint)
                    .WithMany(p => p.CraftBlueprintComponents)
                    .HasForeignKey(d => d.CraftBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprintComponents_CraftBlueprintID");
            });

            modelBuilder.Entity<CraftBlueprints>(entity =>
            {
                entity.HasKey(e => e.CraftBlueprintId);

                entity.Property(e => e.CraftBlueprintId)
                    .HasColumnName("CraftBlueprintID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CraftCategoryId).HasColumnName("CraftCategoryID");

                entity.Property(e => e.CraftId).HasColumnName("CraftID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.CraftCategory)
                    .WithMany(p => p.CraftBlueprints)
                    .HasForeignKey(d => d.CraftCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprints_CraftCategoryID");

                entity.HasOne(d => d.Craft)
                    .WithMany(p => p.CraftBlueprints)
                    .HasForeignKey(d => d.CraftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprints_CraftID");
            });

            modelBuilder.Entity<CraftLevels>(entity =>
            {
                entity.HasKey(e => e.CraftLevelId);

                entity.Property(e => e.CraftLevelId).HasColumnName("CraftLevelID");

                entity.Property(e => e.CraftId).HasColumnName("CraftID");

                entity.HasOne(d => d.Craft)
                    .WithMany(p => p.CraftLevels)
                    .HasForeignKey(d => d.CraftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftLevels_CraftID");
            });

            modelBuilder.Entity<Crafts>(entity =>
            {
                entity.HasKey(e => e.CraftId);

                entity.Property(e => e.CraftId)
                    .HasColumnName("CraftID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<CustomEffects>(entity =>
            {
                entity.HasKey(e => e.CustomEffectId);

                entity.Property(e => e.CustomEffectId)
                    .HasColumnName("CustomEffectID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContinueMessage)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.IconId).HasColumnName("IconID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.ScriptHandler)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StartMessage)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.WornOffMessage)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<DmroleDomain>(entity =>
            {
                entity.ToTable("DMRoleDomain");

                entity.Property(e => e.DmroleDomainId)
                    .HasColumnName("DMRoleDomainID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Downloads>(entity =>
            {
                entity.HasKey(e => e.DownloadId);

                entity.Property(e => e.DownloadId)
                    .HasColumnName("DownloadID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<FameRegions>(entity =>
            {
                entity.HasKey(e => e.FameRegionId);

                entity.Property(e => e.FameRegionId)
                    .HasColumnName("FameRegionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<ForcedSPResetDates>(entity =>
            {
                entity.HasKey(e => e.ForcedSpresetDateId);

                entity.ToTable("ForcedSPResetDates");

                entity.Property(e => e.ForcedSpresetDateId).HasColumnName("ForcedSPResetDateID");
            });

            modelBuilder.Entity<ItemCombinations>(entity =>
            {
                entity.HasKey(e => e.ItemCombinationId);

                entity.Property(e => e.ItemCombinationId)
                    .HasColumnName("ItemCombinationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Hqoutput)
                    .HasColumnName("HQOutput")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Hqquantity).HasColumnName("HQQuantity");

                entity.Property(e => e.ItemA)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ItemAinfinite).HasColumnName("ItemAInfinite");

                entity.Property(e => e.ItemB)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ItemBinfinite).HasColumnName("ItemBInfinite");

                entity.Property(e => e.Output)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KeyItemCategories>(entity =>
            {
                entity.HasKey(e => e.KeyItemCategoryId);

                entity.Property(e => e.KeyItemCategoryId)
                    .HasColumnName("KeyItemCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<KeyItems>(entity =>
            {
                entity.HasKey(e => e.KeyItemId);

                entity.Property(e => e.KeyItemId)
                    .HasColumnName("KeyItemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.KeyItemCategoryId).HasColumnName("KeyItemCategoryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.KeyItemCategory)
                    .WithMany(p => p.KeyItems)
                    .HasForeignKey(d => d.KeyItemCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_KeyItems_KeyItemCategoryID");
            });

            modelBuilder.Entity<LootTableItems>(entity =>
            {
                entity.HasKey(e => e.LootTableItemId);

                entity.Property(e => e.LootTableItemId).HasColumnName("LootTableItemID");

                entity.Property(e => e.LootTableId).HasColumnName("LootTableID");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.LootTable)
                    .WithMany(p => p.LootTableItems)
                    .HasForeignKey(d => d.LootTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_LootTableItems_LootTableID");
            });

            modelBuilder.Entity<LootTables>(entity =>
            {
                entity.HasKey(e => e.LootTableId);

                entity.Property(e => e.LootTableId)
                    .HasColumnName("LootTableID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<NPCGroups>(entity =>
            {
                entity.HasKey(e => e.NpcgroupId);

                entity.ToTable("NPCGroups");

                entity.Property(e => e.NpcgroupId)
                    .HasColumnName("NPCGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PCAbilityCooldowns>(entity =>
            {
                entity.HasKey(e => e.PcabilityCooldownId);

                entity.ToTable("PCAbilityCooldowns");

                entity.Property(e => e.PcabilityCooldownId).HasColumnName("PCAbilityCooldownID");

                entity.Property(e => e.AbilityCooldownCategoryId).HasColumnName("AbilityCooldownCategoryID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.AbilityCooldownCategory)
                    .WithMany(p => p.PcabilityCooldowns)
                    .HasForeignKey(d => d.AbilityCooldownCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCAbilityCooldowns_AbilityCooldownCategoryID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcabilityCooldowns)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCAbilityCooldowns_PlayerID");
            });

            modelBuilder.Entity<PCAuthorizedCDKeys>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("PCAuthorizedCDKeys");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cdkey1)
                    .IsRequired()
                    .HasColumnName("CDKey1")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdkey10)
                    .IsRequired()
                    .HasColumnName("CDKey10")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdkey2)
                    .IsRequired()
                    .HasColumnName("CDKey2")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdkey3)
                    .IsRequired()
                    .HasColumnName("CDKey3")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdkey4)
                    .IsRequired()
                    .HasColumnName("CDKey4")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdkey5)
                    .IsRequired()
                    .HasColumnName("CDKey5")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdkey6)
                    .IsRequired()
                    .HasColumnName("CDKey6")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdkey7)
                    .IsRequired()
                    .HasColumnName("CDKey7")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdkey8)
                    .IsRequired()
                    .HasColumnName("CDKey8")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdkey9)
                    .IsRequired()
                    .HasColumnName("CDKey9")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PCBadges>(entity =>
            {
                entity.HasKey(e => e.PcbadgeId);

                entity.ToTable("PCBadges");

                entity.Property(e => e.PcbadgeId).HasColumnName("PCBadgeID");

                entity.Property(e => e.AcquiredAreaName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.AcquiredAreaResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.AcquiredAreaTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.AcquiredDate).HasColumnType("datetime");

                entity.Property(e => e.BadgeId).HasColumnName("BadgeID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.Badge)
                    .WithMany(p => p.Pcbadges)
                    .HasForeignKey(d => d.BadgeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCBadges_BadgeID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Pcbadges)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCBadges_PlayerID");
            });

            modelBuilder.Entity<PCBlueprints>(entity =>
            {
                entity.HasKey(e => e.PcblueprintId);

                entity.ToTable("PCBlueprints");

                entity.Property(e => e.PcblueprintId).HasColumnName("PCBlueprintID");

                entity.Property(e => e.AcquiredDate).HasColumnType("datetime");

                entity.Property(e => e.CraftBlueprintId).HasColumnName("CraftBlueprintID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.CraftBlueprint)
                    .WithMany(p => p.Pcblueprints)
                    .HasForeignKey(d => d.CraftBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCBlueprints_CraftBlueprintID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Pcblueprints)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCBlueprints_PlayerID");
            });

            modelBuilder.Entity<PCCorpseItems>(entity =>
            {
                entity.HasKey(e => e.PccorpseItemId);

                entity.ToTable("PCCorpseItems");

                entity.Property(e => e.PccorpseItemId).HasColumnName("PCCorpseItemID");

                entity.Property(e => e.NwitemObject)
                    .IsRequired()
                    .HasColumnName("NWItemObject");

                entity.Property(e => e.PccorpseId).HasColumnName("PCCorpseID");

                entity.HasOne(d => d.PcCorpse)
                    .WithMany(p => p.PccorpseItems)
                    .HasForeignKey(d => d.PccorpseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCorpseItems_PCCorpseID");
            });

            modelBuilder.Entity<PCCorpses>(entity =>
            {
                entity.HasKey(e => e.PccorpseId);

                entity.ToTable("PCCorpses");

                entity.Property(e => e.PccorpseId).HasColumnName("PCCorpseID");

                entity.Property(e => e.AreaTag).HasMaxLength(32);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PCCrafts>(entity =>
            {
                entity.HasKey(e => e.PccraftId);

                entity.ToTable("PCCrafts");

                entity.Property(e => e.PccraftId).HasColumnName("PCCraftID");

                entity.Property(e => e.CraftId).HasColumnName("CraftID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.Craft)
                    .WithMany(p => p.Pccrafts)
                    .HasForeignKey(d => d.CraftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCrafts_CraftID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Pccrafts)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCrafts_PlayerID");
            });

            modelBuilder.Entity<PCCustomEffects>(entity =>
            {
                entity.HasKey(e => e.PccustomEffectId);

                entity.ToTable("PCCustomEffects");

                entity.Property(e => e.PccustomEffectId).HasColumnName("PCCustomEffectID");

                entity.Property(e => e.CustomEffectId).HasColumnName("CustomEffectID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.CustomEffect)
                    .WithMany(p => p.PccustomEffects)
                    .HasForeignKey(d => d.CustomEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCustomEffects_CustomEffectID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PccustomEffects)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCustomEffects_PlayerID");
            });

            modelBuilder.Entity<PCEquippedAbilities>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.ToTable("PCEquippedAbilities");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Player)
                    .WithOne(p => p.PcEquippedAbilities)
                    .HasForeignKey<PCEquippedAbilities>(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCEquippedAbilities_PlayerID");

                entity.HasOne(d => d.Slot1Navigation)
                    .WithMany(p => p.PcequippedAbilitiesSlot1Navigation)
                    .HasForeignKey(d => d.Slot1)
                    .HasConstraintName("fk_PCEquippedAbilities_Slot1");

                entity.HasOne(d => d.Slot10Navigation)
                    .WithMany(p => p.PcequippedAbilitiesSlot10Navigation)
                    .HasForeignKey(d => d.Slot10)
                    .HasConstraintName("fk_PCEquippedAbilities_Slot10");

                entity.HasOne(d => d.Slot2Navigation)
                    .WithMany(p => p.PcequippedAbilitiesSlot2Navigation)
                    .HasForeignKey(d => d.Slot2)
                    .HasConstraintName("fk_PCEquippedAbilities_Slot2");

                entity.HasOne(d => d.Slot3Navigation)
                    .WithMany(p => p.PcequippedAbilitiesSlot3Navigation)
                    .HasForeignKey(d => d.Slot3)
                    .HasConstraintName("fk_PCEquippedAbilities_Slot3");

                entity.HasOne(d => d.Slot4Navigation)
                    .WithMany(p => p.PcequippedAbilitiesSlot4Navigation)
                    .HasForeignKey(d => d.Slot4)
                    .HasConstraintName("fk_PCEquippedAbilities_Slot4");

                entity.HasOne(d => d.Slot5Navigation)
                    .WithMany(p => p.PcequippedAbilitiesSlot5Navigation)
                    .HasForeignKey(d => d.Slot5)
                    .HasConstraintName("fk_PCEquippedAbilities_Slot5");

                entity.HasOne(d => d.Slot6Navigation)
                    .WithMany(p => p.PcequippedAbilitiesSlot6Navigation)
                    .HasForeignKey(d => d.Slot6)
                    .HasConstraintName("fk_PCEquippedAbilities_Slot6");

                entity.HasOne(d => d.Slot7Navigation)
                    .WithMany(p => p.PcequippedAbilitiesSlot7Navigation)
                    .HasForeignKey(d => d.Slot7)
                    .HasConstraintName("fk_PCEquippedAbilities_Slot7");

                entity.HasOne(d => d.Slot8Navigation)
                    .WithMany(p => p.PcequippedAbilitiesSlot8Navigation)
                    .HasForeignKey(d => d.Slot8)
                    .HasConstraintName("fk_PCEquippedAbilities_Slot8");

                entity.HasOne(d => d.Slot9Navigation)
                    .WithMany(p => p.PcequippedAbilitiesSlot9Navigation)
                    .HasForeignKey(d => d.Slot9)
                    .HasConstraintName("fk_PCEquippedAbilities_Slot9");
            });

            modelBuilder.Entity<PCKeyItems>(entity =>
            {
                entity.HasKey(e => e.PckeyItemId);

                entity.ToTable("PCKeyItems");

                entity.Property(e => e.PckeyItemId).HasColumnName("PCKeyItemID");

                entity.Property(e => e.AcquiredDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.KeyItemId).HasColumnName("KeyItemID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.KeyItem)
                    .WithMany(p => p.PckeyItems)
                    .HasForeignKey(d => d.KeyItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCKeyItems_KeyItemID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PckeyItems)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCKeyItems_PlayerID");
            });

            modelBuilder.Entity<PCLearnedAbilities>(entity =>
            {
                entity.HasKey(e => e.PclearnedAbilityId);

                entity.ToTable("PCLearnedAbilities");

                entity.Property(e => e.PclearnedAbilityId).HasColumnName("PCLearnedAbilityID");

                entity.Property(e => e.AbilityId).HasColumnName("AbilityID");

                entity.Property(e => e.AcquiredDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.PclearnedAbilities)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCLearnedAbilities_AbilityID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PclearnedAbilities)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCLearnedAbilities_PlayerID");
            });

            modelBuilder.Entity<PCMigrationItems>(entity =>
            {
                entity.HasKey(e => e.PcmigrationItemId);

                entity.ToTable("PCMigrationItems");

                entity.Property(e => e.PcmigrationItemId)
                    .HasColumnName("PCMigrationItemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseItemTypeId).HasColumnName("BaseItemTypeID");

                entity.Property(e => e.CurrentResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.NewResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.PcmigrationId).HasColumnName("PCMigrationID");

                entity.HasOne(d => d.BaseItemType)
                    .WithMany(p => p.PcmigrationItems)
                    .HasForeignKey(d => d.BaseItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCMigrationItems_BaseItemTypeID");

                entity.HasOne(d => d.PcMigration)
                    .WithMany(p => p.PcmigrationItems)
                    .HasForeignKey(d => d.PcmigrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCMigrationItems_PCMigrationID");
            });

            modelBuilder.Entity<PCMigrations>(entity =>
            {
                entity.HasKey(e => e.PcmigrationId);

                entity.ToTable("PCMigrations");

                entity.Property(e => e.PcmigrationId)
                    .HasColumnName("PCMigrationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<PCOutfits>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.ToTable("PCOutfits");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Player)
                    .WithOne(p => p.PcOutfits)
                    .HasForeignKey<PCOutfits>(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCOutfits_PlayerID");
            });

            modelBuilder.Entity<PCOverflowItems>(entity =>
            {
                entity.HasKey(e => e.PcoverflowItemId);

                entity.ToTable("PCOverflowItems");

                entity.Property(e => e.PcoverflowItemId).HasColumnName("PCOverflowItemID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsRequired();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcoverflowItems)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCOverflowItems_PlayerID");
            });

            modelBuilder.Entity<PCQuestKillTargetProgress>(entity =>
            {
                entity.ToTable("PCQuestKillTargetProgress");

                entity.Property(e => e.PcquestKillTargetProgressId).HasColumnName("PCQuestKillTargetProgressID");

                entity.Property(e => e.NpcgroupId).HasColumnName("NPCGroupID");

                entity.Property(e => e.PcquestStatusId).HasColumnName("PCQuestStatusID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.NpcGroup)
                    .WithMany(p => p.PcquestKillTargetProgress)
                    .HasForeignKey(d => d.NpcgroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_NPCGroupID");

                entity.HasOne(d => d.PcQuestStatus)
                    .WithMany(p => p.PcquestKillTargetProgress)
                    .HasForeignKey(d => d.PcquestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_PCQuestStatusID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcquestKillTargetProgress)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_PlayerID");
            });

            modelBuilder.Entity<PCQuestStatus>(entity =>
            {
                entity.ToTable("PCQuestStatus");

                entity.Property(e => e.PcquestStatusId).HasColumnName("PCQuestStatusID");

                entity.Property(e => e.CurrentQuestStateId).HasColumnName("CurrentQuestStateID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.SelectedItemRewardId).HasColumnName("SelectedItemRewardID");

                entity.HasOne(d => d.CurrentQuestState)
                    .WithMany(p => p.PcquestStatus)
                    .HasForeignKey(d => d.CurrentQuestStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestStatus_CurrentQuestStateID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcquestStatus)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestStatus_PlayerID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.PcquestStatus)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestStatus_QuestID");

                entity.HasOne(d => d.SelectedItemReward)
                    .WithMany(p => p.PcquestStatus)
                    .HasForeignKey(d => d.SelectedItemRewardId)
                    .HasConstraintName("FK_PCQuestStatus_SelectedRewardID");
            });

            modelBuilder.Entity<PCRegionalFame>(entity =>
            {
                entity.ToTable("PCRegionalFame");

                entity.Property(e => e.PcregionalFameId).HasColumnName("PCRegionalFameID");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FameRegionId).HasColumnName("FameRegionID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.HasOne(d => d.FameRegion)
                    .WithMany(p => p.PcregionalFame)
                    .HasForeignKey(d => d.FameRegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCRegionalFame_FameRegionID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcregionalFame)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCRegionalFame_PlayerID");
            });

            modelBuilder.Entity<PCSearchSiteItems>(entity =>
            {
                entity.HasKey(e => e.PcsearchSiteItemId);

                entity.ToTable("PCSearchSiteItems");

                entity.Property(e => e.PcsearchSiteItemId).HasColumnName("PCSearchSiteItemID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.SearchItem).IsRequired();

                entity.Property(e => e.SearchSiteId).HasColumnName("SearchSiteID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcsearchSiteItems)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCSearchSiteItems_PlayerID");
            });

            modelBuilder.Entity<PCSearchSites>(entity =>
            {
                entity.HasKey(e => e.PcsearchSiteId);

                entity.ToTable("PCSearchSites");

                entity.Property(e => e.PcsearchSiteId).HasColumnName("PCSearchSiteID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.SearchSiteId).HasColumnName("SearchSiteID");

                entity.Property(e => e.UnlockDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcsearchSites)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCSearchSites_PlayerID");
            });

            modelBuilder.Entity<PCTerritoryFlags>(entity =>
            {
                entity.HasKey(e => e.PcterritoryFlagId);

                entity.ToTable("PCTerritoryFlags");

                entity.Property(e => e.PcterritoryFlagId).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.BuildPrivacySettingId)
                    .HasColumnName("BuildPrivacySettingID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.StructureBlueprintId).HasColumnName("StructureBlueprintID");

                entity.HasOne(d => d.BuildPrivacySetting)
                    .WithMany(p => p.PcterritoryFlags)
                    .HasForeignKey(d => d.BuildPrivacySettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlags_BuildPrivacySettingID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcterritoryFlags)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlags_PlayerID");

                entity.HasOne(d => d.StructureBlueprint)
                    .WithMany(p => p.PcterritoryFlags)
                    .HasForeignKey(d => d.StructureBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlags_StructureBlueprintID");
            });

            modelBuilder.Entity<PCTerritoryFlagsPermissions>(entity =>
            {
                entity.HasKey(e => e.PcterritoryFlagPermissionId);

                entity.ToTable("PCTerritoryFlagsPermissions");

                entity.Property(e => e.PcterritoryFlagPermissionId).HasColumnName("PCTerritoryFlagPermissionID");

                entity.Property(e => e.PcterritoryFlagId).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.TerritoryFlagPermissionId).HasColumnName("TerritoryFlagPermissionID");

                entity.HasOne(d => d.PcTerritoryFlag)
                    .WithMany(p => p.PcterritoryFlagsPermissions)
                    .HasForeignKey(d => d.PcterritoryFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsPermissions_PCTerritoryFlagID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PcterritoryFlagsPermissions)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsPermissions_PlayerID");

                entity.HasOne(d => d.TerritoryFlagPermission)
                    .WithMany(p => p.PcterritoryFlagsPermissions)
                    .HasForeignKey(d => d.TerritoryFlagPermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsPermissions_TerritoryFlagPermissionID");
            });

            modelBuilder.Entity<PCTerritoryFlagsStructures>(entity =>
            {
                entity.HasKey(e => e.PcterritoryFlagStructureId);

                entity.ToTable("PCTerritoryFlagsStructures");

                entity.Property(e => e.PcterritoryFlagStructureId).HasColumnName("PCTerritoryFlagStructureID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PcterritoryFlagId).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.StructureBlueprintId).HasColumnName("StructureBlueprintID");

                entity.HasOne(d => d.PcTerritoryFlag)
                    .WithMany(p => p.PcterritoryFlagsStructures)
                    .HasForeignKey(d => d.PcterritoryFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsStructures_PCTerritoryFlagID");

                entity.HasOne(d => d.StructureBlueprint)
                    .WithMany(p => p.PcterritoryFlagsStructures)
                    .HasForeignKey(d => d.StructureBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsStructures_StructureBlueprintID");
            });

            modelBuilder.Entity<PCTerritoryFlagsStructuresItems>(entity =>
            {
                entity.HasKey(e => e.PcstructureItemId);

                entity.ToTable("PCTerritoryFlagsStructuresItems");

                entity.Property(e => e.PcstructureItemId).HasColumnName("PCStructureItemID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsRequired();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PcstructureId).HasColumnName("PCStructureID");

                entity.HasOne(d => d.Pcstructure)
                    .WithMany(p => p.PcterritoryFlagsStructuresItems)
                    .HasForeignKey(d => d.PcstructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsStructuresItems_PCStructureID");
            });

            modelBuilder.Entity<PCTerritoryFlagsStructuresResearchQueues>(entity =>
            {
                entity.HasKey(e => e.PcstructureResearchId);

                entity.ToTable("PCTerritoryFlagsStructuresResearchQueues");

                entity.Property(e => e.PcstructureResearchId).HasColumnName("PCStructureResearchID");

                entity.Property(e => e.PcstructureId).HasColumnName("PCStructureID");

                entity.Property(e => e.ResearchBlueprintId).HasColumnName("ResearchBlueprintID");

                entity.Property(e => e.StartDateTime).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Pcstructure)
                    .WithMany(p => p.PcterritoryFlagsStructuresResearchQueues)
                    .HasForeignKey(d => d.PcstructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsStructuresResearchQueues_PCStructureID");

                entity.HasOne(d => d.ResearchBlueprint)
                    .WithMany(p => p.PcterritoryFlagsStructuresResearchQueues)
                    .HasForeignKey(d => d.ResearchBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsStructuresResearchQueues_ResearchBlueprintID");
            });

            modelBuilder.Entity<PlayerCharacters>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTimestamp)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CurrentMana).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentManaTick).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateLastForcedSpreset).HasColumnName("DateLastForcedSPReset");

                entity.Property(e => e.DateSanctuaryEnds).HasDefaultValueSql("(dateadd(hour,(72),getutcdate()))");

                entity.Property(e => e.HpregenerationAmount).HasColumnName("HPRegenerationAmount");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.MaxMana).HasDefaultValueSql("((0))");

                entity.Property(e => e.NextResetTokenReceiveDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.NextSpresetDate)
                    .HasColumnName("NextSPResetDate")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.NumberOfSpresets).HasColumnName("NumberOfSPResets");

                entity.Property(e => e.ProfessionId)
                    .HasColumnName("ProfessionID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RespawnAreaTag)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RespawnLocationOrientation).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RespawnLocationX).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RespawnLocationY).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RespawnLocationZ).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RevivalStoneCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnallocatedSp).HasColumnName("UnallocatedSP");

                entity.HasOne(d => d.Profession)
                    .WithMany(p => p.PlayerCharacters)
                    .HasForeignKey(d => d.ProfessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PlayerCharacters_ProfessionID");
            });

            modelBuilder.Entity<PlayerProgressionSkills>(entity =>
            {
                entity.HasKey(e => e.PlayerProgressionSkillId);

                entity.Property(e => e.PlayerProgressionSkillId).HasColumnName("PlayerProgressionSkillID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.ProgressionSkillId).HasColumnName("ProgressionSkillID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerProgressionSkills)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PlayerProgressionSkills_PlayerID");

                entity.HasOne(d => d.ProgressionSkill)
                    .WithMany(p => p.PlayerProgressionSkills)
                    .HasForeignKey(d => d.ProgressionSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PlayerProgressionSkills_ProgressionSkillID");
            });

            modelBuilder.Entity<Portraits>(entity =>
            {
                entity.HasKey(e => e.PortraitId);

                entity.Property(e => e.PortraitId)
                    .HasColumnName("PortraitID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e._2daid).HasColumnName("2DAID");
            });

            modelBuilder.Entity<ProfessionsDomain>(entity =>
            {
                entity.HasKey(e => e.ProfessionId);

                entity.Property(e => e.ProfessionId)
                    .HasColumnName("ProfessionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bonuses)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ProgressionLevels>(entity =>
            {
                entity.HasKey(e => e.Level);

                entity.Property(e => e.Level).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProgressionSkills>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.Property(e => e.SkillId)
                    .HasColumnName("SkillID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuestKillTargetList>(entity =>
            {
                entity.Property(e => e.QuestKillTargetListId).HasColumnName("QuestKillTargetListID");

                entity.Property(e => e.NpcgroupId).HasColumnName("NPCGroupID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.QuestStateId).HasColumnName("QuestStateID");

                entity.HasOne(d => d.NpcGroup)
                    .WithMany(p => p.QuestKillTargetList)
                    .HasForeignKey(d => d.NpcgroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTargetList_NPCGroupID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestKillTargetList)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTargetList_QuestID");

                entity.HasOne(d => d.QuestState)
                    .WithMany(p => p.QuestKillTargetList)
                    .HasForeignKey(d => d.QuestStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTargetList_QuestStateID");
            });

            modelBuilder.Entity<QuestPrerequisites>(entity =>
            {
                entity.HasKey(e => e.QuestPrerequisiteId);

                entity.Property(e => e.QuestPrerequisiteId).HasColumnName("QuestPrerequisiteID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.RequiredQuestId).HasColumnName("RequiredQuestID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestPrerequisitesQuest)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestPrerequisites_QuestID");

                entity.HasOne(d => d.RequiredQuest)
                    .WithMany(p => p.QuestPrerequisitesRequiredQuest)
                    .HasForeignKey(d => d.RequiredQuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestPrerequisites_RequiredQuestID");
            });

            modelBuilder.Entity<QuestRequiredItemList>(entity =>
            {
                entity.Property(e => e.QuestRequiredItemListId).HasColumnName("QuestRequiredItemListID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.QuestStateId).HasColumnName("QuestStateID");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRequiredItemList)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredItemList_QuestID");

                entity.HasOne(d => d.QuestState)
                    .WithMany(p => p.QuestRequiredItemList)
                    .HasForeignKey(d => d.QuestStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredItemList");
            });

            modelBuilder.Entity<QuestRequiredKeyItemList>(entity =>
            {
                entity.HasKey(e => e.QuestRequiredKeyItemId);

                entity.Property(e => e.QuestRequiredKeyItemId).HasColumnName("QuestRequiredKeyItemID");

                entity.Property(e => e.KeyItemId).HasColumnName("KeyItemID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.QuestStateId).HasColumnName("QuestStateID");

                entity.HasOne(d => d.KeyItem)
                    .WithMany(p => p.QuestRequiredKeyItemList)
                    .HasForeignKey(d => d.KeyItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItemList_KeyItemID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRequiredKeyItemList)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItemList_QuestID");

                entity.HasOne(d => d.QuestState)
                    .WithMany(p => p.QuestRequiredKeyItemList)
                    .HasForeignKey(d => d.QuestStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItemList");
            });

            modelBuilder.Entity<QuestRewardItems>(entity =>
            {
                entity.HasKey(e => e.QuestRewardItemId);

                entity.Property(e => e.QuestRewardItemId).HasColumnName("QuestRewardItemID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRewardItems)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRewards_QuestID");
            });

            modelBuilder.Entity<Quests>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.Property(e => e.QuestId)
                    .HasColumnName("QuestID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FameRegionId).HasColumnName("FameRegionID");

                entity.Property(e => e.JournalTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.MapNoteTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RewardKeyItemId).HasColumnName("RewardKeyItemID");

                entity.Property(e => e.RewardXp).HasColumnName("RewardXP");

                entity.Property(e => e.StartKeyItemId).HasColumnName("StartKeyItemID");

                entity.HasOne(d => d.FameRegion)
                    .WithMany(p => p.Quests)
                    .HasForeignKey(d => d.FameRegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quests_FameRegionID");

                entity.HasOne(d => d.RewardKeyItem)
                    .WithMany(p => p.QuestsRewardKeyItem)
                    .HasForeignKey(d => d.RewardKeyItemId)
                    .HasConstraintName("FK_Quests_RewardKeyItemID");

                entity.HasOne(d => d.StartKeyItem)
                    .WithMany(p => p.QuestsStartKeyItem)
                    .HasForeignKey(d => d.StartKeyItemId)
                    .HasConstraintName("FK_Quests_TemporaryKeyItemID");
            });

            modelBuilder.Entity<QuestStates>(entity =>
            {
                entity.HasKey(e => e.QuestStateId);

                entity.Property(e => e.QuestStateId).HasColumnName("QuestStateID");

                entity.Property(e => e.JournalStateId).HasColumnName("JournalStateID");

                entity.Property(e => e.QuestId).HasColumnName("QuestID");

                entity.Property(e => e.QuestTypeId).HasColumnName("QuestTypeID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestStates)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestStates_QuestID");

                entity.HasOne(d => d.QuestType)
                    .WithMany(p => p.QuestStates)
                    .HasForeignKey(d => d.QuestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestStates_QuestTypeID");
            });

            modelBuilder.Entity<QuestTypeDomain>(entity =>
            {
                entity.HasKey(e => e.QuestTypeId);

                entity.Property(e => e.QuestTypeId)
                    .HasColumnName("QuestTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ResearchBlueprints>(entity =>
            {
                entity.HasKey(e => e.ResearchBlueprintId);

                entity.Property(e => e.ResearchBlueprintId).HasColumnName("ResearchBlueprintID");

                entity.Property(e => e.CraftBlueprintId).HasColumnName("CraftBlueprintID");

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.ResearchPoints).HasDefaultValueSql("((0))");

                entity.Property(e => e.SkillRequired).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CraftBlueprint)
                    .WithMany(p => p.ResearchBlueprints)
                    .HasForeignKey(d => d.CraftBlueprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ResearchBlueprints_BlueprintID");
            });

            modelBuilder.Entity<ServerConfiguration>(entity =>
            {
                entity.Property(e => e.ServerConfigurationId)
                    .HasColumnName("ServerConfigurationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxExpAcquirable).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxExpGainDistance).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.MaxLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.MessageOfTheDay)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SpawnTableCreatures>(entity =>
            {
                entity.HasKey(e => e.SpawnTableCreatureId);

                entity.Property(e => e.SpawnTableCreatureId).HasColumnName("SpawnTableCreatureID");

                entity.Property(e => e.DifficultyRating).HasDefaultValueSql("((0))");

                entity.Property(e => e.LootTableId).HasColumnName("LootTableID");

                entity.Property(e => e.MaxNumberInArea).HasDefaultValueSql("((0))");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.SpawnTableId).HasColumnName("SpawnTableID");

                entity.Property(e => e.Weight).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LootTable)
                    .WithMany(p => p.SpawnTableCreatures)
                    .HasForeignKey(d => d.LootTableId)
                    .HasConstraintName("fk_SpawnTableCreatures_LootTableID");

                entity.HasOne(d => d.SpawnTable)
                    .WithMany(p => p.SpawnTableCreatures)
                    .HasForeignKey(d => d.SpawnTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SpawnTableCreatures_SpawnTableID");
            });

            modelBuilder.Entity<SpawnTables>(entity =>
            {
                entity.HasKey(e => e.SpawnTableId);

                entity.Property(e => e.SpawnTableId)
                    .HasColumnName("SpawnTableID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<StorageContainers>(entity =>
            {
                entity.HasKey(e => e.StorageContainerId);

                entity.Property(e => e.StorageContainerId)
                    .HasColumnName("StorageContainerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AreaResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.AreaTag)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<StorageItems>(entity =>
            {
                entity.HasKey(e => e.StorageItemId);

                entity.Property(e => e.StorageItemId).HasColumnName("StorageItemID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsRequired();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StorageContainerId).HasColumnName("StorageContainerID");

                entity.HasOne(d => d.StorageContainer)
                    .WithMany(p => p.StorageItems)
                    .HasForeignKey(d => d.StorageContainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_StorageItems_StorageContainerID");
            });

            modelBuilder.Entity<StructureBlueprints>(entity =>
            {
                entity.HasKey(e => e.StructureBlueprintId);

                entity.Property(e => e.StructureBlueprintId)
                    .HasColumnName("StructureBlueprintID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IronRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ResearchSlots).HasDefaultValueSql("((0))");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.RpperSecond)
                    .HasColumnName("RPPerSecond")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StructureCategoryId).HasColumnName("StructureCategoryID");

                entity.HasOne(d => d.StructureCategory)
                    .WithMany(p => p.StructureBlueprints)
                    .HasForeignKey(d => d.StructureCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_StructureBlueprints_StructureCategoryID");
            });

            modelBuilder.Entity<StructureCategories>(entity =>
            {
                entity.HasKey(e => e.StructureCategoryId);

                entity.Property(e => e.StructureCategoryId).HasColumnName("StructureCategoryID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<StructureQuickBuildAudit>(entity =>
            {
                entity.HasKey(e => e.StructureQuickBuildId);

                entity.Property(e => e.StructureQuickBuildId).HasColumnName("StructureQuickBuildID");

                entity.Property(e => e.DateBuilt).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Dmname)
                    .IsRequired()
                    .HasColumnName("DMName")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PcterritoryFlagId).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.PcterritoryFlagStructureId).HasColumnName("PCTerritoryFlagStructureID");

                entity.HasOne(d => d.PcTerritoryFlag)
                    .WithMany(p => p.StructureQuickBuildAudit)
                    .HasForeignKey(d => d.PcterritoryFlagId)
                    .HasConstraintName("FK_StructureQuickBuildAudit_PCTerritoryFlagID");

                entity.HasOne(d => d.PcTerritoryFlagStructure)
                    .WithMany(p => p.StructureQuickBuildAudit)
                    .HasForeignKey(d => d.PcterritoryFlagStructureId)
                    .HasConstraintName("FK_StructureQuickBuildAudit_PCTerritoryFlagStructureID");
            });

            modelBuilder.Entity<TerritoryFlagPermissions>(entity =>
            {
                entity.HasKey(e => e.TerritoryFlagPermissionId);

                entity.Property(e => e.TerritoryFlagPermissionId)
                    .HasColumnName("TerritoryFlagPermissionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AvatarHash).IsRequired();

                entity.Property(e => e.DiscordUserId)
                    .IsRequired()
                    .HasColumnName("DiscordUserID");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Users_RoleID");
            });

            modelBuilder.Entity<ZombieClothes>(entity =>
            {
                entity.Property(e => e.ZombieClothesId)
                    .HasColumnName("ZombieClothesID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);
            });
        }
    }
}
