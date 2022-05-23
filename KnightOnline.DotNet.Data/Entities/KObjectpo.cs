using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("K_OBJECTPOS")]
    public partial class KObjectpo
    {
        [Column("ZoneID")]
        public short ZoneId { get; set; }
        public byte Belong { get; set; }
        [Column("sIndex")]
        public short SIndex { get; set; }
        public byte Type { get; set; }
        [Column("ControlNpcID")]
        public short ControlNpcId { get; set; }
        public byte Status { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double PosZ { get; set; }
        [Column("byLife")]
        public byte ByLife { get; set; }
    }
}
