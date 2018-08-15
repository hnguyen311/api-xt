using System;
using HSU.TS.API.Data.ModelView;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HSU.TS.API.Data.Models
{
    public partial class XTDbContext : DbContext
    {
        public XTDbContext(DbContextOptions<XTDbContext> options) : base(options)
        {

        }
    

        public virtual DbSet<PS_HSU_CA_PHONGVAN> PS_HSU_CA_PHONGVAN { get; set; }
        public virtual DbSet<PS_HSU_CA_SOTUYEN> PS_HSU_CA_SOTUYEN { get; set; }
        public virtual DbSet<PS_HSU_CITY_STATE> PS_HSU_CITY_STATE { get; set; }
        public virtual DbSet<PS_HSU_CONGBO_TT> PS_HSU_CONGBO_TT { get; set; }
        public virtual DbSet<PS_HSU_COSODT_DHHS> PS_HSU_COSODT_DHHS { get; set; }
        public virtual DbSet<PS_HSU_DANTOC> PS_HSU_DANTOC { get; set; }
        public virtual DbSet<PS_HSU_DIEMSAN_XT> PS_HSU_DIEMSAN_XT { get; set; }
        public virtual DbSet<PS_HSU_DIEMSANDKXT> PS_HSU_DIEMSANDKXT { get; set; }
        public virtual DbSet<PS_HSU_DIEUKIEN_XT> PS_HSU_DIEUKIEN_XT { get; set; }
        public virtual DbSet<PS_HSU_DISTRICT> PS_HSU_DISTRICT { get; set; }
        public virtual DbSet<PS_HSU_DKXT_HS_XT> PS_HSU_DKXT_HS_XT { get; set; }
        public virtual DbSet<PS_HSU_DKXT_PA345> PS_HSU_DKXT_PA345 { get; set; }
        public virtual DbSet<PS_HSU_DM_CHUNGCHI> PS_HSU_DM_CHUNGCHI { get; set; }
        public virtual DbSet<PS_HSU_DM_HOSO_XT> PS_HSU_DM_HOSO_XT { get; set; }
        public virtual DbSet<PS_HSU_DM_LIDO_XT> PS_HSU_DM_LIDO_XT { get; set; }
        public virtual DbSet<PS_HSU_DM_NAM> PS_HSU_DM_NAM { get; set; }
        public virtual DbSet<PS_HSU_DM_NGAYPVNK> PS_HSU_DM_NGAYPVNK { get; set; }
        public virtual DbSet<PS_HSU_DM_NH_NGANH> PS_HSU_DM_NH_NGANH { get; set; }
        public virtual DbSet<PS_HSU_DM_TRG_THPT> PS_HSU_DM_TRG_THPT { get; set; }
        public virtual DbSet<PS_HSU_DMTRUONG_MT> PS_HSU_DMTRUONG_MT { get; set; }
        public virtual DbSet<PS_HSU_DOITUONG> PS_HSU_DOITUONG { get; set; }
        public virtual DbSet<PS_HSU_DOTXETTUYEN> PS_HSU_DOTXETTUYEN { get; set; }
        public virtual DbSet<PS_HSU_DUYET_HS_XT> PS_HSU_DUYET_HS_XT { get; set; }
        public virtual DbSet<PS_HSU_GIAITHUONG> PS_HSU_GIAITHUONG { get; set; }
        public virtual DbSet<PS_HSU_HESO_NG_KH> PS_HSU_HESO_NG_KH { get; set; }
        public virtual DbSet<PS_HSU_HINHTHUC_XT> PS_HSU_HINHTHUC_XT { get; set; }
        public virtual DbSet<PS_HSU_HTXT_NGANH> PS_HSU_HTXT_NGANH { get; set; }
        public virtual DbSet<PS_HSU_KHOI_MON_XT> PS_HSU_KHOI_MON_XT { get; set; }
        public virtual DbSet<PS_HSU_KHOI_XT> PS_HSU_KHOI_XT { get; set; }
        public virtual DbSet<PS_HSU_KHUVUC> PS_HSU_KHUVUC { get; set; }
        public virtual DbSet<PS_HSU_MAPACADPROG> PS_HSU_MAPACADPROG { get; set; }
        public virtual DbSet<PS_HSU_MH_CN_DIEM> PS_HSU_MH_CN_DIEM { get; set; }
        public virtual DbSet<PS_HSU_MONHOC_XT> PS_HSU_MONHOC_XT { get; set; }
        public virtual DbSet<PS_HSU_NANGKHIEU> PS_HSU_NANGKHIEU { get; set; }
        public virtual DbSet<PS_HSU_NG_CHITIEU> PS_HSU_NG_CHITIEU { get; set; }
        public virtual DbSet<PS_HSU_NGANH_HS_XT> PS_HSU_NGANH_HS_XT { get; set; }
        public virtual DbSet<PS_HSU_NGANH_MT> PS_HSU_NGANH_MT { get; set; }
        public virtual DbSet<PS_HSU_NGANHKHOIXT> PS_HSU_NGANHKHOIXT { get; set; }
        public virtual DbSet<PS_HSU_NGUYENVONG> PS_HSU_NGUYENVONG { get; set; }
        public virtual DbSet<PS_HSU_NOIHOC_THPT> PS_HSU_NOIHOC_THPT { get; set; }
        public virtual DbSet<PS_HSU_NOP_HSXT> PS_HSU_NOP_HSXT { get; set; }
        public virtual DbSet<PS_HSU_PT_NG_DK_KH> PS_HSU_PT_NG_DK_KH { get; set; }
        public virtual DbSet<PS_HSU_THANHTICH> PS_HSU_THANHTICH { get; set; }
        public virtual DbSet<PS_HSU_THISINH_TT> PS_HSU_THISINH_TT { get; set; }
        public virtual DbSet<PS_HSU_THONGBAO_TS> PS_HSU_THONGBAO_TS { get; set; }
        public virtual DbSet<PS_HSU_THONGTIN_TS> PS_HSU_THONGTIN_TS { get; set; }
        public virtual DbSet<PS_HSU_TL_NH_NGANH> PS_HSU_TL_NH_NGANH { get; set; }
        public virtual DbSet<PS_HSU_TRACKING> PS_HSU_TRACKING { get; set; }
        public virtual DbSet<PS_HSU_TS_CT_DKXT> PS_HSU_TS_CT_DKXT { get; set; }
        public virtual DbSet<PS_HSU_TS_DIEM_XT> PS_HSU_TS_DIEM_XT { get; set; }
        public virtual DbSet<PS_HSU_TS_DKXT> PS_HSU_TS_DKXT { get; set; }
        public virtual DbSet<PS_HSU_TS_LICH_PV> PS_HSU_TS_LICH_PV { get; set; }
        public virtual DbSet<PS_HSU_TS_LICH_ST> PS_HSU_TS_LICH_ST { get; set; }
        public virtual DbSet<PS_HSU_TS_XT> PS_HSU_TS_XT { get; set; }
        public virtual DbSet<PS_HSU_XEPLOAI_HL> PS_HSU_XEPLOAI_HL { get; set; }
        public virtual DbSet<PSROLEUSER> PSROLEUSER { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Data Source=192.168.247.129;Initial Catalog=FORTEST_XT;User ID=sa;Password=Password1");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PS_HSU_CA_PHONGVAN>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_NGAYPV, e.HSU_CAPV, e.HSU_PHONG, e.HSU_GIOBD, e.HSU_GIOKT });
            });

            modelBuilder.Entity<PS_HSU_CA_SOTUYEN>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_NGAYST, e.HSU_CAST, e.HSU_PHONG, e.HSU_GIOBD, e.HSU_GIOKT });
            });

            modelBuilder.Entity<PS_HSU_CITY_STATE>(entity =>
            {
                entity.Property(e => e.HSU_MATTP).ValueGeneratedNever();
            });

            modelBuilder.Entity<PS_HSU_CONGBO_TT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_NGUYENVONG_XT, e.HSU_DOT_XT, e.HSU_NOP_HSXT_TRE });
            });

            modelBuilder.Entity<PS_HSU_COSODT_DHHS>(entity =>
            {
                entity.Property(e => e.HSU_KIHIEU_COSO).ValueGeneratedNever();
            });

            modelBuilder.Entity<PS_HSU_DANTOC>(entity =>
            {
                entity.Property(e => e.HSU_MA_DANTOC).ValueGeneratedNever();
            });

            modelBuilder.Entity<PS_HSU_DIEMSAN_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_HTXT, e.HSU_BACDAOTAO });
            });

            modelBuilder.Entity<PS_HSU_DIEMSANDKXT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_HTXT, e.HSU_MADIEUKIEN_XT, e.HSU_BACDAOTAO });
            });

            modelBuilder.Entity<PS_HSU_DIEUKIEN_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MADIEUKIEN_XT });
            });

            modelBuilder.Entity<PS_HSU_DISTRICT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_MATTP, e.HSU_MAQH });
            });

            modelBuilder.Entity<PS_HSU_DKXT_HS_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MADIEUKIEN_XT, e.HSU_MA_HS });
            });

            modelBuilder.Entity<PS_HSU_DKXT_PA345>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_HTXT, e.HSU_MA_MONHOC, e.HSU_BACDAOTAO, e.HSU_XL_HOCLUC, e.HSU_XL_HANHKIEM });
            });

            modelBuilder.Entity<PS_HSU_DM_CHUNGCHI>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MACC });
            });

            modelBuilder.Entity<PS_HSU_DM_HOSO_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_HS });
            });

            modelBuilder.Entity<PS_HSU_DM_LIDO_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_LIDO });
            });

            modelBuilder.Entity<PS_HSU_DM_NAM>(entity =>
            {
                entity.Property(e => e.HSU_NAM).ValueGeneratedNever();
            });

            modelBuilder.Entity<PS_HSU_DM_NGAYPVNK>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_NGUYENVONG_XT, e.HSU_DOT_XT, e.HSU_NGAYPV_NK, e.HSU_GIOPV_NK, e.HSU_PHONGPV_NK });
            });

            modelBuilder.Entity<PS_HSU_DM_NH_NGANH>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_NHOM_NGANH });
            });

            modelBuilder.Entity<PS_HSU_DM_TRG_THPT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MATTP, e.HSU_MATRUONG });
            });

            modelBuilder.Entity<PS_HSU_DMTRUONG_MT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MATRUONG_MT });
            });

            modelBuilder.Entity<PS_HSU_DOITUONG>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_DOITUONG_TS });
            });

            modelBuilder.Entity<PS_HSU_DOTXETTUYEN>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_DOT_XT });
            });

            modelBuilder.Entity<PS_HSU_DUYET_HS_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_SOCMND, e.HSU_SOPHIEU_XT, e.HSU_MA_HS });
            });

            modelBuilder.Entity<PS_HSU_GIAITHUONG>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MAGIAITHUONG });
            });

            modelBuilder.Entity<PS_HSU_HESO_NG_KH>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MANGANH, e.HSU_MA_KHOI, e.HSU_MA_MONHOC });
            });

            modelBuilder.Entity<PS_HSU_HINHTHUC_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_HTXT });
            });

            modelBuilder.Entity<PS_HSU_HTXT_NGANH>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_HTXT, e.HSU_MANGANH });
            });

            modelBuilder.Entity<PS_HSU_KHOI_MON_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_KHOI, e.HSU_MA_MONHOC, e.HSU_THUTU_MONHOCXT, e.HSU_MONLAM_DKXT });
            });

            modelBuilder.Entity<PS_HSU_KHOI_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_KHOI });
            });

            modelBuilder.Entity<PS_HSU_KHUVUC>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_KHUVUC_TS });
            });

            modelBuilder.Entity<PS_HSU_MAPACADPROG>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM_TUYENSINH, e.EDUSOFTACADPROG, e.ERPACADPROG, e.HSU_LIENTHONG, e.ERPACADPLAN });
            });

            modelBuilder.Entity<PS_HSU_MH_CN_DIEM>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_MONHOC });
            });

            modelBuilder.Entity<PS_HSU_MONHOC_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_MONHOC });
            });

            modelBuilder.Entity<PS_HSU_NANGKHIEU>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_ID_NUM, e.HSU_MON_NK });
            });

            modelBuilder.Entity<PS_HSU_NG_CHITIEU>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_NGUYENVONG_XT, e.HSU_DOT_XT, e.HSU_MANGANH });
            });

            modelBuilder.Entity<PS_HSU_NGANH_HS_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_HTXT, e.HSU_MANGANH, e.HSU_MA_HS });
            });

            modelBuilder.Entity<PS_HSU_NGANH_MT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MANGANH });
            });

            modelBuilder.Entity<PS_HSU_NGANHKHOIXT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MANGANH, e.HSU_MA_HTXT, e.HSU_MA_KHOI });
            });

            modelBuilder.Entity<PS_HSU_NGUYENVONG>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_NGUYENVONG_XT, e.HSU_DOT_XT, e.HSU_NHOMPHUONGANXT });
            });

            modelBuilder.Entity<PS_HSU_NOIHOC_THPT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_SOCMND, e.HSU_LOP });
            });

            modelBuilder.Entity<PS_HSU_NOP_HSXT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_NGUYENVONG_XT, e.HSU_DOT_XT, e.HSU_SOCMND, e.HSU_SOPHIEU_XT, e.HSU_MA_HS });
            });

            modelBuilder.Entity<PS_HSU_PT_NG_DK_KH>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_HTXT, e.HSU_MANGANH, e.HSU_MADIEUKIEN_XT, e.HSU_MA_KHOI });
            });

            modelBuilder.Entity<PS_HSU_THANHTICH>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_THUHANG });
            });

            modelBuilder.Entity<PS_HSU_THISINH_TT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_SOCMND, e.HSU_SOPHIEU_XT, e.HSU_MANGANH, e.HSU_NGUYENVONG_XT, e.HSU_DOT_XT, e.HSU_MA_HTXT, e.HSU_MA_KHOI });
            });

            modelBuilder.Entity<PS_HSU_THONGBAO_TS>(entity =>
            {
                entity.HasKey(e => new { e.OPRID, e.HSU_SOCMND, e.HSU_SOPHIEU_XT, e.HSU_NGAYGIO_TB });
            });

            modelBuilder.Entity<PS_HSU_THONGTIN_TS>(entity =>
            {
                entity.Property(e => e.HSU_SOCMND).ValueGeneratedNever();
            });

            modelBuilder.Entity<PS_HSU_TL_NH_NGANH>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_MA_NHOM_NGANH, e.HSU_MANGANH });
            });

            modelBuilder.Entity<PS_HSU_TRACKING>(entity =>
            {
                entity.HasKey(e => new { e.OPRID, e.HSU_SOCMND, e.HSU_NGAYGIOTRUYCAP });
            });

            modelBuilder.Entity<PS_HSU_TS_CT_DKXT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_SOPHIEU_XT, e.HSU_MANGANH, e.HSU_BACDAOTAO, e.HSU_MA_HTXT, e.HSU_MA_KHOI })
                    .ForSqlServerIsClustered(false);
            });

            modelBuilder.Entity<PS_HSU_TS_DIEM_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_SOPHIEU_XT, e.HSU_MA_MONHOC });
            });

            modelBuilder.Entity<PS_HSU_TS_DKXT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_SOPHIEU_XT, e.HSU_MANGANH, e.HSU_BACDAOTAO, e.HSU_MA_HTXT });
            });

            modelBuilder.Entity<PS_HSU_TS_LICH_PV>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_SOCMND, e.HSU_SOPHIEU_XT, e.HSU_NGUYENVONG_XT, e.HSU_DOT_XT });
            });

            modelBuilder.Entity<PS_HSU_TS_LICH_ST>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_SOCMND, e.HSU_SOPHIEU_XT, e.HSU_NGUYENVONG_XT, e.HSU_DOT_XT });
            });

            modelBuilder.Entity<PS_HSU_TS_XT>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_SOCMND, e.HSU_SOPHIEU_XT });
            });

            modelBuilder.Entity<PS_HSU_XEPLOAI_HL>(entity =>
            {
                entity.HasKey(e => new { e.HSU_NAM, e.HSU_ID_NUM, e.HSU_MAXEPLOAI });
            });

            modelBuilder.Entity<PSROLEUSER>(entity =>
            {
                entity.Property(e => e.ROLEUSER).ValueGeneratedNever();
            });
        }
    }
}
