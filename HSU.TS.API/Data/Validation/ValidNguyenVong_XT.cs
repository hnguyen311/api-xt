using HSU.TS.API.Data.Interfaces;
using HSU.TS.API.Data.Models;
using HSU.TS.API.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Validation
{
    public class ValidNguyenVong_XT : ValidationAttribute
    {
        IUnitOfWork _uow;
        public ValidNguyenVong_XT(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public   bool IsValidObject(string obj)
        {
            //using( var uow = new UnitOfWork()
            var nguyenvong =  _uow.HSU_DANHMUC_Repository.IsExit_NGUYENVONG(2018,"3");
            //if (!nguyenvong) return BadRequest(nameof(pS_HSU_TS_XT.HSU_NGUYENVONG_XT));
            
            return true;
        }
        protected override ValidationResult IsValid(object value, ValidationContext obj)
        {
            var result = IsValidObject(value.ToString());
            if (result)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(this.ErrorMessage);
        }
    }
}
