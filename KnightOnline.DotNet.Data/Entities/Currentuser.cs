using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("CURRENTUSER")]
    public partial class Currentuser
    {
        [Column("strAccountID")]
        [StringLength(50)]
        [Unicode(false)]
        public string StrAccountId { get; set; } = null!;
        [Column("strCharID")]
        [StringLength(50)]
        [Unicode(false)]
        public string StrCharId { get; set; } = null!;
        [Column("nServerNo")]
        public short NServerNo { get; set; }
        [Column("strServerIP")]
        [StringLength(50)]
        [Unicode(false)]
        public string StrServerIp { get; set; } = null!;
        [Column("strClientIP")]
        [StringLength(50)]
        [Unicode(false)]
        public string StrClientIp { get; set; } = null!;
    }
}
