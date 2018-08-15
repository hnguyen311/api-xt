using HSU.TS.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Extensions
{
    public static class PS_HSU_THONGTIN_TS_EXT
    {
        public static bool IsMapValue(this PS_HSU_THONGTIN_TS fistTS, PS_HSU_THONGTIN_TS secondTS)
        {
          
           
           // if (!fistTS.HSU_HOVACHULOT_TS.Equals(secondTS.HSU_HOVACHULOT_TS, StringComparison.InvariantCultureIgnoreCase)) return false;
            //if (!fistTS.HSU_TEN_TS.Equals(secondTS.HSU_TEN_TS, StringComparison.InvariantCultureIgnoreCase)) return false;
            if (fistTS.HSU_NAM != secondTS.HSU_NAM) return false;
           // if (!fistTS.HSU_EMAIL.Equals(secondTS.HSU_EMAIL, StringComparison.InvariantCultureIgnoreCase)) return false;
            if (!fistTS.HSU_SOCMND.Equals(secondTS.HSU_SOCMND, StringComparison.InvariantCultureIgnoreCase)) return false;
            if (fistTS.HSU_NGAYDK_TTTS != secondTS.HSU_NGAYDK_TTTS) return false;
            return true;


        }
    }
}
