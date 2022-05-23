using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("LEVEL_UP")]
    public partial class LevelUp
    {
        [Column("level")]
        public byte Level { get; set; }
        public long? Exp { get; set; }
    }
}
