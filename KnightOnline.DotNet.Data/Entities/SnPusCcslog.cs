using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("_SN_PUS_CCSLOG")]
    public partial class SnPusCcslog
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("StrAccountID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrAccountId { get; set; }
        [StringLength(21)]
        [Unicode(false)]
        public string? StrCharName { get; set; }
        public int? OldClass { get; set; }
        public int? NewClass { get; set; }
        public int? Cash { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }
    }
}
