using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MONSTER_RESPAWN_LIST_INFORMATION")]
    public partial class MonsterRespawnListInformation
    {
        [Column("sIndex")]
        public short? SIndex { get; set; }
        [Column("sSid")]
        public short? SSid { get; set; }
        [Column("ZoneID")]
        public byte? ZoneId { get; set; }
        [Column("bType")]
        public byte? BType { get; set; }
        public short? X { get; set; }
        public short? Y { get; set; }
        public short? Z { get; set; }
        [Column("sCount")]
        public short? SCount { get; set; }
        [Column("bRadius")]
        public byte? BRadius { get; set; }
    }
}
