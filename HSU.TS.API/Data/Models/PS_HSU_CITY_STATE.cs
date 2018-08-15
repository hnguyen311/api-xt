using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_CITY_STATE
    {
        [Key]
        [StringLength(6)]
        public string HSU_MATTP { get; set; }
        [Required]
        [StringLength(30)]
        public string HSU_TENTTP { get; set; }
    }
}
