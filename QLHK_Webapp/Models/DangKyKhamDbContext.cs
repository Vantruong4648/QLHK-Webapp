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
                    LoaiKhamID = Guid.NewGuid(),
                    TenLoaiKham = "Khám tổng quát"
                },
                new LoaiKham
                {
                    LoaiKhamID = Guid.NewGuid(),
                    TenLoaiKham = "Khám chuyên khoa"
                },
                new LoaiKham
                {
                    LoaiKhamID = Guid.NewGuid(),
                    TenLoaiKham = "Khám nội"
                },

                new LoaiKham
                {
                    LoaiKhamID = Guid.NewGuid(),
                    TenLoaiKham = "Khám ngoại"
                },

                new LoaiKham
                {
                    LoaiKhamID = Guid.NewGuid(),
                    TenLoaiKham = "Khám sản"
                },

                new LoaiKham
                {
                    LoaiKhamID = Guid.NewGuid(),
                    TenLoaiKham = "Khám nhi"
                }
            );

            //Seed Phong Kham
            modelBuilder.Entity<PhongKham>().HasData(
                new PhongKham
                {
                    PhongKhamID = Guid.NewGuid(),
                    TenPhongKham = "Phòng khám 1"
                },
                new PhongKham
                {
                    PhongKhamID = Guid.NewGuid(),
                    TenPhongKham = "Phòng khám 2"
                },
                new PhongKham
                {
                    PhongKhamID = Guid.NewGuid(),
                    TenPhongKham = "Phòng khám 3"
                },
                new PhongKham
                {
                    PhongKhamID = Guid.NewGuid(),
                    TenPhongKham = "Phòng khám 4"
                },
                new PhongKham
                {
                    PhongKhamID = Guid.NewGuid(),
                    TenPhongKham = "Phòng khám 5"
                }
            );
        }
    }
}
