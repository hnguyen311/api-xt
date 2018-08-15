using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DM_HOSO_XT
    {
        public short HSU_NAM { get; set; }
        public short HSU_MA_HS { get; set; }
        [Required]
        [StringLength(1000)]
        public string HSU_TEN_HS { get; set; }
    }
}
