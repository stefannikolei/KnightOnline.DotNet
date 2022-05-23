using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Table("SERVERS")]
    public partial class Server
    {
        [Key]
        [Column("sNum", TypeName = "numeric(18, 0)")]
        public decimal SNum { get; set; }
        [Column("sName")]
        [StringLength(250)]
        [Unicode(false)]
        public string? SName { get; set; }
        [Column("sIP")]
        [StringLength(15)]
        [Unicode(false)]
        public string? SIp { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? DatabaseName { get; set; }
    }
}
