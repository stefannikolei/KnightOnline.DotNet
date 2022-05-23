using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAGIC_TYPE8")]
    public partial class MagicType8
    {
        [Column("iNum")]
        public int INum { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? Name { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string? Description { get; set; }
        public byte Target { get; set; }
        public short Radius { get; set; }
        public byte WarpType { get; set; }
        public short ExpRecover { get; set; }
        public short KickDistance { get; set; }
    }
}
