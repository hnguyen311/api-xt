using HSU.TS.API.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Validation
{
    public class HasValueAttribute : ValidationAttribute
    {
        public string PropName { get; set; }
        public string StringRegrex { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext obj)
        {
            try
            {
                var propertyInfo = obj.ObjectInstance.GetType().GetProperty(PropName);
                if (propertyInfo != null)
                {
                    var val =  propertyInfo.GetValue(obj.ObjectInstance, null);
                    if (val!=null && val.ToString().Length > 0)
                    {
                        if (Regex.IsMatch(value.ToString(), StringRegrex))
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
            catch(Exception)
            {
                return new ValidationResult(this.ErrorMessage);
            }
            
        }
    }
}
