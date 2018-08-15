using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DM_TRG_THPT
    {
        public short HSU_NAM { get; set; }
        [StringLength(10)]
        public string HSU_MATTP { get; set; }
        [StringLength(3)]
        public string HSU_MATRUONG { get; set; }
        [Required]
        [StringLength(100)]
        public string HSU_TENTRUONG { get; set; }
        [Required]
        [StringLength(200)]
        public string HSU_DIACHI_TRUONG { get; set; }
        [Required]
        [StringLength(3)]
        public string HSU_KHUVUC { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_TT_TRUONG_THPT { get; set; }
    }
}
