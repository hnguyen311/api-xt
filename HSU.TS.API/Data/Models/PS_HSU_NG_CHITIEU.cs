using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_NG_CHITIEU
    {
        public short HSU_NAM { get; set; }
        [StringLength(1)]
        public string HSU_NGUYENVONG_XT { get; set; }
        [StringLength(4)]
        public string HSU_DOT_XT { get; set; }
        [StringLength(20)]
        public string HSU_MANGANH { get; set; }
        public short HSU_SL_CHITIEU { get; set; }
    }
}
