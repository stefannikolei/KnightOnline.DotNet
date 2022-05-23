using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAKE_ITEM")]
    public partial class MakeItem
    {
        [Column("sIndex")]
        public short SIndex { get; set; }
        [Column("strItemInfo")]
        [StringLength(20)]
        [Unicode(false)]
        public string? StrItemInfo { get; set; }
        [Column("iItemCode")]
        public int IItemCode { get; set; }
        [Column("byItemLevel")]
        public byte ByItemLevel { get; set; }
    }
}
