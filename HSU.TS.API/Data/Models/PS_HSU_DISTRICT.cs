using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DISTRICT
    {
        [StringLength(6)]
        public string HSU_MATTP { get; set; }
        [StringLength(6)]
        public string HSU_MAQH { get; set; }
        [Required]
        [StringLength(30)]
        public string HSU_TENQH { get; set; }
    }
}
