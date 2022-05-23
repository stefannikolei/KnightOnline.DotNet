using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("SN_NEWS")]
    public partial class SnNews
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("type")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Type { get; set; }
        [Column("date")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Date { get; set; }
        [Column("titletr")]
        [StringLength(80)]
        [Unicode(false)]
        public string? Titletr { get; set; }
        [Column("newstr")]
        [StringLength(4096)]
        [Unicode(false)]
        public string? Newstr { get; set; }
        [Column("titleen")]
        [StringLength(80)]
        [Unicode(false)]
        public string? Titleen { get; set; }
        [Column("newsen")]
        [StringLength(4096)]
        [Unicode(false)]
        public string? Newsen { get; set; }
        [Column("titlees")]
        [StringLength(80)]
        [Unicode(false)]
        public string? Titlees { get; set; }
        [Column("newses")]
        [StringLength(4096)]
        [Unicode(false)]
        public string? Newses { get; set; }
    }
}
