using HSU.TS.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Interfaces
{
    public interface IPS_HSU_NOIHOC_THPT_Repository: IRepository<PS_HSU_NOIHOC_THPT>
    {
        Task<IEnumerable<PS_HSU_NOIHOC_THPT>> GetByCMNN(string cmnn);
        Task<bool> IsExist(string cmnn, string lop);

    }
}
