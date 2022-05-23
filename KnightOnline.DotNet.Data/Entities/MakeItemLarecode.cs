using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAKE_ITEM_LARECODE")]
    public partial class MakeItemLarecode
    {
        [Column("byLevelGrade")]
        public byte ByLevelGrade { get; set; }
        [Column("sUpgradeItem")]
        public short SUpgradeItem { get; set; }
        [Column("sLareItem")]
        public short SLareItem { get; set; }
        [Column("sMagicItem")]
        public short SMagicItem { get; set; }
        [Column("sGereralItem")]
        public short SGereralItem { get; set; }
    }
}
