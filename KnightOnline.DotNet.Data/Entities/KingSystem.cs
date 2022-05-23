using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("KING_SYSTEM")]
    public partial class KingSystem
    {
        [Column("byNation")]
        public byte ByNation { get; set; }
        [Column("byType")]
        public byte ByType { get; set; }
        [Column("sYear")]
        public short SYear { get; set; }
        [Column("byMonth")]
        public byte ByMonth { get; set; }
        [Column("byDay")]
        public byte ByDay { get; set; }
        [Column("byHour")]
        public byte ByHour { get; set; }
        [Column("byMinute")]
        public byte ByMinute { get; set; }
        [Column("byImType")]
        public byte ByImType { get; set; }
        [Column("sImYear")]
        public short SImYear { get; set; }
        [Column("byImMonth")]
        public byte ByImMonth { get; set; }
        [Column("byImDay")]
        public byte ByImDay { get; set; }
        [Column("byImHour")]
        public byte ByImHour { get; set; }
        [Column("byImMinute")]
        public byte ByImMinute { get; set; }
        [Column("byNoahEvent")]
        public byte ByNoahEvent { get; set; }
        [Column("byNoahEvent_Day")]
        public byte ByNoahEventDay { get; set; }
        [Column("byNoahEvent_Hour")]
        public byte ByNoahEventHour { get; set; }
        [Column("byNoahEvent_Minute")]
        public byte ByNoahEventMinute { get; set; }
        [Column("sNoahEvent_Duration")]
        public short SNoahEventDuration { get; set; }
        [Column("byExpEvent")]
        public byte ByExpEvent { get; set; }
        [Column("byExpEvent_Day")]
        public byte ByExpEventDay { get; set; }
        [Column("byExpEvent_Hour")]
        public byte ByExpEventHour { get; set; }
        [Column("byExpEvent_Minute")]
        public byte ByExpEventMinute { get; set; }
        [Column("sExpEvent_Duration")]
        public short SExpEventDuration { get; set; }
        [Column("nTribute")]
        public int NTribute { get; set; }
        [Column("byTerritoryTariff")]
        public byte ByTerritoryTariff { get; set; }
        [Column("nTerritoryTax")]
        public int NTerritoryTax { get; set; }
        [Column("nNationalTreasury")]
        public int NNationalTreasury { get; set; }
        [Column("strKingName")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrKingName { get; set; }
        [Column("strImRequestID")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrImRequestId { get; set; }
    }
}
