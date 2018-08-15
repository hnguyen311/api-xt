using HSU.TS.API.Data.Interfaces;
using HSU.TS.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Repositories
{
    public class PS_HSU_THONGTIN_TS_Repository : Repository<PS_HSU_THONGTIN_TS>, IPS_HSU_THONGTIN_TS_Repository
    {
        private readonly XTDbContext context;
        public PS_HSU_THONGTIN_TS_Repository(XTDbContext context) : base(context)
        {
            this.context = context;
        }

        public bool IsAllowUpdate(short year, string cmnn)
        {
            return context.PS_HSU_TS_XT.Any(p => p.HSU_SOCMND.Equals(cmnn) && p.HSU_NAM == year && p.HSU_LOCK_HSXT.Equals(1));
        }

        public Task<PS_HSU_THONGTIN_TS> GetByCMNN(string cmnn)
        {
            return context.PS_HSU_THONGTIN_TS.Where(p => p.HSU_SOCMND.Equals(cmnn)).SingleOrDefaultAsync();
        }
        public PS_HSU_THONGTIN_TS GetByCMNNAsNoTracking(string cmnn)
        {
            return context.PS_HSU_THONGTIN_TS.AsNoTracking().Where(p => p.HSU_SOCMND.Equals(cmnn)).SingleOrDefault();
        }

        public PS_HSU_THONGTIN_TS GetByEmail(string email)
        {
            return context.PS_HSU_THONGTIN_TS.Where(p => p.HSU_EMAIL.Equals(email)).SingleOrDefault();
        }

        public PS_HSU_THONGTIN_TS IsAuthenticate(string cmnn, string hashPassword)
        {
            return context.PS_HSU_THONGTIN_TS.Where(p => p.HSU_SOCMND.Equals(cmnn)&& p.HSU_PASSWORD_TS.Equals(hashPassword)).SingleOrDefault();
        }
        public bool IsExist(string cmnn, string email)
        {
            return context.PS_HSU_THONGTIN_TS.Any(p => p.HSU_EMAIL.Equals(email, StringComparison.InvariantCultureIgnoreCase) || p.HSU_EMAIL == email);
        }

        public bool IsExist_CMNN(string cmnn)
        {
            return context.PS_HSU_THONGTIN_TS.Any(p => p.HSU_SOCMND.Equals(cmnn) );
        }
        public bool IsExist_EMAIL(string email)
        {
            return context.PS_HSU_THONGTIN_TS.Any(p=> p.HSU_EMAIL.Equals(email, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
