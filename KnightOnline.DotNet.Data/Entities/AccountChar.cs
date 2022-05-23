using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("ACCOUNT_CHAR")]
    public partial class AccountChar
    {
        [Column("strAccountID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrAccountId { get; set; } = null!;
        [Column("bNation")]
        public byte BNation { get; set; }
        [Column("bCharNum")]
        public byte BCharNum { get; set; }
        [Column("strCharID1")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrCharId1 { get; set; }
        [Column("strCharID2")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrCharId2 { get; set; }
        [Column("strCharID3")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrCharId3 { get; set; }
    }
}
