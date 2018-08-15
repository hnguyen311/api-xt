using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_TRACKING
    {
        [StringLength(30)]
        public string OPRID { get; set; }
        [StringLength(20)]
        public string HSU_SOCMND { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NGAYGIOTRUYCAP { get; set; }
        [StringLength(200)]
        public string HSU_FIELD1 { get; set; }
        [StringLength(200)]
        public string HSU_FIELD2 { get; set; }
        [StringLength(200)]
        public string HSU_FIELD3 { get; set; }
        [StringLength(200)]
        public string HSU_FIELD4 { get; set; }
        [StringLength(200)]
        public string HSU_FIELD5 { get; set; }
        [StringLength(200)]
        public string HSU_FIELD6 { get; set; }
        [StringLength(200)]
        public string HSU_FIELD7 { get; set; }
        [StringLength(200)]
        public string HSU_FIELD8 { get; set; }
        [StringLength(200)]
        public string HSU_FIELD9 { get; set; }
        [StringLength(200)]
        public string HSU_FIELD10 { get; set; }
    }
}
