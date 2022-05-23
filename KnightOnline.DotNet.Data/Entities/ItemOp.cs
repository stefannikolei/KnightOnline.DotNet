using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("ITEM_OP")]
    public partial class ItemOp
    {
        [Column("nItemID")]
        public int NItemId { get; set; }
        [Column("bTriggerType")]
        public byte BTriggerType { get; set; }
        [Column("nSkillID")]
        public int NSkillId { get; set; }
        [Column("bTriggerRate")]
        public byte BTriggerRate { get; set; }
    }
}
