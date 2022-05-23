using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("K_NPC")]
    public partial class KNpc
    {
        [Column("sSid")]
        public short SSid { get; set; }
        [Column("strName")]
        [StringLength(30)]
        [Unicode(false)]
        public string? StrName { get; set; }
        [Column("sPid")]
        public short SPid { get; set; }
        [Column("sSize")]
        public short SSize { get; set; }
        [Column("iWeapon1")]
        public int IWeapon1 { get; set; }
        [Column("iWeapon2")]
        public int IWeapon2 { get; set; }
        [Column("byGroup")]
        public byte ByGroup { get; set; }
        [Column("byActType")]
        public byte ByActType { get; set; }
        [Column("byType")]
        public byte ByType { get; set; }
        [Column("byFamily")]
        public byte ByFamily { get; set; }
        [Column("byRank")]
        public byte ByRank { get; set; }
        [Column("byTitle")]
        public byte ByTitle { get; set; }
        [Column("iSellingGroup")]
        public int ISellingGroup { get; set; }
        [Column("sLevel")]
        public short SLevel { get; set; }
        [Column("iExp")]
        public int IExp { get; set; }
        [Column("iLoyalty")]
        public int ILoyalty { get; set; }
        [Column("iHpPoint")]
        public int IHpPoint { get; set; }
        [Column("sMpPoint")]
        public short SMpPoint { get; set; }
        [Column("sAtk")]
        public short SAtk { get; set; }
        [Column("sAc")]
        public short SAc { get; set; }
        [Column("sHitRate")]
        public short SHitRate { get; set; }
        [Column("sEvadeRate")]
        public short SEvadeRate { get; set; }
        [Column("sDamage")]
        public short SDamage { get; set; }
        [Column("sAttackDelay")]
        public short SAttackDelay { get; set; }
        [Column("bySpeed1")]
        public byte BySpeed1 { get; set; }
        [Column("bySpeed2")]
        public byte BySpeed2 { get; set; }
        [Column("sStandtime")]
        public short SStandtime { get; set; }
        [Column("iMagic1")]
        public int IMagic1 { get; set; }
        [Column("iMagic2")]
        public int IMagic2 { get; set; }
        [Column("iMagic3")]
        public int IMagic3 { get; set; }
        [Column("sFireR")]
        public short SFireR { get; set; }
        [Column("sColdR")]
        public short SColdR { get; set; }
        [Column("sLightningR")]
        public short SLightningR { get; set; }
        [Column("sMagicR")]
        public short SMagicR { get; set; }
        [Column("sDiseaseR")]
        public short SDiseaseR { get; set; }
        [Column("sPoisonR")]
        public short SPoisonR { get; set; }
        [Column("sLightR")]
        public short SLightR { get; set; }
        [Column("sBulk")]
        public short SBulk { get; set; }
        [Column("byAttackRange")]
        public byte ByAttackRange { get; set; }
        [Column("bySearchRange")]
        public byte BySearchRange { get; set; }
        [Column("byTracingRange")]
        public byte ByTracingRange { get; set; }
        [Column("iMoney")]
        public int IMoney { get; set; }
        [Column("sItem")]
        public short SItem { get; set; }
        [Column("byDirectAttack")]
        public byte ByDirectAttack { get; set; }
        [Column("byMagicAttack")]
        public byte ByMagicAttack { get; set; }
        [Column("byMoneyType")]
        public byte ByMoneyType { get; set; }
    }
}
