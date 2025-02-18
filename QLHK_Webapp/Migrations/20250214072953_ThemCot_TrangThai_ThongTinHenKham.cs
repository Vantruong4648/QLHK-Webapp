using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLHK_Webapp.Migrations
{
    public partial class ThemCot_TrangThai_ThongTinHenKham : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("11e84f0b-456f-4862-aa7e-b71860797235"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("3095d451-a6a4-4050-ba51-5ad1ec722ecc"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("79578e72-132e-4d10-9454-92c87cb57fec"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("b9eb68f1-3795-417d-9010-dd580d5c41f6"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("d18dca48-2b95-4ecf-a27b-e76ec2174206"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("d35b3a72-9024-4721-bacb-f95315405e3c"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("16051c25-9886-44ce-b495-b415f5ecf07c"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("319c86e3-036e-41db-9458-fb5323932442"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("70ab970c-f075-4048-879e-7a403ede0e58"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("70e80be9-7302-44e9-9d50-78ffba9d2e21"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("e320ce8f-8fd7-4aae-95d2-54b2be87ae0d"));

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "ThongTinHenKham",
                type: "int",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "ThongTinHenKham");

            migrationBuilder.InsertData(
                table: "LoaiKham",
                columns: new[] { "LoaiKhamID", "TenLoaiKham" },
                values: new object[,]
                {
                    { new Guid("11e84f0b-456f-4862-aa7e-b71860797235"), "Khám ngoại" },
                    { new Guid("3095d451-a6a4-4050-ba51-5ad1ec722ecc"), "Khám nhi" },
                    { new Guid("79578e72-132e-4d10-9454-92c87cb57fec"), "Khám chuyên khoa" },
                    { new Guid("b9eb68f1-3795-417d-9010-dd580d5c41f6"), "Khám sản" },
                    { new Guid("d18dca48-2b95-4ecf-a27b-e76ec2174206"), "Khám nội" },
                    { new Guid("d35b3a72-9024-4721-bacb-f95315405e3c"), "Khám tổng quát" }
                });

            migrationBuilder.InsertData(
                table: "PhongKham",
                columns: new[] { "PhongKhamID", "TenPhongKham" },
                values: new object[,]
                {
                    { new Guid("16051c25-9886-44ce-b495-b415f5ecf07c"), "Phòng khám 3" },
                    { new Guid("319c86e3-036e-41db-9458-fb5323932442"), "Phòng khám 4" },
                    { new Guid("70ab970c-f075-4048-879e-7a403ede0e58"), "Phòng khám 5" },
                    { new Guid("70e80be9-7302-44e9-9d50-78ffba9d2e21"), "Phòng khám 2" },
                    { new Guid("e320ce8f-8fd7-4aae-95d2-54b2be87ae0d"), "Phòng khám 1" }
                });
        }
    }
}
