using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("START_POSITION")]
    public partial class StartPosition
    {
        [Column("ZoneID")]
        public short ZoneId { get; set; }
        [Column("sKarusX")]
        public short SKarusX { get; set; }
        [Column("sKarusZ")]
        public short SKarusZ { get; set; }
        [Column("sElmoradX")]
        public short SElmoradX { get; set; }
        [Column("sElmoradZ")]
        public short SElmoradZ { get; set; }
        [Column("sKarusGateX")]
        public short? SKarusGateX { get; set; }
        [Column("sKarusGateZ")]
        public short? SKarusGateZ { get; set; }
        [Column("sElmoGateX")]
        public short? SElmoGateX { get; set; }
        [Column("sElmoGateZ")]
        public short? SElmoGateZ { get; set; }
        [Column("bRangeX")]
        public byte BRangeX { get; set; }
        [Column("bRangeZ")]
        public byte BRangeZ { get; set; }
    }
}
