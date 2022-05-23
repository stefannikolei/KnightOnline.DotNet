using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("SERVER_RESOURCE")]
    public partial class ServerResource
    {
        [Column("nResourceID")]
        public int NResourceId { get; set; }
        [Column("strResource")]
        [StringLength(250)]
        [Unicode(false)]
        public string StrResource { get; set; } = null!;
    }
}
