using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("HOME")]
    public partial class Home
    {
        public byte Nation { get; set; }
        public int ElmoZoneX { get; set; }
        public int ElmoZoneZ { get; set; }
        [Column("ElmoZoneLX")]
        public byte ElmoZoneLx { get; set; }
        [Column("ElmoZoneLZ")]
        public byte ElmoZoneLz { get; set; }
        public int KarusZoneX { get; set; }
        public int KarusZoneZ { get; set; }
        [Column("KarusZoneLX")]
        public byte KarusZoneLx { get; set; }
        [Column("KarusZoneLZ")]
        public byte KarusZoneLz { get; set; }
        public int FreeZoneX { get; set; }
        public int FreeZoneZ { get; set; }
        [Column("FreeZoneLX")]
        public byte FreeZoneLx { get; set; }
        [Column("FreeZoneLZ")]
        public byte FreeZoneLz { get; set; }
        public int BattleZoneX { get; set; }
        public int BattleZoneZ { get; set; }
        [Column("BattleZoneLX")]
        public byte BattleZoneLx { get; set; }
        [Column("BattleZoneLZ")]
        public byte BattleZoneLz { get; set; }
        public int BattleZone2X { get; set; }
        public int BattleZone2Z { get; set; }
        [Column("BattleZone2LX")]
        public byte BattleZone2Lx { get; set; }
        [Column("BattleZone2LZ")]
        public byte BattleZone2Lz { get; set; }
        public int BattleZone3X { get; set; }
        public int BattleZone3Z { get; set; }
        [Column("BattleZone3LX")]
        public byte BattleZone3Lx { get; set; }
        [Column("BattleZone3LZ")]
        public byte BattleZone3Lz { get; set; }
        public int BattleZone4X { get; set; }
        public int BattleZone4Z { get; set; }
        [Column("BattleZone4LX")]
        public byte BattleZone4Lx { get; set; }
        [Column("BattleZone4LZ")]
        public byte BattleZone4Lz { get; set; }
        public int BattleZone5X { get; set; }
        public int BattleZone5Z { get; set; }
        [Column("BattleZone5LX")]
        public byte BattleZone5Lx { get; set; }
        [Column("BattleZone5LZ")]
        public byte BattleZone5Lz { get; set; }
        public int BattleZone6X { get; set; }
        public int BattleZone6Z { get; set; }
        [Column("BattleZone6LX")]
        public byte BattleZone6Lx { get; set; }
        [Column("BattleZone6LZ")]
        public byte BattleZone6Lz { get; set; }
    }
}
