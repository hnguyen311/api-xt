using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_GIAITHUONG
    {
        public short HSU_NAM { get; set; }
        [StringLength(4)]
        public string HSU_MAGIAITHUONG { get; set; }
        [Required]
        [StringLength(254)]
        public string HSU_TENGIAITHUONG { get; set; }
    }
}
