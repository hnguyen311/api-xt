using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_TS_CT_DKXT
    {
        public short HSU_NAM { get; set; }
        [StringLength(8)]
        public string HSU_SOPHIEU_XT { get; set; }
        [StringLength(20)]
        public string HSU_MANGANH { get; set; }
        [StringLength(4)]
        public string HSU_BACDAOTAO { get; set; }
        public short HSU_MA_HTXT { get; set; }
        [StringLength(4)]
        public string HSU_MA_KHOI { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? HSU_TONGDIEM_THUC { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? HSU_TONGDIEM_XT { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? HSU_TB5HK_TOAN { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? HSU_TB5HK_TIENGANH { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? HSU_TB5HK_HOAHOC { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? HSU_TB5HK_SINHHOC { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? HSU_TB5HK_VAN { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
