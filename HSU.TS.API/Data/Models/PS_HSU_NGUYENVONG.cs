using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_NGUYENVONG
    {
        public short HSU_NAM { get; set; }
        [StringLength(1)]
        public string HSU_NGUYENVONG_XT { get; set; }
        [StringLength(4)]
        public string HSU_DOT_XT { get; set; }
        [StringLength(4)]
        public string HSU_NHOMPHUONGANXT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_TUNGAY { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_DENNGAY { get; set; }
        [Required]
        [StringLength(254)]
        public string DESCR254 { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_TINHTRANG_NV { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NGAYXEM_KQXT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HSU_NGAYNHANGIAYTT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NG_BD_NHANGIAY { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NG_KT_NHANGIAY { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_GIOBD { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_GIOKT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NG_BD_NHAPHOC { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NG_KT_NHAPHOC { get; set; }
    }
}
