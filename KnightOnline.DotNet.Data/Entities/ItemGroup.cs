using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("ITEM_GROUP")]
    public partial class ItemGroup
    {
        [Column("group")]
        public short Group { get; set; }
        [Column("name")]
        [StringLength(30)]
        [Unicode(false)]
        public string? Name { get; set; }
        [Column("item1")]
        public int Item1 { get; set; }
        [Column("item2")]
        public int Item2 { get; set; }
        [Column("item3")]
        public int Item3 { get; set; }
        [Column("item4")]
        public int Item4 { get; set; }
        [Column("item5")]
        public int Item5 { get; set; }
        [Column("item6")]
        public int Item6 { get; set; }
        [Column("item7")]
        public int Item7 { get; set; }
        [Column("item8")]
        public int Item8 { get; set; }
        [Column("item9")]
        public int Item9 { get; set; }
        [Column("item10")]
        public int Item10 { get; set; }
        [Column("item11")]
        public int Item11 { get; set; }
        [Column("item12")]
        public int Item12 { get; set; }
        [Column("item13")]
        public int Item13 { get; set; }
        [Column("item14")]
        public int Item14 { get; set; }
        [Column("item15")]
        public int Item15 { get; set; }
        [Column("item16")]
        public int Item16 { get; set; }
        [Column("item17")]
        public int Item17 { get; set; }
        [Column("item18")]
        public int Item18 { get; set; }
        [Column("item19")]
        public int Item19 { get; set; }
        [Column("item20")]
        public int Item20 { get; set; }
        [Column("item21")]
        public int Item21 { get; set; }
        [Column("item22")]
        public int Item22 { get; set; }
        [Column("item23")]
        public int Item23 { get; set; }
        [Column("item24")]
        public int Item24 { get; set; }
        [Column("item25")]
        public int Item25 { get; set; }
        [Column("item26")]
        public int Item26 { get; set; }
        [Column("item27")]
        public int Item27 { get; set; }
        [Column("item28")]
        public int Item28 { get; set; }
        [Column("item29")]
        public int Item29 { get; set; }
        [Column("item30")]
        public int Item30 { get; set; }
    }
}
