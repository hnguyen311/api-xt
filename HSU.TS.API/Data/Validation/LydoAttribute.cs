using HSU.TS.API.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Validation
{
    public class LydoAttribute: ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext obj)
        {
            var propName = nameof(PS_HSU_TS_XT.HSU_TINHTRANG_HOSO);
            try
            {
                var propertyInfo = obj.ObjectInstance.GetType().GetProperty(propName);
                if (propertyInfo != null)
                {
                    var val =  propertyInfo.GetValue(obj.ObjectInstance, null);
                    if (val != null && !val.ToString().Equals("1"))
                    {
                        if (value.ToString().Length > 0)
                        {
                            return ValidationResult.Success;
                        }
                        else
                        {
                            return new ValidationResult(this.ErrorMessage);
                        }
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                }
                return new ValidationResult(this.ErrorMessage);
            }
            catch (Exception)
            {
                return new ValidationResult(this.ErrorMessage);
            }

        }
    }
    public class LydoKhacAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext obj)
        {
            var propName = nameof(PS_HSU_TS_XT.HSU_MA_LIDO);
            try
            {
                var propertyInfo = obj.ObjectInstance.GetType().GetProperty(propName);
                if (propertyInfo != null)
                {
                    var val =  propertyInfo.GetValue(obj.ObjectInstance, null);
                    if (val == null || val.ToString().Length == 0)
                    {
                        if (value.ToString().Trim().Length > 0)
                        {
                            return ValidationResult.Success;
                        }
                        else
                        {
                            return new ValidationResult(this.ErrorMessage);
                        }
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                }
                return new ValidationResult(this.ErrorMessage);
            }
            catch (Exception)
            {
                return new ValidationResult(this.ErrorMessage);
            }

        }
    }
}
