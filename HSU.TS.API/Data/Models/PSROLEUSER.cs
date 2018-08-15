using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PSROLEUSER
    {
        [Key]
        [StringLength(30)]
        public string ROLEUSER { get; set; }
        [Required]
        [StringLength(30)]
        public string ROLENAME { get; set; }
        [Required]
        [StringLength(1)]
        public string DYNAMIC_SW { get; set; }
    }
}
