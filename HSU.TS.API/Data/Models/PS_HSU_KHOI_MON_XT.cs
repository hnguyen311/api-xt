using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_KHOI_MON_XT
    {
        public short HSU_NAM { get; set; }
        [StringLength(10)]
        public string HSU_MA_KHOI { get; set; }
        public short HSU_MA_MONHOC { get; set; }
        [StringLength(4)]
        public string HSU_THUTU_MONHOCXT { get; set; }
        [StringLength(1)]
        public string HSU_MONLAM_DKXT { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
