using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("QUEST_TALK")]
    public partial class QuestTalk
    {
        [Column("iNum")]
        public int INum { get; set; }
        [Column("strTalk")]
        [StringLength(1000)]
        [Unicode(false)]
        public string StrTalk { get; set; } = null!;
    }
}
