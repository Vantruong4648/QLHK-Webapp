﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLHK_Webapp.Models;

#nullable disable

namespace QLHK_Webapp.Migrations
{
    [DbContext(typeof(DangKyKhamDbContext))]
    partial class DangKyKhamDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QLHK_Webapp.Models.LoaiKham", b =>
                {
                    b.Property<Guid>("LoaiKhamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenLoaiKham")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("LoaiKhamID");

                    b.ToTable("LoaiKham", (string)null);

                    b.HasData(
                        new
                        {
                            LoaiKhamID = new Guid("583755c9-eac2-490a-a2e7-c380999ab9c8"),
                            TenLoaiKham = "Khám tổng quát"
                        },
                        new
                        {
                            LoaiKhamID = new Guid("b41b0c03-d821-4157-8cd5-4c56d8449ad3"),
                            TenLoaiKham = "Khám chuyên khoa"
                        },
                        new
                        {
                            LoaiKhamID = new Guid("be37ff91-5eac-4114-b0f4-f71c8fa95ae1"),
                            TenLoaiKham = "Khám nội"
                        },
                        new
                        {
                            LoaiKhamID = new Guid("7a252733-80a0-4a0f-a4ed-a153c05f878e"),
                            TenLoaiKham = "Khám ngoại"
                        },
                        new
                        {
                            LoaiKhamID = new Guid("af26c93b-9a7c-4681-a5c4-7a65a075bab5"),
                            TenLoaiKham = "Khám sản"
                        },
                        new
                        {
                            LoaiKhamID = new Guid("36861796-49eb-40f3-b86e-d19ad39c9aee"),
                            TenLoaiKham = "Khám nhi"
                        });
                });

            modelBuilder.Entity("QLHK_Webapp.Models.NguoiDung", b =>
                {
                    b.Property<Guid>("NguoiDungID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("HoTen")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("NguoiDungID");

                    b.ToTable("NguoiDung", (string)null);

                    b.HasData(
                        new
                        {
                            NguoiDungID = new Guid("f3b13375-a169-4b8f-98cd-65530263ec5e"),
                            DiaChi = "Hà Nội",
                            HoTen = "Nguyen Van A",
                            MatKhau = "123456",
                            SoDienThoai = "0123456789"
                        },
                        new
                        {
                            NguoiDungID = new Guid("adfd63c2-e393-485a-b1d5-02298a82826e"),
                            DiaChi = "Bình Thuận",
                            HoTen = "Nguyen Van B",
                            MatKhau = "123456",
                            SoDienThoai = "0123456789"
                        },
                        new
                        {
                            NguoiDungID = new Guid("4cbd6010-45ce-4c7b-9947-98e7b92cb2f6"),
                            DiaChi = "Tp HCM",
                            HoTen = "Nguyen Van C",
                            MatKhau = "123456",
                            SoDienThoai = "0123456789"
                        });
                });

            modelBuilder.Entity("QLHK_Webapp.Models.PhongKham", b =>
                {
                    b.Property<Guid>("PhongKhamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenPhongKham")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PhongKhamID");

                    b.ToTable("PhongKham", (string)null);

                    b.HasData(
                        new
                        {
                            PhongKhamID = new Guid("4b5fa363-a0cb-4169-9cf8-c6bd0f16d1ae"),
                            TenPhongKham = "Phòng khám 1"
                        },
                        new
                        {
                            PhongKhamID = new Guid("e6d4453a-21cd-4ffb-9d4e-9f635924b220"),
                            TenPhongKham = "Phòng khám 2"
                        },
                        new
                        {
                            PhongKhamID = new Guid("3c68b14c-d37a-4fd2-a949-5a047d0eac4f"),
                            TenPhongKham = "Phòng khám 3"
                        },
                        new
                        {
                            PhongKhamID = new Guid("14e571b9-0bda-489f-9ed4-676776b5b2cd"),
                            TenPhongKham = "Phòng khám 4"
                        },
                        new
                        {
                            PhongKhamID = new Guid("29d4cd6a-5397-44d8-ad78-c20c9988cf2f"),
                            TenPhongKham = "Phòng khám 5"
                        });
                });

            modelBuilder.Entity("QLHK_Webapp.Models.ThongTinHenKham", b =>
                {
                    b.Property<Guid>("ThongTinHenKhamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("GioiTinh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("HoTen")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid?>("LoaiKhamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LyDoKham")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("NgayHenKham")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("NguoiDungID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PhongKhamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ThongTinHenKhamID");

                    b.HasIndex("LoaiKhamID");

                    b.HasIndex("NguoiDungID");

                    b.HasIndex("PhongKhamID");

                    b.ToTable("ThongTinHenKham", (string)null);

                    b.HasData(
                        new
                        {
                            ThongTinHenKhamID = new Guid("f3b13375-a169-4b8f-98cd-65530263ec5e"),
                            DiaChi = "Hà Nội",
                            GioiTinh = "Nam",
                            HoTen = "Nguyen Van A",
                            NgayHenKham = new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NgaySinh = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0123456789",
                            TrangThai = 0
                        },
                        new
                        {
                            ThongTinHenKhamID = new Guid("adfd63c2-e393-485a-b1d5-02298a82826e"),
                            DiaChi = "Bình Thuận",
                            GioiTinh = "Nam",
                            HoTen = "Nguyen Van B",
                            NgayHenKham = new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NgaySinh = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0123456789",
                            TrangThai = 0
                        },
                        new
                        {
                            ThongTinHenKhamID = new Guid("4cbd6010-45ce-4c7b-9947-98e7b92cb2f6"),
                            DiaChi = "Tp HCM",
                            GioiTinh = "Nam",
                            HoTen = "Nguyen Van C",
                            NgayHenKham = new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NgaySinh = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0123456789",
                            TrangThai = 0
                        });
                });

            modelBuilder.Entity("QLHK_Webapp.Models.ThongTinHenKham", b =>
                {
                    b.HasOne("QLHK_Webapp.Models.LoaiKham", "LoaiKham")
                        .WithMany()
                        .HasForeignKey("LoaiKhamID");

                    b.HasOne("QLHK_Webapp.Models.NguoiDung", "NguoiDung")
                        .WithMany("ThongTinHenKhams")
                        .HasForeignKey("NguoiDungID");

                    b.HasOne("QLHK_Webapp.Models.PhongKham", "PhongKham")
                        .WithMany()
                        .HasForeignKey("PhongKhamID");

                    b.Navigation("LoaiKham");

                    b.Navigation("NguoiDung");

                    b.Navigation("PhongKham");
                });

            modelBuilder.Entity("QLHK_Webapp.Models.NguoiDung", b =>
                {
                    b.Navigation("ThongTinHenKhams");
                });
#pragma warning restore 612, 618
        }
    }
}
