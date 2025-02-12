﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLHK_Webapp.Models;

#nullable disable

namespace QLHK_Webapp.Migrations
{
    [DbContext(typeof(DangKyKhamDbContext))]
    [Migration("20250211090328_Them_ThongTin_NguoiDung")]
    partial class Them_ThongTin_NguoiDung
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PhongKhamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ThongTinHenKhamID");

                    b.HasIndex("LoaiKhamID");

                    b.HasIndex("NguoiDungID");

                    b.HasIndex("PhongKhamID");

                    b.ToTable("ThongTinHenKham", (string)null);
                });

            modelBuilder.Entity("QLHK_Webapp.Models.ThongTinHenKham", b =>
                {
                    b.HasOne("QLHK_Webapp.Models.LoaiKham", "LoaiKham")
                        .WithMany()
                        .HasForeignKey("LoaiKhamID");

                    b.HasOne("QLHK_Webapp.Models.NguoiDung", "NguoiDung")
                        .WithMany("ThongTinHenKham")
                        .HasForeignKey("NguoiDungID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLHK_Webapp.Models.PhongKham", "PhongKham")
                        .WithMany()
                        .HasForeignKey("PhongKhamID");

                    b.Navigation("LoaiKham");

                    b.Navigation("NguoiDung");

                    b.Navigation("PhongKham");
                });

            modelBuilder.Entity("QLHK_Webapp.Models.NguoiDung", b =>
                {
                    b.Navigation("ThongTinHenKham");
                });
#pragma warning restore 612, 618
        }
    }
}
