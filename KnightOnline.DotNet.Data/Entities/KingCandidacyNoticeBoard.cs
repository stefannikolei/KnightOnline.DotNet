using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("KING_CANDIDACY_NOTICE_BOARD")]
    public partial class KingCandidacyNoticeBoard
    {
        [Column("strUserID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrUserId { get; set; } = null!;
        [Column("byNation")]
        public byte ByNation { get; set; }
        [Column("sNoticeLen")]
        public short SNoticeLen { get; set; }
        [Column("strNotice")]
        [MaxLength(1024)]
        public byte[] StrNotice { get; set; } = null!;
    }
}
