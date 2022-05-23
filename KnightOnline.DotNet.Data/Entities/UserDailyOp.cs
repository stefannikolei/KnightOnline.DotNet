using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("USER_DAILY_OP")]
    public partial class UserDailyOp
    {
        [Column("strUserID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrUserId { get; set; } = null!;
        public int ChaosMapTime { get; set; }
        public int UserRankRewardTime { get; set; }
        public int PersonalRankRewardTime { get; set; }
        public int KingWingTime { get; set; }
        public int WarderKillerTime1 { get; set; }
        public int WarderKillerTime2 { get; set; }
        public int KeeperKillerTime { get; set; }
        public int UserLoyaltyWingRewardTime { get; set; }
    }
}
