using HSU.TS.API.Data.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HSU.TS.API.Data.Models
{
    public partial class PS_HSU_THONGTIN_TS
    {
        [Required]
        public short HSU_NAM { get; set; } = short.Parse(DateTime.Now.Year.ToString());
        [Required]
        [StringLength(60)]
        public string HSU_HOVACHULOT_TS { get; set; }
        [Required]
        [StringLength(30)]
        public string HSU_TEN_TS { get; set; }
        [StringLength(1)]
        [RegularExpression(@"^([M]|[F])$")]
        public string HSU_GIOITINH { get; set; }
        [StringLength(2)]
        [RegularExpression(@"^[1-31]$", ErrorMessage = "Invalid HSU_NGAYSINH_TS")]
        public string HSU_NGAYSINH_TS { get; set; }
        [StringLength(2)]
        [RegularExpression(@"^[1-12]$", ErrorMessage = "Invalid HSU_THANGSINH_TS")]
        public string HSU_THANGSINH_TS { get; set; }
        [StringLength(4)]
        public string HSU_NAMSINH_TS { get; set; }
        [Key]
        [Required]
        [StringLength(20, MinimumLength = 9)]
        [RegularExpression(@"^(?:\d{9}|\d{10}|\d{11}|\d{12})$", ErrorMessage = "Invalid HSU_SOCMND")]
        public string HSU_SOCMND { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 32)]
        public string HSU_PASSWORD_TS { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HSU_NGAYCAP_CMND { get; set; }
        [StringLength(40)]
        public string HSU_NOICAP_CMND { get; set; }
        [StringLength(15)]
        public string HSU_DIENTHOAINHA { get; set; }
        [StringLength(15)]
        [RegularExpression(@"^(?:\d{6}|\d{7}|\d{8}|\d{9}|\d{10}|\d{11}|\d{12})$",
            ErrorMessage = "Invalid HSU_DIENTHOAIDD")]

        public string HSU_DIENTHOAIDD { get; set; }
        [Required]
        [StringLength(50)]
        [RegularExpression(@"\A(?i:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
            ErrorMessage = "Invalid HSU_EMAIL")]
        public string HSU_EMAIL { get; set; }
        [StringLength(100)]
        public string HSU_SONHA_TENDUONG { get; set; }
        [StringLength(50)]
        public string HSU_XAPHUONG { get; set; }
        [StringLength(50)]
        public string HSU_QUANHUYEN { get; set; }
        [StringLength(50)]
        public string HSU_TINHTP { get; set; }
        [StringLength(2)]
        public string HSU_MATINHTP { get; set; }
        [StringLength(2)]
        public string HSU_MA_QUAN_HUYEN { get; set; }
        public short? HSU_NAMTN_THPT { get; set; }
        [StringLength(1)]
        [RegularExpression(@"^[0-1]$")]
        public string HSU_DA_HOC_HOASEN { get; set; } = "0";
        [StringLength(10)]
        [HasValue(PropName = "HSU_DA_HOC_HOASEN", StringRegrex = "^.{1, 10}$")]
        public string HSU_MSSV_HOASEN { get; set; }
        [StringLength(1)]

        public string HSU_HUONGUUTIEN { get; set; }
        [StringLength(10)]
        public string HSU_KHUVUC_TS { get; set; }
        [StringLength(2)]
        public string HSU_DOITUONG_TS { get; set; }
        [StringLength(10)]
        public string HSU_MA_DANTOC { get; set; }
        [StringLength(500)]
        public string HSU_HOCBATHPT { get; set; }
        [StringLength(254)]
        public string HSU_CODE_TS { get; set; }
        [Column(TypeName = "datetime")]
        [HasValue(PropName = "HSU_CODE_TS", StringRegrex = "^.{1, 254}$")]
        public DateTime? HSU_NGAYGIO_CODE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HSU_NGAYDK_TTTS { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime? HSU_NGAYCN_TTTS { get; set; }
        [StringLength(30)]
        public string HSU_NGUOINHAP_TTTS { get; set; }
        [StringLength(30)]
        public string HSU_NGUOISUA_TTTS { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HSU_NGAYSUA_TTTS { get; set; }
        public int HSU_VERSION { get; set; } = 0;
        [StringLength(254)]
        public string HSU_FB_AUTH_CODE { get; set; }
        [StringLength(254)]
        public string HSU_GO_AUTH_CODE { get; set; }
        [StringLength(254)]
        public string HSU_SMS_CODE { get; set; }
        [StringLength(254)]
        public string HSU_EMAIL_CODE { get; set; }
        [StringLength(1)]
        public string HSU_EMAIL_VERIFIED { get; set; } = "0";
        [StringLength(1)]
        public string HSU_SMS_VERIFIED { get; set; } = "0";
        [StringLength(254)]
        public string HSU_USERDATA1 { get; set; }
        [StringLength(254)]
        public string HSU_USERDATA2 { get; set; }
        [StringLength(254)]
        public string HSU_USERDATA3 { get; set; }
        [StringLength(254)]
        public string HSU_USERDATA4 { get; set; }
        [StringLength(254)]
        public string HSU_USERDATA5 { get; set; }
        [StringLength(254)]
        public string HSU_USERDATA6 { get; set; }
        [StringLength(254)]
        public string HSU_USERDATA7 { get; set; }
        [StringLength(254)]
        public string HSU_USERDATA8 { get; set; }
        [StringLength(254)]
        public string HSU_USERDATA9 { get; set; }
        [StringLength(254)]
        public string HSU_USERDATA10 { get; set; }
    }
}
