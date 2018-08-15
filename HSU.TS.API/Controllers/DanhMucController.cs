using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HSU.TS.API.Data;
using HSU.TS.API.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HSU.TS.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Danhmuc")]
    public class DanhMucController : Controller
    {
        private IUnitOfWork _uow;

        public DanhMucController(IUnitOfWork uow)
        {
            this._uow = uow;

        }
        [HttpGet("phuongthuc/{id?}")]
        public async Task<IActionResult> Get_Phuongthuc(string id = null)
        {
            try
            {
                if(!short.TryParse(id, out short year))
                {
                    year = Int16.Parse(DateTime.Now.Year.ToString());
                }
                
                var obj = await _uow.HSU_DANHMUC_Repository.Get_HINHTHUC_XTs(year);
                if (obj == null)
                    return NotFound();
                return Ok(obj);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("nganh/{maPT}/{nam?}")]
        public async Task<IActionResult> Get_NganhTheoPT(string maPT, string nam = null)
        {
            try
            {
                
                var year = Util.GetYearAsShort(nam);
                if (!short.TryParse(maPT, out short maphuongthuc))
                {
                    return NotFound();
                }

                var obj = await _uow.HSU_DANHMUC_Repository.Get_NGANH_XTs(maphuongthuc,year);
                if (obj == null)
                    return NotFound();
                return Ok(obj);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("thpt/{nam}/{maThanhPho}/{maTruong?}")] 
        public async Task<IActionResult> Get_THPT(string nam, string maThanhPho, string maTruong)
        {
            try
            {
                var year = Util.GetYearAsShort(nam);
                var obj =await _uow.HSU_DANHMUC_Repository.Get_THPTs(year,maThanhPho, maTruong);
                return Ok(obj);

            }
            catch(Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("city/{id?}")]//id: ma city
        public async Task<IActionResult> Get_City(string id)
        {
            try
            {
                
                var obj =await _uow.HSU_DANHMUC_Repository.Get_CITY(id);
                return Ok(obj);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("truongmythuat/{year?}")]//id: ma city
        public async Task<IActionResult> Get_TruongMyThuat(string year)
        {
            try
            {
                var nam = Util.GetYearAsShort(year);
                var obj =await _uow.HSU_DANHMUC_Repository.Get_TRUONGMYTHUAT(nam);
                return Ok(obj);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("monnangkhieu")]
        public IActionResult Get_MonNangKhieu()
        {
            try
            {
                var obj = Para.NangKhieu;
                return Ok(obj);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("thuhanggiai")]
        public IActionResult Get_ThuHang()
        {
            try
            {
                var obj = Para.ThuHang;
                return Ok(obj);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("xeploai")]
        public IActionResult Get_XepLoai()
        {
            try
            {
                var obj =  Para.XepLoai;
                return Ok(obj);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("lydoxettuyen/{year?}")]
        public async Task<IActionResult> Get_LyDoXetTuyen(string year)
        {
            try
            {
                var nam = Util.GetYearAsShort(year);
                var obj = await _uow.HSU_DANHMUC_Repository.Get_LYDOXETTUYEN(nam);
                return Ok(obj);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}