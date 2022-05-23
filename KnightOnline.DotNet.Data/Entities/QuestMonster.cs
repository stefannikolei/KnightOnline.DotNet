using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("QUEST_MONSTER")]
    public partial class QuestMonster
    {
        [Column("sQuestNum")]
        public short SQuestNum { get; set; }
        [Column("sNum1a")]
        public short SNum1a { get; set; }
        [Column("sNum1b")]
        public short SNum1b { get; set; }
        [Column("sNum1c")]
        public short SNum1c { get; set; }
        [Column("sNum1d")]
        public short SNum1d { get; set; }
        [Column("sCount1")]
        public short SCount1 { get; set; }
        [Column("sNum2a")]
        public short SNum2a { get; set; }
        [Column("sNum2b")]
        public short SNum2b { get; set; }
        [Column("sNum2c")]
        public short SNum2c { get; set; }
        [Column("sNum2d")]
        public short SNum2d { get; set; }
        [Column("sCount2")]
        public short SCount2 { get; set; }
        [Column("sNum3a")]
        public short SNum3a { get; set; }
        [Column("sNum3b")]
        public short SNum3b { get; set; }
        [Column("sNum3c")]
        public short SNum3c { get; set; }
        [Column("sNum3d")]
        public short SNum3d { get; set; }
        [Column("sCount3")]
        public short SCount3 { get; set; }
        [Column("sNum4a")]
        public short SNum4a { get; set; }
        [Column("sNum4b")]
        public short SNum4b { get; set; }
        [Column("sNum4c")]
        public short SNum4c { get; set; }
        [Column("sNum4d")]
        public short SNum4d { get; set; }
        [Column("sCount4")]
        public short SCount4 { get; set; }
    }
}
