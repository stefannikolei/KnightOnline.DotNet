using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("K_OBJECTEVENT")]
    public partial class KObjectevent
    {
        [Column("sZoneNo")]
        public short SZoneNo { get; set; }
        [Column("sIndex")]
        public short SIndex { get; set; }
        [Column("byLife")]
        public byte ByLife { get; set; }
        [Column("sBelong")]
        public short SBelong { get; set; }
        [Column("sType")]
        public short SType { get; set; }
        [Column("sControlNpcId")]
        public short SControlNpcId { get; set; }
        [Column("sStatus")]
        public short SStatus { get; set; }
        [Column("sPosX")]
        public short SPosX { get; set; }
        [Column("sPosY")]
        public short SPosY { get; set; }
        [Column("sPosZ")]
        public short SPosZ { get; set; }
    }
}
