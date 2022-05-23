using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAKE_ITEM_GRADECODE")]
    public partial class MakeItemGradecode
    {
        [Column("byItemIndex")]
        public byte ByItemIndex { get; set; }
        [Column("byGrade_1")]
        public short ByGrade1 { get; set; }
        [Column("byGrade_2")]
        public short? ByGrade2 { get; set; }
        [Column("byGrade_3")]
        public short? ByGrade3 { get; set; }
        [Column("byGrade_4")]
        public short? ByGrade4 { get; set; }
        [Column("byGrade_5")]
        public short? ByGrade5 { get; set; }
        [Column("byGrade_6")]
        public short? ByGrade6 { get; set; }
        [Column("byGrade_7")]
        public short? ByGrade7 { get; set; }
        [Column("byGrade_8")]
        public short? ByGrade8 { get; set; }
        [Column("byGrade_9")]
        public short? ByGrade9 { get; set; }
    }
}
