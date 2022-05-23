using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("ZONE_INFO")]
    public partial class ZoneInfo
    {
        public byte ServerNo { get; set; }
        public short ZoneNo { get; set; }
        [Column("strZoneName")]
        [StringLength(50)]
        [Unicode(false)]
        public string StrZoneName { get; set; } = null!;
        public int InitX { get; set; }
        public int InitZ { get; set; }
        public int InitY { get; set; }
        public byte Type { get; set; }
        public byte RoomEvent { get; set; }
        [Column("bz")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Bz { get; set; }
    }
}
