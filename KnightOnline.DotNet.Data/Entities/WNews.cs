using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("w_News")]
    public partial class WNews
    {
        [Column("id")]
        public int? Id { get; set; }
        [Column("date")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Date { get; set; }
        [Column("konu", TypeName = "text")]
        public string? Konu { get; set; }
        [Column("haber", TypeName = "text")]
        public string? Haber { get; set; }
        [Column("tr")]
        public int? Tr { get; set; }
    }
}
