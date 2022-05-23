using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAGIC_TYPE5")]
    public partial class MagicType5
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
        public byte ExpRecover { get; set; }
        public short NeedStone { get; set; }
    }
}
