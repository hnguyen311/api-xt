using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_MAPACADPROG
    {
        [StringLength(4)]
        public string HSU_NAM_TUYENSINH { get; set; }
        [StringLength(10)]
        public string EDUSOFTACADPROG { get; set; }
        [StringLength(10)]
        public string ERPACADPROG { get; set; }
        [StringLength(1)]
        public string HSU_LIENTHONG { get; set; }
        [StringLength(10)]
        public string ERPACADPLAN { get; set; }
        [Required]
        [StringLength(70)]
        public string DESCRIPTION { get; set; }
        [StringLength(254)]
        public string HSU_LINK_THAMKHAO { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_STATUS { get; set; }
        public string HSU_MOTA_VANTAT { get; set; }
    }
}
