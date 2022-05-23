using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("K_WARPINFO")]
    public partial class KWarpinfo
    {
        [Column("sWarpID")]
        public short SWarpId { get; set; }
        [Column("strWarpName")]
        [StringLength(32)]
        [Unicode(false)]
        public string? StrWarpName { get; set; }
        [Column("strAnnounce")]
        [StringLength(256)]
        [Unicode(false)]
        public string? StrAnnounce { get; set; }
    }
}
