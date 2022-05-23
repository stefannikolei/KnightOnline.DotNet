using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MONSTER_CHALLENGE")]
    public partial class MonsterChallenge
    {
        [Column("sIndex")]
        public short SIndex { get; set; }
        [Column("bStartTime1")]
        public byte BStartTime1 { get; set; }
        [Column("bStartTime2")]
        public byte BStartTime2 { get; set; }
        [Column("bStartTime3")]
        public byte BStartTime3 { get; set; }
        [Column("bLevelMin")]
        public byte BLevelMin { get; set; }
        [Column("bLevelMax")]
        public byte BLevelMax { get; set; }
    }
}
