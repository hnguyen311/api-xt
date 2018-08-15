using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DM_NAM
    {
        [Key]
        public short HSU_NAM { get; set; }
        [Required]
        [StringLength(50)]
        public string HSU_MOTA_NAM { get; set; }
    }
}
