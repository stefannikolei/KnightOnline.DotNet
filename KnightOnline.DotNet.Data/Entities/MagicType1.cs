using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAGIC_TYPE1")]
    public partial class MagicType1
    {
        [Column("iNum")]
        public int INum { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? Name { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string? Description { get; set; }
        public byte Type { get; set; }
        public short HitRate { get; set; }
        public short Hit { get; set; }
        public short AddDamage { get; set; }
        public byte Delay { get; set; }
        public byte ComboType { get; set; }
        public byte ComboCount { get; set; }
        public short ComboDamage { get; set; }
        public short Range { get; set; }
    }
}
