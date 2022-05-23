using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("MAGIC_TYPE6")]
    public partial class MagicType6
    {
        [Column("iNum")]
        public int INum { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? Name { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string? Description { get; set; }
        public short Size { get; set; }
        [Column("TransformID")]
        public short TransformId { get; set; }
        public short Duration { get; set; }
        public short MaxHp { get; set; }
        public short MaxMp { get; set; }
        public byte Speed { get; set; }
        public short AttackSpeed { get; set; }
        public short TotalHit { get; set; }
        public short TotalAc { get; set; }
        public short TotalHitRate { get; set; }
        public short TotalEvasionRate { get; set; }
        public short TotalFireR { get; set; }
        public short TotalColdR { get; set; }
        public short TotalLightningR { get; set; }
        public short TotalMagicR { get; set; }
        public short TotalDiseaseR { get; set; }
        public short TotalPoisonR { get; set; }
        public short Class { get; set; }
        public byte UserSkillUse { get; set; }
        public byte NeedItem { get; set; }
        public byte SkillSuccessRate { get; set; }
        public byte MonsterFriendly { get; set; }
        public byte Nation { get; set; }
    }
}
