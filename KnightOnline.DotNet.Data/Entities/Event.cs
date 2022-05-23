using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("EVENT")]
    public partial class Event
    {
        public byte ZoneNum { get; set; }
        public short EventNum { get; set; }
        public byte Type { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string? Cond1 { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string? Cond2 { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string? Cond3 { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string? Cond4 { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string? Cond5 { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string? Exec1 { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string? Exec2 { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string? Exec3 { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string? Exec4 { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string? Exec5 { get; set; }
    }
}
