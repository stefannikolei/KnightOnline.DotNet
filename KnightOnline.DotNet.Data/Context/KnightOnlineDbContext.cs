using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using KnightOnline.DotNet.Data.Entities;

namespace KnightOnline.DotNet.Data.Context
{
    public class KnightOnlineDbContext : DbContext
    {
        public KnightOnlineDbContext(DbContextOptions<KnightOnlineDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountChar> AccountChars { get; set; } = null!;
        public virtual DbSet<Battle> Battles { get; set; } = null!;
        public virtual DbSet<BeginnerItem> BeginnerItems { get; set; } = null!;
        public virtual DbSet<Coefficient> Coefficients { get; set; } = null!;
        public virtual DbSet<Concurrent> Concurrents { get; set; } = null!;
        public virtual DbSet<Currentuser> Currentusers { get; set; } = null!;
        public virtual DbSet<EnesKcbsnotice> EnesKcbsnotices { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<EventTrigger> EventTriggers { get; set; } = null!;
        public virtual DbSet<FriendList> FriendLists { get; set; } = null!;
        public virtual DbSet<Home> Homes { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<ItemExchange> ItemExchanges { get; set; } = null!;
        public virtual DbSet<ItemGroup> ItemGroups { get; set; } = null!;
        public virtual DbSet<ItemOp> ItemOps { get; set; } = null!;
        public virtual DbSet<ItemUpgrade> ItemUpgrades { get; set; } = null!;
        public virtual DbSet<Itemler> Itemlers { get; set; } = null!;
        public virtual DbSet<ItemupProbability> ItemupProbabilities { get; set; } = null!;
        public virtual DbSet<KMonster> KMonsters { get; set; } = null!;
        public virtual DbSet<KMonsterItem> KMonsterItems { get; set; } = null!;
        public virtual DbSet<KNpc> KNpcs { get; set; } = null!;
        public virtual DbSet<KNpcpo> KNpcpos { get; set; } = null!;
        public virtual DbSet<KObjectevent> KObjectevents { get; set; } = null!;
        public virtual DbSet<KObjectpo> KObjectpos { get; set; } = null!;
        public virtual DbSet<KWarpinfo> KWarpinfos { get; set; } = null!;
        public virtual DbSet<KingBallotBox> KingBallotBoxes { get; set; } = null!;
        public virtual DbSet<KingCandidacyNoticeBoard> KingCandidacyNoticeBoards { get; set; } = null!;
        public virtual DbSet<KingElectionList> KingElectionLists { get; set; } = null!;
        public virtual DbSet<KingSystem> KingSystems { get; set; } = null!;
        public virtual DbSet<Knight> Knights { get; set; } = null!;
        public virtual DbSet<KnightsAlliance> KnightsAlliances { get; set; } = null!;
        public virtual DbSet<KnightsCape> KnightsCapes { get; set; } = null!;
        public virtual DbSet<KnightsRating> KnightsRatings { get; set; } = null!;
        public virtual DbSet<KnightsSiegeWarfare> KnightsSiegeWarfares { get; set; } = null!;
        public virtual DbSet<KnightsUser> KnightsUsers { get; set; } = null!;
        public virtual DbSet<LevelUp> LevelUps { get; set; } = null!;
        public virtual DbSet<Magic> Magics { get; set; } = null!;
        public virtual DbSet<MagicType1> MagicTypeOnes { get; set; } = null!;
        public virtual DbSet<MagicType2> MagicTypeTwos { get; set; } = null!;
        public virtual DbSet<MagicType3> MagicTypeThrees { get; set; } = null!;
        public virtual DbSet<MagicType4> MagicTypeFours { get; set; } = null!;
        public virtual DbSet<MagicType5> MagicTypeFives { get; set; } = null!;
        public virtual DbSet<MagicType6> MagicTypeSixs { get; set; } = null!;
        public virtual DbSet<MagicType7> MagicTypeSevens { get; set; } = null!;
        public virtual DbSet<MagicType8> MagicTypeEights { get; set; } = null!;
        public virtual DbSet<MagicType9> MagicTypeNines { get; set; } = null!;
        public virtual DbSet<MailBox> MailBoxes { get; set; } = null!;
        public virtual DbSet<MailItem> MailItems { get; set; } = null!;
        public virtual DbSet<MakeDefensive> MakeDefensives { get; set; } = null!;
        public virtual DbSet<MakeItem> MakeItems { get; set; } = null!;
        public virtual DbSet<MakeItemGradecode> MakeItemGradecodes { get; set; } = null!;
        public virtual DbSet<MakeItemGroup> MakeItemGroups { get; set; } = null!;
        public virtual DbSet<MakeItemLarecode> MakeItemLarecodes { get; set; } = null!;
        public virtual DbSet<MakeWeapon> MakeWeapons { get; set; } = null!;
        public virtual DbSet<MonsterChallenge> MonsterChallenges { get; set; } = null!;
        public virtual DbSet<MonsterChallengeSummonList> MonsterChallengeSummonLists { get; set; } = null!;
        public virtual DbSet<MonsterRespawnList> MonsterRespawnLists { get; set; } = null!;
        public virtual DbSet<MonsterRespawnListInformation> MonsterRespawnListInformations { get; set; } = null!;
        public virtual DbSet<MonsterSummonList> MonsterSummonLists { get; set; } = null!;
        public virtual DbSet<MonsterSummonListZone> MonsterSummonListZones { get; set; } = null!;
        public virtual DbSet<PremiumItem> PremiumItems { get; set; } = null!;
        public virtual DbSet<PremiumItemExp> PremiumItemExps { get; set; } = null!;
        public virtual DbSet<PusCash> PusCashes { get; set; } = null!;
        public virtual DbSet<PusItemleri> PusItemleris { get; set; } = null!;
        public virtual DbSet<PusItemleriPaket> PusItemleriPakets { get; set; } = null!;
        public virtual DbSet<PusPaypalLog> PusPaypalLogs { get; set; } = null!;
        public virtual DbSet<QuestHelper> QuestHelpers { get; set; } = null!;
        public virtual DbSet<QuestLog> QuestLogs { get; set; } = null!;
        public virtual DbSet<QuestMenu> QuestMenus { get; set; } = null!;
        public virtual DbSet<QuestMonster> QuestMonsters { get; set; } = null!;
        public virtual DbSet<QuestTalk> QuestTalks { get; set; } = null!;
        public virtual DbSet<RentalItem> RentalItems { get; set; } = null!;
        public virtual DbSet<RentalItemList> RentalItemLists { get; set; } = null!;
        public virtual DbSet<SealedItem> SealedItems { get; set; } = null!;
        public virtual DbSet<Server> Servers { get; set; } = null!;
        public virtual DbSet<ServerResource> ServerResources { get; set; } = null!;
        public virtual DbSet<SetItem> SetItems { get; set; } = null!;
        public virtual DbSet<SnNews> SnNews { get; set; } = null!;
        public virtual DbSet<SnNewsMain> SnNewsMains { get; set; } = null!;
        public virtual DbSet<SnPusCcslog> SnPusCcslogs { get; set; } = null!;
        public virtual DbSet<SnPusNcslog> SnPusNcslogs { get; set; } = null!;
        public virtual DbSet<SnPusNtslog> SnPusNtslogs { get; set; } = null!;
        public virtual DbSet<SnTicket> SnTickets { get; set; } = null!;
        public virtual DbSet<StartPosition> StartPositions { get; set; } = null!;
        public virtual DbSet<StartPositionRandom> StartPositionRandoms { get; set; } = null!;
        public virtual DbSet<TbUser> TbUsers { get; set; } = null!;
        public virtual DbSet<UserDailyOp> UserDailyOps { get; set; } = null!;
        public virtual DbSet<UserItem> UserItems { get; set; } = null!;
        public virtual DbSet<UserKnightsRank> UserKnightsRanks { get; set; } = null!;
        public virtual DbSet<UserPersonalRank> UserPersonalRanks { get; set; } = null!;
        public virtual DbSet<UserRentalItem> UserRentalItems { get; set; } = null!;
        public virtual DbSet<UserSavedMagic> UserSavedMagics { get; set; } = null!;
        public virtual DbSet<UserdataSkillshortcut> UserdataSkillshortcuts { get; set; } = null!;
        public virtual DbSet<Userdatum> Userdata { get; set; } = null!;
        public virtual DbSet<ClientVersion> Versions { get; set; } = null!;
        public virtual DbSet<WDownload> WDownloads { get; set; } = null!;
        public virtual DbSet<WNews> WNews { get; set; } = null!;
        public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;
        public virtual DbSet<WarehouseItemler> WarehouseItemlers { get; set; } = null!;
        public virtual DbSet<WebItemmall> WebItemmalls { get; set; } = null!;
        public virtual DbSet<WebItemmallLog> WebItemmallLogs { get; set; } = null!;
        public virtual DbSet<ZoneInfo> ZoneInfos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountChar>(entity =>
            {
                entity.Property(e => e.StrAccountId).IsFixedLength();

                entity.Property(e => e.StrCharId1).IsFixedLength();

                entity.Property(e => e.StrCharId2).IsFixedLength();

                entity.Property(e => e.StrCharId3).IsFixedLength();
            });

            modelBuilder.Entity<Battle>(entity =>
            {
                entity.Property(e => e.StrUserName).IsFixedLength();
            });

            modelBuilder.Entity<BeginnerItem>(entity =>
            {
                entity.Property(e => e.StrClass).IsFixedLength();

                entity.Property(e => e.StrItem1).IsFixedLength();
            });

            modelBuilder.Entity<EnesKcbsnotice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Cond1).IsFixedLength();

                entity.Property(e => e.Cond2).IsFixedLength();

                entity.Property(e => e.Cond3).IsFixedLength();

                entity.Property(e => e.Cond4).IsFixedLength();

                entity.Property(e => e.Cond5).IsFixedLength();

                entity.Property(e => e.Exec1).IsFixedLength();

                entity.Property(e => e.Exec2).IsFixedLength();

                entity.Property(e => e.Exec3).IsFixedLength();

                entity.Property(e => e.Exec4).IsFixedLength();

                entity.Property(e => e.Exec5).IsFixedLength();
            });

