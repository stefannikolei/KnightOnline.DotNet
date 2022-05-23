using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("PUS_ITEMLERI_PAKET")]
    public partial class PusItemleriPaket
    {
        [Column("PID")]
        public int Pid { get; set; }
        [Column("PItem1")]
        public int Pitem1 { get; set; }
        public int Adet1 { get; set; }
        [Column("PItem2")]
        public int Pitem2 { get; set; }
        public int Adet2 { get; set; }
        [Column("PItem3")]
        public int Pitem3 { get; set; }
        public int Adet3 { get; set; }
        [Column("PItem4")]
        public int Pitem4 { get; set; }
        public int Adet4 { get; set; }
        [Column("PItem5")]
        public int Pitem5 { get; set; }
        public int Adet5 { get; set; }
    }
}
