using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_TS_DKXT
    {
        public short HSU_NAM { get; set; }
        [StringLength(8)]
        public string HSU_SOPHIEU_XT { get; set; }
        [StringLength(20)]
        public string HSU_MANGANH { get; set; }
        [StringLength(4)]
        public string HSU_BACDAOTAO { get; set; }
        public short HSU_MA_HTXT { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_THUTU_UUTIEN { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
