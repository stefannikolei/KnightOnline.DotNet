using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAKE_DEFENSIVE")]
    public partial class MakeDefensive
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
    }
}
