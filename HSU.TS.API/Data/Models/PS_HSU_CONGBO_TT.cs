using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_CONGBO_TT
    {
        public short HSU_NAM { get; set; }
        [StringLength(1)]
        public string HSU_NGUYENVONG_XT { get; set; }
        [StringLength(4)]
        public string HSU_DOT_XT { get; set; }
        [StringLength(4)]
        public string HSU_NOP_HSXT_TRE { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_CB_TT { get; set; }
    }
}
