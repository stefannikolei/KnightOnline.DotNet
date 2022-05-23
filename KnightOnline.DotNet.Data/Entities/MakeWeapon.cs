using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAKE_WEAPON")]
    public partial class MakeWeapon
    {
        [Column("byLevel")]
        public byte ByLevel { get; set; }
        [Column("sClass_1")]
        public short? SClass1 { get; set; }
        [Column("sClass_2")]
        public short? SClass2 { get; set; }
        [Column("sClass_3")]
        public short? SClass3 { get; set; }
        [Column("sClass_4")]
        public short? SClass4 { get; set; }
        [Column("sClass_5")]
        public short? SClass5 { get; set; }
        [Column("sClass_6")]
        public short? SClass6 { get; set; }
        [Column("sClass_7")]
        public short? SClass7 { get; set; }
        [Column("sClass_8")]
        public short? SClass8 { get; set; }
        [Column("sClass_9")]
        public short? SClass9 { get; set; }
        [Column("sClass_10")]
        public short? SClass10 { get; set; }
        [Column("sClass_11")]
        public short? SClass11 { get; set; }
        [Column("sClass_12")]
        public short? SClass12 { get; set; }
    }
}
