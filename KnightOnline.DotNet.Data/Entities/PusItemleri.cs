using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("PUS_ITEMLERI")]
    public partial class PusItemleri
    {
        [Column("id")]
        public int? Id { get; set; }
        [Column("type")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Type { get; set; }
        [Column("itemismi")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Itemismi { get; set; }
        [Column("ucret")]
        public int? Ucret { get; set; }
        [Column("adet")]
        public short? Adet { get; set; }
        [Column("itemkodu")]
        public int? Itemkodu { get; set; }
        [Column("resim")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Resim { get; set; }
        [Column("alindi")]
        public int? Alindi { get; set; }
    }
}
