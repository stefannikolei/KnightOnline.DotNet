using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("EnesKCBSNotice")]
    public partial class EnesKcbsnotice
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("AccountID")]
        [StringLength(75)]
        [Unicode(false)]
        public string? AccountId { get; set; }
        [Column("StrUserID")]
        [StringLength(75)]
        [Unicode(false)]
        public string? StrUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GirisZamani { get; set; }
        public int? Durum { get; set; }
    }
}