            modelBuilder.Entity<FriendList>(entity =>
            {
                entity.Property(e => e.StrFriend1).IsFixedLength();

                entity.Property(e => e.StrFriend10).IsFixedLength();

                entity.Property(e => e.StrFriend11).IsFixedLength();

                entity.Property(e => e.StrFriend12).IsFixedLength();

                entity.Property(e => e.StrFriend13).IsFixedLength();

                entity.Property(e => e.StrFriend14).IsFixedLength();

                entity.Property(e => e.StrFriend15).IsFixedLength();

                entity.Property(e => e.StrFriend16).IsFixedLength();

                entity.Property(e => e.StrFriend17).IsFixedLength();

                entity.Property(e => e.StrFriend18).IsFixedLength();

                entity.Property(e => e.StrFriend19).IsFixedLength();

                entity.Property(e => e.StrFriend2).IsFixedLength();

                entity.Property(e => e.StrFriend20).IsFixedLength();

                entity.Property(e => e.StrFriend21).IsFixedLength();

                entity.Property(e => e.StrFriend22).IsFixedLength();

                entity.Property(e => e.StrFriend23).IsFixedLength();

                entity.Property(e => e.StrFriend24).IsFixedLength();

                entity.Property(e => e.StrFriend3).IsFixedLength();

                entity.Property(e => e.StrFriend4).IsFixedLength();

                entity.Property(e => e.StrFriend5).IsFixedLength();

                entity.Property(e => e.StrFriend6).IsFixedLength();

                entity.Property(e => e.StrFriend7).IsFixedLength();

                entity.Property(e => e.StrFriend8).IsFixedLength();

                entity.Property(e => e.StrFriend9).IsFixedLength();

                entity.Property(e => e.StrUserId).IsFixedLength();
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.StrName).IsFixedLength();
            });

