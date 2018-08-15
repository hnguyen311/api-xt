using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_NGANH_HS_XT
    {
        public short HSU_NAM { get; set; }
        public short HSU_MA_HTXT { get; set; }
        [StringLength(20)]
        public string HSU_MANGANH { get; set; }
        public short HSU_MA_HS { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
