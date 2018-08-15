using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_TL_NH_NGANH
    {
        public short HSU_NAM { get; set; }
        [StringLength(40)]
        public string HSU_MA_NHOM_NGANH { get; set; }
        [StringLength(20)]
        public string HSU_MANGANH { get; set; }
        [StringLength(254)]
        public string HSU_CHUTHICH { get; set; }
    }
}
