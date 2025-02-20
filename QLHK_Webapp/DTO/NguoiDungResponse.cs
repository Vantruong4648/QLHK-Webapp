using QLHK_Webapp.Models;

namespace QLHK_Webapp.DTO
{
    public class NguoiDungResponse
    {
        public Guid NguoiDungID { get; set; }
        public string? HoTen { get; set; }
        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }

        public ICollection<ThongTinHenKham>? ThongTinHenKhams { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(NguoiDungResponse)) return false;

            NguoiDungResponse dangky = (NguoiDungResponse)obj;
            return this.NguoiDungID == dangky.NguoiDungID && this.HoTen == dangky.HoTen && this.SoDienThoai == dangky.SoDienThoai && this.DiaChi == dangky.DiaChi;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

    public static class NguoiDungExtension
    {
        public static NguoiDungResponse ToNguoiDungShortResponse(this NguoiDung nguoidung)
        {
            return new NguoiDungResponse
            {
                NguoiDungID = nguoidung.NguoiDungID,
                HoTen = nguoidung.HoTen,
                SoDienThoai = nguoidung.SoDienThoai,
                DiaChi = nguoidung.DiaChi
            };
        }

        public static NguoiDungResponse ToNguoiDungResponse(this NguoiDung nguoidung)
        {
            return new NguoiDungResponse
            {
                NguoiDungID = nguoidung.NguoiDungID,
                HoTen = nguoidung.HoTen,
                SoDienThoai = nguoidung.SoDienThoai,
                DiaChi = nguoidung.DiaChi,
                ThongTinHenKhams = nguoidung.ThongTinHenKhams,
            };
        }
    }
}
