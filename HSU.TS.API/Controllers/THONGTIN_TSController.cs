using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
    [Route("api/Thongtin_TS")]
    [Authorize]
    public class THONGTIN_TSController : Controller
    {
        private IUnitOfWork _uow;

        public THONGTIN_TSController(IUnitOfWork uow)
        {
            this._uow = uow;

        }
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(string id)
        {

          

            var cmnn = string.Empty;
            if (this.CurrentUserIsAdmin())
            {
                if (id != null)
                {
                    cmnn = id;
                }
            }
            else
            {
                cmnn = this.GetUserId();
            }
            if (cmnn == string.Empty)
            {
                return NotFound();
            }
            var obj = await _uow.PS_HSU_THONGTIN_TS_Repository.GetByCMNN(cmnn);
            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }
        [HttpPost("Create")]
        [AllowAnonymous]
        [ValidateModel]
        public async Task<IActionResult> CreateAsync([FromBody] PS_HSU_THONGTIN_TS thongtin_ts)
        {
            if (_uow.PS_HSU_THONGTIN_TS_Repository.IsExist(thongtin_ts.HSU_SOCMND, thongtin_ts.HSU_EMAIL))
            {
                return BadRequest();
            }
            else
            {
                if (this.CurrentUserIsAdmin())
                {
                    thongtin_ts.HSU_NGUOINHAP_TTTS = this.GetUserId();
                }

                if (IsValidRecord(thongtin_ts).Result)
                {
                    _uow.PS_HSU_THONGTIN_TS_Repository.Add(thongtin_ts);
                    await _uow.SaveChangesAsync();
                    return CreatedAtAction(nameof(CreateAsync), new { cmnn = thongtin_ts.HSU_SOCMND }, thongtin_ts);
                }
                return BadRequest();

            }
        }

        [HttpPut("Update/{id}")]
        [ValidateModel]
        public async Task<IActionResult> Update(string id, [FromBody]PS_HSU_THONGTIN_TS thongtin_ts)
        {
            var userId = this.GetUserId();
            if (this.CurrentUserIsAdmin())
            {
                thongtin_ts.HSU_NGUOISUA_TTTS = userId;
                thongtin_ts.HSU_NGAYSUA_TTTS = DateTime.Now;
            }
            else
            {
                if (!id.Equals(userId))
                {
                    return BadRequest();
                }
            }

            var ts = _uow.PS_HSU_THONGTIN_TS_Repository.GetByCMNNAsNoTracking(id);
            if (ts.IsMapValue(thongtin_ts) && IsValidRecord(thongtin_ts).Result)
            {
                ts = thongtin_ts;
                _uow.PS_HSU_THONGTIN_TS_Repository.Update(ts);
                await _uow.SaveChangesAsync();
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut("UpdatePassword/{id}")]
        [ValidateModel]
        public async Task<IActionResult> UpdatePassword(string id, [FromBody]PS_HSU_THONGTIN_TS thongtin_ts)
        {

            if (this.CurrentUserIsAdmin())
            {
                return BadRequest();
            }

            var cmnn = this.GetUserId();
            if (id.Equals(cmnn) && thongtin_ts != null)//check token with id querystring
            {
                var ts = await _uow.PS_HSU_THONGTIN_TS_Repository.GetByCMNN(cmnn);
                if (ts != null && thongtin_ts.HSU_PASSWORD_TS != null)
                {
                    if (!ts.HSU_PASSWORD_TS.Equals(thongtin_ts.HSU_PASSWORD_TS, StringComparison.InvariantCultureIgnoreCase))
                    {
                        ts.HSU_PASSWORD_TS = thongtin_ts.HSU_PASSWORD_TS;
                        _uow.PS_HSU_THONGTIN_TS_Repository.Update(ts);
                        await _uow.SaveChangesAsync();
                    }
                    return Ok();
                }
            }
            return BadRequest();

        }

        private async Task<bool> IsValidRecord(PS_HSU_THONGTIN_TS thongtin_ts)
        {
            var city = await _uow.HSU_DANHMUC_Repository.IsExist_CITY(thongtin_ts.HSU_MATINHTP);
            var dist = await _uow.HSU_DANHMUC_Repository.IsExist_DISTRICT(thongtin_ts.HSU_MATINHTP, thongtin_ts.HSU_MA_QUAN_HUYEN);
            var doituong = await _uow.HSU_DANHMUC_Repository.IsExit_DOITUONG(thongtin_ts.HSU_NAM,thongtin_ts.HSU_DOITUONG_TS);
            var khuvuc =await  _uow.HSU_DANHMUC_Repository.IsExist_KHUVUC(thongtin_ts.HSU_NAM, thongtin_ts.HSU_KHUVUC_TS);
            var dantoc = await _uow.HSU_DANHMUC_Repository.IsExit_DANTOC(thongtin_ts.HSU_MA_DANTOC);
            return (city && dist && doituong && khuvuc && dantoc);
        }
    }
}