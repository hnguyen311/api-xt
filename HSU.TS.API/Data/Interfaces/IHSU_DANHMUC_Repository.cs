using HSU.TS.API.Data.Models;
using HSU.TS.API.Data.ModelView;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Interfaces
{
    public interface IHSU_DANHMUC_Repository: IRepository<Danhmuc>
    {
        //Hinh thuc xet tuyen
        Task<IEnumerable<PS_HSU_HINHTHUC_XT>> Get_HINHTHUC_XTs(short year);
        
        //Nganh xet tuyen
        Task<IEnumerable<NganhDesc>> Get_NGANH_XTs(short maPhuongThuc, short year);
        
        //Truong THPT
        Task<IEnumerable<PS_HSU_DM_TRG_THPT>> Get_THPTs(short nam, string maThanhpho, string maTruong);
        Task<bool> IsExist_THPTs(short nam, string maThanhpho, string maTruong);
        
        //Tinh - TP
        Task<IEnumerable<PS_HSU_CITY_STATE>> Get_CITY(string maCity);
        Task<bool> IsExist_CITY(string maCity);
        
        //Quan-Huyen
        Task<IEnumerable<PS_HSU_DISTRICT>> Get_DISTRICT(string maCity, string maDistrict);
        Task<bool> IsExist_DISTRICT(string maCity, string maDistrict);

        //Khu vuc uu tien
        Task<IEnumerable<PS_HSU_KHUVUC>> Get_KHUVUC(short nam, string khuvucTS);
        Task<bool> IsExist_KHUVUC(short nam, string khuvucTS);

        //Nguyen vong
        Task<IEnumerable<PS_HSU_NGUYENVONG>> Get_NGUYENVONG(short nam);
        Task<bool> IsExit_NGUYENVONG(short nam, string nguyenvong);

        //Dot xet tuyen
        Task<IEnumerable<PS_HSU_DOTXETTUYEN>> Get_DOTXETTUYEN(short nam);
        Task<bool> IsExit_DOTXETTUYEN(short nam, string dotxt);

        //Dieu kien xet tuyen
        Task<IEnumerable<PS_HSU_DIEUKIEN_XT>> Get_DIEUKIENXT(short nam);
        Task<bool> IsExit_DIEUKIENXT(short nam, short dkxt);

        //Truong My thuat
        Task<IEnumerable<PS_HSU_DMTRUONG_MT>> Get_TRUONGMYTHUAT(short nam);
        Task<bool> IsExit_TRUONGMYTHUAT(short nam, string matruong);
       
        //Ly do xet tuyen
        Task<IEnumerable<PS_HSU_DM_LIDO_XT>> Get_LYDOXETTUYEN(short nam);
        Task<bool> IsExit_LYDOXETTUYEN(short nam, short malydo);

        //Doi tuong TS
        Task<IEnumerable<PS_HSU_DOITUONG>> Get_DOITUONG(short nam, string doituongTS);
        Task<bool> IsExit_DOITUONG(short nam, string doituongTS);

        //Dan toc
        Task<IEnumerable<PS_HSU_DANTOC>> Get_DANTOC(string maDantoc);
        Task<bool> IsExit_DANTOC(string maDantoc);
    }
}
