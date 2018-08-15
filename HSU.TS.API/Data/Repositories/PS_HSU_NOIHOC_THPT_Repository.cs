using HSU.TS.API.Data.Interfaces;
using HSU.TS.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Repositories
{
    public class PS_HSU_NOIHOC_THPT_Repository : Repository<PS_HSU_NOIHOC_THPT>, IPS_HSU_NOIHOC_THPT_Repository
    {
        private readonly XTDbContext context;
        public PS_HSU_NOIHOC_THPT_Repository(XTDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<PS_HSU_NOIHOC_THPT>> GetByCMNN(string cmnn)
        {
            return await context.PS_HSU_NOIHOC_THPT.Where(p => p.HSU_SOCMND.Equals(cmnn)).ToListAsync();
        }

        public async Task<bool> IsExist(string cmnn, string lop)
        {
            return await  context.PS_HSU_NOIHOC_THPT.AnyAsync(p => p.HSU_SOCMND.Equals(cmnn) && p.HSU_LOP == lop);
        }
    }
}
