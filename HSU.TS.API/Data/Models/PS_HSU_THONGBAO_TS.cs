using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_THONGBAO_TS
    {
        [StringLength(30)]
        public string OPRID { get; set; }
        [StringLength(20)]
        public string HSU_SOCMND { get; set; }
        [StringLength(8)]
        public string HSU_SOPHIEU_XT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NGAYGIO_TB { get; set; }
        public string HSU_NOIDUNG_TB { get; set; }
    }
}
