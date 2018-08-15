using HSU.TS.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Interfaces
{
    public interface IPS_HSU_TS_XT_Repository: IRepository<PS_HSU_TS_XT>
    {
        Task<IEnumerable<PS_HSU_TS_XT>> Get_TS_XT(short year, string cmnn);
        Task<PS_HSU_TS_XT> Get_TS_XT(short year, string cmnn, string sophieu);
        PS_HSU_TS_XT Get_TS_XT_NoTracking(short year, string cmnn, string sophieu);
        Task<bool> IsExist(short year, string cmnn, string sophieu);
    }
}
