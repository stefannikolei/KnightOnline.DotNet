using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("USERDATA")]
    public partial class Userdatum
    {
        [Column("strUserID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrUserId { get; set; } = null!;
        public byte Nation { get; set; }
        public byte Race { get; set; }
        public short Class { get; set; }
        [Column("HairRGB")]
        public int HairRgb { get; set; }
        public byte Rank { get; set; }
        public byte Title { get; set; }
        public byte Level { get; set; }
        public long Exp { get; set; }
        public int Loyalty { get; set; }
        public byte Face { get; set; }
        public byte City { get; set; }
        public short Knights { get; set; }
        public byte Fame { get; set; }
        public short Hp { get; set; }
        public short Mp { get; set; }
        public short Sp { get; set; }
        public byte Strong { get; set; }
        public byte Sta { get; set; }
        public byte Dex { get; set; }
        public byte Intel { get; set; }
        public byte Cha { get; set; }
        public byte Authority { get; set; }
        public short Points { get; set; }
        public int Gold { get; set; }
        public byte Zone { get; set; }
        public short? Bind { get; set; }
        [Column("PX")]
        public int Px { get; set; }
        [Column("PZ")]
        public int Pz { get; set; }
        [Column("PY")]
        public int Py { get; set; }
        [Column("dwTime")]
        public int DwTime { get; set; }
        [Column("strSkill")]
        [StringLength(10)]
        [Unicode(false)]
        public string? StrSkill { get; set; }
        [Column("strItem")]
        [MaxLength(584)]
        public byte[]? StrItem { get; set; }
        [Column("strSerial")]
        [MaxLength(584)]
        public byte[]? StrSerial { get; set; }
        [Column("sQuestCount")]
        public short SQuestCount { get; set; }
        [Column("strQuest")]
        [MaxLength(600)]
        public byte[]? StrQuest { get; set; }
        public int MannerPoint { get; set; }
        public int LoyaltyMonthly { get; set; }
        [Column("strItemTime")]
        [MaxLength(584)]
        public byte[]? StrItemTime { get; set; }
        [Column("dtCreateTime", TypeName = "datetime")]
        public DateTime DtCreateTime { get; set; }
        [Column("dtUpdateTime", TypeName = "datetime")]
        public DateTime? DtUpdateTime { get; set; }
        [Column("CSWFreeLoyaltyUpdateTime", TypeName = "datetime")]
        public DateTime? CswfreeLoyaltyUpdateTime { get; set; }
    }
}