            modelBuilder.Entity<ItemGroup>(entity =>
            {
                entity.Property(e => e.Name).IsFixedLength();
            });

            modelBuilder.Entity<ItemUpgrade>(entity =>
            {
                entity.Property(e => e.NIndex).ValueGeneratedNever();

                entity.Property(e => e.StrName).IsFixedLength();
            });

            modelBuilder.Entity<KingBallotBox>(entity =>
            {
                entity.Property(e => e.StrAccountId).IsFixedLength();

                entity.Property(e => e.StrCandidacyId).IsFixedLength();

                entity.Property(e => e.StrCharId).IsFixedLength();
            });

            modelBuilder.Entity<KingCandidacyNoticeBoard>(entity =>
            {
                entity.Property(e => e.StrUserId).IsFixedLength();
            });

            modelBuilder.Entity<KingElectionList>(entity =>
            {
                entity.Property(e => e.StrName).IsFixedLength();
            });

            modelBuilder.Entity<KingSystem>(entity =>
            {
                entity.Property(e => e.StrImRequestId).IsFixedLength();

                entity.Property(e => e.StrKingName).IsFixedLength();
            });

            modelBuilder.Entity<Knight>(entity =>
            {
                entity.HasKey(e => e.Idnum)
                    .HasName("PK_Table_1");

                entity.Property(e => e.Idnum).ValueGeneratedNever();

                entity.Property(e => e.Chief).IsFixedLength();

                entity.Property(e => e.DtCreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idname).IsFixedLength();

                entity.Property(e => e.Members).HasDefaultValueSql("((1))");

                entity.Property(e => e.SCape).HasDefaultValueSql("((-1))");

                entity.Property(e => e.StrClanNotice).IsFixedLength();

                entity.Property(e => e.StrEnemyName).IsFixedLength();

                entity.Property(e => e.ViceChief1).IsFixedLength();

                entity.Property(e => e.ViceChief2).IsFixedLength();

                entity.Property(e => e.ViceChief3).IsFixedLength();
            });

