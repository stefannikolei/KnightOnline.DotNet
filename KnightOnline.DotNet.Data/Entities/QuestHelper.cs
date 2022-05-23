using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("QUEST_HELPER")]
    public partial class QuestHelper
    {
        [Column("nIndex")]
        public int NIndex { get; set; }
        [Column("bMessageType")]
        public byte BMessageType { get; set; }
        [Column("bLevel")]
        public byte BLevel { get; set; }
        [Column("nExp")]
        public int NExp { get; set; }
        [Column("bClass")]
        public byte BClass { get; set; }
        [Column("bNation")]
        public byte BNation { get; set; }
        [Column("bQuestType")]
        public byte BQuestType { get; set; }
        [Column("bZone")]
        public byte BZone { get; set; }
        [Column("sNpcId")]
        public short SNpcId { get; set; }
        [Column("sEventDataIndex")]
        public short SEventDataIndex { get; set; }
        [Column("bEventStatus")]
        public byte BEventStatus { get; set; }
        [Column("nEventTriggerIndex")]
        public int NEventTriggerIndex { get; set; }
        [Column("nEventCompleteIndex")]
        public int NEventCompleteIndex { get; set; }
        [Column("nExchangeIndex")]
        public int NExchangeIndex { get; set; }
        [Column("nEventTalkIndex")]
        public int NEventTalkIndex { get; set; }
        [Column("strLuaFilename")]
        [StringLength(40)]
        [Unicode(false)]
        public string StrLuaFilename { get; set; } = null!;
    }
}
