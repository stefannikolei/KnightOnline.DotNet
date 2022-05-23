using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("PUS_CASH")]
    public partial class PusCash
    {
        [Column("cashid")]
        public int Cashid { get; set; }
        public int Total { get; set; }
        public int Cash { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string Aciklama { get; set; } = null!;
        [Column("PID")]
        public int Pid { get; set; }
    }
}
