using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_NOIHOC_THPT
    {
        [StringLength(20)]
        public string HSU_SOCMND { get; set; }
        [StringLength(20)]
        [Range(10, 12)] //hnguyen
        public string HSU_LOP { get; set; }
        [Required]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "This field must be 2 characters")]
        public string HSU_MATINHTP { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "This field must be 3 characters")]
        public string HSU_MATRUONG { get; set; }
        [StringLength(100)]
        public string HSU_TENTRUONG { get; set; }
        [StringLength(50)]
        public string HSU_XAPHUONG { get; set; }
        [StringLength(50)]
        public string HSU_QUANHUYEN { get; set; }
        [StringLength(50)]
        public string HSU_TINHTP { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
