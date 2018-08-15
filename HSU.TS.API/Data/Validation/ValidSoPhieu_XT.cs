using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Validation
{
    public class ValidSoPhieu_XT : ValidationAttribute
    {
      
        public bool IsValidSoPhieu(string sophieu)
        {
            // length of sophieu = 8
            if (sophieu.Length != 8) return false;
            //year 2 digits of current year; ex: 2018->18
            var nam = sophieu.Substring(0,2);
            var currentYear2Digit = DateTime.Now.Year.ToString().Substring(2,2);
            if (nam != currentYear2Digit) return false;
            //Phuongthuc from 1-4 
            if (!int.TryParse(sophieu.Substring(2, 1), out int phuongthuc)) return false;
            //Sophieu 5 digits
            if (!int.TryParse(sophieu.Substring(3, 5), out int idPhieu)) return false;
            return true;
        }
        protected override ValidationResult IsValid(object value, ValidationContext obj)
        {
            if (IsValidSoPhieu(value.ToString()))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(this.ErrorMessage);
        }
    }
}
