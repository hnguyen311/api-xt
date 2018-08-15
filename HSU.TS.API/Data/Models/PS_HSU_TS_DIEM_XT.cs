using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_TS_DIEM_XT
    {
        public short HSU_NAM { get; set; }
        [StringLength(8)]
        public string HSU_SOPHIEU_XT { get; set; }
        public short HSU_MA_MONHOC { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal HSU_DIEMMONHOC_XT { get; set; }
        [StringLength(4)]
        public string HSU_XL_HOCLUC { get; set; }
        [StringLength(4)]
        public string HSU_XL_HANHKIEM { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
