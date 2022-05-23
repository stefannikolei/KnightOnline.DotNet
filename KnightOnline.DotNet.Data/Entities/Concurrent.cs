using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("CONCURRENT")]
    public partial class Concurrent
    {
        [Column("serverid")]
        public byte Serverid { get; set; }
        [Column("zone1_count")]
        public short Zone1Count { get; set; }
        [Column("zone2_count")]
        public short Zone2Count { get; set; }
        [Column("zone3_count")]
        public short Zone3Count { get; set; }
    }
}
