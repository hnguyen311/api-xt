using HSU.TS.API.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HSU.TS.API.Data.Validation
{
    public class TS_XT_PhuongThucDieuKien : ValidationAttribute
    {
        string _phuongthuc_prop;
        string _dieukien_prop;
        ParaType _para;
        bool _usePara = false;

        public TS_XT_PhuongThucDieuKien()
        {

        }
       
    

        public string PhuongThuc { get; set; }
        public string DieuKien { get; set; }
        public string[] DieuKienList { get; set; }
        public string StringRegrex { get; set; }
        public string[] StringRegrexList { get; set; }
        public ParaType ParaName
        {
            get
            {
                return _para;
            }
            set
            {
                _usePara = true;
                _para = value;

            }
        }

        public enum ParaType
        {
            Para_NangKhieu,
            Para_ThuHang,
            Para_XepLoai,
        }
        bool PropertyContainsValue(Object obj, string propName, string propVal)
        {
            var propertyInfo = obj.GetType().GetProperty(propName);
            if (propertyInfo != null)
            {
                var val =  propertyInfo.GetValue(obj, null);
                return propVal.Equals(val.ToString());
            }
            return false;
        }
        private bool IsValidValue(object value, ValidationContext obj)
        {
            if (_usePara)
            {
                switch (ParaName)
                {
                    case ParaType.Para_NangKhieu:
                        return Para.NangKhieu.Any(p => p.Item1.Equals(value?.ToString(), StringComparison.InvariantCultureIgnoreCase));

                    case ParaType.Para_ThuHang:
                        return Para.ThuHang.Any(p => p.Item1.Equals(value?.ToString()));

                    case ParaType.Para_XepLoai:
                        return Para.XepLoai.Any(p => p.Item1.Equals(value?.ToString()));
                }
            }
            else
            {
                if (value == null)
                {
                    return false;
                }
                else
                {
                    //return Regex.IsMatch(value.ToString(), StringRegrex);
                    var b = Regex.IsMatch(value.ToString(),StringRegrex); //for test
                    return b;
                }
            }
            return true;
        }
        private bool IsValidDK_PT(object value, ValidationContext obj)
        {
            bool pt = true;
            bool dk = true;
            if (PhuongThuc != null)
            {
                pt = PropertyContainsValue(obj.ObjectInstance, _phuongthuc_prop, PhuongThuc);
            }
            if (DieuKien != null)
            {
                dk = PropertyContainsValue(obj.ObjectInstance, _dieukien_prop, DieuKien.ToString());
            }
            return (pt && dk);
        }
        protected bool IsValidSingle(object value, ValidationContext obj)
        {
            if (IsValidDK_PT(value, obj))
            {
                return IsValidValue(value, obj);
            }
            return true;
        }
        protected bool IsValidMulti(object value, ValidationContext obj)
        {
            for (int i = 0; i <= DieuKienList.Length - 1; i++)
            {
                DieuKien = DieuKienList[i];
                if (!_usePara)
                {
                    if (StringRegrexList != null)
                    {
                        if (StringRegrexList.Length == DieuKienList.Length)
                        {
                            StringRegrex = StringRegrexList[i];
                        }
                    }
                }

                if (IsValidDK_PT(value, obj))
                {
                    return IsValidValue(value, obj);
                }
            }
            return true;
        }
        protected override ValidationResult IsValid(object value, ValidationContext obj)
        {
            try
            {
                this._phuongthuc_prop = nameof(PS_HSU_TS_XT.PhuongThuc);
                this._dieukien_prop = nameof(PS_HSU_TS_XT.HSU_MADIEUKIEN_XT);
                bool result = false;
                if (DieuKienList != null && DieuKienList.Length > 0)
                {
                    result = IsValidMulti(value, obj);
                }
                else
                {
                    result = IsValidSingle(value, obj);
                }
                if (result)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(this.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                return new ValidationResult(ex.Message);
            }


        }
    }

}
