using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAGIC_TYPE9")]
    public partial class MagicType9
    {
        [Column("iNum")]
        public int INum { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? Name { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string? Description { get; set; }
        public byte ValidGroup { get; set; }
        public byte NationChange { get; set; }
        public short MonsterNum { get; set; }
        public byte TargetChange { get; set; }
        public byte StateChange { get; set; }
        public short Radius { get; set; }
        public short Hitrate { get; set; }
        public short Duration { get; set; }
        public short AddDamage { get; set; }
        public short Vision { get; set; }
        public int NeedItem { get; set; }
    }
}
