using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DKXT_PA345
    {
        public short HSU_NAM { get; set; }
        public short HSU_MA_HTXT { get; set; }
        public short HSU_MA_MONHOC { get; set; }
        [Required]
        [StringLength(100)]
        public string HSU_TEN_MONHOC { get; set; }
        [StringLength(4)]
        public string HSU_BACDAOTAO { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal HSU_DIEM_DAT_DKXT { get; set; }
        [StringLength(4)]
        public string HSU_XL_HOCLUC { get; set; }
        [StringLength(4)]
        public string HSU_XL_HANHKIEM { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
