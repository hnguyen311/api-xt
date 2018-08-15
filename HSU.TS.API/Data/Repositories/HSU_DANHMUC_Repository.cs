using HSU.TS.API.Data.Interfaces;
using HSU.TS.API.Data.Models;
using HSU.TS.API.Data.ModelView;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Repositories
{
    public class HSU_DANHMUC_Repository : Repository<Danhmuc>, IHSU_DANHMUC_Repository
    {
        private readonly XTDbContext context;

        public HSU_DANHMUC_Repository(XTDbContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<PS_HSU_HINHTHUC_XT>> Get_HINHTHUC_XTs(short year)
        {
            return await context.PS_HSU_HINHTHUC_XT.Where(p => p.HSU_NAM == year).ToListAsync();

        }
        public async Task<IEnumerable<PS_HSU_DM_TRG_THPT>> Get_THPTs(short nam, string maThanhPho, string maTruong)
        {
            if (maTruong != null)
            {
                return await context.PS_HSU_DM_TRG_THPT.Where(p => p.HSU_NAM == nam && p.HSU_MATTP == maThanhPho && p.HSU_MATRUONG == maTruong).ToListAsync();
            }
            return await context.PS_HSU_DM_TRG_THPT.Where(p => p.HSU_NAM == nam && p.HSU_MATTP == maThanhPho).ToListAsync();

        }
        public async Task<IEnumerable<NganhDesc>> Get_NGANH_XTs(short maPhuongThuc, short year)
        {
            var nganhDesc = new List<NganhDesc>();

            //Copy old query
            var Nganhs = await
                (from a in context.PS_HSU_MAPACADPROG
                 join b in context.PS_HSU_PT_NG_DK_KH on a.EDUSOFTACADPROG equals b.HSU_MANGANH
                 join c in context.PS_HSU_DIEUKIEN_XT on b.HSU_MADIEUKIEN_XT equals c.HSU_MADIEUKIEN_XT
                 where     a.HSU_NAM_TUYENSINH == year.ToString()
                        && b.HSU_NAM == year
                        && c.HSU_NAM == year
                        && b.HSU_MA_HTXT == maPhuongThuc
                        && c.HSU_STATUS.Equals("A",StringComparison.InvariantCultureIgnoreCase)
                 select new
                 {
                     HSU_NAM= b.HSU_NAM,
                     HSU_MA_HTXT= b.HSU_MA_HTXT,
                     HSU_MANGANH= b.HSU_MANGANH,
                     HSU_MADIEUKIEN_XT= b.HSU_MADIEUKIEN_XT,
                     HSU_MA_KHOI= b.HSU_MA_KHOI,
                     NGANH_DESC = a.DESCRIPTION,
                     DKXT_DESC = c.HSU_MOTA_DKXT

                 }).Distinct().ToListAsync();


            foreach (var obj in Nganhs.Select((value, i) => new { i, value }))
            {
                var n = new NganhDesc
                {
                    Id = obj.i,
                    HSU_MADIEUKIEN_XT = obj.value.HSU_MADIEUKIEN_XT,
                    NGANH_DESC = obj.value.NGANH_DESC,
                    HSU_MANGANH = obj.value.HSU_MANGANH,
                    HSU_MA_HTXT = obj.value.HSU_MA_HTXT,
                    HSU_MA_KHOI = obj.value.HSU_MA_KHOI,
                    HSU_NAM = obj.value.HSU_NAM,
                    DKXT_DESC = obj.value.DKXT_DESC

                };

                nganhDesc.Add(n);

            }
            return nganhDesc;
        }

        public async Task<IEnumerable<PS_HSU_CITY_STATE>> Get_CITY(string maCity)
        {
            if (maCity != null)
            {
                return await context.PS_HSU_CITY_STATE.Where(p => p.HSU_MATTP == maCity).ToListAsync();
            }
            return await context.PS_HSU_CITY_STATE.ToListAsync();
        }

        public async Task<IEnumerable<PS_HSU_NGUYENVONG>> Get_NGUYENVONG(short nam)
        {
            return await context.PS_HSU_NGUYENVONG.Where(p => p.HSU_NAM == nam).ToListAsync();
        }

        public async Task<IEnumerable<PS_HSU_DOTXETTUYEN>> Get_DOTXETTUYEN(short nam)
        {
            return await context.PS_HSU_DOTXETTUYEN.Where(p => p.HSU_NAM == nam).ToListAsync();
        }

        public async Task<bool> IsExit_NGUYENVONG(short nam, string nguyenvong)
        {
            return await context.PS_HSU_NGUYENVONG.AnyAsync(p => p.HSU_NAM == nam && p.HSU_NGUYENVONG_XT == nguyenvong);
        }

        public async Task<bool> IsExit_DOTXETTUYEN(short nam, string dotxt)
        {
            return await context.PS_HSU_DOTXETTUYEN.AnyAsync(p => p.HSU_NAM == nam && p.HSU_DOT_XT == dotxt);
        }

        public async Task<IEnumerable<PS_HSU_DIEUKIEN_XT>> Get_DIEUKIENXT(short nam)
        {
            return await context.PS_HSU_DIEUKIEN_XT.Where(p => p.HSU_NAM == nam).ToListAsync();
        }

        public async Task<bool> IsExit_DIEUKIENXT(short nam, short dkxt)
        {
            return await context.PS_HSU_DIEUKIEN_XT.AnyAsync(p => p.HSU_NAM == nam && p.HSU_MADIEUKIEN_XT == dkxt);
        }

        public async Task<IEnumerable<PS_HSU_DMTRUONG_MT>> Get_TRUONGMYTHUAT(short nam)
        {
            return await context.PS_HSU_DMTRUONG_MT.Where(p => p.HSU_NAM == nam).ToListAsync();
        }

        public async Task<bool> IsExit_TRUONGMYTHUAT(short nam, string matruong)
        {
            return await context.PS_HSU_DMTRUONG_MT.AnyAsync(p => p.HSU_NAM == nam && p.HSU_MATRUONG_MT == matruong);
        }

        public async Task<IEnumerable<PS_HSU_DM_LIDO_XT>> Get_LYDOXETTUYEN(short nam)
        {
            return await context.PS_HSU_DM_LIDO_XT.Where(p => p.HSU_NAM == nam).ToListAsync();
        }

        public async Task<bool> IsExit_LYDOXETTUYEN(short nam, short malydo)
        {
            return await context.PS_HSU_DM_LIDO_XT.AnyAsync(p => p.HSU_NAM == nam && p.HSU_MA_LIDO == malydo);
        }

        public async Task<bool> IsExist_CITY(string maCity)
        {
            return await context.PS_HSU_CITY_STATE.AnyAsync(p => p.HSU_MATTP == maCity);
        }

        public async Task<bool> IsExist_THPTs(short nam, string maThanhpho, string maTruong)
        {
            return await context.PS_HSU_DM_TRG_THPT.AnyAsync(p => p.HSU_NAM == nam && p.HSU_MATTP == maThanhpho && p.HSU_MATRUONG == maTruong);
        }
        //QUAN HUYEN
        public async Task<IEnumerable<PS_HSU_DISTRICT>> Get_DISTRICT(string maCity, string maDistrict)
        {
            if (maDistrict != null)
            {
                return await context.PS_HSU_DISTRICT.Where(p => p.HSU_MATTP == maCity && p.HSU_MAQH == maDistrict).ToListAsync();
            }
            return await context.PS_HSU_DISTRICT.Where(p => p.HSU_MATTP == maCity).ToListAsync();
        }

        public async Task<bool> IsExist_DISTRICT(string maCity, string maDistrict)
        {
            return await context.PS_HSU_DISTRICT.AnyAsync(p => p.HSU_MATTP == maCity && p.HSU_MAQH == maDistrict);
        }
        
        //Khu vuc tuyen sinh
        public async Task<IEnumerable<PS_HSU_KHUVUC>> Get_KHUVUC(short nam, string khuvucTS)
        {
            if (khuvucTS != null)
            {
                return await context.PS_HSU_KHUVUC.Where(p => p.HSU_NAM == nam && p.HSU_KHUVUC_TS == khuvucTS).ToListAsync();
            }
            return await context.PS_HSU_KHUVUC.Where(p => p.HSU_NAM == nam).ToListAsync();
        }

        public async Task<bool> IsExist_KHUVUC(short nam, string khuvucTS)
        {
            return await context.PS_HSU_KHUVUC.AnyAsync(p => p.HSU_NAM == nam && p.HSU_KHUVUC_TS == khuvucTS);
        }
        //Doi tuong
        public async Task<IEnumerable<PS_HSU_DOITUONG>> Get_DOITUONG(short nam, string doituongTS)
        {
            if (doituongTS != null)
            {
                return await context.PS_HSU_DOITUONG.Where(p => p.HSU_NAM == nam && p.HSU_DOITUONG_TS == doituongTS).ToListAsync();
            }
            return await context.PS_HSU_DOITUONG.Where(p => p.HSU_NAM == nam).ToListAsync();
        }

        public async Task<bool> IsExit_DOITUONG(short nam, string doituongTS)
        {
            return await context.PS_HSU_DOITUONG.AnyAsync(p => p.HSU_NAM == nam && p.HSU_DOITUONG_TS == doituongTS);
        }
        //Dan toc
        public async Task<IEnumerable<PS_HSU_DANTOC>> Get_DANTOC(string maDantoc)
        {
            if (maDantoc != null)
            {
                return await context.PS_HSU_DANTOC.Where(p => p.HSU_MA_DANTOC == maDantoc).ToListAsync();
            }
            return await context.PS_HSU_DANTOC.Where(p => p.HSU_MA_DANTOC == maDantoc).ToListAsync();
        }

        public async Task<bool> IsExit_DANTOC(string maDantoc)
        {
            return await context.PS_HSU_DANTOC.AnyAsync(p => p.HSU_MA_DANTOC == maDantoc);
        }
    }
}
