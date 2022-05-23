using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("QUEST_MENU")]
    public partial class QuestMenu
    {
        [Column("iNum")]
        public int INum { get; set; }
        [Column("strMenu")]
        [StringLength(100)]
        [Unicode(false)]
        public string StrMenu { get; set; } = null!;
    }
}
