using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("COEFFICIENT")]
    public partial class Coefficient
    {
        [Column("sClass")]
        public short SClass { get; set; }
        public double ShortSword { get; set; }
        public double Sword { get; set; }
        public double Axe { get; set; }
        public double Club { get; set; }
        public double Spear { get; set; }
        public double Pole { get; set; }
        public double Staff { get; set; }
        public double? Bow { get; set; }
        public double Hp { get; set; }
        public double Mp { get; set; }
        public double Sp { get; set; }
        public double Ac { get; set; }
        public double Hitrate { get; set; }
        public double Evasionrate { get; set; }
    }
}
