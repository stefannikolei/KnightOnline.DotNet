using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("WEB_ITEMMALL_LOG")]
    public partial class WebItemmallLog
    {
        [Column("strAccountID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrAccountId { get; set; } = null!;
        [Column("strCharID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrCharId { get; set; } = null!;
        public short ServerNo { get; set; }
        [Column("ItemID")]
        public int ItemId { get; set; }
        public short ItemCount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime BuyTime { get; set; }
        [Column("img_file_name")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ImgFileName { get; set; }
        [Column("strItemName")]
        [StringLength(100)]
        [Unicode(false)]
        public string? StrItemName { get; set; }
        [Column("price")]
        public int? Price { get; set; }
        [Column("pay_type")]
        public int? PayType { get; set; }
    }
}
