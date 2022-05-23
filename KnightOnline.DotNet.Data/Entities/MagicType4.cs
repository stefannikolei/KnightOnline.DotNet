using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAGIC_TYPE4")]
    public partial class MagicType4
    {
        [Column("iNum")]
        public int INum { get; set; }
        [StringLength(500)]
        public string Name { get; set; } = null!;
        [StringLength(500)]
        public string Description { get; set; } = null!;
        public byte BuffType { get; set; }
        public byte Radius { get; set; }
        public short Duration { get; set; }
        public byte AttackSpeed { get; set; }
        public byte Speed { get; set; }
        [Column("AC")]
        public short Ac { get; set; }
        [Column("ACPct")]
        public short Acpct { get; set; }
        public byte Attack { get; set; }
        public byte MagicAttack { get; set; }
        [Column("MaxHP")]
        public short MaxHp { get; set; }
        [Column("MaxHPPct")]
        public short MaxHppct { get; set; }
        [Column("MaxMP")]
        public short MaxMp { get; set; }
        [Column("MaxMPPct")]
        public short MaxMppct { get; set; }
        public byte HitRate { get; set; }
        public short AvoidRate { get; set; }
        public short Str { get; set; }
        public short Sta { get; set; }
        public short Dex { get; set; }
        public short Intel { get; set; }
        public short Cha { get; set; }
        public byte FireR { get; set; }
        public byte ColdR { get; set; }
        public byte LightningR { get; set; }
        public byte MagicR { get; set; }
        public byte DiseaseR { get; set; }
        public byte PoisonR { get; set; }
        public short ExpPct { get; set; }
        public short SpecialAmount { get; set; }
    }
}
