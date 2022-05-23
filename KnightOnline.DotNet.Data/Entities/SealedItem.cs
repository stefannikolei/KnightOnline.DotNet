using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Table("SEALED_ITEMS")]
    public partial class SealedItem
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("strAccountID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrAccountId { get; set; } = null!;
        [Column("strUserID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrUserId { get; set; } = null!;
        [Column("nItemSerial")]
        public long NItemSerial { get; set; }
        [Column("nItemID")]
        public int NItemId { get; set; }
        [Column("bSealType")]
        public byte BSealType { get; set; }
    }
}
