using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("SET_ITEM")]
    public partial class SetItem
    {
        public int SetIndex { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? SetName { get; set; }
        [Column("ACBonus")]
        public short Acbonus { get; set; }
        [Column("HPBonus")]
        public short Hpbonus { get; set; }
        [Column("MPBonus")]
        public short Mpbonus { get; set; }
        public short StrengthBonus { get; set; }
        public short StaminaBonus { get; set; }
        public short DexterityBonus { get; set; }
        public short IntelBonus { get; set; }
        public short CharismaBonus { get; set; }
        public short FlameResistance { get; set; }
        public short GlacierResistance { get; set; }
        public short LightningResistance { get; set; }
        public short PoisonResistance { get; set; }
        public short MagicResistance { get; set; }
        public short CurseResistance { get; set; }
        [Column("XPBonusPercent")]
        public short XpbonusPercent { get; set; }
        public short CoinBonusPercent { get; set; }
        [Column("APBonusPercent")]
        public short ApbonusPercent { get; set; }
        [Column("APBonusClassType")]
        public short ApbonusClassType { get; set; }
        [Column("APBonusClassPercent")]
        public short ApbonusClassPercent { get; set; }
        [Column("ACBonusClassType")]
        public short AcbonusClassType { get; set; }
        [Column("ACBonusClassPercent")]
        public short AcbonusClassPercent { get; set; }
        public short MaxWeightBonus { get; set; }
        [Column("NPBonus")]
        public byte Npbonus { get; set; }
        public byte Unk10 { get; set; }
        public byte Unk11 { get; set; }
        public byte Unk12 { get; set; }
        public byte Unk13 { get; set; }
        public byte Unk14 { get; set; }
        public byte Unk15 { get; set; }
        public byte Unk16 { get; set; }
        public byte Unk17 { get; set; }
        public byte Unk18 { get; set; }
        public byte Unk19 { get; set; }
        public byte Unk20 { get; set; }
        public byte Unk21 { get; set; }
    }
}
