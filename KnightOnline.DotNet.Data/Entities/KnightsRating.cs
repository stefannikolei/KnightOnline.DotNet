using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("KNIGHTS_RATING")]
    public partial class KnightsRating
    {
        [Column("nRank")]
        public int NRank { get; set; }
        [Column("shIndex")]
        public short ShIndex { get; set; }
        [Column("strName")]
        [StringLength(20)]
        [Unicode(false)]
        public string StrName { get; set; } = null!;
        [Column("nPoints")]
        public int NPoints { get; set; }
        [Column("nClanPointFund")]
        public int NClanPointFund { get; set; }
    }
}
