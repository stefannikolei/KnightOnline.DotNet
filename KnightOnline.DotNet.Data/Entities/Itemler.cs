using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("ITEMLER")]
    public partial class Itemler
    {
        [Column("dwid")]
        public int? Dwid { get; set; }
        [Column("stacksize")]
        public short? Stacksize { get; set; }
        [Column("durability")]
        public short? Durability { get; set; }
        [Column("strUserId")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StrUserId { get; set; }
        [Column("sira")]
        public int? Sira { get; set; }
        [Column("itembasicname")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Itembasicname { get; set; }
        [Column("extname")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Extname { get; set; }
    }
}
