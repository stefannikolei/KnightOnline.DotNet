using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("w_Downloads")]
    public partial class WDownload
    {
        [Column("id")]
        public int? Id { get; set; }
        [Column("titletr")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Titletr { get; set; }
        [Column("titleen")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Titleen { get; set; }
        [Column("url")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Url { get; set; }
        [Column("tarih")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Tarih { get; set; }
    }
}
