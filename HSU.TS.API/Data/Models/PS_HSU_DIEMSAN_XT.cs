using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DIEMSAN_XT
    {
        public short HSU_NAM { get; set; }
        public short HSU_MA_HTXT { get; set; }
        [StringLength(4)]
        public string HSU_BACDAOTAO { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal HSU_DIEMSAN { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
