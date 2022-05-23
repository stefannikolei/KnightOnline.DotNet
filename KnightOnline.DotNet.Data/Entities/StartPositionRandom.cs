using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("START_POSITION_RANDOM")]
    public partial class StartPositionRandom
    {
        [Column("ZoneID")]
        public byte? ZoneId { get; set; }
        public short? PosX { get; set; }
        public short? PosZ { get; set; }
        public byte? Radius { get; set; }
    }
}
