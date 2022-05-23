using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("K_MONSTER_ITEM")]
    public partial class KMonsterItem
    {
        [Column("sIndex")]
        public short SIndex { get; set; }
        [Column("iItem01")]
        public int? IItem01 { get; set; }
        [Column("sPersent01")]
        public short? SPersent01 { get; set; }
        [Column("iItem02")]
        public int? IItem02 { get; set; }
        [Column("sPersent02")]
        public short? SPersent02 { get; set; }
        [Column("iItem03")]
        public int? IItem03 { get; set; }
        [Column("sPersent03")]
        public short? SPersent03 { get; set; }
        [Column("iItem04")]
        public int? IItem04 { get; set; }
        [Column("sPersent04")]
        public short? SPersent04 { get; set; }
        [Column("iItem05")]
        public int? IItem05 { get; set; }
        [Column("sPersent05")]
        public short? SPersent05 { get; set; }
    }
}
