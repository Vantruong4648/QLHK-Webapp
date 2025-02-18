using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLHK_Webapp.Migrations
{
    public partial class update_key_nguoidung_thongtinhk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinHenKham_NguoiDung_NguoiDungID",
                table: "ThongTinHenKham");

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("35c60cc6-4e4c-464f-8a8d-c00513e6edb2"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("8f8b6667-8bb5-404d-89ce-ce065d29987d"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("b798975f-2980-491c-b63f-181c4cc439bc"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("bb86bd6b-1231-48cb-98e8-d5579623d6c1"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("cd7b8bb1-467a-4de9-a983-cb1ed1090ac1"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("e4943923-95f5-4efa-9c7c-24d2174cf68e"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("50ca55f1-3523-45cc-84e0-9769bcf5ea5f"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("73bb3420-9a44-408e-9bcb-19f45114c0a0"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("e39b27d6-127b-446b-8458-c70e485ec2ec"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("edd30b1c-c233-4a97-b359-a68bd7ac3864"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("fbd97991-4a00-4e80-9fe7-5a01c75823c4"));

            migrationBuilder.AlterColumn<Guid>(
                name: "NguoiDungID",
                table: "ThongTinHenKham",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "LoaiKham",
                columns: new[] { "LoaiKhamID", "TenLoaiKham" },
                values: new object[,]
                {
                    { new Guid("01de28b9-4c60-4e32-b778-e9601c903a09"), "Khám chuyên khoa" },
                    { new Guid("0295f7b6-e1f2-4280-a75d-71d81bc95b26"), "Khám sản" },
                    { new Guid("55d1015c-8b4f-4836-a383-8e7d7713a870"), "Khám nội" },
                    { new Guid("8ce53862-5b2a-437d-a1e4-3e809b4aca23"), "Khám nhi" },
                    { new Guid("ab5d63af-f747-46ba-8e09-f81517402852"), "Khám tổng quát" },
                    { new Guid("f245fe01-8051-40b5-b964-f680a2e2a6be"), "Khám ngoại" }
                });

            migrationBuilder.InsertData(
                table: "PhongKham",
                columns: new[] { "PhongKhamID", "TenPhongKham" },
                values: new object[,]
                {
                    { new Guid("c3b11d8c-207a-4062-a745-c05f16d20c9f"), "Phòng khám 4" },
                    { new Guid("cfa33b60-bb94-4890-b98e-3aa33d4b8b81"), "Phòng khám 5" },
                    { new Guid("d96fb04d-b207-4e49-972b-255222a83f57"), "Phòng khám 1" },
                    { new Guid("e3f1bf20-87fe-48f8-b5d3-e089b98cf730"), "Phòng khám 2" },
                    { new Guid("fa9e6f4b-a6ea-4af9-9714-e4eb6c5b64d9"), "Phòng khám 3" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinHenKham_NguoiDung_NguoiDungID",
                table: "ThongTinHenKham",
                column: "NguoiDungID",
                principalTable: "NguoiDung",
                principalColumn: "NguoiDungID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinHenKham_NguoiDung_NguoiDungID",
                table: "ThongTinHenKham");

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("01de28b9-4c60-4e32-b778-e9601c903a09"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("0295f7b6-e1f2-4280-a75d-71d81bc95b26"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("55d1015c-8b4f-4836-a383-8e7d7713a870"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("8ce53862-5b2a-437d-a1e4-3e809b4aca23"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("ab5d63af-f747-46ba-8e09-f81517402852"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("f245fe01-8051-40b5-b964-f680a2e2a6be"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("c3b11d8c-207a-4062-a745-c05f16d20c9f"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("cfa33b60-bb94-4890-b98e-3aa33d4b8b81"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("d96fb04d-b207-4e49-972b-255222a83f57"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("e3f1bf20-87fe-48f8-b5d3-e089b98cf730"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("fa9e6f4b-a6ea-4af9-9714-e4eb6c5b64d9"));

            migrationBuilder.AlterColumn<Guid>(
                name: "NguoiDungID",
                table: "ThongTinHenKham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "LoaiKham",
                columns: new[] { "LoaiKhamID", "TenLoaiKham" },
                values: new object[,]
                {
                    { new Guid("35c60cc6-4e4c-464f-8a8d-c00513e6edb2"), "Khám chuyên khoa" },
                    { new Guid("8f8b6667-8bb5-404d-89ce-ce065d29987d"), "Khám nhi" },
                    { new Guid("b798975f-2980-491c-b63f-181c4cc439bc"), "Khám tổng quát" },
                    { new Guid("bb86bd6b-1231-48cb-98e8-d5579623d6c1"), "Khám nội" },
                    { new Guid("cd7b8bb1-467a-4de9-a983-cb1ed1090ac1"), "Khám sản" },
                    { new Guid("e4943923-95f5-4efa-9c7c-24d2174cf68e"), "Khám ngoại" }
                });

            migrationBuilder.InsertData(
                table: "PhongKham",
                columns: new[] { "PhongKhamID", "TenPhongKham" },
                values: new object[,]
                {
                    { new Guid("50ca55f1-3523-45cc-84e0-9769bcf5ea5f"), "Phòng khám 3" },
                    { new Guid("73bb3420-9a44-408e-9bcb-19f45114c0a0"), "Phòng khám 1" },
                    { new Guid("e39b27d6-127b-446b-8458-c70e485ec2ec"), "Phòng khám 4" },
                    { new Guid("edd30b1c-c233-4a97-b359-a68bd7ac3864"), "Phòng khám 2" },
                    { new Guid("fbd97991-4a00-4e80-9fe7-5a01c75823c4"), "Phòng khám 5" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinHenKham_NguoiDung_NguoiDungID",
                table: "ThongTinHenKham",
                column: "NguoiDungID",
                principalTable: "NguoiDung",
                principalColumn: "NguoiDungID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
