using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MONSTER_SUMMON_LIST_ZONE")]
    public partial class MonsterSummonListZone
    {
        [Column("nIndex")]
        public int NIndex { get; set; }
        [Column("ZoneID")]
        public short ZoneId { get; set; }
        [Column("sSid")]
        public short SSid { get; set; }
        [Column("strName")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StrName { get; set; }
        [Column("byFamily")]
        public byte ByFamily { get; set; }
    }
}
