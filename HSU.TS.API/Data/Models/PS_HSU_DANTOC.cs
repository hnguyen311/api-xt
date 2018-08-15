using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DANTOC
    {
        [Key]
        [StringLength(8)]
        public string HSU_MA_DANTOC { get; set; }
        [Required]
        [StringLength(50)]
        public string HSU_TEN_DANTOC { get; set; }
    }
}
