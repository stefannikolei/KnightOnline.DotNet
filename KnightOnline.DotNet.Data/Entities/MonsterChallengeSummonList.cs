using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MONSTER_CHALLENGE_SUMMON_LIST")]
    public partial class MonsterChallengeSummonList
    {
        [Column("sIndex")]
        public short SIndex { get; set; }
        [Column("bLevel")]
        public byte BLevel { get; set; }
        [Column("bStage")]
        public byte BStage { get; set; }
        [Column("bStageLevel")]
        public byte BStageLevel { get; set; }
        [Column("sTime")]
        public short STime { get; set; }
        [Column("sSid")]
        public short SSid { get; set; }
        [Column("strName")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StrName { get; set; }
        [Column("sCount")]
        public short SCount { get; set; }
        [Column("sPosX")]
        public short SPosX { get; set; }
        [Column("sPosZ")]
        public short SPosZ { get; set; }
        [Column("bRange")]
        public byte BRange { get; set; }
    }
}
