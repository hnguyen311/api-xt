using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HSU.TS.API.Data;
using HSU.TS.API.Data.Extensions;
using HSU.TS.API.Data.Interfaces;
using HSU.TS.API.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HSU.TS.API.Controllers
{
    [Produces("application/json")]
    [Route("api/TS_XT")]
    [Authorize]
    public class TS_XTController : Controller
    {
        private IUnitOfWork _uow;

        public TS_XTController(IUnitOfWork uow)
        {
            this._uow = uow;

        }
        [HttpGet("{year?}/{cmnn?}/{sophieu?}")]
        public async Task<IActionResult> GetTS_XT(string year, string cmnn, string sophieu)
        {
            try
            {
                var nam = Util.GetYearAsShort(year);
                if (!this.CurrentUserIsAdmin()) cmnn = this.GetUserId();
                if (sophieu == null)
                {
                    var objs = await _uow.PS_HSU_TS_XT_Repository.Get_TS_XT(nam, cmnn);
                    if (objs != null && objs.Count() > 0)
                        return Ok(objs);
                    return NotFound();
                }
                else
                {
                    var obj = await _uow.PS_HSU_TS_XT_Repository.Get_TS_XT(nam, cmnn, sophieu);
                    if (obj != null)
                    {
                        return Ok(obj);
                    }
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> PostTS_XT([FromBody]PS_HSU_TS_XT pS_HSU_TS_XT)
        {
            try
            {
                var sophieu = pS_HSU_TS_XT.HSU_SOPHIEU_XT;
                var phuongthuc = pS_HSU_TS_XT.PhuongThuc;
                //Check existing an instance
                var objs = await _uow.PS_HSU_TS_XT_Repository.IsExist(pS_HSU_TS_XT.HSU_NAM, pS_HSU_TS_XT.HSU_SOCMND, sophieu);
                if (objs)
                {
                    return BadRequest();
                }
                //Check is admin for update manual
                if (this.CurrentUserIsAdmin())
                {
                    pS_HSU_TS_XT.HSU_NGUOIDANGKI_HS = this.GetUserId();
                }
                //Check valid ref value
                if (IsValidRecord(pS_HSU_TS_XT))
                {
                    //Do Post action
                    _uow.PS_HSU_TS_XT_Repository.Add(pS_HSU_TS_XT);
                    await _uow.SaveChangesAsync();
                    return CreatedAtAction(nameof(PostTS_XT), new { cmnn = pS_HSU_TS_XT.HSU_SOCMND }, pS_HSU_TS_XT);
                }
                return BadRequest();// invalid ref data

            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        [HttpPut("{nam}/{id}/{sophieu}")]
        [ValidateModel]
        public async Task<IActionResult> Update(string nam, string id, string soPhieu, [FromBody]PS_HSU_TS_XT pS_HSU_TS_XT)
        {
            try
            {
                var year = Util.GetYearAsShort(nam);
                var userId = this.GetUserId();
                if (this.CurrentUserIsAdmin())
                {
                    pS_HSU_TS_XT.HSU_NGUOISUA_HS = userId;
                    pS_HSU_TS_XT.HSU_NGAYSUA_HS = DateTime.Now;
                }
                else
                {
                    if (!id.Equals(userId))
                    {
                        return BadRequest();
                    }
                }
                var ts =  _uow.PS_HSU_TS_XT_Repository.Get_TS_XT_NoTracking(year, id, soPhieu);
                if (ts.IsMapValue(pS_HSU_TS_XT) && IsValidRecord(pS_HSU_TS_XT))
                {
                    ts = pS_HSU_TS_XT;
                    _uow.PS_HSU_TS_XT_Repository.Update(ts);
                    await _uow.SaveChangesAsync();
                    return Ok();
                }
                return BadRequest();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("NopHS/{cmnn}/{sophieu}")]
        [ValidateModel]
        public async Task<IActionResult> NopHS(string cmnn, string soPhieu)
        {
            try
            {
                var nam = Util.GetYearAsShort();
                if (!this.CurrentUserIsAdmin()) cmnn = this.GetUserId();
                var obj = await _uow.PS_HSU_TS_XT_Repository.Get_TS_XT(nam, cmnn, soPhieu);
                if (obj != null)
                {
                    obj.HSU_NOP_HOSO_XT = "1";
                    obj.HSU_NGAYGIO_NOP_HS = DateTime.Now;
                    _uow.PS_HSU_TS_XT_Repository.Update(obj);
                    await _uow.SaveChangesAsync();
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        private bool IsValidRecord(PS_HSU_TS_XT pS_HSU_TS_XT)
        {

            //Check ThongTin_TS is valid
            if (!_uow.PS_HSU_THONGTIN_TS_Repository.IsExist_CMNN(pS_HSU_TS_XT.HSU_SOCMND)) return false;
            //Check nguyenvong is valid in table
            if (!_uow.HSU_DANHMUC_Repository.IsExit_NGUYENVONG(pS_HSU_TS_XT.HSU_NAM, pS_HSU_TS_XT.HSU_NGUYENVONG_XT).Result) return false;

            //Check dot_xet_tuyen is valid in Table
            if (!_uow.HSU_DANHMUC_Repository.IsExit_DOTXETTUYEN(pS_HSU_TS_XT.HSU_NAM, pS_HSU_TS_XT.HSU_DOT_XT).Result) return false;

            //Check Ma dieu kien xet tuyen
            if (!_uow.HSU_DANHMUC_Repository.IsExit_DIEUKIENXT(pS_HSU_TS_XT.HSU_NAM, pS_HSU_TS_XT.HSU_MADIEUKIEN_XT).Result) return false;

            if (pS_HSU_TS_XT.HSU_MADIEUKIEN_XT == 13)
            {
                if (!_uow.HSU_DANHMUC_Repository.IsExit_TRUONGMYTHUAT(pS_HSU_TS_XT.HSU_NAM, pS_HSU_TS_XT.HSU_MATRUONG_MT).Result) return false;
            }
            return true;
        }

    }
}