using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLHK_Webapp.Migrations
{
    public partial class update_thongtinhenkhams_totbale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("36861796-49eb-40f3-b86e-d19ad39c9aee"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("583755c9-eac2-490a-a2e7-c380999ab9c8"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("7a252733-80a0-4a0f-a4ed-a153c05f878e"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("af26c93b-9a7c-4681-a5c4-7a65a075bab5"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("b41b0c03-d821-4157-8cd5-4c56d8449ad3"));

            migrationBuilder.DeleteData(
                table: "LoaiKham",
                keyColumn: "LoaiKhamID",
                keyValue: new Guid("be37ff91-5eac-4114-b0f4-f71c8fa95ae1"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("14e571b9-0bda-489f-9ed4-676776b5b2cd"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("29d4cd6a-5397-44d8-ad78-c20c9988cf2f"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("3c68b14c-d37a-4fd2-a949-5a047d0eac4f"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("4b5fa363-a0cb-4169-9cf8-c6bd0f16d1ae"));

            migrationBuilder.DeleteData(
                table: "PhongKham",
                keyColumn: "PhongKhamID",
                keyValue: new Guid("e6d4453a-21cd-4ffb-9d4e-9f635924b220"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "LoaiKham",
                columns: new[] { "LoaiKhamID", "TenLoaiKham" },
                values: new object[,]
                {
                    { new Guid("36861796-49eb-40f3-b86e-d19ad39c9aee"), "Khám nhi" },
                    { new Guid("583755c9-eac2-490a-a2e7-c380999ab9c8"), "Khám tổng quát" },
                    { new Guid("7a252733-80a0-4a0f-a4ed-a153c05f878e"), "Khám ngoại" },
                    { new Guid("af26c93b-9a7c-4681-a5c4-7a65a075bab5"), "Khám sản" },
                    { new Guid("b41b0c03-d821-4157-8cd5-4c56d8449ad3"), "Khám chuyên khoa" },
                    { new Guid("be37ff91-5eac-4114-b0f4-f71c8fa95ae1"), "Khám nội" }
                });

            migrationBuilder.InsertData(
                table: "PhongKham",
                columns: new[] { "PhongKhamID", "TenPhongKham" },
                values: new object[,]
                {
                    { new Guid("14e571b9-0bda-489f-9ed4-676776b5b2cd"), "Phòng khám 4" },
                    { new Guid("29d4cd6a-5397-44d8-ad78-c20c9988cf2f"), "Phòng khám 5" },
                    { new Guid("3c68b14c-d37a-4fd2-a949-5a047d0eac4f"), "Phòng khám 3" },
                    { new Guid("4b5fa363-a0cb-4169-9cf8-c6bd0f16d1ae"), "Phòng khám 1" },
                    { new Guid("e6d4453a-21cd-4ffb-9d4e-9f635924b220"), "Phòng khám 2" }
                });
        }
    }
}
