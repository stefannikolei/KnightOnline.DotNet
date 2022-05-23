using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Table("MAIL_BOX")]
    public partial class MailBox
    {
        [Key]
        [Column("nLetterID")]
        public int NLetterId { get; set; }
        [Column("dtSendDate", TypeName = "datetime")]
        public DateTime DtSendDate { get; set; }
        [Column("dtReadDate", TypeName = "datetime")]
        public DateTime? DtReadDate { get; set; }
        [Column("bStatus")]
        public byte BStatus { get; set; }
        [Column("strSenderID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrSenderId { get; set; } = null!;
        [Column("strRecipientID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrRecipientId { get; set; } = null!;
        [Column("strSubject")]
        [StringLength(31)]
        [Unicode(false)]
        public string StrSubject { get; set; } = null!;
        [Column("strMessage")]
        [StringLength(128)]
        [Unicode(false)]
        public string StrMessage { get; set; } = null!;
        [Column("bType")]
        public byte BType { get; set; }
        [Column("nItemID")]
        public int NItemId { get; set; }
        [Column("sCount")]
        public short SCount { get; set; }
        [Column("sDurability")]
        public short SDurability { get; set; }
        [Column("nSerialNum")]
        public long NSerialNum { get; set; }
        [Column("nCoins")]
        public int NCoins { get; set; }
        [Column("bDeleted")]
        public bool BDeleted { get; set; }
    }
}
