using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnightOnline.DotNet.Data.Entities
{
    [Keyless]
    [Table("FRIEND_LIST")]
    public partial class FriendList
    {
        [Column("strUserID")]
        [StringLength(21)]
        [Unicode(false)]
        public string StrUserId { get; set; } = null!;
        [Column("strFriend1")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend1 { get; set; }
        [Column("strFriend2")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend2 { get; set; }
        [Column("strFriend3")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend3 { get; set; }
        [Column("strFriend4")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend4 { get; set; }
        [Column("strFriend5")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend5 { get; set; }
        [Column("strFriend6")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend6 { get; set; }
        [Column("strFriend7")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend7 { get; set; }
        [Column("strFriend8")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend8 { get; set; }
        [Column("strFriend9")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend9 { get; set; }
        [Column("strFriend10")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend10 { get; set; }
        [Column("strFriend11")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend11 { get; set; }
        [Column("strFriend12")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend12 { get; set; }
        [Column("strFriend13")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend13 { get; set; }
        [Column("strFriend14")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend14 { get; set; }
        [Column("strFriend15")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend15 { get; set; }
        [Column("strFriend16")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend16 { get; set; }
        [Column("strFriend17")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend17 { get; set; }
        [Column("strFriend18")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend18 { get; set; }
        [Column("strFriend19")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend19 { get; set; }
        [Column("strFriend20")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend20 { get; set; }
        [Column("strFriend21")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend21 { get; set; }
        [Column("strFriend22")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend22 { get; set; }
        [Column("strFriend23")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend23 { get; set; }
        [Column("strFriend24")]
        [StringLength(21)]
        [Unicode(false)]
        public string? StrFriend24 { get; set; }
    }
}
