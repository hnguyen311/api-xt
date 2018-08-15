using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_COSODT_DHHS
    {
        [Key]
        [StringLength(4)]
        public string HSU_KIHIEU_COSO { get; set; }
        [Required]
        [StringLength(200)]
        public string HSU_DIACHI_TRUONG { get; set; }
        [Required]
        [StringLength(20)]
        public string HSU_DTLL_TRUONG { get; set; }
        [Required]
        [StringLength(20)]
        public string HSU_FAX_TRUONG { get; set; }
        [Required]
        [StringLength(200)]
        public string HSU_MOTA { get; set; }
    }
}
