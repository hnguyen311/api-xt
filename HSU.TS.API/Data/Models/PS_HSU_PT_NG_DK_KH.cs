using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_PT_NG_DK_KH
    {
        public short HSU_NAM { get; set; }
        public short HSU_MA_HTXT { get; set; }
        [StringLength(20)]
        public string HSU_MANGANH { get; set; }
        public short HSU_MADIEUKIEN_XT { get; set; }
        [StringLength(4)]
        public string HSU_MA_KHOI { get; set; }
        [StringLength(254)]
        public string HSU_CHUTHICH { get; set; }
      
       
    }
    //public partial class PS_HSU_PT_NG_DK_KH
    //{
    //  [NotMapped]
    //    public string Description { get; set; }
    //    [NotMapped]
    //    public virtual PS_HSU_MAPACADPROG MAPACADPROGs { get; set; }

    //}
}
