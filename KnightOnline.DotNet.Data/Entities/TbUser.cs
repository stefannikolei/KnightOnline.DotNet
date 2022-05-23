using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("TB_USER")]
    public partial class TbUser
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("strAccountID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrAccountId { get; set; } = null!;
        [Column("strPasswd")]
        [StringLength(28)]
        [Unicode(false)]
        public string? StrPasswd { get; set; }
        [Column("strSealPasswd")]
        [StringLength(8)]
        [Unicode(false)]
        public string StrSealPasswd { get; set; } = null!;
        [Column("strClientIP")]
        [StringLength(15)]
        [Unicode(false)]
        public string? StrClientIp { get; set; }
        [Column("bPremiumType")]
        public byte BPremiumType { get; set; }
        [Column("dtPremiumTime", TypeName = "datetime")]
        public DateTime? DtPremiumTime { get; set; }
        [Column("sHours")]
        public short SHours { get; set; }
        [Column("dtCreateTime", TypeName = "datetime")]
        public DateTime? DtCreateTime { get; set; }
        [Column("cashpoint")]
        public int? Cashpoint { get; set; }
        [Column("pusadmin")]
        public int? Pusadmin { get; set; }
        [Column("sepet")]
        [StringLength(1000)]
        [Unicode(false)]
        public string? Sepet { get; set; }
        public int? StrSoru { get; set; }
        [Column("strCevap")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StrCevap { get; set; }
        [Column("strAd")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StrAd { get; set; }
        [Column("strSoyad")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StrSoyad { get; set; }
    }
}
