using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("USER_SAVED_MAGIC")]
    public partial class UserSavedMagic
    {
        [Column("strCharID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrCharId { get; set; } = null!;
        [Column("nSkill1")]
        public int NSkill1 { get; set; }
        [Column("nDuring1")]
        public short NDuring1 { get; set; }
        [Column("nSkill2")]
        public int NSkill2 { get; set; }
        [Column("nDuring2")]
        public short NDuring2 { get; set; }
        [Column("nSkill3")]
        public int NSkill3 { get; set; }
        [Column("nDuring3")]
        public short NDuring3 { get; set; }
        [Column("nSkill4")]
        public int NSkill4 { get; set; }
        [Column("nDuring4")]
        public short NDuring4 { get; set; }
        [Column("nSkill5")]
        public int NSkill5 { get; set; }
        [Column("nDuring5")]
        public short NDuring5 { get; set; }
        [Column("nSkill6")]
        public int NSkill6 { get; set; }
        [Column("nDuring6")]
        public short NDuring6 { get; set; }
        [Column("nSkill7")]
        public int NSkill7 { get; set; }
        [Column("nDuring7")]
        public short NDuring7 { get; set; }
        [Column("nSkill8")]
        public int NSkill8 { get; set; }
        [Column("nDuring8")]
        public short NDuring8 { get; set; }
        [Column("nSkill9")]
        public int NSkill9 { get; set; }
        [Column("nDuring9")]
        public short NDuring9 { get; set; }
        [Column("nSkill10")]
        public int NSkill10 { get; set; }
        [Column("nDuring10")]
        public short NDuring10 { get; set; }
    }
}
