using HSU.TS.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Extensions
{
    public static class PS_HSU_TS_XT_EXT
    {
        public static bool IsMapValue(this PS_HSU_TS_XT fistTS, PS_HSU_TS_XT secondTS)
        {
            if (fistTS.HSU_NAM != secondTS.HSU_NAM) return false;
            if (!fistTS.HSU_SOCMND.Equals(secondTS.HSU_SOCMND, StringComparison.InvariantCultureIgnoreCase)) return false;
            if (fistTS.HSU_SOPHIEU_XT != secondTS.HSU_SOPHIEU_XT) return false;
            return true;


        }
    }
}
