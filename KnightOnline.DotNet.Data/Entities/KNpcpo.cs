using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("K_NPCPOS")]
    public partial class KNpcpo
    {
        [Column("ZoneID")]
        public short ZoneId { get; set; }
        [Column("NpcID")]
        public int NpcId { get; set; }
        public byte ActType { get; set; }
        public byte RegenType { get; set; }
        public byte DungeonFamily { get; set; }
        public byte SpecialType { get; set; }
        public byte TrapNumber { get; set; }
        public int LeftX { get; set; }
        public int TopZ { get; set; }
        public int RightX { get; set; }
        public int BottomZ { get; set; }
        public int LimitMinX { get; set; }
        public int LimitMinZ { get; set; }
        public int LimitMaxX { get; set; }
        public int LimitMaxZ { get; set; }
        [Column("NumNPC")]
        public byte NumNpc { get; set; }
        public short RegTime { get; set; }
        [Column("byDirection")]
        public byte ByDirection { get; set; }
        public byte DotCnt { get; set; }
        [Column("path", TypeName = "text")]
        public string? Path { get; set; }
    }
}
