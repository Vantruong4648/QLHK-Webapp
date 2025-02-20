using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLHK_Webapp.Migrations
{
    public partial class capnhat_dulieumau : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "NguoiDung",
                columns: new[] { "NguoiDungID", "DiaChi", "HoTen", "MatKhau", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("4cbd6010-45ce-4c7b-9947-98e7b92cb2f6"), "Tp HCM", "Nguyen Van C", "123456", "0123456789" },
                    { new Guid("adfd63c2-e393-485a-b1d5-02298a82826e"), "Bình Thuận", "Nguyen Van B", "123456", "0123456789" },
                    { new Guid("f3b13375-a169-4b8f-98cd-65530263ec5e"), "Hà Nội", "Nguyen Van A", "123456", "0123456789" }
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

            migrationBuilder.InsertData(
                table: "ThongTinHenKham",
                columns: new[] { "ThongTinHenKhamID", "DiaChi", "GioiTinh", "HoTen", "LoaiKhamID", "LyDoKham", "NgayHenKham", "NgaySinh", "NguoiDungID", "PhongKhamID", "SoDienThoai", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("4cbd6010-45ce-4c7b-9947-98e7b92cb2f6"), "Tp HCM", "Nam", "Nguyen Van C", null, null, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "0123456789", 0 },
                    { new Guid("adfd63c2-e393-485a-b1d5-02298a82826e"), "Bình Thuận", "Nam", "Nguyen Van B", null, null, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "0123456789", 0 },
                    { new Guid("f3b13375-a169-4b8f-98cd-65530263ec5e"), "Hà Nội", "Nam", "Nguyen Van A", null, null, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "0123456789", 0 }
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
                table: "NguoiDung",
                keyColumn: "NguoiDungID",
                keyValue: new Guid("4cbd6010-45ce-4c7b-9947-98e7b92cb2f6"));

            migrationBuilder.DeleteData(
                table: "NguoiDung",
                keyColumn: "NguoiDungID",
                keyValue: new Guid("adfd63c2-e393-485a-b1d5-02298a82826e"));

            migrationBuilder.DeleteData(
                table: "NguoiDung",
                keyColumn: "NguoiDungID",
                keyValue: new Guid("f3b13375-a169-4b8f-98cd-65530263ec5e"));

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

            migrationBuilder.DeleteData(
                table: "ThongTinHenKham",
                keyColumn: "ThongTinHenKhamID",
                keyValue: new Guid("4cbd6010-45ce-4c7b-9947-98e7b92cb2f6"));

            migrationBuilder.DeleteData(
                table: "ThongTinHenKham",
                keyColumn: "ThongTinHenKhamID",
                keyValue: new Guid("adfd63c2-e393-485a-b1d5-02298a82826e"));

            migrationBuilder.DeleteData(
                table: "ThongTinHenKham",
                keyColumn: "ThongTinHenKhamID",
                keyValue: new Guid("f3b13375-a169-4b8f-98cd-65530263ec5e"));

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
        }
    }
}