            modelBuilder.Entity<KnightsAlliance>(entity =>
            {
                entity.HasKey(e => e.SMainAllianceKnights)
                    .HasName("PK_KNIGHTS_ALLIANCE1");

                entity.Property(e => e.SMainAllianceKnights).ValueGeneratedNever();
            });

            modelBuilder.Entity<KnightsCape>(entity =>
            {
                entity.Property(e => e.StrName).IsFixedLength();
            });

            modelBuilder.Entity<KnightsRating>(entity =>
            {
                entity.Property(e => e.StrName).IsFixedLength();
            });

            modelBuilder.Entity<KnightsSiegeWarfare>(entity =>
            {
                entity.Property(e => e.SCastleIndex).ValueGeneratedNever();

                entity.Property(e => e.StrChallengeList).IsFixedLength();
            });

            modelBuilder.Entity<KnightsUser>(entity =>
            {
                entity.Property(e => e.StrUserId).IsFixedLength();
            });

            modelBuilder.Entity<Magic>(entity =>
            {
                entity.Property(e => e.Description).IsFixedLength();

                entity.Property(e => e.EnName).IsFixedLength();

                entity.Property(e => e.KrName).IsFixedLength();
            });

            modelBuilder.Entity<MagicType1>(entity =>
            {
                entity.Property(e => e.Description).IsFixedLength();

                entity.Property(e => e.Name).IsFixedLength();
            });

            modelBuilder.Entity<MagicType2>(entity =>
            {
                entity.Property(e => e.Description).IsFixedLength();

                entity.Property(e => e.Name).IsFixedLength();
            });

            modelBuilder.Entity<MagicType3>(entity =>
            {
                entity.Property(e => e.Description).IsFixedLength();

                entity.Property(e => e.Name).IsFixedLength();
            });

            modelBuilder.Entity<MagicType4>(entity =>
            {
                entity.Property(e => e.Description).IsFixedLength();

                entity.Property(e => e.Name).IsFixedLength();
            });

            modelBuilder.Entity<MagicType5>(entity =>
            {
                entity.Property(e => e.Description).IsFixedLength();

                entity.Property(e => e.Name).IsFixedLength();
            });

            modelBuilder.Entity<MagicType6>(entity =>
            {
                entity.Property(e => e.Description).IsFixedLength();

                entity.Property(e => e.Name).IsFixedLength();
            });

            modelBuilder.Entity<MagicType7>(entity =>
            {
                entity.Property(e => e.StrName).IsFixedLength();

                entity.Property(e => e.StrNote).IsFixedLength();
            });

