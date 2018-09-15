using Microsoft.EntityFrameworkCore;
using SWLOR.Web.Data.Entities;

namespace SWLOR.Web.Data
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<AuthorizedDM> AuthorizedDMs { get; set; }
        public virtual DbSet<BaseItemType> BaseItemTypes { get; set; }
        public virtual DbSet<BuildPrivacyDomain> BuildPrivacyDomain { get; set; }
        public virtual DbSet<ChatChannelsDomain> ChatChannelsDomain { get; set; }
        public virtual DbSet<ChatLog> ChatLog { get; set; }
        public virtual DbSet<ClientLogEvent> ClientLogEvents { get; set; }
        public virtual DbSet<ClientLogEventTypesDomain> ClientLogEventTypesDomain { get; set; }
        public virtual DbSet<ConstructionSiteComponent> ConstructionSiteComponents { get; set; }
        public virtual DbSet<ConstructionSite> ConstructionSites { get; set; }
        public virtual DbSet<CooldownCategory> CooldownCategories { get; set; }
        public virtual DbSet<CraftBlueprintCategory> CraftBlueprintCategories { get; set; }
        public virtual DbSet<CraftBlueprintComponent> CraftBlueprintComponents { get; set; }
        public virtual DbSet<CraftBlueprint> CraftBlueprints { get; set; }
        public virtual DbSet<CraftDevice> CraftDevices { get; set; }
        public virtual DbSet<CustomEffect> CustomEffects { get; set; }
        public virtual DbSet<DMRoleDomain> DMRoleDomain { get; set; }
        public virtual DbSet<Download> Downloads { get; set; }
        public virtual DbSet<FameRegion> FameRegions { get; set; }
        public virtual DbSet<GameTopic> GameTopics { get; set; }
        public virtual DbSet<GameTopicCategory> GameTopicCategories { get; set; }
        public virtual DbSet<GrowingPlant> GrowingPlants { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<KeyItemCategory> KeyItemCategories { get; set; }
        public virtual DbSet<KeyItem> KeyItems { get; set; }
        public virtual DbSet<LootTableItem> LootTableItems { get; set; }
        public virtual DbSet<LootTable> LootTables { get; set; }
        public virtual DbSet<NPCGroup> NPCGroups { get; set; }
        public virtual DbSet<PCCooldown> PCCooldowns { get; set; }
        public virtual DbSet<PCCorpseItem> PCCorpseItems { get; set; }
        public virtual DbSet<PCCorpse> PCCorpses { get; set; }
        public virtual DbSet<PCCustomEffect> PCCustomEffects { get; set; }
        public virtual DbSet<PCKeyItem> PCKeyItems { get; set; }
        public virtual DbSet<PCMapPin> PCMapPins { get; set; }
        public virtual DbSet<PCMigrationItem> PCMigrationItems { get; set; }
        public virtual DbSet<PCMigration> PCMigrations { get; set; }
        public virtual DbSet<PCOutfit> PCOutfits { get; set; }
        public virtual DbSet<PCOverflowItem> PCOverflowItems { get; set; }
        public virtual DbSet<PCPerk> PCPerks { get; set; }
        public virtual DbSet<PCQuestKillTargetProgress> PCQuestKillTargetProgress { get; set; }
        public virtual DbSet<PCQuestStatus> PCQuestStatus { get; set; }
        public virtual DbSet<PCRegionalFame> PCRegionalFame { get; set; }
        public virtual DbSet<PCSearchSiteItem> PCSearchSiteItems { get; set; }
        public virtual DbSet<PCSearchSite> PCSearchSites { get; set; }
        public virtual DbSet<PCSkill> PCSkills { get; set; }
        public virtual DbSet<PCTerritoryFlag> PCTerritoryFlags { get; set; }
        public virtual DbSet<PCTerritoryFlagsPermission> PCTerritoryFlagsPermissions { get; set; }
        public virtual DbSet<PCTerritoryFlagsStructure> PCTerritoryFlagsStructures { get; set; }
        public virtual DbSet<PCTerritoryFlagsStructuresItem> PCTerritoryFlagsStructuresItems { get; set; }
        public virtual DbSet<PerkCategory> PerkCategories { get; set; }
        public virtual DbSet<PerkExecutionType> PerkExecutionTypes { get; set; }
        public virtual DbSet<PerkLevel> PerkLevels { get; set; }
        public virtual DbSet<PerkLevelSkillRequirement> PerkLevelSkillRequirements { get; set; }
        public virtual DbSet<Perk> Perks { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }
        public virtual DbSet<PlayerCharacter> PlayerCharacters { get; set; }
        public virtual DbSet<QuestKillTargetList> QuestKillTargetList { get; set; }
        public virtual DbSet<QuestPrerequisite> QuestPrerequisites { get; set; }
        public virtual DbSet<QuestRequiredItemList> QuestRequiredItemList { get; set; }
        public virtual DbSet<QuestRequiredKeyItemList> QuestRequiredKeyItemList { get; set; }
        public virtual DbSet<QuestRewardItem> QuestRewardItems { get; set; }
        public virtual DbSet<Quests> Quests { get; set; }
        public virtual DbSet<QuestState> QuestStates { get; set; }
        public virtual DbSet<QuestTypeDomain> QuestTypeDomain { get; set; }
        public virtual DbSet<ServerConfiguration> ServerConfiguration { get; set; }
        public virtual DbSet<SkillCategory> SkillCategories { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SkillXPRequirement> SkillXPRequirement { get; set; }
        public virtual DbSet<StorageContainer> StorageContainers { get; set; }
        public virtual DbSet<StorageItem> StorageItems { get; set; }
        public virtual DbSet<StructureBlueprint> StructureBlueprints { get; set; }
        public virtual DbSet<StructureCategory> StructureCategories { get; set; }
        public virtual DbSet<StructureComponent> StructureComponents { get; set; }
        public virtual DbSet<StructureQuickBuildAudit> StructureQuickBuildAudit { get; set; }
        public virtual DbSet<TerritoryFlagPermission> TerritoryFlagPermissions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attribute>(entity =>
            {
                entity.ToTable("Attributes");
                entity.HasKey(e => e.AttributeID);

                entity.Property(e => e.AttributeID)
                    .HasColumnName("AttributeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NWNValue)
                    .HasColumnName("NWNValue")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AuthorizedDM>(entity =>
            {
                entity.HasKey(e => e.AuthorizedDMID);

                entity.ToTable("AuthorizedDMs");

                entity.Property(e => e.AuthorizedDMID).HasColumnName("AuthorizedDMID");

                entity.Property(e => e.CDKey)
                    .IsRequired()
                    .HasColumnName("CDKey")
                    .HasMaxLength(20);

                entity.Property(e => e.DMRole).HasColumnName("DMRole");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BaseItemType>(entity =>
            {
                entity.ToTable("BaseItemTypes");
                entity.HasKey(e => e.BaseItemTypeID);

                entity.Property(e => e.BaseItemTypeID)
                    .HasColumnName("BaseItemTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<BuildPrivacyDomain>(entity =>
            {
                entity.ToTable("BuildPrivacyDomain");
                entity.HasKey(e => e.BuildPrivacyTypeID);

                entity.Property(e => e.BuildPrivacyTypeID)
                    .HasColumnName("BuildPrivacyTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<ChatChannelsDomain>(entity =>
            {
                entity.ToTable("ChatChannelsDomain");
                entity.HasKey(e => e.ChatChannelID);

                entity.Property(e => e.ChatChannelID)
                    .HasColumnName("ChatChannelID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ChatLog>(entity =>
            {
                entity.ToTable("ChatLog");
                entity.Property(e => e.ChatLogID).HasColumnName("ChatLogID");

                entity.Property(e => e.ChatChannelID).HasColumnName("ChatChannelID");

                entity.Property(e => e.DateSent).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceiverAccountName).HasMaxLength(1024);

                entity.Property(e => e.ReceiverCDKey)
                    .HasColumnName("ReceiverCDKey")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceiverDMName)
                    .HasColumnName("ReceiverDMName")
                    .HasMaxLength(60);

                entity.Property(e => e.ReceiverPlayerID)
                    .HasColumnName("ReceiverPlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.SenderAccountName)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderCDKey)
                    .IsRequired()
                    .HasColumnName("SenderCDKey")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderDMName)
                    .HasColumnName("SenderDMName")
                    .HasMaxLength(60);

                entity.Property(e => e.SenderPlayerID)
                    .HasColumnName("SenderPlayerID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ClientLogEvent>(entity =>
            {
                entity.ToTable("ClientLogEvents");
                entity.HasKey(e => e.ClientLogEventID);

                entity.Property(e => e.ClientLogEventID).HasColumnName("ClientLogEventID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.CDKey)
                    .IsRequired()
                    .HasColumnName("CDKey")
                    .HasMaxLength(20);

                entity.Property(e => e.ClientLogEventTypeID).HasColumnName("ClientLogEventTypeID");

                entity.Property(e => e.DateOfEvent).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PlayerID)
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ClientLogEventTypesDomain>(entity =>
            {
                entity.ToTable("ClientLogEventTypesDomain");
                entity.HasKey(e => e.ClientLogEventTypeID);

                entity.Property(e => e.ClientLogEventTypeID)
                    .HasColumnName("ClientLogEventTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ConstructionSiteComponent>(entity =>
            {
                entity.ToTable("ConstructionSiteComponents");
                entity.HasKey(e => e.ConstructionSiteComponentID);

                entity.Property(e => e.ConstructionSiteComponentID).HasColumnName("ConstructionSiteComponentID");

                entity.Property(e => e.ConstructionSiteID).HasColumnName("ConstructionSiteID");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.StructureComponentID).HasColumnName("StructureComponentID");

                entity.HasOne(d => d.ConstructionSite)
                    .WithMany(p => p.ConstructionSiteComponents)
                    .HasForeignKey(d => d.ConstructionSiteID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConstructionSiteComponents_ConstructionSiteID");
            });

            modelBuilder.Entity<ConstructionSite>(entity =>
            {
                entity.ToTable("ConstructionSites");
                entity.HasKey(e => e.ConstructionSiteID);

                entity.Property(e => e.ConstructionSiteID).HasColumnName("ConstructionSiteID");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PCTerritoryFlagID).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.StructureBlueprintID).HasColumnName("StructureBlueprintID");

                entity.HasOne(d => d.PCTerritoryFlag)
                    .WithMany(p => p.ConstructionSites)
                    .HasForeignKey(d => d.PCTerritoryFlagID)
                    .HasConstraintName("fk_ConstructionSites_PCTerritoryFlagID");
            });

            modelBuilder.Entity<CooldownCategory>(entity =>
            {
                entity.ToTable("CooldownCategories");
                entity.HasKey(e => e.CooldownCategoryID);

                entity.Property(e => e.CooldownCategoryID)
                    .HasColumnName("CooldownCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseCooldownTime).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CraftBlueprintCategory>(entity =>
            {
                entity.ToTable("CraftBlueprintCategories");
                entity.HasKey(e => e.CraftBlueprintCategoryID);

                entity.Property(e => e.CraftBlueprintCategoryID)
                    .HasColumnName("CraftBlueprintCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<CraftBlueprintComponent>(entity =>
            {
                entity.ToTable("CraftBlueprintComponents");
                entity.HasKey(e => e.CraftComponentID);

                entity.Property(e => e.CraftComponentID).HasColumnName("CraftComponentID");

                entity.Property(e => e.CraftBlueprintID).HasColumnName("CraftBlueprintID");

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.CraftBlueprint)
                    .WithMany(p => p.CraftBlueprintComponents)
                    .HasForeignKey(d => d.CraftBlueprintID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprintComponents_CraftBlueprintID");
            });

            modelBuilder.Entity<CraftBlueprint>(entity =>
            {
                entity.ToTable("CraftBlueprints");
                entity.HasKey(e => e.CraftBlueprintID);

                entity.Property(e => e.CraftBlueprintID)
                    .HasColumnName("CraftBlueprintID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CraftCategoryID).HasColumnName("CraftCategoryID");

                entity.Property(e => e.CraftDeviceID).HasColumnName("CraftDeviceID");

                entity.Property(e => e.CraftTierLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.PerkID).HasColumnName("PerkID");

                entity.Property(e => e.RequiredPerkLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.SkillID).HasColumnName("SkillID");
            });

            modelBuilder.Entity<CraftDevice>(entity =>
            {
                entity.ToTable("CraftDevices");
                entity.HasKey(e => e.CraftDeviceID);

                entity.Property(e => e.CraftDeviceID)
                    .HasColumnName("CraftDeviceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CustomEffect>(entity =>
            {
                entity.ToTable("CustomEffects");
                entity.HasKey(e => e.CustomEffectID);

                entity.Property(e => e.CustomEffectID)
                    .HasColumnName("CustomEffectID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContinueMessage)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.IconID).HasColumnName("IconID");

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

            modelBuilder.Entity<DMRoleDomain>(entity =>
            {
                entity.ToTable("DMRoleDomain");

                entity.Property(e => e.DMRoleDomainID)
                    .HasColumnName("DMRoleDomainID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Download>(entity =>
            {
                entity.ToTable("Downloads");
                entity.HasKey(e => e.DownloadID);

                entity.Property(e => e.DownloadID)
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

                entity.Property(e => e.URL)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<FameRegion>(entity =>
            {
                entity.ToTable("FameRegions");
                entity.HasKey(e => e.FameRegionID);

                entity.Property(e => e.FameRegionID)
                    .HasColumnName("FameRegionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<GameTopic>(entity =>
            {
                entity.ToTable("GameTopics");
                entity.HasKey(e => e.GameTopicID);

                entity.Property(e => e.GameTopicID)
                    .HasColumnName("GameTopicID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Text)
                    .IsRequired();
            });

            modelBuilder.Entity<GameTopicCategory>(entity =>
            {
                entity.ToTable("GameTopicCategories");
                entity.HasKey(e => e.GameTopicCategoryID);

                entity.Property(e => e.GameTopicCategoryID)
                    .HasColumnName("GameTopicCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<GrowingPlant>(entity =>
            {
                entity.ToTable("GrowingPlants");
                entity.HasKey(e => e.GrowingPlantID);

                entity.Property(e => e.GrowingPlantID).HasColumnName("GrowingPlantID");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationOrientation)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationX)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationY)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationZ)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LongevityBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlantID).HasColumnName("PlantID");

                entity.Property(e => e.RemainingTicks).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalTicks).HasDefaultValueSql("((0))");

                entity.Property(e => e.WaterStatus).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Items");
                entity.HasKey(e => e.Resref);

                entity.Property(e => e.Resref)
                    .HasMaxLength(16)
                    .ValueGeneratedNever();

                entity.Property(e => e.AC)
                    .HasColumnName("AC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AssociatedSkillID)
                    .HasColumnName("AssociatedSkillID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CastingSpeed).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftBonusArmorsmith).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftBonusCooking).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftBonusMetalworking).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftBonusWeaponsmith).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftBonusWoodworking).HasDefaultValueSql("((0))");

                entity.Property(e => e.CraftTierLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.DurabilityPoints).HasDefaultValueSql("((0))");

                entity.Property(e => e.HPBonus)
                    .HasColumnName("HPBonus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemTypeID)
                    .HasColumnName("ItemTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LoggingBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ManaBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.MiningBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecommendedLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.Weight).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.ToTable("ItemTypes");
                entity.HasKey(e => e.ItemTypeID);

                entity.Property(e => e.ItemTypeID)
                    .HasColumnName("ItemTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<KeyItemCategory>(entity =>
            {
                entity.ToTable("KeyItemCategories");
                entity.HasKey(e => e.KeyItemCategoryID);

                entity.Property(e => e.KeyItemCategoryID)
                    .HasColumnName("KeyItemCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<KeyItem>(entity =>
            {
                entity.ToTable("KeyItems");
                entity.HasKey(e => e.KeyItemID);

                entity.Property(e => e.KeyItemID)
                    .HasColumnName("KeyItemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.KeyItemCategoryID).HasColumnName("KeyItemCategoryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<LootTableItem>(entity =>
            {
                entity.ToTable("LootTableItems");
                entity.HasKey(e => e.LootTableItemID);

                entity.Property(e => e.LootTableItemID).HasColumnName("LootTableItemID");

                entity.Property(e => e.LootTableID).HasColumnName("LootTableID");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LootTable>(entity =>
            {
                entity.ToTable("LootTables");
                entity.HasKey(e => e.LootTableID);

                entity.Property(e => e.LootTableID)
                    .HasColumnName("LootTableID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<NPCGroup>(entity =>
            {
                entity.ToTable("NPCGroups");
                entity.HasKey(e => e.NPCGroupID);

                entity.Property(e => e.NPCGroupID)
                    .HasColumnName("NPCGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PCCooldown>(entity =>
            {
                entity.ToTable("PCCooldowns");
                entity.HasKey(e => e.PCCooldownID);
                
                entity.Property(e => e.PCCooldownID).HasColumnName("PCCooldownID");

                entity.Property(e => e.CooldownCategoryID).HasColumnName("CooldownCategoryID");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<PCCorpseItem>(entity =>
            {
                entity.ToTable("PCCorpseItems");
                entity.HasKey(e => e.PCCorpseItemID);
                
                entity.Property(e => e.PCCorpseItemID).HasColumnName("PCCorpseItemID");

                entity.Property(e => e.NWItemObject)
                    .IsRequired()
                    .HasColumnName("NWItemObject");

                entity.Property(e => e.PCCorpseID).HasColumnName("PCCorpseID");

                entity.HasOne(d => d.PCCorpse)
                    .WithMany(p => p.PCCorpseItems)
                    .HasForeignKey(d => d.PCCorpseID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCorpseItems_PCCorpseID");
            });

            modelBuilder.Entity<PCCorpse>(entity =>
            {
                entity.ToTable("PCCorpses");
                entity.HasKey(e => e.PCCorpseID);
                
                entity.Property(e => e.PCCorpseID).HasColumnName("PCCorpseID");

                entity.Property(e => e.AreaTag).HasMaxLength(32);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PCCustomEffect>(entity =>
            {
                entity.ToTable("PCCustomEffects");
                entity.HasKey(e => e.PCCustomEffectID);
                
                entity.Property(e => e.PCCustomEffectID).HasColumnName("PCCustomEffectID");

                entity.Property(e => e.CustomEffectID).HasColumnName("CustomEffectID");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<PCKeyItem>(entity =>
            {
                entity.ToTable("PCKeyItems");

                entity.HasKey(e => e.PCKeyItemID);
                
                entity.Property(e => e.PCKeyItemID).HasColumnName("PCKeyItemID");

                entity.Property(e => e.AcquiredDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.KeyItemID).HasColumnName("KeyItemID");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<PCMapPin>(entity =>
            {
                entity.ToTable("PCMapPins");

                entity.HasKey(e => e.PCMapPinID);
                
                entity.Property(e => e.PCMapPinID).HasColumnName("PCMapPinID");

                entity.Property(e => e.AreaTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.NoteText)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<PCMigrationItem>(entity =>
            {
                entity.ToTable("PCMigrationItems");
                entity.HasKey(e => e.PCMigrationItemID);
                
                entity.Property(e => e.PCMigrationItemID)
                    .HasColumnName("PCMigrationItemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseItemTypeID).HasColumnName("BaseItemTypeID");

                entity.Property(e => e.CurrentResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.NewResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.PCMigrationID).HasColumnName("PCMigrationID");
                
                entity.HasOne(d => d.PCMigration)
                    .WithMany(p => p.PcmigrationItems)
                    .HasForeignKey(d => d.PCMigrationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCMigrationItems_PCMigrationID");
            });

            modelBuilder.Entity<PCMigration>(entity =>
            {
                entity.ToTable("PCMigrations");

                entity.HasKey(e => e.PCMigrationID);

                entity.Property(e => e.PCMigrationID)
                    .HasColumnName("PCMigrationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<PCOutfit>(entity =>
            {
                entity.ToTable("PCOutfits");
                entity.HasKey(e => e.PlayerID);
                
                entity.Property(e => e.PlayerID)
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<PCOverflowItem>(entity =>
            {
                entity.ToTable("PCOverflowItems");
                entity.HasKey(e => e.PCOverflowItemID);
                
                entity.Property(e => e.PCOverflowItemID).HasColumnName("PCOverflowItemID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsRequired();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<PCPerk>(entity =>
            {
                entity.ToTable("PCPerks");
                entity.HasKey(e => e.PCPerkID);
                
                entity.Property(e => e.PCPerkID).HasColumnName("PCPerkID");

                entity.Property(e => e.AcquiredDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PerkID).HasColumnName("PerkID");

                entity.Property(e => e.PerkLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<PCQuestKillTargetProgress>(entity =>
            {
                entity.ToTable("PCQuestKillTargetProgress");

                entity.Property(e => e.PCQuestKillTargetProgressID).HasColumnName("PCQuestKillTargetProgressID");

                entity.Property(e => e.NPCGroupID).HasColumnName("NPCGroupID");

                entity.Property(e => e.PCQuestStatusID).HasColumnName("PCQuestStatusID");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);
                
                entity.HasOne(d => d.PCQuestStatus)
                    .WithMany(p => p.PCQuestKillTargetProgress)
                    .HasForeignKey(d => d.PCQuestStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_PCQuestStatusID");
            });

            modelBuilder.Entity<PCQuestStatus>(entity =>
            {
                entity.ToTable("PCQuestStatus");

                entity.Property(e => e.PCQuestStatusID).HasColumnName("PCQuestStatusID");

                entity.Property(e => e.CurrentQuestStateID).HasColumnName("CurrentQuestStateID");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.QuestID).HasColumnName("QuestID");

                entity.Property(e => e.SelectedItemRewardID).HasColumnName("SelectedItemRewardID");
            });

            modelBuilder.Entity<PCRegionalFame>(entity =>
            {
                entity.ToTable("PCRegionalFame");

                entity.Property(e => e.PCRegionalFameID).HasColumnName("PCRegionalFameID");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FameRegionID).HasColumnName("FameRegionID");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<PCSearchSiteItem>(entity =>
            {
                entity.ToTable("PCSearchSiteItems");
                entity.HasKey(e => e.PCSearchSiteItemID);
                
                entity.Property(e => e.PCSearchSiteItemID).HasColumnName("PCSearchSiteItemID");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.SearchItem).IsRequired();

                entity.Property(e => e.SearchSiteID).HasColumnName("SearchSiteID");
            });

            modelBuilder.Entity<PCSearchSite>(entity =>
            {
                entity.ToTable("PCSearchSites");
                entity.HasKey(e => e.PCSearchSiteID);
                
                entity.Property(e => e.PCSearchSiteID).HasColumnName("PCSearchSiteID");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.SearchSiteID).HasColumnName("SearchSiteID");

                entity.Property(e => e.UnlockDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PCSkill>(entity =>
            {
                entity.ToTable("PCSkills");
                entity.HasKey(e => e.PCSkillID);
                
                entity.Property(e => e.PCSkillID).HasColumnName("PCSkillID");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.Rank).HasDefaultValueSql("((0))");

                entity.Property(e => e.SkillID).HasColumnName("SkillID");

                entity.Property(e => e.XP)
                    .HasColumnName("XP")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PCTerritoryFlag>(entity =>
            {
                entity.ToTable("PCTerritoryFlags");
                entity.HasKey(e => e.PCTerritoryFlagID);
                
                entity.Property(e => e.PCTerritoryFlagID).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.BuildPrivacySettingID)
                    .HasColumnName("BuildPrivacySettingID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.StructureBlueprintID).HasColumnName("StructureBlueprintID");
            });

            modelBuilder.Entity<PCTerritoryFlagsPermission>(entity =>
            {
                entity.ToTable("PCTerritoryFlagsPermissions");
                entity.HasKey(e => e.PCTerritoryFlagPermissionID);
                
                entity.Property(e => e.PCTerritoryFlagPermissionID).HasColumnName("PCTerritoryFlagPermissionID");

                entity.Property(e => e.PCTerritoryFlagID).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60);

                entity.Property(e => e.TerritoryFlagPermissionID).HasColumnName("TerritoryFlagPermissionID");

                entity.HasOne(d => d.PCTerritoryFlag)
                    .WithMany(p => p.PCTerritoryFlagsPermissions)
                    .HasForeignKey(d => d.PCTerritoryFlagID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsPermissions_PCTerritoryFlagID");
            });

            modelBuilder.Entity<PCTerritoryFlagsStructure>(entity =>
            {
                entity.HasKey(e => e.PCTerritoryFlagStructureID);

                entity.ToTable("PCTerritoryFlagsStructures");

                entity.Property(e => e.PCTerritoryFlagStructureID).HasColumnName("PCTerritoryFlagStructureID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CustomName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PCTerritoryFlagID).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.StructureBlueprintID).HasColumnName("StructureBlueprintID");

                entity.HasOne(d => d.PCTerritoryFlag)
                    .WithMany(p => p.PCTerritoryFlagsStructures)
                    .HasForeignKey(d => d.PCTerritoryFlagID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsStructures_PCTerritoryFlagID");
            });

            modelBuilder.Entity<PCTerritoryFlagsStructuresItem>(entity =>
            {
                entity.HasKey(e => e.PCStructureItemID);

                entity.ToTable("PCTerritoryFlagsStructuresItems");

                entity.Property(e => e.PCStructureItemID).HasColumnName("PCStructureItemID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsRequired();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PCStructureID).HasColumnName("PCStructureID");

                entity.HasOne(d => d.PCStructure)
                    .WithMany(p => p.PCTerritoryFlagsStructuresItems)
                    .HasForeignKey(d => d.PCStructureID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCTerritoryFlagsStructuresItems_PCStructureID");
            });

            modelBuilder.Entity<PerkCategory>(entity =>
            {
                entity.ToTable("PerkCategories");
                entity.HasKey(e => e.PerkCategoryID);

                entity.Property(e => e.PerkCategoryID)
                    .HasColumnName("PerkCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sequence).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PerkExecutionType>(entity =>
            {
                entity.ToTable("PerkExecutionTypes");
                entity.HasKey(e => e.PerkExecutionTypeID);

                entity.Property(e => e.PerkExecutionTypeID)
                    .HasColumnName("PerkExecutionTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PerkLevel>(entity =>
            {
                entity.ToTable("PerkLevels");
                entity.HasKey(e => e.PerkLevelID);

                entity.HasIndex(e => new { PerkId = e.PerkID, e.Level })
                    .HasName("uq_PerkLevels_PerkIDLevel")
                    .IsUnique();

                entity.Property(e => e.PerkLevelID).HasColumnName("PerkLevelID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.PerkID).HasColumnName("PerkID");

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PerkLevelSkillRequirement>(entity =>
            {
                entity.ToTable("PerkLevelSkillRequirements");
                entity.HasKey(e => e.PerkLevelSkillRequirementID);

                entity.Property(e => e.PerkLevelSkillRequirementID).HasColumnName("PerkLevelSkillRequirementID");

                entity.Property(e => e.PerkLevelID).HasColumnName("PerkLevelID");

                entity.Property(e => e.RequiredRank).HasDefaultValueSql("((0))");

                entity.Property(e => e.SkillID).HasColumnName("SkillID");

                

            });

            modelBuilder.Entity<Perk>(entity =>
            {
                entity.ToTable("Perks");
                entity.HasKey(e => e.PerkID);

                entity.Property(e => e.PerkID)
                    .HasColumnName("PerkID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseCastingTime).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.BaseManaCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.CooldownCategoryID).HasColumnName("CooldownCategoryID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExecutionTypeID)
                    .HasColumnName("ExecutionTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FeatID)
                    .HasColumnName("FeatID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemResref).HasMaxLength(16);

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

                entity.Property(e => e.PerkCategoryID).HasColumnName("PerkCategoryID");
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.ToTable("Plants");
                entity.HasKey(e => e.PlantID);

                entity.Property(e => e.PlantID)
                    .HasColumnName("PlantID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseTicks).HasDefaultValueSql("((0))");

                entity.Property(e => e.Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WaterTicks).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PlayerCharacter>(entity =>
            {
                entity.ToTable("PlayerCharacters");
                entity.HasKey(e => e.PlayerID);

                entity.Property(e => e.PlayerID)
                    .HasColumnName("PlayerID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CHABase)
                    .HasColumnName("CHABase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CONBase)
                    .HasColumnName("CONBase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTimestamp)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CurrentMana).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentManaTick).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateLastForcedSPReset).HasColumnName("DateLastForcedSPReset");

                entity.Property(e => e.DateSanctuaryEnds).HasDefaultValueSql("(dateadd(hour,(72),getutcdate()))");

                entity.Property(e => e.DEXBase)
                    .HasColumnName("DEXBase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayHelmet).HasDefaultValueSql("((1))");

                entity.Property(e => e.HPRegenerationAmount).HasColumnName("HPRegenerationAmount");

                entity.Property(e => e.INTBase)
                    .HasColumnName("INTBase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.MaxMana).HasDefaultValueSql("((0))");

                entity.Property(e => e.NextResetTokenReceiveDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.NextSPResetDate)
                    .HasColumnName("NextSPResetDate")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.NumberOfSPResets).HasColumnName("NumberOfSPResets");

                entity.Property(e => e.RespawnAreaTag)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RespawnLocationOrientation).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RespawnLocationX).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RespawnLocationY).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RespawnLocationZ).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RevivalStoneCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.STRBase)
                    .HasColumnName("STRBase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSPAcquired)
                    .HasColumnName("TotalSPAcquired")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnallocatedSP).HasColumnName("UnallocatedSP");

                entity.Property(e => e.WISBase)
                    .HasColumnName("WISBase")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QuestKillTargetList>(entity =>
            {
                entity.ToTable("QuestKillTargetList");
                entity.Property(e => e.QuestKillTargetListID).HasColumnName("QuestKillTargetListID");

                entity.Property(e => e.NPCGroupID).HasColumnName("NPCGroupID");

                entity.Property(e => e.QuestID).HasColumnName("QuestID");

                entity.Property(e => e.QuestStateID).HasColumnName("QuestStateID");
                
                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestKillTargetList)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTargetList_QuestID");

                entity.HasOne(d => d.QuestState)
                    .WithMany(p => p.QuestKillTargetList)
                    .HasForeignKey(d => d.QuestStateID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTargetList_QuestStateID");
            });

            modelBuilder.Entity<QuestPrerequisite>(entity =>
            {
                entity.ToTable("QuestPrerequisites");
                entity.HasKey(e => e.QuestPrerequisiteID);

                entity.Property(e => e.QuestPrerequisiteID).HasColumnName("QuestPrerequisiteID");

                entity.Property(e => e.QuestID).HasColumnName("QuestID");

                entity.Property(e => e.RequiredQuestID).HasColumnName("RequiredQuestID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestPrerequisitesQuest)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestPrerequisites_QuestID");

                entity.HasOne(d => d.RequiredQuest)
                    .WithMany(p => p.QuestPrerequisitesRequiredQuest)
                    .HasForeignKey(d => d.RequiredQuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestPrerequisites_RequiredQuestID");
            });

            modelBuilder.Entity<QuestRequiredItemList>(entity =>
            {
                entity.ToTable("QuestRequiredItemList");
                entity.Property(e => e.QuestRequiredItemListID).HasColumnName("QuestRequiredItemListID");

                entity.Property(e => e.QuestID).HasColumnName("QuestID");

                entity.Property(e => e.QuestStateID).HasColumnName("QuestStateID");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRequiredItemList)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredItemList_QuestID");

                entity.HasOne(d => d.QuestState)
                    .WithMany(p => p.QuestRequiredItemList)
                    .HasForeignKey(d => d.QuestStateID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredItemList");
            });

            modelBuilder.Entity<QuestRequiredKeyItemList>(entity =>
            {
                entity.ToTable("QuestRequiredKeyItemList");
                entity.HasKey(e => e.QuestRequiredKeyItemID);

                entity.Property(e => e.QuestRequiredKeyItemID).HasColumnName("QuestRequiredKeyItemID");

                entity.Property(e => e.KeyItemID).HasColumnName("KeyItemID");

                entity.Property(e => e.QuestID).HasColumnName("QuestID");

                entity.Property(e => e.QuestStateID).HasColumnName("QuestStateID");
                
                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRequiredKeyItemList)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItemList_QuestID");

                entity.HasOne(d => d.QuestState)
                    .WithMany(p => p.QuestRequiredKeyItemList)
                    .HasForeignKey(d => d.QuestStateID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItemList");
            });

            modelBuilder.Entity<QuestRewardItem>(entity =>
            {
                entity.ToTable("QuestRewardItems");
                entity.HasKey(e => e.QuestRewardItemID);

                entity.Property(e => e.QuestRewardItemID).HasColumnName("QuestRewardItemID");

                entity.Property(e => e.QuestID).HasColumnName("QuestID");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRewardItems)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRewards_QuestID");
            });

            modelBuilder.Entity<Quests>(entity =>
            {
                entity.ToTable("Quests");
                entity.HasKey(e => e.QuestID);

                entity.Property(e => e.QuestID).HasColumnName("QuestID");

                entity.Property(e => e.FameRegionID).HasColumnName("FameRegionID");

                entity.Property(e => e.JournalTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.MapNoteTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RewardKeyItemID).HasColumnName("RewardKeyItemID");

                entity.Property(e => e.RewardXP).HasColumnName("RewardXP");

                entity.Property(e => e.StartKeyItemID).HasColumnName("StartKeyItemID");
            });

            modelBuilder.Entity<QuestState>(entity =>
            {
                entity.ToTable("QuestStates");
                entity.HasKey(e => e.QuestStateID);

                entity.Property(e => e.QuestStateID).HasColumnName("QuestStateID");

                entity.Property(e => e.JournalStateID).HasColumnName("JournalStateID");

                entity.Property(e => e.QuestID).HasColumnName("QuestID");

                entity.Property(e => e.QuestTypeID).HasColumnName("QuestTypeID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestStates)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestStates_QuestID");
            });

            modelBuilder.Entity<QuestTypeDomain>(entity =>
            {
                entity.ToTable("QuestTypeDomain");
                entity.HasKey(e => e.QuestTypeID);

                entity.Property(e => e.QuestTypeID)
                    .HasColumnName("QuestTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ServerConfiguration>(entity =>
            {
                entity.ToTable("ServerConfiguration");
                entity.Property(e => e.ServerConfigurationID)
                    .HasColumnName("ServerConfigurationID")
                    .ValueGeneratedNever();

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

            modelBuilder.Entity<SkillCategory>(entity =>
            {
                entity.ToTable("SkillCategories");
                entity.HasKey(e => e.SkillCategoryID);

                entity.Property(e => e.SkillCategoryID)
                    .HasColumnName("SkillCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sequence).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skills");
                entity.HasKey(e => e.SkillID);

                entity.Property(e => e.SkillID)
                    .HasColumnName("SkillID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaxRank).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrimaryID)
                    .HasColumnName("Primary")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SecondaryID)
                    .HasColumnName("Secondary")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SkillCategoryID)
                    .HasColumnName("SkillCategoryID");

                entity.Property(e => e.TertiaryID)
                    .HasColumnName("Tertiary")
                    .HasDefaultValueSql("('')");
               
                
                
            });

            modelBuilder.Entity<SkillXPRequirement>(entity =>
            {
                entity.ToTable("SkillXPRequirement");

                entity.Property(e => e.SkillXPRequirementID).HasColumnName("SkillXPRequirementID");

                entity.Property(e => e.SkillID).HasColumnName("SkillID");

                entity.Property(e => e.XP).HasColumnName("XP");
            });

            modelBuilder.Entity<StorageContainer>(entity =>
            {
                entity.ToTable("StorageContainers");
                entity.HasKey(e => e.StorageContainerID);

                entity.Property(e => e.StorageContainerID)
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

            modelBuilder.Entity<StorageItem>(entity =>
            {
                entity.ToTable("StorageItems");
                entity.HasKey(e => e.StorageItemID);

                entity.Property(e => e.StorageItemID).HasColumnName("StorageItemID");

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsRequired();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StorageContainerID).HasColumnName("StorageContainerID");

                entity.HasOne(d => d.StorageContainer)
                    .WithMany(p => p.StorageItems)
                    .HasForeignKey(d => d.StorageContainerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_StorageItems_StorageContainerID");
            });

            modelBuilder.Entity<StructureBlueprint>(entity =>
            {
                entity.ToTable("StructureBlueprints");
                entity.HasKey(e => e.StructureBlueprintID);

                entity.Property(e => e.StructureBlueprintID)
                    .HasColumnName("StructureBlueprintID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CraftTierLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.GivesSkillXP).HasColumnName("GivesSkillXP");

                entity.Property(e => e.Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PerkID).HasColumnName("PerkID");

                entity.Property(e => e.RequiredPerkLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.SpecialCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StructureCategoryID).HasColumnName("StructureCategoryID");
            });

            modelBuilder.Entity<StructureCategory>(entity =>
            {
                entity.ToTable("StructureCategories");
                entity.HasKey(e => e.StructureCategoryID);

                entity.Property(e => e.StructureCategoryID).HasColumnName("StructureCategoryID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<StructureComponent>(entity =>
            {
                entity.ToTable("StructureComponents");
                entity.HasKey(e => e.StructureComponentID);

                entity.Property(e => e.StructureComponentID).HasColumnName("StructureComponentID");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StructureBlueprintID).HasColumnName("StructureBlueprintID");

                entity.HasOne(d => d.StructureBlueprint)
                    .WithMany(p => p.StructureComponents)
                    .HasForeignKey(d => d.StructureBlueprintID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StructureComponents_StructureBlueprintID");
            });

            modelBuilder.Entity<StructureQuickBuildAudit>(entity =>
            {
                entity.ToTable("StructureQuickBuildAudit");
                entity.HasKey(e => e.StructureQuickBuildID);

                entity.Property(e => e.StructureQuickBuildID).HasColumnName("StructureQuickBuildID");

                entity.Property(e => e.DateBuilt).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DMName)
                    .IsRequired()
                    .HasColumnName("DMName")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PCTerritoryFlagID).HasColumnName("PCTerritoryFlagID");

                entity.Property(e => e.PCTerritoryFlagStructureID).HasColumnName("PCTerritoryFlagStructureID");

                entity.HasOne(d => d.PCTerritoryFlag)
                    .WithMany(p => p.StructureQuickBuildAudit)
                    .HasForeignKey(d => d.PCTerritoryFlagID)
                    .HasConstraintName("FK_StructureQuickBuildAudit_PCTerritoryFlagID");
            });

            modelBuilder.Entity<TerritoryFlagPermission>(entity =>
            {
                entity.ToTable("TerritoryFlagPermissions");
                entity.HasKey(e => e.TerritoryFlagPermissionID);

                entity.Property(e => e.TerritoryFlagPermissionID)
                    .HasColumnName("TerritoryFlagPermissionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.UserID);

                entity.Property(e => e.UserID).HasColumnName("UserID");

                entity.Property(e => e.AvatarHash).IsRequired();

                entity.Property(e => e.DateRegistered).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DiscordUserID)
                    .IsRequired()
                    .HasColumnName("DiscordUserID");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.RoleID)
                    .HasColumnName("RoleID")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(32);
            });
        }
    }
}
