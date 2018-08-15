using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_XEPLOAI_HL
    {
        public short HSU_NAM { get; set; }
        public int HSU_ID_NUM { get; set; }
        [StringLength(4)]
        public string HSU_MAXEPLOAI { get; set; }
        [Required]
        [StringLength(254)]
        public string HSU_TENXEPLOAI { get; set; }
    }
}
