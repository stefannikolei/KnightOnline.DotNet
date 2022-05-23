using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MONSTER_SUMMON_LIST")]
    public partial class MonsterSummonList
    {
        [Column("sSid")]
        public short SSid { get; set; }
        [Column("strName")]
        [StringLength(30)]
        [Unicode(false)]
        public string? StrName { get; set; }
        [Column("sLevel")]
        public short SLevel { get; set; }
        [Column("sProbability")]
        public short SProbability { get; set; }
        [Column("bType")]
        public byte BType { get; set; }
    }
}
