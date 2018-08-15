using HSU.TS.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Interfaces
{
    public interface IPS_HSU_THONGTIN_TS_Repository : IRepository<PS_HSU_THONGTIN_TS>
    {
       Task<PS_HSU_THONGTIN_TS> GetByCMNN(string cmnn);
        PS_HSU_THONGTIN_TS GetByCMNNAsNoTracking(string cmnn);       
        PS_HSU_THONGTIN_TS GetByEmail(string email);
        bool IsExist_CMNN(string cmnn);
        bool IsExist(string cmnn, string email);
        bool IsExist_EMAIL(string email);
        PS_HSU_THONGTIN_TS IsAuthenticate(string cmnn, string hashPassword);
        bool IsAllowUpdate(short year, string cmnn);
    }
}
