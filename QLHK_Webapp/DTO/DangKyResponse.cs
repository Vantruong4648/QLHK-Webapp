using QLHK_Webapp.Models;

namespace QLHK_Webapp.DTO
{
    public class DangKyResponse
    {
        public Guid NguoiDungID { get; set; }
        public string? HoTen { get; set; }
        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(DangKyResponse)) return false;

            DangKyResponse dangky = (DangKyResponse)obj;
            return this.NguoiDungID == dangky.NguoiDungID && this.HoTen == dangky.HoTen && this.SoDienThoai == dangky.SoDienThoai && this.DiaChi == dangky.DiaChi;
        }
    }

    public static class DangKyExtension
    {
        public static DangKyResponse ToDangKyResponse(this NguoiDung nguoidung)
        {
            return new DangKyResponse
            {
                NguoiDungID = nguoidung.NguoiDungID,
                HoTen = nguoidung.HoTen,
                SoDienThoai = nguoidung.SoDienThoai,
                DiaChi = nguoidung.DiaChi
            };
        }
    }
}
