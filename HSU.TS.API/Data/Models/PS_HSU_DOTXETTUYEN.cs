using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DOTXETTUYEN
    {
        public short HSU_NAM { get; set; }
        [StringLength(4)]
        public string HSU_DOT_XT { get; set; }
        [Required]
        [StringLength(254)]
        public string DESCR254 { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_TINHTRANGDOTXT { get; set; }
    }
}
