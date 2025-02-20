using Microsoft.EntityFrameworkCore;

namespace QLHK_Webapp.Models
{
    public class DangKyKhamDbContext : DbContext
    {
        public DangKyKhamDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<ThongTinHenKham> ThongTinHenKhams { get; set; }
        public DbSet<LoaiKham> LoaiKhams { get; set; }
        public DbSet<PhongKham> PhongKhams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<NguoiDung>().ToTable("NguoiDung");
            modelBuilder.Entity<ThongTinHenKham>().ToTable("ThongTinHenKham");
            modelBuilder.Entity<LoaiKham>().ToTable("LoaiKham");
            modelBuilder.Entity<PhongKham>().ToTable("PhongKham");

            //Seed Loai Kham
            modelBuilder.Entity<LoaiKham>().HasData(
                new LoaiKham
                {
                    LoaiKhamID = new Guid("583755c9-eac2-490a-a2e7-c380999ab9c8"),
                    TenLoaiKham = "Khám tổng quát"
                },
                new LoaiKham
                {
                    LoaiKhamID = new Guid("b41b0c03-d821-4157-8cd5-4c56d8449ad3"),
                    TenLoaiKham = "Khám chuyên khoa"
                },
                new LoaiKham
                {
                    LoaiKhamID = new Guid("be37ff91-5eac-4114-b0f4-f71c8fa95ae1"),
                    TenLoaiKham = "Khám nội"
                },

                new LoaiKham
                {
                    LoaiKhamID = new Guid("7a252733-80a0-4a0f-a4ed-a153c05f878e"),
                    TenLoaiKham = "Khám ngoại"
                },

                new LoaiKham
                {
                    LoaiKhamID = new Guid("af26c93b-9a7c-4681-a5c4-7a65a075bab5"),
                    TenLoaiKham = "Khám sản"
                },

                new LoaiKham
                {
                    LoaiKhamID = new Guid("36861796-49eb-40f3-b86e-d19ad39c9aee"),
                    TenLoaiKham = "Khám nhi"
                }
            );

            //Seed Phong Kham
            modelBuilder.Entity<PhongKham>().HasData(
                new PhongKham
                {
                    PhongKhamID = new Guid("4b5fa363-a0cb-4169-9cf8-c6bd0f16d1ae"),
                    TenPhongKham = "Phòng khám 1"
                },
                new PhongKham
                {
                    PhongKhamID = new Guid("e6d4453a-21cd-4ffb-9d4e-9f635924b220"),
                    TenPhongKham = "Phòng khám 2"
                },
                new PhongKham
                {
                    PhongKhamID = new Guid("3c68b14c-d37a-4fd2-a949-5a047d0eac4f"),
                    TenPhongKham = "Phòng khám 3"
                },
                new PhongKham
                {
                    PhongKhamID = new Guid("14e571b9-0bda-489f-9ed4-676776b5b2cd"),
                    TenPhongKham = "Phòng khám 4"
                },
                new PhongKham
                {
                    PhongKhamID = new Guid("29d4cd6a-5397-44d8-ad78-c20c9988cf2f"),
                    TenPhongKham = "Phòng khám 5"
                }
            );

            //seed nguoi dung
            modelBuilder.Entity<NguoiDung>().HasData(
                new NguoiDung
                {
                    NguoiDungID = new Guid("F3B13375-A169-4B8F-98CD-65530263EC5E"),
                    HoTen = "Nguyen Van A",
                    SoDienThoai = "0123456789",
                    DiaChi = "Hà Nội",
                    MatKhau = "123456"
                },
                new NguoiDung
                {
                    NguoiDungID = new Guid("ADFD63C2-E393-485A-B1D5-02298A82826E"),
                    HoTen = "Nguyen Van B",
                    SoDienThoai = "0123456789",
                    DiaChi = "Bình Thuận",
                    MatKhau = "123456"
                },
                new NguoiDung
                {
                    NguoiDungID = new Guid("4CBD6010-45CE-4C7B-9947-98E7B92CB2F6"),
                    HoTen = "Nguyen Van C",
                    SoDienThoai = "0123456789",
                    DiaChi = "Tp HCM",
                    MatKhau = "123456"
                }
             );

            //Seed ThongTinHenKham
            modelBuilder.Entity<ThongTinHenKham>().HasData(
                new ThongTinHenKham
                {
                    ThongTinHenKhamID = new Guid("F3B13375-A169-4B8F-98CD-65530263EC5E"),
                    HoTen = "Nguyen Van A",
                    SoDienThoai = "0123456789",
                    NgaySinh = new DateTime(1990, 1, 1),
                    GioiTinh = "Nam",
                    DiaChi = "Hà Nội",
                    NgayHenKham = new DateTime(2022, 2, 14),
                },
                new ThongTinHenKham
                {
                    ThongTinHenKhamID = new Guid("ADFD63C2-E393-485A-B1D5-02298A82826E"),
                    HoTen = "Nguyen Van B",
                    SoDienThoai = "0123456789",
                    NgaySinh = new DateTime(1990, 1, 1),
                    GioiTinh = "Nam",
                    DiaChi = "Bình Thuận",
                    NgayHenKham = new DateTime(2022, 2, 14),
                },
                new ThongTinHenKham
                {
                    ThongTinHenKhamID = new Guid("4CBD6010-45CE-4C7B-9947-98E7B92CB2F6"),
                    HoTen = "Nguyen Van C",
                    SoDienThoai = "0123456789",
                    NgaySinh = new DateTime(1990, 1, 1),
                    GioiTinh = "Nam",
                    DiaChi = "Tp HCM",
                    NgayHenKham = new DateTime(2022, 2, 14),
                }
                );
        }
    }
}
