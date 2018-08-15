using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_NANGKHIEU
    {
        public short HSU_NAM { get; set; }
        public int HSU_ID_NUM { get; set; }
        [StringLength(4)]
        public string HSU_MON_NK { get; set; }
        [Required]
        [StringLength(254)]
        public string HSU_TENMON_NK { get; set; }
    }
}
