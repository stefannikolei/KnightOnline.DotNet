using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MONSTER_RESPAWN_LIST")]
    public partial class MonsterRespawnList
    {
        [Column("sIndex")]
        public short SIndex { get; set; }
        [Column("sSid")]
        public short SSid { get; set; }
        [Column("sCount")]
        public short SCount { get; set; }
    }
}
