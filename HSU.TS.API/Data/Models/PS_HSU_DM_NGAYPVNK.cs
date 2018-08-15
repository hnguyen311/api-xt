using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_DM_NGAYPVNK
    {
        public short HSU_NAM { get; set; }
        [StringLength(1)]
        public string HSU_NGUYENVONG_XT { get; set; }
        [StringLength(4)]
        public string HSU_DOT_XT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NGAYPV_NK { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_GIOPV_NK { get; set; }
        [StringLength(100)]
        public string HSU_PHONGPV_NK { get; set; }
        [StringLength(254)]
        public string HSU_CHUTHICH { get; set; }
    }
}
