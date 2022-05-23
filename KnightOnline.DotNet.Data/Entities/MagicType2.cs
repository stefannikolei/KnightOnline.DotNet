using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAGIC_TYPE2")]
    public partial class MagicType2
    {
        [Column("iNum")]
        public int INum { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? Description { get; set; }
        public byte HitType { get; set; }
        public short HitRate { get; set; }
        public short AddDamage { get; set; }
        public short AddRange { get; set; }
        public byte NeedArrow { get; set; }
    }
}
