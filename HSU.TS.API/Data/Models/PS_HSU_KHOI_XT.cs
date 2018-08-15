using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_KHOI_XT
    {
        public short HSU_NAM { get; set; }
        [StringLength(10)]
        public string HSU_MA_KHOI { get; set; }
        [Required]
        [StringLength(1000)]
        public string HSU_MOTA_KHOI { get; set; }
        public short HSU_MA_HTXT { get; set; }
    }
}
