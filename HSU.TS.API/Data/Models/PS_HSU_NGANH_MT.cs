using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_NGANH_MT
    {
        public short HSU_NAM { get; set; }
        [StringLength(20)]
        public string HSU_MANGANH { get; set; }
        [Required]
        [StringLength(100)]
        public string HSU_TENNGANH { get; set; }
    }
}
