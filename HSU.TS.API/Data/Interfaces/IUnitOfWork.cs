using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPS_HSU_THONGTIN_TS_Repository PS_HSU_THONGTIN_TS_Repository { get; }
        IHSU_DANHMUC_Repository HSU_DANHMUC_Repository { get; }
        IPS_HSU_NOIHOC_THPT_Repository PS_HSU_NOIHOC_THPT_Repository { get; }
        IPS_HSU_TS_XT_Repository PS_HSU_TS_XT_Repository { get; }
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
