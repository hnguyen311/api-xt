using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_CA_SOTUYEN
    {
        public short HSU_NAM { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NGAYST { get; set; }
        public short HSU_CAST { get; set; }
        [StringLength(30)]
        public string HSU_PHONG { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_GIOBD { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_GIOKT { get; set; }
        public short HSU_SISO { get; set; }
        public short HSU_DANGKI { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
