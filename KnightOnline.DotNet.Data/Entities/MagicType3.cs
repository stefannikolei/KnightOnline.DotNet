using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAGIC_TYPE3")]
    public partial class MagicType3
    {
        [Column("iNum")]
        public int INum { get; set; }
        [StringLength(500)]
        public string Name { get; set; } = null!;
        [StringLength(500)]
        public string Description { get; set; } = null!;
        public byte DirectType { get; set; }
        public short FirstDamage { get; set; }
        public short EndDamage { get; set; }
        public short TimeDamage { get; set; }
        public byte Duration { get; set; }
        public byte Attribute { get; set; }
        public byte Radius { get; set; }
        public short Angle { get; set; }
    }
}
