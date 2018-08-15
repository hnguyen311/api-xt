using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_KHUVUC
    {
        public short HSU_NAM { get; set; }
        [StringLength(10)]
        public string HSU_KHUVUC_TS { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal HSU_DIEM_UU_TIEN { get; set; }
    }
}
