using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAIL_ITEM")]
    public partial class MailItem
    {
        [Column("ID")]
        public int Id { get; set; }
        public byte? Status { get; set; }
        [Column("sId")]
        [StringLength(21)]
        [Unicode(false)]
        public string? SId { get; set; }
        [Column("tId")]
        [StringLength(21)]
        [Unicode(false)]
        public string? TId { get; set; }
        [StringLength(32)]
        [Unicode(false)]
        public string? Title { get; set; }
        [Column("bAccess")]
        public byte? BAccess { get; set; }
        [StringLength(130)]
        [Unicode(false)]
        public string? Content { get; set; }
        public byte? Type { get; set; }
        public int? Gold { get; set; }
        [Column("nNum")]
        public int? NNum { get; set; }
        [Column("sCount")]
        public short? SCount { get; set; }
        [Column("sTime", TypeName = "smalldatetime")]
        public DateTime? STime { get; set; }
        [Column("bDay")]
        public byte? BDay { get; set; }
    }
}
