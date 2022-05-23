using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("EVENT_TRIGGER")]
    public partial class EventTrigger
    {
        [Column("nIndex")]
        public int? NIndex { get; set; }
        [Column("bNpcType")]
        public short? BNpcType { get; set; }
        [Column("sNpcID")]
        public int? SNpcId { get; set; }
        [Column("nTriggerNum")]
        public int? NTriggerNum { get; set; }
    }
}
