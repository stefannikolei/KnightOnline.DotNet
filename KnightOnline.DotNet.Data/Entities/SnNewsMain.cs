using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("SN_NEWS_MAIN")]
    public partial class SnNewsMain
    {
        [Column("id")]
        public int Id { get; set; }
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
        [Column("newsid")]
        public int? Newsid { get; set; }
        [Column("newsimage")]
        public int? Newsimage { get; set; }
    }
}
