using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLHK_Webapp.Migrations
{
    public partial class CapNhat_SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
