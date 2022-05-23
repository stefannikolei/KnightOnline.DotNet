using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("PREMIUM_ITEM")]
    public partial class PremiumItem
    {
        public byte Type { get; set; }
        public short ExpRestorePercent { get; set; }
        public short NoahPercent { get; set; }
        public short DropPercent { get; set; }
        public int BonusLoyalty { get; set; }
        public short RepairDiscountPercent { get; set; }
        public short ItemSellPercent { get; set; }
    }
}
