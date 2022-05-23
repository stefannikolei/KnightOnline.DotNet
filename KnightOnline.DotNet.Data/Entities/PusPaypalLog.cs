using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("PUS_PAYPAL_LOG")]
    public partial class PusPaypalLog
    {
        [Column("strAccountID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StrAccountId { get; set; }
        [Column("strUserID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StrUserId { get; set; }
        [Column("token")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Token { get; set; }
        [Column("cashID")]
        public int? CashId { get; set; }
        [Column("eskiCash")]
        public int? EskiCash { get; set; }
        [Column("yeniCash")]
        public int? YeniCash { get; set; }
        [Column("tutar")]
        public int? Tutar { get; set; }
    }
}