            modelBuilder.Entity<MagicType8>(entity =>
            {
                entity.Property(e => e.Description).IsFixedLength();

                entity.Property(e => e.Name).IsFixedLength();
            });

            modelBuilder.Entity<MagicType9>(entity =>
            {
                entity.Property(e => e.Description).IsFixedLength();

                entity.Property(e => e.Name).IsFixedLength();
            });

            modelBuilder.Entity<MailBox>(entity =>
            {
                entity.HasKey(e => e.NLetterId)
                    .HasName("PK__MAIL_BOX__616EF9253FC215FF");

                entity.Property(e => e.BStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.BType).HasDefaultValueSql("((1))");

                entity.Property(e => e.DtSendDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StrMessage).IsFixedLength();

                entity.Property(e => e.StrRecipientId).IsFixedLength();

                entity.Property(e => e.StrSenderId).IsFixedLength();

                entity.Property(e => e.StrSubject).IsFixedLength();
            });

            modelBuilder.Entity<MailItem>(entity =>
            {
                entity.Property(e => e.Content).IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SId).IsFixedLength();

                entity.Property(e => e.TId).IsFixedLength();

                entity.Property(e => e.Title).IsFixedLength();
            });

            modelBuilder.Entity<MakeItem>(entity =>
            {
                entity.Property(e => e.StrItemInfo).IsFixedLength();
            });

            modelBuilder.Entity<QuestHelper>(entity =>
            {
                entity.Property(e => e.StrLuaFilename).IsFixedLength();
            });

            modelBuilder.Entity<QuestMenu>(entity =>
            {
                entity.Property(e => e.StrMenu).IsFixedLength();
            });

            modelBuilder.Entity<QuestTalk>(entity =>
            {
                entity.Property(e => e.StrTalk).IsFixedLength();
            });

            modelBuilder.Entity<RentalItem>(entity =>
            {
                entity.Property(e => e.NRentalIndex).ValueGeneratedNever();

                entity.Property(e => e.ByRegType).HasDefaultValueSql("(0)");

                entity.Property(e => e.SDurability).HasDefaultValueSql("(0)");

                entity.Property(e => e.StrBorrowerAcId).IsFixedLength();

                entity.Property(e => e.StrBorrowerCharId).IsFixedLength();

                entity.Property(e => e.StrLenderAcId).IsFixedLength();

                entity.Property(e => e.StrLenderCharId).IsFixedLength();

                entity.Property(e => e.TimeRegister).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<RentalItemList>(entity =>
            {
                entity.Property(e => e.NRentalIndex).ValueGeneratedNever();

                entity.Property(e => e.ByRegType).HasDefaultValueSql("(0)");

                entity.Property(e => e.StrBorrowerAcId).IsFixedLength();

                entity.Property(e => e.StrBorrowerCharId).IsFixedLength();

                entity.Property(e => e.StrLenderAcId).IsFixedLength();

                entity.Property(e => e.StrLenderCharId).IsFixedLength();

                entity.Property(e => e.TimeRegister).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SealedItem>(entity =>
            {
                entity.Property(e => e.StrAccountId).IsFixedLength();

                entity.Property(e => e.StrUserId).IsFixedLength();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.HasKey(e => e.SNum)
                    .HasName("PK__SERVERS__3B98AD42329C25A4");

                entity.Property(e => e.SNum).ValueGeneratedOnAdd();

                entity.Property(e => e.DatabaseName).IsFixedLength();

                entity.Property(e => e.SIp).IsFixedLength();

                entity.Property(e => e.SName).IsFixedLength();
            });

            modelBuilder.Entity<SnNews>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SnNewsMain>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SnPusCcslog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StrCharName).IsFixedLength();
            });

            modelBuilder.Entity<SnPusNcslog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StrNewName).IsFixedLength();

                entity.Property(e => e.StrOldName).IsFixedLength();
            });

            modelBuilder.Entity<SnPusNtslog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SnTicket>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StrStatus).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.Property(e => e.BPremiumType).HasDefaultValueSql("((7))");

                entity.Property(e => e.Cashpoint).HasDefaultValueSql("((100))");

                entity.Property(e => e.DtCreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtPremiumTime).HasDefaultValueSql("(getdate()+(3))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Pusadmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.SHours).HasDefaultValueSql("((720))");

                entity.Property(e => e.Sepet).HasDefaultValueSql("((0))");

                entity.Property(e => e.StrAd).HasDefaultValueSql("((0))");

                entity.Property(e => e.StrCevap).HasDefaultValueSql("((0))");

                entity.Property(e => e.StrClientIp).IsFixedLength();

                entity.Property(e => e.StrSealPasswd)
                    .HasDefaultValueSql("((12345678))")
                    .IsFixedLength();

                entity.Property(e => e.StrSoru).HasDefaultValueSql("((0))");

                entity.Property(e => e.StrSoyad).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserDailyOp>(entity =>
            {
                entity.Property(e => e.StrUserId).IsFixedLength();
            });

            modelBuilder.Entity<UserItem>(entity =>
            {
                entity.Property(e => e.NItemSerial).IsFixedLength();
            });

            modelBuilder.Entity<UserKnightsRank>(entity =>
            {
                entity.Property(e => e.ShIndex).ValueGeneratedNever();

                entity.Property(e => e.StrName).IsFixedLength();
            });

            modelBuilder.Entity<UserPersonalRank>(entity =>
            {
                entity.Property(e => e.NRank).ValueGeneratedNever();

                entity.Property(e => e.StrElmoUserId).IsFixedLength();

                entity.Property(e => e.StrKarusUserId).IsFixedLength();

                entity.Property(e => e.StrPosition).IsFixedLength();
            });

            modelBuilder.Entity<UserRentalItem>(entity =>
            {
                entity.Property(e => e.StrUserId).IsFixedLength();

                entity.Property(e => e.StrAccountId).IsFixedLength();
            });

            modelBuilder.Entity<UserSavedMagic>(entity =>
            {
                entity.Property(e => e.NDuring4).HasComment("");

                entity.Property(e => e.NDuring5).HasComment("");

                entity.Property(e => e.NSkill8).HasComment("");

                entity.Property(e => e.StrCharId).IsFixedLength();
            });

            modelBuilder.Entity<UserdataSkillshortcut>(entity =>
            {
                entity.Property(e => e.StrCharId).IsFixedLength();
            });

            modelBuilder.Entity<Userdatum>(entity =>
            {
                entity.Property(e => e.Authority).HasDefaultValueSql("((1))");

                entity.Property(e => e.DtCreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gold).HasDefaultValueSql("((200000))");

                entity.Property(e => e.Hp).HasDefaultValueSql("((100))");

                entity.Property(e => e.Level).HasDefaultValueSql("((1))");

                entity.Property(e => e.Loyalty).HasDefaultValueSql("((500))");

                entity.Property(e => e.Mp).HasDefaultValueSql("((100))");

                entity.Property(e => e.Px).HasDefaultValueSql("((31000))");

                entity.Property(e => e.Pz).HasDefaultValueSql("((36000))");

                entity.Property(e => e.Sp).HasDefaultValueSql("((100))");

                entity.Property(e => e.StrItem).IsFixedLength();

                entity.Property(e => e.StrItemTime)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.StrQuest).IsFixedLength();

                entity.Property(e => e.StrSerial).IsFixedLength();

                entity.Property(e => e.StrUserId).IsFixedLength();

                entity.Property(e => e.Zone).HasDefaultValueSql("((21))");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.Property(e => e.StrAccountId).IsFixedLength();

                entity.Property(e => e.StrSerial).IsFixedLength();

                entity.Property(e => e.WarehouseData).IsFixedLength();

                entity.Property(e => e.WarehouseDataTime)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();
            });

            modelBuilder.Entity<WebItemmall>(entity =>
            {
                entity.Property(e => e.BuyTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StrAccountId).IsFixedLength();

                entity.Property(e => e.StrCharId).IsFixedLength();
            });

            modelBuilder.Entity<WebItemmallLog>(entity =>
            {
                entity.Property(e => e.BuyTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StrAccountId).IsFixedLength();

                entity.Property(e => e.StrCharId).IsFixedLength();
            });
        }
    }
}
