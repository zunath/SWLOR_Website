using Microsoft.EntityFrameworkCore;
using SWLOR.Web.Data.Entities;

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

        public virtual DbSet<ApartmentBuilding> ApartmentBuilding { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AreaWalkmesh> AreaWalkmesh { get; set; }
        public virtual DbSet<Association> Association { get; set; }
        public virtual DbSet<Attribute> Attribute { get; set; }
        public virtual DbSet<AuthorizedDM> AuthorizedDM { get; set; }
        public virtual DbSet<Backgrounds> Backgrounds { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankItem> BankItem { get; set; }
        public virtual DbSet<BaseItemType> BaseItemType { get; set; }
        public virtual DbSet<BaseStructure> BaseStructure { get; set; }
        public virtual DbSet<BaseStructureType> BaseStructureType { get; set; }
        public virtual DbSet<BugReport> BugReport { get; set; }
        public virtual DbSet<BuildingStyle> BuildingStyle { get; set; }
        public virtual DbSet<BuildingType> BuildingType { get; set; }
        public virtual DbSet<ChatChannel> ChatChannel { get; set; }
        public virtual DbSet<ChatLog> ChatLog { get; set; }
        public virtual DbSet<ClientLogEvent> ClientLogEvent { get; set; }
        public virtual DbSet<ClientLogEventType> ClientLogEventType { get; set; }
        public virtual DbSet<ComponentType> ComponentType { get; set; }
        public virtual DbSet<CooldownCategory> CooldownCategory { get; set; }
        public virtual DbSet<CraftBlueprint> CraftBlueprint { get; set; }
        public virtual DbSet<CraftBlueprintCategory> CraftBlueprintCategory { get; set; }
        public virtual DbSet<CraftDevice> CraftDevice { get; set; }
        public virtual DbSet<CustomEffect> CustomEffect { get; set; }
        public virtual DbSet<CustomEffectCategory> CustomEffectCategory { get; set; }
        public virtual DbSet<DatabaseVersion> DatabaseVersion { get; set; }
        public virtual DbSet<DataPackage> DataPackage { get; set; }
        public virtual DbSet<DiscordChatQueue> DiscordChatQueue { get; set; }
        public virtual DbSet<DMRole> DMRole { get; set; }
        public virtual DbSet<Download> Download { get; set; }
        public virtual DbSet<EnmityAdjustmentRule> EnmityAdjustmentRule { get; set; }
        public virtual DbSet<Error> Error { get; set; }
        public virtual DbSet<FameRegion> FameRegion { get; set; }
        public virtual DbSet<GameTopic> GameTopic { get; set; }
        public virtual DbSet<GameTopicCategory> GameTopicCategory { get; set; }
        public virtual DbSet<GrowingPlant> GrowingPlant { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<KeyItem> KeyItem { get; set; }
        public virtual DbSet<KeyItemCategory> KeyItemCategory { get; set; }
        public virtual DbSet<LootTable> LootTable { get; set; }
        public virtual DbSet<LootTableItem> LootTableItem { get; set; }
        public virtual DbSet<Mod> Mod { get; set; }
        public virtual DbSet<NPCGroup> NPCGroup { get; set; }
        public virtual DbSet<PCBase> PCBase { get; set; }
        public virtual DbSet<PCBasePermission> PCBasePermission { get; set; }
        public virtual DbSet<PCBaseStructure> PCBaseStructure { get; set; }
        public virtual DbSet<PCBaseStructureItem> PCBaseStructureItem { get; set; }
        public virtual DbSet<PCBaseStructurePermission> PCBaseStructurePermission { get; set; }
        public virtual DbSet<PCBaseType> PCBaseType { get; set; }
        public virtual DbSet<PCCooldown> PCCooldown { get; set; }
        public virtual DbSet<PCCraftedBlueprint> PCCraftedBlueprint { get; set; }
        public virtual DbSet<PCCustomEffect> PCCustomEffect { get; set; }
        public virtual DbSet<PCImpoundedItem> PCImpoundedItem { get; set; }
        public virtual DbSet<PCKeyItem> PCKeyItem { get; set; }
        public virtual DbSet<PCMapPin> PCMapPin { get; set; }
        public virtual DbSet<PCMapProgression> PCMapProgression { get; set; }
        public virtual DbSet<PCObjectVisibility> PCObjectVisibility { get; set; }
        public virtual DbSet<PCOutfit> PCOutfit { get; set; }
        public virtual DbSet<PCOverflowItem> PCOverflowItem { get; set; }
        public virtual DbSet<PCPerk> PCPerk { get; set; }
        public virtual DbSet<PCPerkRefund> PCPerkRefund { get; set; }
        public virtual DbSet<PCQuestItemProgress> PCQuestItemProgress { get; set; }
        public virtual DbSet<PCQuestKillTargetProgress> PCQuestKillTargetProgress { get; set; }
        public virtual DbSet<PCQuestStatus> PCQuestStatus { get; set; }
        public virtual DbSet<PCRegionalFame> PCRegionalFame { get; set; }
        public virtual DbSet<PCSearchSite> PCSearchSite { get; set; }
        public virtual DbSet<PCSearchSiteItem> PCSearchSiteItem { get; set; }
        public virtual DbSet<PCSkill> PCSkill { get; set; }
        public virtual DbSet<Perk> Perk { get; set; }
        public virtual DbSet<PerkCategory> PerkCategory { get; set; }
        public virtual DbSet<PerkExecutionType> PerkExecutionType { get; set; }
        public virtual DbSet<PerkLevel> PerkLevel { get; set; }
        public virtual DbSet<PerkLevelQuestRequirement> PerkLevelQuestRequirement { get; set; }
        public virtual DbSet<PerkLevelSkillRequirement> PerkLevelSkillRequirement { get; set; }
        public virtual DbSet<Plant> Plant { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Quest> Quest { get; set; }
        public virtual DbSet<QuestKillTarget> QuestKillTarget { get; set; }
        public virtual DbSet<QuestPrerequisite> QuestPrerequisite { get; set; }
        public virtual DbSet<QuestRequiredItem> QuestRequiredItem { get; set; }
        public virtual DbSet<QuestRequiredKeyItem> QuestRequiredKeyItem { get; set; }
        public virtual DbSet<QuestRewardItem> QuestRewardItem { get; set; }
        public virtual DbSet<QuestState> QuestState { get; set; }
        public virtual DbSet<QuestType> QuestType { get; set; }
        public virtual DbSet<ServerConfiguration> ServerConfiguration { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SkillCategory> SkillCategory { get; set; }
        public virtual DbSet<SkillXPRequirement> SkillXPRequirement { get; set; }
        public virtual DbSet<Spawn> Spawn { get; set; }
        public virtual DbSet<SpawnObject> SpawnObject { get; set; }
        public virtual DbSet<SpawnObjectType> SpawnObjectType { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApartmentBuilding>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasIndex(e => e.Resref)
                    .HasName("UQ_Area_Resref")
                    .IsUnique();

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.DateLastBaked).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.NortheastLootTable)
                    .WithMany(p => p.AreaNortheastLootTable)
                    .HasForeignKey(d => d.NortheastLootTableID)
                    .HasConstraintName("FK_Area_NortheastLootTableID");

                entity.HasOne(d => d.NortheastOwnerNavigation)
                    .WithMany(p => p.AreaNortheastOwnerNavigation)
                    .HasForeignKey(d => d.NortheastOwner)
                    .HasConstraintName("FK_Area_NortheastOwner");

                entity.HasOne(d => d.NorthwestLootTable)
                    .WithMany(p => p.AreaNorthwestLootTable)
                    .HasForeignKey(d => d.NorthwestLootTableID)
                    .HasConstraintName("FK_Area_NorthwestLootTableID");

                entity.HasOne(d => d.NorthwestOwnerNavigation)
                    .WithMany(p => p.AreaNorthwestOwnerNavigation)
                    .HasForeignKey(d => d.NorthwestOwner)
                    .HasConstraintName("FK_Area_NorthwestOwner");

                entity.HasOne(d => d.ResourceSpawnTable)
                    .WithMany(p => p.Area)
                    .HasForeignKey(d => d.ResourceSpawnTableID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Area_ResourceSpawnTableID");

                entity.HasOne(d => d.SoutheastLootTable)
                    .WithMany(p => p.AreaSoutheastLootTable)
                    .HasForeignKey(d => d.SoutheastLootTableID)
                    .HasConstraintName("FK_Area_SoutheastLootTableID");

                entity.HasOne(d => d.SoutheastOwnerNavigation)
                    .WithMany(p => p.AreaSoutheastOwnerNavigation)
                    .HasForeignKey(d => d.SoutheastOwner)
                    .HasConstraintName("FK_Area_SoutheastOwner");

                entity.HasOne(d => d.SouthwestLootTable)
                    .WithMany(p => p.AreaSouthwestLootTable)
                    .HasForeignKey(d => d.SouthwestLootTableID)
                    .HasConstraintName("FK_Area_SouthwestLootTableID");

                entity.HasOne(d => d.SouthwestOwnerNavigation)
                    .WithMany(p => p.AreaSouthwestOwnerNavigation)
                    .HasForeignKey(d => d.SouthwestOwner)
                    .HasConstraintName("FK_Area_SouthwestOwner");
            });

            modelBuilder.Entity<AreaWalkmesh>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AreaWalkmesh)
                    .HasForeignKey(d => d.AreaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AreaWalkmesh_AreaID");
            });

            modelBuilder.Entity<Association>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Attribute>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AuthorizedDM>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.CDKey)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Backgrounds>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

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

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

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

            modelBuilder.Entity<BankItem>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.DateStored).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ItemID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsRequired();

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BankItem)
                    .HasForeignKey(d => d.BankID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankItem_BankID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.BankItem)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankItem_PlayerID");
            });

            modelBuilder.Entity<BaseItemType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<BaseStructure>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

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
                    .WithMany(p => p.BaseStructure)
                    .HasForeignKey(d => d.BaseStructureTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BaseStructure_BaseStructureTypeID");
            });

            modelBuilder.Entity<BaseStructureType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<BugReport>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.AreaResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.CDKey)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DateSubmitted).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.TargetName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.HasOne(d => d.SenderPlayer)
                    .WithMany(p => p.BugReport)
                    .HasForeignKey(d => d.SenderPlayerID)
                    .HasConstraintName("FK_BugReport_SenderPlayerID");
            });

            modelBuilder.Entity<BuildingStyle>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.DoorRule)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.BaseStructure)
                    .WithMany(p => p.BuildingStyle)
                    .HasForeignKey(d => d.BaseStructureID)
                    .HasConstraintName("FK_BuildingStyle_BaseStructureID");

                entity.HasOne(d => d.BuildingType)
                    .WithMany(p => p.BuildingStyle)
                    .HasForeignKey(d => d.BuildingTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BuildingStyle_BuildingTypeID");
            });

            modelBuilder.Entity<BuildingType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<ChatChannel>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ChatLog>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.DateSent).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceiverAccountName).HasMaxLength(1024);

                entity.Property(e => e.ReceiverCDKey).HasMaxLength(20);

                entity.Property(e => e.ReceiverDMName).HasMaxLength(300);

                entity.Property(e => e.SenderAccountName)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderCDKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderDMName).HasMaxLength(300);

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
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.CDKey)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DateOfEvent).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.ClientLogEventType)
                    .WithMany(p => p.ClientLogEvent)
                    .HasForeignKey(d => d.ClientLogEventTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientLogEvent_ClientLogEventTypeID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.ClientLogEvent)
                    .HasForeignKey(d => d.PlayerID)
                    .HasConstraintName("FK_ClientLogEvent_PlayerID");
            });

            modelBuilder.Entity<ClientLogEventType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ComponentType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CooldownCategory>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CraftBlueprint>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.BaseStructure)
                    .WithMany(p => p.CraftBlueprint)
                    .HasForeignKey(d => d.BaseStructureID)
                    .HasConstraintName("FK__CraftBlue__BaseS__5D2BD0E6");

                entity.HasOne(d => d.CraftCategory)
                    .WithMany(p => p.CraftBlueprint)
                    .HasForeignKey(d => d.CraftCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprint_CraftCategoryID");

                entity.HasOne(d => d.CraftDevice)
                    .WithMany(p => p.CraftBlueprint)
                    .HasForeignKey(d => d.CraftDeviceID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CraftBlueprint_CraftDeviceID");

                entity.HasOne(d => d.MainComponentType)
                    .WithMany(p => p.CraftBlueprintMainComponentType)
                    .HasForeignKey(d => d.MainComponentTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprint_MainComponentTypeID");

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.CraftBlueprint)
                    .HasForeignKey(d => d.PerkID)
                    .HasConstraintName("FK_CraftBlueprint_PerkID");

                entity.HasOne(d => d.SecondaryComponentType)
                    .WithMany(p => p.CraftBlueprintSecondaryComponentType)
                    .HasForeignKey(d => d.SecondaryComponentTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprint_SecondaryComponentTypeID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.CraftBlueprint)
                    .HasForeignKey(d => d.SkillID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CraftBlueprint_SkillID");

                entity.HasOne(d => d.TertiaryComponentType)
                    .WithMany(p => p.CraftBlueprintTertiaryComponentType)
                    .HasForeignKey(d => d.TertiaryComponentTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CraftBlueprint_TertiaryComponentTypeID");
            });

            modelBuilder.Entity<CraftBlueprintCategory>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<CraftDevice>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CustomEffect>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

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

                entity.HasOne(d => d.CustomEffectCategory)
                    .WithMany(p => p.CustomEffect)
                    .HasForeignKey(d => d.CustomEffectCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomEffect_CustomEffectCategoryID");
            });

            modelBuilder.Entity<CustomEffectCategory>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DatabaseVersion>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.DateApplied).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DataPackage>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Checksum)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.DateFound).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.PackageName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<DiscordChatQueue>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.DateSent).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderAccountName)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderCDKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DMRole>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Download>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

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
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Error>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Caller).IsRequired();

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.StackTrace).IsRequired();
            });

            modelBuilder.Entity<FameRegion>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<GameTopic>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.GameTopicCategory)
                    .WithMany(p => p.GameTopic)
                    .HasForeignKey(d => d.GameTopicCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameTopic_GameTopicCategoryID");
            });

            modelBuilder.Entity<GameTopicCategory>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<GrowingPlant>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationAreaTag)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.GrowingPlant)
                    .HasForeignKey(d => d.PlantID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrowingPlant_PlantID");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<KeyItem>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.KeyItemCategory)
                    .WithMany(p => p.KeyItem)
                    .HasForeignKey(d => d.KeyItemCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_KeyItem_KeyItemCategoryID");
            });

            modelBuilder.Entity<KeyItemCategory>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<LootTable>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<LootTableItem>(entity =>
            {
                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SpawnRule)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.LootTable)
                    .WithMany(p => p.LootTableItem)
                    .HasForeignKey(d => d.LootTableID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_LootTableItem_LootTableID");
            });

            modelBuilder.Entity<Mod>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

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
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PCBase>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.AreaResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.CustomName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateFuelEnds).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateInitialPurchase).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.ApartmentBuilding)
                    .WithMany(p => p.PCBase)
                    .HasForeignKey(d => d.ApartmentBuildingID)
                    .HasConstraintName("FK_PCBase_ApartmentBuildingID");

                entity.HasOne(d => d.AreaResrefNavigation)
                    .WithMany(p => p.PCBase)
                    .HasPrincipalKey(p => p.Resref)
                    .HasForeignKey(d => d.AreaResref)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBase_AreaResref");

                entity.HasOne(d => d.BuildingStyle)
                    .WithMany(p => p.PCBase)
                    .HasForeignKey(d => d.BuildingStyleID)
                    .HasConstraintName("FK_PCBase_BuildingStyleID");

                entity.HasOne(d => d.PCBaseType)
                    .WithMany(p => p.PCBase)
                    .HasForeignKey(d => d.PCBaseTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBase_PCBaseTypeID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCBase)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBase_PlayerID");
            });

            modelBuilder.Entity<PCBasePermission>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.HasOne(d => d.PCBase)
                    .WithMany(p => p.PCBasePermission)
                    .HasForeignKey(d => d.PCBaseID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBasePermission_PCBaseID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCBasePermission)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBasePermission_PlayerID");
            });

            modelBuilder.Entity<PCBaseStructure>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.CustomName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.BaseStructure)
                    .WithMany(p => p.PCBaseStructure)
                    .HasForeignKey(d => d.BaseStructureID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBaseStructure_BaseStructureID");

                entity.HasOne(d => d.ExteriorStyle)
                    .WithMany(p => p.PCBaseStructureExteriorStyle)
                    .HasForeignKey(d => d.ExteriorStyleID)
                    .HasConstraintName("FK_PCBaseStructure_ExteriorStyleID");

                entity.HasOne(d => d.InteriorStyle)
                    .WithMany(p => p.PCBaseStructureInteriorStyle)
                    .HasForeignKey(d => d.InteriorStyleID)
                    .HasConstraintName("FK_PCBaseStructure_InteriorStyleID");

                entity.HasOne(d => d.PCBase)
                    .WithMany(p => p.PCBaseStructure)
                    .HasForeignKey(d => d.PCBaseID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBaseStructure_PCBaseID");

                entity.HasOne(d => d.ParentPCBaseStructure)
                    .WithMany(p => p.InverseParentPCBaseStructure)
                    .HasForeignKey(d => d.ParentPCBaseStructureID)
                    .HasConstraintName("FK_PCBaseStructure_ParentPCBaseStructureID");
            });

            modelBuilder.Entity<PCBaseStructureItem>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

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
                    .WithMany(p => p.PCBaseStructureItem)
                    .HasForeignKey(d => d.PCBaseStructureID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBaseStructureItem_PCBaseStructureID");
            });

            modelBuilder.Entity<PCBaseStructurePermission>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.HasOne(d => d.PCBaseStructure)
                    .WithMany(p => p.PCBaseStructurePermission)
                    .HasForeignKey(d => d.PCBaseStructureID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBaseStructurePermissions_PCBaseStructureID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCBaseStructurePermission)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCBaseStructurePermissions_PlayerID");
            });

            modelBuilder.Entity<PCBaseType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PCCooldown>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.HasOne(d => d.CooldownCategory)
                    .WithMany(p => p.PCCooldown)
                    .HasForeignKey(d => d.CooldownCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCooldown_CooldownCategoryID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCCooldown)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCooldown_PlayerID");
            });

            modelBuilder.Entity<PCCraftedBlueprint>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.DateFirstCrafted).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.CraftBlueprint)
                    .WithMany(p => p.PCCraftedBlueprint)
                    .HasForeignKey(d => d.CraftBlueprintID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCCraftedBlueprint_CraftBlueprintID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCCraftedBlueprint)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCCraftedBlueprint_PlayerID");
            });

            modelBuilder.Entity<PCCustomEffect>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.CasterNWNObjectID)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.CustomEffect)
                    .WithMany(p => p.PCCustomEffect)
                    .HasForeignKey(d => d.CustomEffectID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCustomEffect_CustomEffectID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCCustomEffect)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCCustomEffect_PlayerID");
            });

            modelBuilder.Entity<PCImpoundedItem>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

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

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCImpoundedItem)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCItemImpound_PlayerID");
            });

            modelBuilder.Entity<PCKeyItem>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.AcquiredDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.KeyItem)
                    .WithMany(p => p.PCKeyItem)
                    .HasForeignKey(d => d.KeyItemID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCKeyItem_KeyItemID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCKeyItem)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCKeyItem_PlayerID");
            });

            modelBuilder.Entity<PCMapPin>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.AreaTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.NoteText)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCMapPin)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCMapPin_PlayerID");
            });

            modelBuilder.Entity<PCMapProgression>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.AreaResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Progression)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCMapProgression)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCMapProgression_PlayerID");
            });

            modelBuilder.Entity<PCObjectVisibility>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.VisibilityObjectID)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCObjectVisibility)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCObjectVisibility_PlayerID");
            });

            modelBuilder.Entity<PCOutfit>(entity =>
            {
                entity.HasKey(e => e.PlayerID);

                entity.Property(e => e.PlayerID).ValueGeneratedNever();

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
                    .HasConstraintName("fk_PCOutfit_PlayerID");
            });

            modelBuilder.Entity<PCOverflowItem>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemObject).IsUnicode(false);

                entity.Property(e => e.ItemResref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCOverflowItem)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCOverflowItem_PlayerID");
            });

            modelBuilder.Entity<PCPerk>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.AcquiredDate).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.PCPerk)
                    .HasForeignKey(d => d.PerkID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCPerk_PerkID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCPerk)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCPerk_PlayerID");
            });

            modelBuilder.Entity<PCPerkRefund>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.DateRefunded).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.PCPerkRefund)
                    .HasForeignKey(d => d.PerkID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCPerkRefund_PerkID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCPerkRefund)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCPerkRefund_PlayerID");
            });

            modelBuilder.Entity<PCQuestItemProgress>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.PCQuestStatus)
                    .WithMany(p => p.PCQuestItemProgress)
                    .HasForeignKey(d => d.PCQuestStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestItemProgress_PCQuesttatusID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCQuestItemProgress)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestItemProgress_PlayerID");
            });

            modelBuilder.Entity<PCQuestKillTargetProgress>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.HasOne(d => d.NPCGroup)
                    .WithMany(p => p.PCQuestKillTargetProgress)
                    .HasForeignKey(d => d.NPCGroupID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_NPCGroupID");

                entity.HasOne(d => d.PCQuestStatus)
                    .WithMany(p => p.PCQuestKillTargetProgress)
                    .HasForeignKey(d => d.PCQuestStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_PCQuesttatusID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCQuestKillTargetProgress)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuestKillTargetProgress_PlayerID");
            });

            modelBuilder.Entity<PCQuestStatus>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.HasOne(d => d.CurrentQuestState)
                    .WithMany(p => p.PCQuestStatus)
                    .HasForeignKey(d => d.CurrentQuestStateID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuesttatus_CurrentQuesttateID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCQuestStatus)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuesttatus_PlayerID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.PCQuestStatus)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCQuesttatus_QuestID");

                entity.HasOne(d => d.SelectedItemReward)
                    .WithMany(p => p.PCQuestStatus)
                    .HasForeignKey(d => d.SelectedItemRewardID)
                    .HasConstraintName("FK_PCQuesttatus_SelectedRewardID");
            });

            modelBuilder.Entity<PCRegionalFame>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

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

            modelBuilder.Entity<PCSearchSite>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.UnlockDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCSearchSite)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCSearchSite_PlayerID");
            });

            modelBuilder.Entity<PCSearchSiteItem>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.SearchItem).IsUnicode(false);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCSearchSiteItem)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PCSearchSiteItem_PlayerID");
            });

            modelBuilder.Entity<PCSkill>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PCSkill)
                    .HasForeignKey(d => d.PlayerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCSkill_PlayerID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.PCSkill)
                    .HasForeignKey(d => d.SkillID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCSkill_SkillID");
            });

            modelBuilder.Entity<Perk>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FeatID).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemResref).HasMaxLength(16);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.CooldownCategory)
                    .WithMany(p => p.Perk)
                    .HasForeignKey(d => d.CooldownCategoryID)
                    .HasConstraintName("fk_Perk_CooldownCategoryID");

                entity.HasOne(d => d.EnmityAdjustmentRule)
                    .WithMany(p => p.Perk)
                    .HasForeignKey(d => d.EnmityAdjustmentRuleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Perk_EnmityAdjustmentRuleID");

                entity.HasOne(d => d.ExecutionType)
                    .WithMany(p => p.Perk)
                    .HasForeignKey(d => d.ExecutionTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Perk_ExecutionTypeID");

                entity.HasOne(d => d.PerkCategory)
                    .WithMany(p => p.Perk)
                    .HasForeignKey(d => d.PerkCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Perk_PerkCategoryID");
            });

            modelBuilder.Entity<PerkCategory>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PerkExecutionType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PerkLevel>(entity =>
            {
                entity.HasIndex(e => new { e.PerkID, e.Level })
                    .HasName("uq_PerkLevel_PerkIDLevel")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.PerkLevel)
                    .HasForeignKey(d => d.PerkID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerkLevel_PerkID");
            });

            modelBuilder.Entity<PerkLevelQuestRequirement>(entity =>
            {
                entity.HasOne(d => d.PerkLevel)
                    .WithMany(p => p.PerkLevelQuestRequirement)
                    .HasForeignKey(d => d.PerkLevelID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerkLevelQuestRequirement_PerkLevelID");

                entity.HasOne(d => d.RequiredQuest)
                    .WithMany(p => p.PerkLevelQuestRequirement)
                    .HasForeignKey(d => d.RequiredQuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerkLevelQuestRequirement_RequiredQuestID");
            });

            modelBuilder.Entity<PerkLevelSkillRequirement>(entity =>
            {
                entity.HasOne(d => d.PerkLevel)
                    .WithMany(p => p.PerkLevelSkillRequirement)
                    .HasForeignKey(d => d.PerkLevelID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerkLevelkillRequirements_PerkLevelID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.PerkLevelSkillRequirement)
                    .HasForeignKey(d => d.SkillID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerkLevelkillRequirements_SkillID");
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

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

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.CreateTimestamp)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateSanctuaryEnds).HasDefaultValueSql("(dateadd(hour,(72),getutcdate()))");

                entity.Property(e => e.DisplayDiscord)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayHelmet)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayHolonet)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationAreaResref).HasMaxLength(16);

                entity.Property(e => e.RespawnAreaResref)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Association)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.AssociationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Player_AssociationID");

                entity.HasOne(d => d.PrimaryResidencePCBase)
                    .WithMany(p => p.PlayerNavigation)
                    .HasForeignKey(d => d.PrimaryResidencePCBaseID)
                    .HasConstraintName("FK_Player_PrimaryResidencePCBaseID");

                entity.HasOne(d => d.PrimaryResidencePCBaseStructure)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.PrimaryResidencePCBaseStructureID)
                    .HasConstraintName("FK_Player_PrimaryResidencePCBaseStructureID");
            });

            modelBuilder.Entity<Quest>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.JournalTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.MapNoteTag)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OnAcceptArgs)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OnAcceptRule)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OnAdvanceArgs)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OnAdvanceRule)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OnCompleteArgs)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OnCompleteRule)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OnKillTargetArgs)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OnKillTargetRule)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.FameRegion)
                    .WithMany(p => p.Quest)
                    .HasForeignKey(d => d.FameRegionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quest_FameRegionID");

                entity.HasOne(d => d.RewardKeyItem)
                    .WithMany(p => p.QuestRewardKeyItem)
                    .HasForeignKey(d => d.RewardKeyItemID)
                    .HasConstraintName("FK_Quest_RewardKeyItemID");

                entity.HasOne(d => d.StartKeyItem)
                    .WithMany(p => p.QuestStartKeyItem)
                    .HasForeignKey(d => d.StartKeyItemID)
                    .HasConstraintName("FK_Quest_TemporaryKeyItemID");
            });

            modelBuilder.Entity<QuestKillTarget>(entity =>
            {
                entity.HasOne(d => d.NPCGroup)
                    .WithMany(p => p.QuestKillTarget)
                    .HasForeignKey(d => d.NPCGroupID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTarget_NPCGroupID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestKillTarget)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTarget_QuestID");

                entity.HasOne(d => d.QuestState)
                    .WithMany(p => p.QuestKillTarget)
                    .HasForeignKey(d => d.QuestStateID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestKillTarget_QuesttateID");
            });

            modelBuilder.Entity<QuestPrerequisite>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestPrerequisiteQuest)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestPrerequisite_QuestID");

                entity.HasOne(d => d.RequiredQuest)
                    .WithMany(p => p.QuestPrerequisiteRequiredQuest)
                    .HasForeignKey(d => d.RequiredQuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestPrerequisite_RequiredQuestID");
            });

            modelBuilder.Entity<QuestRequiredItem>(entity =>
            {
                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRequiredItem)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredItem_QuestID");

                entity.HasOne(d => d.QuestState)
                    .WithMany(p => p.QuestRequiredItem)
                    .HasForeignKey(d => d.QuestStateID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredItem");
            });

            modelBuilder.Entity<QuestRequiredKeyItem>(entity =>
            {
                entity.HasOne(d => d.KeyItem)
                    .WithMany(p => p.QuestRequiredKeyItem)
                    .HasForeignKey(d => d.KeyItemID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItem_KeyItemID");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRequiredKeyItem)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItem_QuestID");

                entity.HasOne(d => d.Questtate)
                    .WithMany(p => p.QuestRequiredKeyItem)
                    .HasForeignKey(d => d.QuesttateID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRequiredKeyItem");
            });

            modelBuilder.Entity<QuestRewardItem>(entity =>
            {
                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestRewardItem)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestRewards_QuestID");
            });

            modelBuilder.Entity<QuestState>(entity =>
            {
                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.QuestState)
                    .HasForeignKey(d => d.QuestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Questtates_QuestID");

                entity.HasOne(d => d.QuestType)
                    .WithMany(p => p.QuestState)
                    .HasForeignKey(d => d.QuestTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Questtates_QuestTypeID");
            });

            modelBuilder.Entity<QuestType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ServerConfiguration>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

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

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.ContributesToSkillCap)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Primary).HasDefaultValueSql("('')");

                entity.Property(e => e.Secondary).HasDefaultValueSql("('')");

                entity.Property(e => e.Tertiary).HasDefaultValueSql("('')");

                entity.HasOne(d => d.PrimaryAttribute)
                    .WithMany(p => p.SkillPrimaryNavigation)
                    .HasForeignKey(d => d.Primary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skill_Primary");

                entity.HasOne(d => d.SecondaryAttribute)
                    .WithMany(p => p.SkillSecondaryNavigation)
                    .HasForeignKey(d => d.Secondary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skill_Secondary");

                entity.HasOne(d => d.SkillCategory)
                    .WithMany(p => p.Skill)
                    .HasForeignKey(d => d.SkillCategoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skill_SkillCategoryID");

                entity.HasOne(d => d.TertiaryAttribute)
                    .WithMany(p => p.SkillTertiaryNavigation)
                    .HasForeignKey(d => d.Tertiary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skill_Tertiary");
            });

            modelBuilder.Entity<SkillCategory>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SkillXPRequirement>(entity =>
            {
                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.SkillXPRequirement)
                    .HasForeignKey(d => d.SkillID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SkillXPRequirement_SkillID");
            });

            modelBuilder.Entity<Spawn>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.SpawnObjectType)
                    .WithMany(p => p.Spawn)
                    .HasForeignKey(d => d.SpawnObjectTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spawn_SpawnObjectTypeID");
            });

            modelBuilder.Entity<SpawnObject>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.BehaviourScript)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Resref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.SpawnRule)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Weight).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.NPCGroup)
                    .WithMany(p => p.SpawnObject)
                    .HasForeignKey(d => d.NPCGroupID)
                    .HasConstraintName("FK_SpawnObject_NPCGroupID");

                entity.HasOne(d => d.Spawn)
                    .WithMany(p => p.SpawnObject)
                    .HasForeignKey(d => d.SpawnID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpawnObject_SpawnID");
            });

            modelBuilder.Entity<SpawnObjectType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.AvatarHash).IsRequired();

                entity.Property(e => e.DateRegistered).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DiscordUserID).IsRequired();

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_User_RoleID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
