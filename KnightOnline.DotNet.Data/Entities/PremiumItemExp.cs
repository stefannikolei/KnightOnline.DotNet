using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("PREMIUM_ITEM_EXP")]
    public partial class PremiumItemExp
    {
        [Column("nIndex")]
        public short NIndex { get; set; }
        public byte Type { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        [Column("sPercent")]
        public short SPercent { get; set; }
    }
}
