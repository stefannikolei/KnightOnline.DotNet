using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Table("RENTAL_ITEM")]
    public partial class RentalItem
    {
        [Key]
        [Column("nRentalIndex")]
        public int NRentalIndex { get; set; }
        [Column("nItemIndex")]
        public int? NItemIndex { get; set; }
        [Column("sDurability")]
        public short? SDurability { get; set; }
        [Column("nSerialNumber")]
        public long? NSerialNumber { get; set; }
        [Column("byRegType")]
        public byte? ByRegType { get; set; }
        [Column("byItemType")]
        public byte? ByItemType { get; set; }
        [Column("byClass")]
        public byte? ByClass { get; set; }
        [Column("sRentalTime")]
        public short? SRentalTime { get; set; }
        [Column("nRentalMoney")]
        public int? NRentalMoney { get; set; }
        [Column("strLenderCharID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrLenderCharId { get; set; }
        [Column("strLenderAcID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrLenderAcId { get; set; }
        [Column("strBorrowerCharID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrBorrowerCharId { get; set; }
        [Column("strBorrowerAcID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrBorrowerAcId { get; set; }
        [Column("timeLender", TypeName = "smalldatetime")]
        public DateTime? TimeLender { get; set; }
        [Column("timeRegister", TypeName = "smalldatetime")]
        public DateTime TimeRegister { get; set; }
    }
}
