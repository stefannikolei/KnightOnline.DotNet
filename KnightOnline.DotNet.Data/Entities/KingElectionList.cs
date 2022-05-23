using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("KING_ELECTION_LIST")]
    public partial class KingElectionList
    {
        [Column("byType")]
        public byte ByType { get; set; }
        [Column("byNation")]
        public byte ByNation { get; set; }
        [Column("nKnights")]
        public short? NKnights { get; set; }
        [Column("strName")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrName { get; set; }
        [Column("nMoney")]
        public int NMoney { get; set; }
    }
}
