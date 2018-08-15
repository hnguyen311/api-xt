using HSU.TS.API.Data.Validation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSU.TS.API.Data.Models
{


    public partial class PS_HSU_TS_XT
    {

        public short HSU_NAM { get; set; }
        [StringLength(20)]
        public string HSU_SOCMND { get; set; }

        [ValidSoPhieu_XT]
        public string HSU_SOPHIEU_XT { get; set; }
        [NotMapped] 
        public string PhuongThuc
        {

            get
            {
                if (HSU_SOPHIEU_XT.Length == 8)
                {
                    return HSU_SOPHIEU_XT.Substring(2, 1);
                }
                return string.Empty;

            }
        }

        [StringLength(8)]
        public string HSU_SOPHIEU2 { get; set; }
        [StringLength(15)]
        public string HSU_SOBAODANH { get; set; }
        [Required]
        [StringLength(1)]
        [Range(0, Int64.MaxValue, ErrorMessage = "This field should not contain characters")]
        public string HSU_NGUYENVONG_XT { get; set; }
        [Required]
        [StringLength(4)]
        [Range(0, Int64.MaxValue, ErrorMessage = "This field should not contain characters")]
        public string HSU_DOT_XT { get; set; }
        [Required]
        public short HSU_MADIEUKIEN_XT { get; set; }
        [Required]
        [StringLength(1)]
        public string HSU_LIENTHONG { get; set; }
        [TS_XT_PhuongThucDieuKien(PhuongThuc = "3",DieuKien = "6", StringRegrex = "^((19|20)\\d{2})")]// this ok
        public short? HSU_NAMTN_CD { get; set; }
        [StringLength(1)]
        public string HSU_HUONGUUTIEN { get; set; }
        [StringLength(10)]
        public string HSU_KHUVUC_TS { get; set; }
        [StringLength(2)]
        public string HSU_DOITUONG_TS { get; set; }
        [StringLength(1)]
        public string HSU_DT_NK_HAY_TTNT { get; set; }
        [StringLength(4)]
        public string HSU_SOTUYEN_NK { get; set; }
        [StringLength(4)]

        [TS_XT_PhuongThucDieuKien(DieuKien = "13", ParaName = TS_XT_PhuongThucDieuKien.ParaType.Para_NangKhieu)]//OK
        public string HSU_MON_NK { get; set; }
        [StringLength(4)]
       [TS_XT_PhuongThucDieuKien(DieuKien = "12", ParaName = TS_XT_PhuongThucDieuKien.ParaType.Para_ThuHang)] //OK
        public string HSU_THUHANG { get; set; }

        [TS_XT_PhuongThucDieuKien(DieuKien = "12", StringRegrex = "^((19|20)\\d{2})")]// this ok
        public short? HSU_NAM_DOATGIAI { get; set; }
        [StringLength(200)]
         [TS_XT_PhuongThucDieuKien(DieuKien = "12", StringRegrex = "^.{1,200}$")]// this ok

        public string HSU_TENCUOCTHI { get; set; }
        [StringLength(254)]
         [TS_XT_PhuongThucDieuKien(DieuKien = "12", StringRegrex = "^.{1,254}$")]// this ok
        public string HSU_TENTOCHUC_CT { get; set; }
        [StringLength(20)]
         [TS_XT_PhuongThucDieuKien(DieuKien = "13", StringRegrex = "^.{1,20}$")]// this ok
        public string HSU_SBD_TS_MYTHUAT { get; set; }
        [StringLength(10)]
         [TS_XT_PhuongThucDieuKien(DieuKien = "13", StringRegrex = "^.{1,10}$")]// this ok
        public string HSU_MATRUONG_MT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HSU_NGAYDANOP_TTNT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HSU_NGAYSENOP_TTNT { get; set; }
        [StringLength(1)]
        [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKienList = new string[] { "4", "5" }, StringRegrexList = new string[] { "^(1)", "^(2)" })]// this ok
        public string HSU_LOAICC_NN { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HSU_NGAYHIEULUC { get; set; }
        [Column(TypeName = "datetime")]
          [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKienList = new string[] { "4", "5" }, StringRegrex = "^.{1,254}$")]// this ok
        public DateTime? HSU_NGAYTHI { get; set; }
        [StringLength(100)]
         [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKien = "5", StringRegrex = "^.{1,100}$")]// this ok
        public string HSU_ID_TOEFL { get; set; }
        [StringLength(100)]
          [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKien = "5", StringRegrex = "^.{1,100}$")]// this ok
        public string HSU_PASSWORD_TOEFL { get; set; }
        [StringLength(254)]
             [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKienList = new string[] { "6", "7","14" }, StringRegrex = "^.{1,254}$")]// this ok
        public string HSU_TENNGANH_TN { get; set; }
        [StringLength(254)]
        [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKienList = new string[] { "6", "7", "14" }, StringRegrex = "^.{1,254}$")]// this ok
        public string HSU_SOHIEUBANG_TN { get; set; }
        [StringLength(254)]
          [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKienList = new string[] { "6", "7", "14" }, StringRegrex = "^.{1,254}$")]// this ok
        public string HSU_TENTRUONG_TN { get; set; }
        [StringLength(4)]
        [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKienList = new string[] { "7", "14" }, ParaName = TS_XT_PhuongThucDieuKien.ParaType.Para_XepLoai)]// this ok
        public string HSU_XEPLOAI_TN { get; set; }
        [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKienList = new string[] { "7", "14" }, StringRegrex = "^.{1,4}$")]// this ok
        public short? HSU_NAMTN_TCCN { get; set; }
        [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKien = "11" , StringRegrex = "^[1-9]$")]// this ok
        public short? HSU_MACC { get; set; }
        [Column(TypeName = "datetime")]
        [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKien = "11", StringRegrex = "^.{1,254}$")]// this ok
        public DateTime? HSU_NGAYCAP_CC { get; set; }
        [StringLength(254)]
        [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKien = "11", StringRegrex = "^.{1,254}$")]// this ok
        public string HSU_TOCHUC_CAPCC { get; set; }
        [StringLength(254)]
       [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKien = "15", StringRegrex = "^.{1,254}$")]// this ok
        public string HSU_TENCC_MULMEDIA { get; set; }
        [Column(TypeName = "datetime")]
        [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKien = "15", StringRegrex = "^.{1,254}$")]// this ok
        public DateTime? HSU_NGCAP_MULMEDIA { get; set; }
        [StringLength(254)]
        [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKien = "15", StringRegrex = "^.{1,254}$")]// this ok
        public string HSU_TENTC_MULMEDIA { get; set; }
        [Column(TypeName = "datetime")]
        [TS_XT_PhuongThucDieuKien(PhuongThuc = "3", DieuKien = "16", StringRegrex = "^.{1,254}$")]// this ok
        public DateTime? HSU_NGAYPV_NK { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HSU_NGAYNOP_BL { get; set; }
        [StringLength(30)]
        public string HSU_NGUOIDANGKI_HS { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HSU_NGAYGIO_DKXT { get; set; } = DateTime.Now;
        [Required]
        [StringLength(4)]
        [RegularExpression(@"^[0-1]$")]
        public string HSU_NOP_HOSO_XT { get; set; } = "0";
        [Column(TypeName = "datetime")]
        public DateTime? HSU_NGAYGIO_NOP_HS { get; set; } 
        [Required]
        [StringLength(30)]
        [HasValue(PropName = "HSU_NGAYSUA_HS", StringRegrex = "^.{1,30}$")]
        public string HSU_NGUOISUA_HS { get; set; } = "";
        [Column(TypeName = "datetime")]
        [HasValue(PropName = "HSU_NGUOISUA_HS", StringRegrex = "^.{1,30}$")]
        public DateTime? HSU_NGAYSUA_HS { get; set; }
        [StringLength(30)]
       [HasValue(PropName = "HSU_NGAYDUYET_HS", StringRegrex = "^.{1,30}$")]
        public string HSU_NGUOIDUYET_HS { get; set; }
        [Column(TypeName = "datetime")]
        [HasValue(PropName = "HSU_NGUOIDUYET_HS", StringRegrex = "^.{1,30}$")]
        public DateTime? HSU_NGAYDUYET_HS { get; set; }
        [Lydo]
        public short? HSU_MA_LIDO { get; set; }
        [StringLength(1000)]
        [LydoKhac]
        public string HSU_LIDO_KHAC { get; set; }
        [Required]
        [StringLength(1)]
        [RegularExpression(@"^[0-3]$")]
        public string HSU_TT_HS_DKXT { get; set; } = "1";
        [Required]
        [StringLength(1)]
        [RegularExpression(@"^[0-2]$")]
        public string HSU_TINHTRANG_HOSO { get; set; } = "1";
        [Required]
        [StringLength(4)]
        [RegularExpression(@"^([D]|[T])(_H)$")]
        public string HSU_NOP_HSXT_TRE { get; set; } = "D_H";
        [Required]
        [StringLength(1)]
        [RegularExpression(@"^[0-1]$")]
        public string HSU_LOCK_HSXT { get; set; } = "0";
        [Required]
        [StringLength(1)]
        [RegularExpression(@"^[0-1]$")]
        public string HSU_TS_QUANTAM_PA1 { get; set; } = "0";
        public int HSU_VERSION { get; set; }
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
        [StringLength(254)]
        public string HSU_NGHE_DT { get; set; }
        [StringLength(254)]
        public string HSU_MON_DT { get; set; }
        [StringLength(254)]
        public string HSU_TENDETAI { get; set; }
        [StringLength(4)]
        public string HSU_MAGIAITHUONG { get; set; }
        public string HSU_GHICHU { get; set; }
    }
}
