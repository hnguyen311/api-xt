using HSU.TS.API.Data.Interfaces;
using HSU.TS.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private XTDbContext context ;
        public UnitOfWork(XTDbContext context)
        {
            this.context = context;
        }
        private IPS_HSU_THONGTIN_TS_Repository pS_HSU_THONGTIN_TS_repository;
        
        private IPS_HSU_NOIHOC_THPT_Repository pS_HSU_NOIHOC_THPT_Repository;
        private IHSU_DANHMUC_Repository hSU_DANHMUC_Repository;
        private IPS_HSU_TS_XT_Repository pS_HSU_TS_XT_Repository;

        public IPS_HSU_THONGTIN_TS_Repository PS_HSU_THONGTIN_TS_Repository
        {
            get
            {
                if (this.pS_HSU_THONGTIN_TS_repository == null)
                {
                    this.pS_HSU_THONGTIN_TS_repository = new PS_HSU_THONGTIN_TS_Repository(context);
                }
                return pS_HSU_THONGTIN_TS_repository;
            }
        }
     
        public IPS_HSU_NOIHOC_THPT_Repository PS_HSU_NOIHOC_THPT_Repository
        {
            get
            {
                if (this.pS_HSU_NOIHOC_THPT_Repository == null)
                {
                    this.pS_HSU_NOIHOC_THPT_Repository = new PS_HSU_NOIHOC_THPT_Repository(context);
                }
                return pS_HSU_NOIHOC_THPT_Repository;
            }
        }

        public IHSU_DANHMUC_Repository HSU_DANHMUC_Repository
        {
            get
            {
                if (this.hSU_DANHMUC_Repository == null)
                {
                   this.hSU_DANHMUC_Repository = new HSU_DANHMUC_Repository(context);
                }
                return hSU_DANHMUC_Repository;
            }
        }

        public IPS_HSU_TS_XT_Repository PS_HSU_TS_XT_Repository
        {
            get
            {
                if (this.pS_HSU_TS_XT_Repository == null)
                {
                    this.pS_HSU_TS_XT_Repository = new PS_HSU_TS_XT_Repository(context);
                }
                return pS_HSU_TS_XT_Repository;
            }
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
        public async Task<int> SaveChangesAsync()
        {
           return await context.SaveChangesAsync();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
