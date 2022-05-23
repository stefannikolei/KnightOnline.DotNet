using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Table("USER_RENTAL_ITEM")]
    public partial class UserRentalItem
    {
        [Key]
        [Column("strUserID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrUserId { get; set; } = null!;
        [Column("strAccountID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrAccountId { get; set; }
        [Column("byRentalType")]
        public byte? ByRentalType { get; set; }
        [Column("byRegType")]
        public byte? ByRegType { get; set; }
        [Column("nRentalIndex")]
        public int? NRentalIndex { get; set; }
        [Column("nItemIndex")]
        public int? NItemIndex { get; set; }
        [Column("sDurability")]
        public short? SDurability { get; set; }
        [Column("nSerialNumber")]
        public long? NSerialNumber { get; set; }
        [Column("nRentalMoney")]
        public int? NRentalMoney { get; set; }
        [Column("sRentalTime")]
        public short? SRentalTime { get; set; }
        [Column("sDuringTime")]
        public short? SDuringTime { get; set; }
        [Column("timeRental", TypeName = "smalldatetime")]
        public DateTime? TimeRental { get; set; }
        [Column("timeRegister", TypeName = "smalldatetime")]
        public DateTime? TimeRegister { get; set; }
    }
}
