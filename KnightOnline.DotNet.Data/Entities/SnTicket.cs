using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("_SN_TICKET")]
    public partial class SnTicket
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("StrUserID")]
        [StringLength(80)]
        [Unicode(false)]
        public string? StrUserId { get; set; }
        [StringLength(80)]
        [Unicode(false)]
        public string? StrTitle { get; set; }
        [StringLength(1500)]
        [Unicode(false)]
        public string? StrQuestion { get; set; }
        [StringLength(1500)]
        [Unicode(false)]
        public string? StrAnswer { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? StrType { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? StrStatus { get; set; }
    }
}
