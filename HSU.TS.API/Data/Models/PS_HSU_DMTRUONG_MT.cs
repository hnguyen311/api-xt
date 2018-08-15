using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DMTRUONG_MT
    {
        public short HSU_NAM { get; set; }
        [StringLength(10)]
        public string HSU_MATRUONG_MT { get; set; }
        [Required]
        [StringLength(100)]
        public string HSU_TENTRUONG_MT { get; set; }
        [Required]
        [StringLength(200)]
        public string HSU_DIACHI_TRUONG { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
