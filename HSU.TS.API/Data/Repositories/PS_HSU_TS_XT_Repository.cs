using HSU.TS.API.Data.Interfaces;
using HSU.TS.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Repositories
{
    public class PS_HSU_TS_XT_Repository : Repository<PS_HSU_TS_XT>, IPS_HSU_TS_XT_Repository
    {
        private readonly XTDbContext context;


        public PS_HSU_TS_XT_Repository(XTDbContext context) : base(context)
        {
            this.context = context;
        }

   
        public async Task<IEnumerable<PS_HSU_TS_XT>> Get_TS_XT(short year, string cmnn)
        {
            return await context.PS_HSU_TS_XT.Where(p => p.HSU_NAM == year && p.HSU_SOCMND == cmnn).ToListAsync();
        }

        public async Task<bool> IsExist(short year, string cmnn, string sophieu)
        {
            return await context.PS_HSU_TS_XT.AnyAsync(p => p.HSU_NAM == year && p.HSU_SOCMND == cmnn && p.HSU_SOPHIEU_XT == sophieu);
        }

        public async Task<PS_HSU_TS_XT> Get_TS_XT(short year, string cmnn, string sophieu)
        {
            return await context.PS_HSU_TS_XT.SingleOrDefaultAsync(p => p.HSU_NAM == year && p.HSU_SOCMND == cmnn && p.HSU_SOPHIEU_XT == sophieu);
        }

        public PS_HSU_TS_XT Get_TS_XT_NoTracking(short year, string cmnn, string sophieu)
        {
            return  context.PS_HSU_TS_XT.AsNoTracking().SingleOrDefault(p => p.HSU_NAM == year && p.HSU_SOCMND == cmnn && p.HSU_SOPHIEU_XT == sophieu);
        }
    }
}
