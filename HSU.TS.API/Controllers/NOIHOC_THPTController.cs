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
    [Route("api/noihoc_thpt")]
    [Authorize]
    public class NOIHOC_THPTController : Controller
    {
        private IUnitOfWork _uow;

        public NOIHOC_THPTController(IUnitOfWork uow)
        {
            this._uow = uow;

        }
        [HttpGet("{cmnn}")]
        public async Task<IActionResult> GetNoiHoc_THPT(string cmnn)
        {
            try
            {
                var objs = await _uow.PS_HSU_NOIHOC_THPT_Repository.GetByCMNN(cmnn);
                if (objs == null)
                    return BadRequest();
                return Ok(objs);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("")]
        [ValidateModel]
        public async Task<IActionResult> PostNoiHoc_THPT([FromBody]PS_HSU_NOIHOC_THPT thpt)
        {
            try
            {
                var cmnn = this.GetUserId();
                if (cmnn == null)
                    return BadRequest();
                if (thpt.HSU_SOCMND.Equals(cmnn, StringComparison.InvariantCultureIgnoreCase))
                {
                    var year = Util.GetYearAsShort();
                    var THPTObj = await _uow.HSU_DANHMUC_Repository.IsExist_THPTs(year,thpt.HSU_MATINHTP, thpt.HSU_MATRUONG);
                    var CityObj = await _uow.HSU_DANHMUC_Repository.IsExist_CITY(thpt.HSU_MATINHTP);
                    if (THPTObj && CityObj)
                    {
                        if (!_uow.PS_HSU_THONGTIN_TS_Repository.IsExist_CMNN(thpt.HSU_SOCMND))
                            return NotFound();
                        var exist = await _uow.PS_HSU_NOIHOC_THPT_Repository.IsExist(thpt.HSU_SOCMND, thpt.HSU_LOP);
                        if (exist)
                        {
                            return BadRequest();
                        }
                        else
                        {
                            _uow.PS_HSU_NOIHOC_THPT_Repository.Add(thpt);
                            await _uow.SaveChangesAsync();
                            return CreatedAtAction(nameof(PostNoiHoc_THPT), new { cmnn = thpt.HSU_SOCMND }, thpt);
                        }
                    }
                }
                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
       
    }
}