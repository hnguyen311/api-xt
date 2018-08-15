using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DM_LIDO_XT
    {
        public short HSU_NAM { get; set; }
        public short HSU_MA_LIDO { get; set; }
        [Required]
        [StringLength(254)]
        public string HSU_MOTA_LIDO { get; set; }
    }
}
