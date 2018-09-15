using Microsoft.EntityFrameworkCore;
using SWLOR.Web.Data.Entities;
using Attribute = SWLOR.Web.Data.Entities.Attribute;

namespace SWLOR.Web.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<AreaWalkmesh> AreaWalkmesh { get; set; }
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<AuthorizedDM> AuthorizedDMs { get; set; }
        public virtual DbSet<Background> Backgrounds { get; set; }
        public virtual DbSet<BaseItemType> BaseItemTypes { get; set; }
        public virtual DbSet<BaseStructure> BaseStructures { get; set; }
        public virtual DbSet<BaseStructureType> BaseStructureType { get; set; }
        public virtual DbSet<BuildingStyle> BuildingStyles { get; set; }
        public virtual DbSet<ChatChannelsDomain> ChatChannelsDomain { get; set; }
        public virtual DbSet<ChatLog> ChatLog { get; set; }
        public virtual DbSet<ClientLogEvent> ClientLogEvents { get; set; }
        public virtual DbSet<ClientLogEventTypesDomain> ClientLogEventTypesDomain { get; set; }
        public virtual DbSet<ComponentType> ComponentTypes { get; set; }
        public virtual DbSet<CooldownCategory> CooldownCategories { get; set; }
        public virtual DbSet<CraftBlueprintCategory> CraftBlueprintCategories { get; set; }
        public virtual DbSet<CraftBlueprint> CraftBlueprints { get; set; }
        public virtual DbSet<CraftDevice> CraftDevices { get; set; }
        public virtual DbSet<CustomEffect> CustomEffects { get; set; }
        public virtual DbSet<DMRoleDomain> DMRoleDomain { get; set; }
        public virtual DbSet<Download> Downloads { get; set; }
        public virtual DbSet<EnmityAdjustmentRule> EnmityAdjustmentRule { get; set; }
        public virtual DbSet<FameRegion> FameRegions { get; set; }
        public virtual DbSet<GameTopicCategory> GameTopicCategories { get; set; }
        public virtual DbSet<GameTopic> GameTopics { get; set; }
        public virtual DbSet<GrowingPlant> GrowingPlants { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<KeyItemCategory> KeyItemCategories { get; set; }
        public virtual DbSet<KeyItem> KeyItems { get; set; }
        public virtual DbSet<LootTableItem> LootTableItems { get; set; }
        public virtual DbSet<LootTable> LootTables { get; set; }
        public virtual DbSet<Mod> Mods { get; set; }
        public virtual DbSet<NPCGroup> NPCGroups { get; set; }
        public virtual DbSet<PCBasePermission> PCBasePermissions { get; set; }
        public virtual DbSet<PCBase> PCBases { get; set; }
        public virtual DbSet<PCBaseStructureItem> PCBaseStructureItems { get; set; }
        public virtual DbSet<PCBaseStructurePermission> PCBaseStructurePermissions { get; set; }
        public virtual DbSet<PCBaseStructure> PCBaseStructures { get; set; }
        public virtual DbSet<PCCooldown> PCCooldowns { get; set; }
        public virtual DbSet<PCCustomEffect> PCCustomEffects { get; set; }
        public virtual DbSet<PCImpoundedItem> PCImpoundedItems { get; set; }
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
        public virtual DbSet<Quest> Quests { get; set; }
        public virtual DbSet<QuestState> QuestStates { get; set; }
        public virtual DbSet<QuestTypeDomain> QuestTypeDomain { get; set; }
        public virtual DbSet<ServerConfiguration> ServerConfiguration { get; set; }
        public virtual DbSet<SkillCategory> SkillCategories { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SkillXPRequirement> SkillXPRequirement { get; set; }
        public virtual DbSet<SpawnObject> SpawnObjects { get; set; }
        public virtual DbSet<SpawnObjectType> SpawnObjectType { get; set; }
        public virtual DbSet<Spawn> Spawns { get; set; }
        public virtual DbSet<StorageContainer> StorageContainers { get; set; }
        public virtual DbSet<StorageItem> StorageItems { get; set; }
        public virtual DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.AreaID);

                entity.HasIndex(e => e.Resref)
                    .HasName("UQ_Areas_Resref")
                    .IsUnique();

                entity.Property(e => e.AreaID)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateLastBaked).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NortheastOwner).HasMaxLength(60);

                entity.Property(e => e.NorthwestOwner).HasMaxLength(60);

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.SoutheastOwner).HasMaxLength(60);

                entity.Property(e => e.SouthwestOwner).HasMaxLength(60);

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.NortheastOwnerNavigation)
                    .WithMany(p => p.AreasNortheastOwnerNavigation)
                    .HasForeignKey(d => d.NortheastOwner)
                    .HasConstraintName("FK_Areas_NortheastOwner");

                entity.HasOne(d => d.NorthwestOwnerNavigation)
                    .WithMany(p => p.AreasNorthwestOwnerNavigation)
                    .HasForeignKey(d => d.NorthwestOwner)
                    .HasConstraintName("FK_Areas_NorthwestOwner");

                entity.HasOne(d => d.ResourceSpawnTable)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.ResourceSpawnTableID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Areas_ResourceSpawnTableID");

                entity.HasOne(d => d.SoutheastOwnerNavigation)
                    .WithMany(p => p.AreasSoutheastOwnerNavigation)
                    .HasForeignKey(d => d.SoutheastOwner)
                    .HasConstraintName("FK_Areas_SoutheastOwner");

                entity.HasOne(d => d.SouthwestOwnerNavigation)
                    .WithMany(p => p.AreasSouthwestOwnerNavigation)
                    .HasForeignKey(d => d.SouthwestOwner)
                    .HasConstraintName("FK_Areas_SouthwestOwner");
            });

            modelBuilder.Entity<AreaWalkmesh>(entity =>
            {
                entity.Property(e => e.AreaID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AreaWalkmesh)
                    .HasForeignKey(d => d.AreaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AreaWalkmesh_AreaID");
            });

            modelBuilder.Entity<Attribute>(entity =>
            {
                entity.HasKey(e => e.AttributeID);

                entity.Property(e => e.AttributeID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AuthorizedDM>(entity =>
            {
                entity.HasKey(e => e.AuthorizedDMID);

                entity.Property(e => e.CDKey)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Background>(entity =>
            {
                entity.HasKey(e => e.BackgroundID);

                entity.Property(e => e.BackgroundID).ValueGeneratedNever();

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

            modelBuilder.Entity<BaseItemType>(entity =>
            {
                entity.HasKey(e => e.BaseItemTypeID);

                entity.Property(e => e.BaseItemTypeID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<BaseStructure>(entity =>
            {
                entity.HasKey(e => e.BaseStructureID);

                entity.Property(e => e.BaseStructureID).ValueGeneratedNever();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlaceableResref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.BaseStructureType)
                    .WithMany(p => p.BaseStructures)
                    .HasForeignKey(d => d.BaseStructureTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BaseStructures_BaseStructureTypeID");
            });

            modelBuilder.Entity<BaseStructureType>(entity =>
            {
                entity.Property(e => e.BaseStructureTypeID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<BuildingStyle>(entity =>
            {
                entity.HasKey(e => e.BuildingStyleID);

                entity.Property(e => e.BuildingStyleID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.BaseStructure)
                    .WithMany(p => p.BuildingStyles)
                    .HasForeignKey(d => d.BaseStructureID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BuildingStyles_BaseStructureID");
            });

            modelBuilder.Entity<ChatChannelsDomain>(entity =>
            {
                entity.HasKey(e => e.ChatChannelID);

                entity.Property(e => e.ChatChannelID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ChatLog>(entity =>
            {
                entity.Property(e => e.DateSent).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceiverAccountName).HasMaxLength(1024);

                entity.Property(e => e.ReceiverCDKey).HasMaxLength(20);

                entity.Property(e => e.ReceiverDMName).HasMaxLength(60);

                entity.Property(e => e.ReceiverPlayerID).HasMaxLength(60);

                entity.Property(e => e.SenderAccountName)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderCDKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderDMName).HasMaxLength(60);

                entity.Property(e => e.SenderPlayerID).HasMaxLength(60);

                entity.HasOne(d => d.ChatChannel)
                    .WithMany(p => p.ChatLog)
                    .HasForeignKey(d => d.ChatChannelID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ChatLog_ChatChannelID");

                entity.HasOne(d => d.ReceiverPlayer)
                    .WithMany(p => p.ChatLogReceiverPlayer)
                    .HasForeignKey(d => d.ReceiverPlayerID)
                    .HasConstraintName("fk_ChatLog_ReceiverPlayerID");

                entity.HasOne(d => d.SenderPlayer)
                    .WithMany(p => p.ChatLogSenderPlayer)
                    .HasForeignKey(d => d.SenderPlayerID)
                    .HasConstraintName("fk_ChatLog_SenderPlayerID");
            });

            modelBuilder.Entity<ClientLogEvent>(entity =>
            {
                entity.HasKey(e => e.ClientLogEventID);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.CDKey)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DateOfEvent).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PlayerID).HasMaxLength(60);

                entity.HasOne(d => d.ClientLogEventType)
                    .WithMany(p => p.ClientLogEvents)
                    .HasForeignKey(d => d.ClientLogEventTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientLogEvents_ClientLogEventTypeID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.ClientLogEvents)
                    .HasForeignKey(d => d.PlayerID)
                    .HasConstraintName("FK_ClientLogEvents_PlayerID");
            });

            modelBuilder.Entity<ClientLogEventTypesDomain>(entity =>
            {
                entity.HasKey(e => e.ClientLogEventTypeID);

                entity.Property(e => e.ClientLogEventTypeID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ComponentType>(entity =>
            {
                entity.HasKey(e => e.ComponentTypeID);

                entity.Property(e => e.ComponentTypeID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CooldownCategory>(entity =>
            {
                entity.HasKey(e => e.CooldownCategoryID);

                entity.Property(e => e.CooldownCategoryID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CraftBlueprintCategory>(entity =>
            {
                entity.HasKey(e => e.CraftBlueprintCategoryID);

                entity.Property(e => e.CraftBlueprintCategoryID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<CraftBlueprint>(entity =>
            {
                entity.HasKey(e => e.CraftBlueprintID);

                entity.Property(e => e.CraftBlueprintID).ValueGeneratedNever();

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.BaseStructure)
                    .WithMany(p => p.CraftBlueprints)
                    .HasForeignKey(d => d.BaseStructureID)
                    .HasConstraintName("FK__CraftBlue__BaseS__2F2FFC0C");

                entity.HasOne(d => d.CraftCategory)
                    .WithMany(p => p.CraftBlueprints)
                    .HasForeignKey(d => d.CraftCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprints_CraftCategoryID");

                entity.HasOne(d => d.CraftDevice)
                    .WithMany(p => p.CraftBlueprints)
                    .HasForeignKey(d => d.CraftDeviceID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CraftBlueprints_CraftDeviceID");

                entity.HasOne(d => d.MainComponentType)
                    .WithMany(p => p.CraftBlueprintsMainComponentType)
                    .HasForeignKey(d => d.MainComponentTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprints_MainComponentTypeID");

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.CraftBlueprints)
                    .HasForeignKey(d => d.PerkID)
                    .HasConstraintName("FK_CraftBlueprints_PerkID");

                entity.HasOne(d => d.SecondaryComponentType)
                    .WithMany(p => p.CraftBlueprintsSecondaryComponentType)
                    .HasForeignKey(d => d.SecondaryComponentTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprints_SecondaryComponentTypeID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.CraftBlueprints)
                    .HasForeignKey(d => d.SkillID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CraftBlueprints_SkillID");

                entity.HasOne(d => d.TertiaryComponentType)
                    .WithMany(p => p.CraftBlueprintsTertiaryComponentType)
                    .HasForeignKey(d => d.TertiaryComponentTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprints_TertiaryComponentTypeID");
            });

            modelBuilder.Entity<CraftDevice>(entity =>
            {
                entity.HasKey(e => e.CraftDeviceID);

                entity.Property(e => e.CraftDeviceID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CustomEffect>(entity =>
            {
                entity.HasKey(e => e.CustomEffectID);

                entity.Property(e => e.CustomEffectID).ValueGeneratedNever();

                entity.Property(e => e.ContinueMessage)
                    .IsRequired()
                    .HasMaxLength(64);

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
                entity.Property(e => e.DMRoleDomainID).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Download>(entity =>
            {
                entity.HasKey(e => e.DownloadID);

                entity.Property(e => e.DownloadID).ValueGeneratedNever();

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

            modelBuilder.Entity<EnmityAdjustmentRule>(entity =>
            {
                entity.Property(e => e.EnmityAdjustmentRuleID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<FameRegion>(entity =>
            {
                entity.HasKey(e => e.FameRegionID);

                entity.Property(e => e.FameRegionID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<GameTopicCategory>(entity =>
            {
                entity.HasKey(e => e.GameTopicCategoryID);

                entity.Property(e => e.GameTopicCategoryID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<GameTopic>(entity =>
            {
                entity.HasKey(e => e.GameTopicID);

                entity.Property(e => e.GameTopicID).ValueGeneratedNever();

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.GameTopicCategory)
                    .WithMany(p => p.GameTopics)
                    .HasForeignKey(d => d.GameTopicCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameTopics_GameTopicCategoryID");
            });

            modelBuilder.Entity<GrowingPlant>(entity =>
            {
                entity.HasKey(e => e.GrowingPlantID);

                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.GrowingPlants)
                    .HasForeignKey(d => d.PlantID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrowingPlants_PlantID");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeID);

                entity.Property(e => e.ItemTypeID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<KeyItemCategory>(entity =>
            {
                entity.HasKey(e => e.KeyItemCategoryID);

                entity.Property(e => e.KeyItemCategoryID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<KeyItem>(entity =>
            {
                entity.HasKey(e => e.KeyItemID);

                entity.Property(e => e.KeyItemID).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.KeyItemCategory)
                    .WithMany(p => p.KeyItems)
                    .HasForeignKey(d => d.KeyItemCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_KeyItems_KeyItemCategoryID");
            });

            modelBuilder.Entity<LootTableItem>(entity =>
            {
                entity.HasKey(e => e.LootTableItemID);

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.LootTable)
                    .WithMany(p => p.LootTableItems)
                    .HasForeignKey(d => d.LootTableID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_LootTableItems_LootTableID");
            });

            modelBuilder.Entity<LootTable>(entity =>
            {
                entity.HasKey(e => e.LootTableID);

                entity.Property(e => e.LootTableID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Mod>(entity =>
            {
                entity.HasKey(e => e.ModID);

                entity.Property(e => e.ModID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Script)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<NPCGroup>(entity =>
            {
                entity.HasKey(e => e.NPCGroupID);

                entity.Property(e => e.NPCGroupID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PCBasePermission>(entity =>
            {
                entity.HasKey(e => e.PCBasePermissionID);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.PCBase)
                    .WithMany(p => p.PCBasePermissions)
                    .HasForeignKey(d => d.PCBaseID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBasePermissions_PCBaseID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCBasePermissions)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBasePermissions_PlayerID");
            });

            modelBuilder.Entity<PCBase>(entity =>
            {
                entity.HasKey(e => e.PCBaseID);

                entity.HasIndex(e => new { e.AreaResref, e.Sector })
                    .HasName("UQ_PCBases_AreaResrefSector")
                    .IsUnique();

                entity.Property(e => e.AreaResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.DateFuelEnds).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateInitialPurchase).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.AreaResrefNavigation)
                    .WithMany(p => p.PCBases)
                    .HasPrincipalKey(p => p.Resref)
                    .HasForeignKey(d => d.AreaResref)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBases_AreaResref");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCBases)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBases_PlayerID");
            });

            modelBuilder.Entity<PCBaseStructureItem>(entity =>
            {
                entity.HasKey(e => e.PCBaseStructureItemID);

                entity.Property(e => e.ItemGlobalID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.PCBaseStructure)
                    .WithMany(p => p.PCBaseStructureItems)
                    .HasForeignKey(d => d.PCBaseStructureID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBaseStructureItems_PCBaseStructureID");
            });

            modelBuilder.Entity<PCBaseStructurePermission>(entity =>
            {
                entity.HasKey(e => e.PCBaseStructurePermissionID);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.PCBaseStructure)
                    .WithMany(p => p.PCBaseStructurePermissions)
                    .HasForeignKey(d => d.PCBaseStructureID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBaseStructurePermissions_PCBaseStructureID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCBaseStructurePermissions)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBaseStructurePermissions_PlayerID");
            });

            modelBuilder.Entity<PCBaseStructure>(entity =>
            {
                entity.HasKey(e => e.PCBaseStructureID);

                entity.Property(e => e.CustomName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.BaseStructure)
                    .WithMany(p => p.PCBaseStructures)
                    .HasForeignKey(d => d.BaseStructureID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBaseStructures_BaseStructureID");

                entity.HasOne(d => d.ExteriorStyle)
                    .WithMany(p => p.PCBaseStructuresExteriorStyle)
                    .HasForeignKey(d => d.ExteriorStyleID)
                    .HasConstraintName("FK_PCBaseStructures_ExteriorStyleID");

                entity.HasOne(d => d.InteriorStyle)
                    .WithMany(p => p.PCBaseStructuresInteriorStyle)
                    .HasForeignKey(d => d.InteriorStyleID)
                    .HasConstraintName("FK_PCBaseStructures_InteriorStyleID");

                entity.HasOne(d => d.PCBase)
                    .WithMany(p => p.PCBaseStructures)
                    .HasForeignKey(d => d.PCBaseID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBaseStructures_PCBaseID");

                entity.HasOne(d => d.ParentPCBaseStructure)
                    .WithMany(p => p.InverseParentPCBaseStructure)
                    .HasForeignKey(d => d.ParentPCBaseStructureID)
                    .HasConstraintName("FK_PCBaseStructures_ParentPCBaseStructureID");
            });

            modelBuilder.Entity<PCCooldown>(entity =>
            {
                entity.HasKey(e => e.PCCooldownID);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.CooldownCategory)
                    .WithMany(p => p.PCCooldowns)
                    .HasForeignKey(d => d.CooldownCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCooldowns_CooldownCategoryID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCCooldowns)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCooldowns_PlayerID");
            });

            modelBuilder.Entity<PCCustomEffect>(entity =>
            {
                entity.HasKey(e => e.PCCustomEffectID);

                entity.Property(e => e.CasterNWNObjectID)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.CustomEffect)
                    .WithMany(p => p.PCCustomEffects)
                    .HasForeignKey(d => d.CustomEffectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCustomEffects_CustomEffectID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCCustomEffects)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCustomEffects_PlayerID");
            });

            modelBuilder.Entity<PCImpoundedItem>(entity =>
            {
                entity.HasKey(e => e.PCImpoundedItemID);

                entity.Property(e => e.DateImpounded).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ItemObject).IsRequired();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCImpoundedItems)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCItemImpound_PlayerID");
            });

            modelBuilder.Entity<PCKeyItem>(entity =>
            {
                entity.HasKey(e => e.PCKeyItemID);

                entity.Property(e => e.AcquiredDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.KeyItem)
                    .WithMany(p => p.PCKeyItems)
                    .HasForeignKey(d => d.KeyItemID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCKeyItems_KeyItemID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCKeyItems)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCKeyItems_PlayerID");
            });

            modelBuilder.Entity<PCMapPin>(entity =>
            {
                entity.HasKey(e => e.PCMapPinID);

                entity.Property(e => e.AreaTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.NoteText)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCMapPins)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCMapPins_PlayerID");
            });

            modelBuilder.Entity<PCMigrationItem>(entity =>
            {
                entity.HasKey(e => e.PCMigrationItemID);

                entity.Property(e => e.PCMigrationItemID).ValueGeneratedNever();

                entity.Property(e => e.CurrentResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.NewResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.BaseItemType)
                    .WithMany(p => p.PCMigrationItems)
                    .HasForeignKey(d => d.BaseItemTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCMigrationItems_BaseItemTypeID");

                entity.HasOne(d => d.PCMigration)
                    .WithMany(p => p.PCMigrationItems)
                    .HasForeignKey(d => d.PCMigrationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCMigrationItems_PCMigrationID");
            });

            modelBuilder.Entity<PCMigration>(entity =>
            {
                entity.HasKey(e => e.PCMigrationID);

                entity.Property(e => e.PCMigrationID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<PCOutfit>(entity =>
            {
                entity.HasKey(e => e.PlayerID);

                entity.Property(e => e.PlayerID)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.Outfit1).IsUnicode(false);

                entity.Property(e => e.Outfit10).IsUnicode(false);

                entity.Property(e => e.Outfit2).IsUnicode(false);

                entity.Property(e => e.Outfit3).IsUnicode(false);

                entity.Property(e => e.Outfit4).IsUnicode(false);

                entity.Property(e => e.Outfit5).IsUnicode(false);

                entity.Property(e => e.Outfit6).IsUnicode(false);

                entity.Property(e => e.Outfit7).IsUnicode(false);

                entity.Property(e => e.Outfit8).IsUnicode(false);

                entity.Property(e => e.Outfit9).IsUnicode(false);

                entity.HasOne(d => d.Player)
                    .WithOne(p => p.PCOutfit)
                    .HasForeignKey<PCOutfit>(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCOutfits_PlayerID");
            });

            modelBuilder.Entity<PCOverflowItem>(entity =>
            {
                entity.HasKey(e => e.PCOverflowItemID);

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsUnicode(false);

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCOverflowItems)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCOverflowItems_PlayerID");
            });

            modelBuilder.Entity<PCPerk>(entity =>
            {
                entity.HasKey(e => e.PCPerkID);

                entity.Property(e => e.AcquiredDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.PCPerks)
                    .HasForeignKey(d => d.PerkID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCPerks_PerkID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCPerks)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCPerks_PlayerID");
            });

            modelBuilder.Entity<PCQuestKillTargetProgress>(entity =>
            {
                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.NPCGroup)
                    .WithMany(p => p.PCQuestKillTargetProgress)
                    .HasForeignKey(d => d.NPCGroupID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_NPCGroupID");

                entity.HasOne(d => d.PCQuestStatus)
                    .WithMany(p => p.PCQuestKillTargetProgress)
                    .HasForeignKey(d => d.PCQuestStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_PCQuestStatusID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCQuestKillTargetProgress)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_PlayerID");
            });

            modelBuilder.Entity<PCQuestStatus>(entity =>
            {
                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.CurrentQuestState)
                    .WithMany(p => p.PCQuestStatus)
                    .HasForeignKey(d => d.CurrentQuestStateID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestStatus_CurrentQuestStateID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCQuestStatus)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestStatus_PlayerID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.PCQuestStatus)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestStatus_QuestID");

                entity.HasOne(d => d.SelectedItemReward)
                    .WithMany(p => p.PCQuestStatus)
                    .HasForeignKey(d => d.SelectedItemRewardID)
                    .HasConstraintName("FK_PCQuestStatus_SelectedRewardID");
            });

            modelBuilder.Entity<PCRegionalFame>(entity =>
            {
                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.FameRegion)
                    .WithMany(p => p.PCRegionalFame)
                    .HasForeignKey(d => d.FameRegionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCRegionalFame_FameRegionID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCRegionalFame)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCRegionalFame_PlayerID");
            });

            modelBuilder.Entity<PCSearchSiteItem>(entity =>
            {
                entity.HasKey(e => e.PCSearchSiteItemID);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.SearchItem).IsUnicode(false);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCSearchSiteItems)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCSearchSiteItems_PlayerID");
            });

            modelBuilder.Entity<PCSearchSite>(entity =>
            {
                entity.HasKey(e => e.PCSearchSiteID);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UnlockDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCSearchSites)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCSearchSites_PlayerID");
            });

            modelBuilder.Entity<PCSkill>(entity =>
            {
                entity.HasKey(e => e.PCSkillID);

                entity.Property(e => e.PlayerID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCSkills)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCSkills_PlayerID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.PCSkills)
                    .HasForeignKey(d => d.SkillID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCSkills_SkillID");
            });

            modelBuilder.Entity<PerkCategory>(entity =>
            {
                entity.HasKey(e => e.PerkCategoryID);

                entity.Property(e => e.PerkCategoryID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PerkExecutionType>(entity =>
            {
                entity.HasKey(e => e.PerkExecutionTypeID);

                entity.Property(e => e.PerkExecutionTypeID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PerkLevel>(entity =>
            {
                entity.HasKey(e => e.PerkLevelID);

                entity.HasIndex(e => new { e.PerkID, e.Level })
                    .HasName("uq_PerkLevels_PerkIDLevel")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.PerkLevels)
                    .HasForeignKey(d => d.PerkID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerkLevels_PerkID");
            });

            modelBuilder.Entity<PerkLevelSkillRequirement>(entity =>
            {
                entity.HasKey(e => e.PerkLevelSkillRequirementID);

                entity.HasOne(d => d.PerkLevel)
                    .WithMany(p => p.PerkLevelSkillRequirements)
                    .HasForeignKey(d => d.PerkLevelID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerkLevelSkillRequirements_PerkLevelID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.PerkLevelSkillRequirements)
                    .HasForeignKey(d => d.SkillID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerkLevelSkillRequirements_SkillID");
            });

            modelBuilder.Entity<Perk>(entity =>
            {
                entity.HasKey(e => e.PerkID);

                entity.Property(e => e.PerkID).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FeatID).HasDefaultValueSql("((0))");

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

                entity.HasOne(d => d.CooldownCategory)
                    .WithMany(p => p.Perks)
                    .HasForeignKey(d => d.CooldownCategoryID)
                    .HasConstraintName("fk_Perks_CooldownCategoryID");

                entity.HasOne(d => d.EnmityAdjustmentRule)
                    .WithMany(p => p.Perks)
                    .HasForeignKey(d => d.EnmityAdjustmentRuleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Perks_EnmityAdjustmentRuleID");

                entity.HasOne(d => d.ExecutionType)
                    .WithMany(p => p.Perks)
                    .HasForeignKey(d => d.ExecutionTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Perks_ExecutionTypeID");

                entity.HasOne(d => d.PerkCategory)
                    .WithMany(p => p.Perks)
                    .HasForeignKey(d => d.PerkCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Perks_PerkCategoryID");
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.HasKey(e => e.PlantID);

                entity.Property(e => e.PlantID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeedResref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PlayerCharacter>(entity =>
            {
                entity.HasKey(e => e.PlayerID);

                entity.Property(e => e.PlayerID)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTimestamp)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateSanctuaryEnds).HasDefaultValueSql("(dateadd(hour,(72),getutcdate()))");

                entity.Property(e => e.DisplayHelmet)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationAreaResref).HasMaxLength(16);

                entity.Property(e => e.RespawnAreaResref)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.PrimaryResidencePCBaseStructure)
                    .WithMany(p => p.PlayerCharacters)
                    .HasForeignKey(d => d.PrimaryResidencePCBaseStructureID)
                    .HasConstraintName("FK_PlayerCharacters_PrimaryResidencePCBaseStructureID");
            });

            modelBuilder.Entity<QuestKillTargetList>(entity =>
            {
                entity.HasOne(d => d.NPCGroup)
                    .WithMany(p => p.QuestKillTargetList)
                    .HasForeignKey(d => d.NPCGroupID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTargetList_NPCGroupID");

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
                entity.HasKey(e => e.QuestPrerequisiteID);

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
                entity.HasKey(e => e.QuestRequiredKeyItemID);

                entity.HasOne(d => d.KeyItem)
                    .WithMany(p => p.QuestRequiredKeyItemList)
                    .HasForeignKey(d => d.KeyItemID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItemList_KeyItemID");

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
                entity.HasKey(e => e.QuestRewardItemID);

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRewardItems)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRewards_QuestID");
            });

            modelBuilder.Entity<Quest>(entity =>
            {
                entity.HasKey(e => e.QuestID);

                entity.Property(e => e.JournalTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.MapNoteTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.FameRegion)
                    .WithMany(p => p.Quests)
                    .HasForeignKey(d => d.FameRegionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quests_FameRegionID");

                entity.HasOne(d => d.RewardKeyItem)
                    .WithMany(p => p.QuestsRewardKeyItem)
                    .HasForeignKey(d => d.RewardKeyItemID)
                    .HasConstraintName("FK_Quests_RewardKeyItemID");

                entity.HasOne(d => d.StartKeyItem)
                    .WithMany(p => p.QuestsStartKeyItem)
                    .HasForeignKey(d => d.StartKeyItemID)
                    .HasConstraintName("FK_Quests_TemporaryKeyItemID");
            });

            modelBuilder.Entity<QuestState>(entity =>
            {
                entity.HasKey(e => e.QuestStateID);

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestStates)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestStates_QuestID");

                entity.HasOne(d => d.QuestType)
                    .WithMany(p => p.QuestStates)
                    .HasForeignKey(d => d.QuestTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestStates_QuestTypeID");
            });

            modelBuilder.Entity<QuestTypeDomain>(entity =>
            {
                entity.HasKey(e => e.QuestTypeID);

                entity.Property(e => e.QuestTypeID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ServerConfiguration>(entity =>
            {
                entity.Property(e => e.ServerConfigurationID).ValueGeneratedNever();

                entity.Property(e => e.AreaBakeStep).HasDefaultValueSql("((2))");

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
                entity.HasKey(e => e.SkillCategoryID);

                entity.Property(e => e.SkillCategoryID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => e.SkillID);

                entity.Property(e => e.SkillID).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrimaryAttributeID).HasDefaultValueSql("('')").HasColumnName("Primary");

                entity.Property(e => e.SecondaryAttributeID).HasDefaultValueSql("('')").HasColumnName("Secondary");

                entity.Property(e => e.TertiaryAttributeID).HasDefaultValueSql("('')").HasColumnName("Tertiary");

                entity.HasOne(d => d.PrimaryAttribute)
                    .WithMany(p => p.SkillsPrimaryNavigation)
                    .HasForeignKey(d => d.PrimaryAttributeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skills_Primary");

                entity.HasOne(d => d.SecondaryAttribute)
                    .WithMany(p => p.SkillsSecondaryNavigation)
                    .HasForeignKey(d => d.SecondaryAttributeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skills_Secondary");

                entity.HasOne(d => d.SkillCategory)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.SkillCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skills_SkillCategoryID");

                entity.HasOne(d => d.TertiaryAttribute)
                    .WithMany(p => p.SkillsTertiaryNavigation)
                    .HasForeignKey(d => d.TertiaryAttributeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skills_Tertiary");
            });

            modelBuilder.Entity<SkillXPRequirement>(entity =>
            {
                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.SkillXPRequirement)
                    .HasForeignKey(d => d.SkillID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SkillXPRequirement_SkillID");
            });

            modelBuilder.Entity<SpawnObject>(entity =>
            {
                entity.HasKey(e => e.SpawnObjectID);

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.SpawnRule)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Weight).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.NPCGroup)
                    .WithMany(p => p.SpawnObjects)
                    .HasForeignKey(d => d.NPCGroupID)
                    .HasConstraintName("FK_SpawnObjects_NPCGroupID");

                entity.HasOne(d => d.Spawn)
                    .WithMany(p => p.SpawnObjects)
                    .HasForeignKey(d => d.SpawnID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpawnObjects_SpawnID");
            });

            modelBuilder.Entity<SpawnObjectType>(entity =>
            {
                entity.Property(e => e.SpawnObjectTypeID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Spawn>(entity =>
            {
                entity.HasKey(e => e.SpawnID);

                entity.Property(e => e.SpawnID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.SpawnObjectType)
                    .WithMany(p => p.Spawns)
                    .HasForeignKey(d => d.SpawnObjectTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spawns_SpawnObjectTypeID");
            });

            modelBuilder.Entity<StorageContainer>(entity =>
            {
                entity.HasKey(e => e.StorageContainerID);

                entity.Property(e => e.StorageContainerID).ValueGeneratedNever();

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
                entity.HasKey(e => e.StorageItemID);

                entity.Property(e => e.GlobalID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsUnicode(false);

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.StorageContainer)
                    .WithMany(p => p.StorageItems)
                    .HasForeignKey(d => d.StorageContainerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_StorageItems_StorageContainerID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserID);

                entity.Property(e => e.AvatarHash).IsRequired();

                entity.Property(e => e.DateRegistered).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DiscordUserID).IsRequired();

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.RoleID).HasDefaultValueSql("((3))");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Users_RoleID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
