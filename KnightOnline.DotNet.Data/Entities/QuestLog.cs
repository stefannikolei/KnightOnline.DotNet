using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("QUEST_LOG")]
    public partial class QuestLog
    {
        [Column("sQuestNum")]
        public short SQuestNum { get; set; }
        [Column("nCount")]
        public int NCount { get; set; }
    }
}
