using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLHK_Webapp.Migrations
{
    public partial class ThemCacBang_Thongtin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiKham",
                columns: table => new
                {
                    LoaiKhamID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoaiKham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiKham", x => x.LoaiKhamID);
                });

            migrationBuilder.CreateTable(
                name: "PhongKham",
                columns: table => new
                {
                    PhongKhamID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenPhongKham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongKham", x => x.PhongKhamID);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinHenKham",
                columns: table => new
                {
                    ThongTinHenKhamID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayHenKham = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LyDoKham = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LoaiKhamID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhongKhamID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NguoiDungID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinHenKham", x => x.ThongTinHenKhamID);
                    table.ForeignKey(
                        name: "FK_ThongTinHenKham_LoaiKham_LoaiKhamID",
                        column: x => x.LoaiKhamID,
                        principalTable: "LoaiKham",
                        principalColumn: "LoaiKhamID");
                    table.ForeignKey(
                        name: "FK_ThongTinHenKham_NguoiDung_NguoiDungID",
                        column: x => x.NguoiDungID,
                        principalTable: "NguoiDung",
                        principalColumn: "NguoiDungID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThongTinHenKham_PhongKham_PhongKhamID",
                        column: x => x.PhongKhamID,
                        principalTable: "PhongKham",
                        principalColumn: "PhongKhamID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinHenKham_LoaiKhamID",
                table: "ThongTinHenKham",
                column: "LoaiKhamID");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinHenKham_NguoiDungID",
                table: "ThongTinHenKham",
                column: "NguoiDungID");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinHenKham_PhongKhamID",
                table: "ThongTinHenKham",
                column: "PhongKhamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThongTinHenKham");

            migrationBuilder.DropTable(
                name: "LoaiKham");

            migrationBuilder.DropTable(
                name: "PhongKham");
        }
    }
}
