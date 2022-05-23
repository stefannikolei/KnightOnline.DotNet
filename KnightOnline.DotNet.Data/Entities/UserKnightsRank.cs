using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Table("USER_KNIGHTS_RANK")]
    public partial class UserKnightsRank
    {
        [Key]
        [Column("shIndex")]
        public short ShIndex { get; set; }
        [Column("strName")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrName { get; set; } = null!;
        [Column("strElmoUserID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrElmoUserId { get; set; }
        [Column("strElmoKnightsName")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrElmoKnightsName { get; set; }
        [Column("nElmoLoyalty")]
        public int? NElmoLoyalty { get; set; }
        [Column("strKarusUserID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrKarusUserId { get; set; }
        [Column("strKarusKnightsName")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrKarusKnightsName { get; set; }
        [Column("nKarusLoyalty")]
        public int? NKarusLoyalty { get; set; }
        [Column("nMoney")]
        public int NMoney { get; set; }
    }
}
