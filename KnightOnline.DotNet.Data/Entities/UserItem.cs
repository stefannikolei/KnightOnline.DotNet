using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("USER_ITEMS")]
    public partial class UserItem
    {
        [Column("nItemID")]
        public int? NItemId { get; set; }
        [Column("nItemSerial")]
        [StringLength(586)]
        public string? NItemSerial { get; set; }
    }
}
