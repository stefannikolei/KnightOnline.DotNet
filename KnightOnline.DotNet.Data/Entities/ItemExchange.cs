using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("ITEM_EXCHANGE")]
    public partial class ItemExchange
    {
        [Column("nIndex")]
        public int NIndex { get; set; }
        [Column("nNpcNum")]
        public short NNpcNum { get; set; }
        [Column("strNpcName")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StrNpcName { get; set; }
        [Column("strNote")]
        [StringLength(100)]
        [Unicode(false)]
        public string? StrNote { get; set; }
        [Column("bRandomFlag")]
        public byte BRandomFlag { get; set; }
        [Column("nOriginItemNum1")]
        public int NOriginItemNum1 { get; set; }
        [Column("nOriginItemCount1")]
        public int NOriginItemCount1 { get; set; }
        [Column("nOriginItemNum2")]
        public int NOriginItemNum2 { get; set; }
        [Column("nOriginItemCount2")]
        public int NOriginItemCount2 { get; set; }
        [Column("nOriginItemNum3")]
        public int NOriginItemNum3 { get; set; }
        [Column("nOriginItemCount3")]
        public int NOriginItemCount3 { get; set; }
        [Column("nOriginItemNum4")]
        public int NOriginItemNum4 { get; set; }
        [Column("nOriginItemCount4")]
        public int NOriginItemCount4 { get; set; }
        [Column("nOriginItemNum5")]
        public int NOriginItemNum5 { get; set; }
        [Column("nOriginItemCount5")]
        public int NOriginItemCount5 { get; set; }
        [Column("nOriginItemNum6")]
        public int NOriginItemNum6 { get; set; }
        [Column("nOriginItemCount6")]
        public int NOriginItemCount6 { get; set; }
        [Column("nOriginItemNum7")]
        public int NOriginItemNum7 { get; set; }
        [Column("nOriginItemCount7")]
        public int NOriginItemCount7 { get; set; }
        [Column("nOriginItemNum8")]
        public int NOriginItemNum8 { get; set; }
        [Column("nOriginItemCount8")]
        public int NOriginItemCount8 { get; set; }
        [Column("nOriginItemNum9")]
        public int NOriginItemNum9 { get; set; }
        [Column("nOriginItemCount9")]
        public int NOriginItemCount9 { get; set; }
        [Column("nOriginItemNum10")]
        public int NOriginItemNum10 { get; set; }
        [Column("nOriginItemCount10")]
        public int NOriginItemCount10 { get; set; }
        [Column("nOriginItemNum11")]
        public int NOriginItemNum11 { get; set; }
        [Column("nOriginItemCount11")]
        public int NOriginItemCount11 { get; set; }
        [Column("nExchangeItemNum1")]
        public int NExchangeItemNum1 { get; set; }
        [Column("nExchangeItemCount1")]
        public int NExchangeItemCount1 { get; set; }
        [Column("nExchangeItemNum2")]
        public int NExchangeItemNum2 { get; set; }
        [Column("nExchangeItemCount2")]
        public int NExchangeItemCount2 { get; set; }
        [Column("nExchangeItemNum3")]
        public int NExchangeItemNum3 { get; set; }
        [Column("nExchangeItemCount3")]
        public int NExchangeItemCount3 { get; set; }
        [Column("nExchangeItemNum4")]
        public int NExchangeItemNum4 { get; set; }
        [Column("nExchangeItemCount4")]
        public int NExchangeItemCount4 { get; set; }
        [Column("nExchangeItemNum5")]
        public int NExchangeItemNum5 { get; set; }
        [Column("nExchangeItemCount5")]
        public int NExchangeItemCount5 { get; set; }
    }
}
