using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_THANHTICH
    {
        public short HSU_NAM { get; set; }
        [StringLength(4)]
        public string HSU_THUHANG { get; set; }
        [Required]
        [StringLength(254)]
        public string HSU_TENTHUHANG { get; set; }
    }
}
