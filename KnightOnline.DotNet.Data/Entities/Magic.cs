using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAGIC")]
    public partial class Magic
    {
        public int MagicNum { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? EnName { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? KrName { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string? Description { get; set; }
        public int BeforeAction { get; set; }
        public byte TargetAction { get; set; }
        public int SelfEffect { get; set; }
        public short FlyingEffect { get; set; }
        public short TargetEffect { get; set; }
        public byte Moral { get; set; }
        public short SkillLevel { get; set; }
        public short Skill { get; set; }
        public short Msp { get; set; }
        [Column("HP")]
        public short Hp { get; set; }
        public byte ItemGroup { get; set; }
        public int UseItem { get; set; }
        public short CastTime { get; set; }
        public short ReCastTime { get; set; }
        public short SuccessRate { get; set; }
        public byte Type1 { get; set; }
        public byte Type2 { get; set; }
        public short Range { get; set; }
        public short Etc { get; set; }
        public byte? UseStanding { get; set; }
    }
}
