using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_TS_LICH_PV
    {
        public short HSU_NAM { get; set; }
        [StringLength(20)]
        public string HSU_SOCMND { get; set; }
        [StringLength(8)]
        public string HSU_SOPHIEU_XT { get; set; }
        [StringLength(1)]
        public string HSU_NGUYENVONG_XT { get; set; }
        [StringLength(4)]
        public string HSU_DOT_XT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NGAYPV { get; set; }
        public short HSU_CAPV { get; set; }
        [Required]
        [StringLength(30)]
        public string HSU_PHONG { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
