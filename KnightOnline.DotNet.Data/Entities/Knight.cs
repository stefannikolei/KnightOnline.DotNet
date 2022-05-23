using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Table("KNIGHTS")]
    public partial class Knight
    {
        [Key]
        [Column("IDNum")]
        public short Idnum { get; set; }
        public byte Flag { get; set; }
        public byte Nation { get; set; }
        public byte Ranking { get; set; }
        [Column("IDName")]
        [StringLength(21)]
        [Unicode(false)]
        public string Idname { get; set; } = null!;
        public short Members { get; set; }
        [StringLength(21)]
        [Unicode(false)]
        public string Chief { get; set; } = null!;
        [Column("ViceChief_1")]
        [StringLength(21)]
        [Unicode(false)]
        public string? ViceChief1 { get; set; }
        [Column("ViceChief_2")]
        [StringLength(21)]
        [Unicode(false)]
        public string? ViceChief2 { get; set; }
        [Column("ViceChief_3")]
        [StringLength(21)]
        [Unicode(false)]
        public string? ViceChief3 { get; set; }
        public long Gold { get; set; }
        public short Domination { get; set; }
        public int Points { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Mark { get; set; }
        [Column("sMarkVersion")]
        public short SMarkVersion { get; set; }
        [Column("sMarkLen")]
        public short SMarkLen { get; set; }
        [Column("sCape")]
        public short SCape { get; set; }
        [Column("bCapeR")]
        public byte BCapeR { get; set; }
        [Column("bCapeG")]
        public byte BCapeG { get; set; }
        [Column("bCapeB")]
        public byte BCapeB { get; set; }
        [Column("sAllianceKnights")]
        public short SAllianceKnights { get; set; }
        public int ClanPointFund { get; set; }
        [Column("strClanNotice")]
        [StringLength(128)]
        [Unicode(false)]
        public string? StrClanNotice { get; set; }
        [Column("bySiegeFlag")]
        public byte BySiegeFlag { get; set; }
        [Column("nLose")]
        public short NLose { get; set; }
        [Column("nVictory")]
        public short NVictory { get; set; }
        public byte ClanPointMethod { get; set; }
        [Column("dtCreateTime", TypeName = "datetime")]
        public DateTime DtCreateTime { get; set; }
        [Column("nWarEnemyID")]
        public short NWarEnemyId { get; set; }
        [Column("strEnemyName")]
        [StringLength(30)]
        [Unicode(false)]
        public string? StrEnemyName { get; set; }
        [Column("byOldWarResult")]
        public byte ByOldWarResult { get; set; }
    }
}
