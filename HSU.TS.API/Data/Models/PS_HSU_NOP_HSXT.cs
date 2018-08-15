using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_NOP_HSXT
    {
        public short HSU_NAM { get; set; }
        [StringLength(1)]
        public string HSU_NGUYENVONG_XT { get; set; }
        [StringLength(4)]
        public string HSU_DOT_XT { get; set; }
        [StringLength(20)]
        public string HSU_SOCMND { get; set; }
        [StringLength(8)]
        public string HSU_SOPHIEU_XT { get; set; }
        public short HSU_MA_HS { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_CHECK_UNCHECK { get; set; }
        [Column(TypeName = "date")]
        public DateTime? HSU_NGAY_BOSUNG_HS { get; set; }
        public short HSU_SOLUONGTACPHAM { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NGAYGIO_NOP_HS { get; set; }
        [Required]
        [StringLength(30)]
        public string HSU_NGUOINHAN_HSXT { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
