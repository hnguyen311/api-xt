using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSU.TS.API.Data
{
    public static class Util
    {

        public static short GetYearAsShort(string sYear = "")
        {
            if (!short.TryParse(sYear, out short year))
            {
                year = Int16.Parse(DateTime.Now.Year.ToString());
            }

            return year;
        }
    }
    public static class Para
    {
        public static IEnumerable<Tuple<string,string>> NangKhieu = new List<Tuple<string,string>>
        {
            new Tuple<string, string>("HH","Môn hình họa"),
            new Tuple<string, string>("VE","Môn vẽ"),
            new Tuple<string, string>("TTM","Môn trang trí màu"),
            new Tuple<string, string>("NKK","Môn năng khiếu khác"),
        };
        public static IEnumerable<Tuple<string,string>> ThuHang = new List<Tuple<string,string>>
        {
            new Tuple<string, string>("0","Giải đặc biệt"),
            new Tuple<string, string>("1","Giải nhất"),
            new Tuple<string, string>("2","Giải nhì"),
            new Tuple<string, string>("3","Giải ba"),
            new Tuple<string, string>("4","Giải khuyến khích"),
        };
        public static IEnumerable<Tuple<string,string>> XepLoai = new List<Tuple<string,string>>
        {
             new Tuple<string, string>("XS","Xuất sắc"),
            new Tuple<string, string>("G","Giỏi"),
            new Tuple<string, string>("K","Khá"),
            new Tuple<string, string>("TBK","Trung bình khá"),
            new Tuple<string, string>("TB","Trung bình"),
        };
        public enum USERROLE
        {

            HSU_STUDENT = 0,
            HSU_TUYENSINH = 1


        }
    }
    


}
