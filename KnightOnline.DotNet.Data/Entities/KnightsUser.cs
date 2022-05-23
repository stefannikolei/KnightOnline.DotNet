using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("KNIGHTS_USER")]
    public partial class KnightsUser
    {
        [Column("sIDNum")]
        public short SIdnum { get; set; }
        [Column("strUserID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrUserId { get; set; } = null!;
        [Column("nDonatedNP")]
        public int NDonatedNp { get; set; }
    }
}
