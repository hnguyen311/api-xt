using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_HESO_NG_KH
    {
        public short HSU_NAM { get; set; }
        [StringLength(20)]
        public string HSU_MANGANH { get; set; }
        [StringLength(10)]
        public string HSU_MA_KHOI { get; set; }
        public short HSU_MA_MONHOC { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_HESO { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
