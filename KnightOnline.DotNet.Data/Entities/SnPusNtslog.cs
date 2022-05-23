using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("_SN_PUS_NTSLOG")]
    public partial class SnPusNtslog
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("StrAccountID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrAccountId { get; set; }
        public int? StrOldNation { get; set; }
        public int? Cash { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }
    }
}
