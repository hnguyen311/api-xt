using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.ModelView
{
    
    public class NganhDesc
    {
        public long Id { get; set; }
        public short HSU_NAM { get; set; }
        public short HSU_MA_HTXT { get; set; }
        [StringLength(20)]
        public string HSU_MANGANH { get; set; }
        public short HSU_MADIEUKIEN_XT { get; set; }
        [StringLength(4)]
        public string HSU_MA_KHOI { get; set; }
        [StringLength(70)]
        public string NGANH_DESC { get; set; }
        public string DKXT_DESC { get; set; }
    }
}
