using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("BEGINNER_ITEM")]
    public partial class BeginnerItem
    {
        [Column("iClass")]
        public short Class { get; set; }
        [Column("strClass")]
        [StringLength(10)]
        [Unicode(false)]
        public string? StrClass { get; set; }
        public long Gold { get; set; }
        [Column("strItem")]
        [StringLength(1200)]
        [Unicode(false)]
        public string? StrItem { get; set; }
        [Column("strItem1")]
        [MaxLength(1200)]
        public byte[]? StrItem1 { get; set; }
    }
}
