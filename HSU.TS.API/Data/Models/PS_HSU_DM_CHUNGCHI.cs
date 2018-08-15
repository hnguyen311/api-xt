using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DM_CHUNGCHI
    {
        public short HSU_NAM { get; set; }
        public short HSU_MACC { get; set; }
        [StringLength(1000)]
        public string HSU_MOTA_CC { get; set; }
    }
}
