using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Table("USER_PERSONAL_RANK")]
    public partial class UserPersonalRank
    {
        [Key]
        [Column("nRank")]
        public short NRank { get; set; }
        [Column("strPosition")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrPosition { get; set; } = null!;
        [Column("nElmoUP")]
        public short NElmoUp { get; set; }
        [Column("strElmoUserID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrElmoUserId { get; set; }
        [Column("nElmoLoyaltyMonthly")]
        public int? NElmoLoyaltyMonthly { get; set; }
        [Column("nElmoCheck")]
        public int NElmoCheck { get; set; }
        [Column("nKarusUP")]
        public short NKarusUp { get; set; }
        [Column("strKarusUserID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrKarusUserId { get; set; }
        [Column("nKarusLoyaltyMonthly")]
        public int? NKarusLoyaltyMonthly { get; set; }
        [Column("nKarusCheck")]
        public int NKarusCheck { get; set; }
        [Column("nSalary")]
        public int NSalary { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; }
    }
}
