using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("WAREHOUSE")]
    public partial class Warehouse
    {
        [Column("strAccountID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrAccountId { get; set; } = null!;
        [Column("nMoney")]
        public int NMoney { get; set; }
        [Column("dwTime")]
        public int DwTime { get; set; }
        [MaxLength(1536)]
        public byte[]? WarehouseData { get; set; }
        [Column("strSerial")]
        [MaxLength(1536)]
        public byte[]? StrSerial { get; set; }
        [MaxLength(1536)]
        public byte[]? WarehouseDataTime { get; set; }
    }
}
