using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAKE_ITEM_GROUP")]
    public partial class MakeItemGroup
    {
        [Column("iItemGroupNum")]
        public int IItemGroupNum { get; set; }
        [Column("iItem_1")]
        public int IItem1 { get; set; }
        [Column("iItem_2")]
        public int IItem2 { get; set; }
        [Column("iItem_3")]
        public int IItem3 { get; set; }
        [Column("iItem_4")]
        public int IItem4 { get; set; }
        [Column("iItem_5")]
        public int IItem5 { get; set; }
        [Column("iItem_6")]
        public int IItem6 { get; set; }
        [Column("iItem_7")]
        public int IItem7 { get; set; }
        [Column("iItem_8")]
        public int IItem8 { get; set; }
        [Column("iItem_9")]
        public int IItem9 { get; set; }
        [Column("iItem_10")]
        public int IItem10 { get; set; }
        [Column("iItem_11")]
        public int IItem11 { get; set; }
        [Column("iItem_12")]
        public int IItem12 { get; set; }
        [Column("iItem_13")]
        public int IItem13 { get; set; }
        [Column("iItem_14")]
        public int IItem14 { get; set; }
        [Column("iItem_15")]
        public int IItem15 { get; set; }
        [Column("iItem_16")]
        public int IItem16 { get; set; }
        [Column("iItem_17")]
        public int IItem17 { get; set; }
        [Column("iItem_18")]
        public int IItem18 { get; set; }
        [Column("iItem_19")]
        public int IItem19 { get; set; }
        [Column("iItem_20")]
        public int IItem20 { get; set; }
        [Column("iItem_21")]
        public int IItem21 { get; set; }
        [Column("iItem_22")]
        public int IItem22 { get; set; }
        [Column("iItem_23")]
        public int IItem23 { get; set; }
        [Column("iItem_24")]
        public int IItem24 { get; set; }
        [Column("iItem_25")]
        public int IItem25 { get; set; }
        [Column("iItem_26")]
        public int IItem26 { get; set; }
        [Column("iItem_27")]
        public int IItem27 { get; set; }
        [Column("iItem_28")]
        public int IItem28 { get; set; }
        [Column("iItem_29")]
        public int IItem29 { get; set; }
        [Column("iItem_30")]
        public int IItem30 { get; set; }
    }
}
