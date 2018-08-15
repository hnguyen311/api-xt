using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DIEUKIEN_XT
    {
        public short HSU_NAM { get; set; }
        public short HSU_MADIEUKIEN_XT { get; set; }
        [StringLength(1000)]
        public string HSU_MOTA_DKXT { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_STATUS { get; set; }
    }
}
