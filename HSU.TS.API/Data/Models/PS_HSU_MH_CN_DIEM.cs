using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_MH_CN_DIEM
    {
        public short HSU_NAM { get; set; }
        public short HSU_MA_MONHOC { get; set; }
        [Required]
        [StringLength(100)]
        public string HSU_TEN_MONHOC { get; set; }
        [Required]
        [StringLength(254)]
        public string HSU_CHUTHICH { get; set; }
    }
}
