using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("BATTLE")]
    public partial class Battle
    {
        [Column("sIndex")]
        public short SIndex { get; set; }
        [Column("byNation")]
        public byte ByNation { get; set; }
        [Column("strUserName")]
        [StringLength(30)]
        [Unicode(false)]
        public string? StrUserName { get; set; }
    }
}
