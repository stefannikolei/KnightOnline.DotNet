using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("KNIGHTS_CAPE")]
    public partial class KnightsCape
    {
        [Column("sCapeIndex")]
        public short SCapeIndex { get; set; }
        [Column("strName")]
        [StringLength(30)]
        [Unicode(false)]
        public string StrName { get; set; } = null!;
        [Column("nBuyPrice")]
        public int NBuyPrice { get; set; }
        [Column("nDuration")]
        public int NDuration { get; set; }
        [Column("byGrade")]
        public byte ByGrade { get; set; }
        [Column("nBuyLoyalty")]
        public int NBuyLoyalty { get; set; }
        [Column("byRanking")]
        public byte ByRanking { get; set; }
    }
}
