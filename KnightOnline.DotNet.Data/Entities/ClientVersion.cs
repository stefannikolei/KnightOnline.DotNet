using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("VERSION")]
    public partial class ClientVersion
    {
        [Column("sVersion")]
        public short SVersion { get; set; }
        [Column("strFileName")]
        [StringLength(50)]
        [Unicode(false)]
        public string StrFileName { get; set; } = null!;
        [Column("strCompressName")]
        [StringLength(50)]
        [Unicode(false)]
        public string StrCompressName { get; set; } = null!;
        [Column("sHistoryVersion")]
        public short SHistoryVersion { get; set; }
    }
}
