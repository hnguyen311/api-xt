using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_THISINH_TT
    {
        public short HSU_NAM { get; set; }
        [StringLength(20)]
        public string HSU_SOCMND { get; set; }
        [StringLength(8)]
        public string HSU_SOPHIEU_XT { get; set; }
        [Required]
        [StringLength(8)]
        public string HSU_SOPHIEU2 { get; set; }
        [Required]
        [StringLength(15)]
        public string HSU_SOBAODANH { get; set; }
        [StringLength(20)]
        public string HSU_MANGANH { get; set; }
        [StringLength(1)]
        public string HSU_NGUYENVONG_XT { get; set; }
        [StringLength(4)]
        public string HSU_DOT_XT { get; set; }
        public short HSU_MA_HTXT { get; set; }
        [StringLength(4)]
        public string HSU_MA_KHOI { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal HSU_TONGDIEM_THUC { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal HSU_TONGDIEM_TT { get; set; }
        [Required]
        [StringLength(4)]
        public string HSU_BACDAOTAO { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_LIENTHONG { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NGAY_TT { get; set; }
        [Required]
        [StringLength(254)]
        public string HSU_CHUTHICH { get; set; }
        [Required]
        [StringLength(4)]
        public string HSU_NOP_HSXT_TRE { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_COMMITTED { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_CHUYEN_DL { get; set; }
        [Required]
        [StringLength(30)]
        public string HSU_NGUOICHAY_XT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NGAYGIOCHAY_XT { get; set; }
    }
}
