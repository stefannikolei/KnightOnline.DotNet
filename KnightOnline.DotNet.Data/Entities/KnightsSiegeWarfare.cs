using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Table("KNIGHTS_SIEGE_WARFARE")]
    public partial class KnightsSiegeWarfare
    {
        [Key]
        [Column("sCastleIndex")]
        public short SCastleIndex { get; set; }
        [Column("sMasterKnights")]
        public short SMasterKnights { get; set; }
        [Column("bySiegeType")]
        public byte BySiegeType { get; set; }
        [Column("byWarDay")]
        public byte ByWarDay { get; set; }
        [Column("byWarTime")]
        public byte ByWarTime { get; set; }
        [Column("byWarMinute")]
        public byte ByWarMinute { get; set; }
        [Column("sChallengeList_1")]
        public short SChallengeList1 { get; set; }
        [Column("sChallengeList_2")]
        public short SChallengeList2 { get; set; }
        [Column("sChallengeList_3")]
        public short SChallengeList3 { get; set; }
        [Column("sChallengeList_4")]
        public short SChallengeList4 { get; set; }
        [Column("sChallengeList_5")]
        public short SChallengeList5 { get; set; }
        [Column("sChallengeList_6")]
        public short SChallengeList6 { get; set; }
        [Column("sChallengeList_7")]
        public short SChallengeList7 { get; set; }
        [Column("sChallengeList_8")]
        public short SChallengeList8 { get; set; }
        [Column("sChallengeList_9")]
        public short SChallengeList9 { get; set; }
        [Column("sChallengeList_10")]
        public short SChallengeList10 { get; set; }
        [Column("byWarRequestDay")]
        public byte ByWarRequestDay { get; set; }
        [Column("byWarRequestTime")]
        public byte ByWarRequestTime { get; set; }
        [Column("byWarRequestMinute")]
        public byte ByWarRequestMinute { get; set; }
        [Column("byGuerrillaWarDay")]
        public byte ByGuerrillaWarDay { get; set; }
        [Column("byGuerrillaWarTime")]
        public byte ByGuerrillaWarTime { get; set; }
        [Column("byGuerrillaWarMinute")]
        public byte ByGuerrillaWarMinute { get; set; }
        [Column("strChallengeList")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StrChallengeList { get; set; }
        [Column("sMoradonTariff")]
        public short SMoradonTariff { get; set; }
        [Column("sDellosTariff")]
        public short SDellosTariff { get; set; }
        [Column("nDungeonCharge")]
        public int NDungeonCharge { get; set; }
        [Column("nMoradonTax")]
        public int NMoradonTax { get; set; }
        [Column("nDellosTax")]
        public int NDellosTax { get; set; }
        [Column("sRequestList_1")]
        public short SRequestList1 { get; set; }
        [Column("sRequestList_2")]
        public short SRequestList2 { get; set; }
        [Column("sRequestList_3")]
        public short SRequestList3 { get; set; }
        [Column("sRequestList_4")]
        public short SRequestList4 { get; set; }
        [Column("sRequestList_5")]
        public short SRequestList5 { get; set; }
        [Column("sRequestList_6")]
        public short SRequestList6 { get; set; }
        [Column("sRequestList_7")]
        public short SRequestList7 { get; set; }
        [Column("sRequestList_8")]
        public short SRequestList8 { get; set; }
        [Column("sRequestList_9")]
        public short SRequestList9 { get; set; }
        [Column("sRequestList_10")]
        public short SRequestList10 { get; set; }
    }
}
