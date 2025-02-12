using QLHK_Webapp.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLHK_Webapp.DTO
{
    public class ThongTinHenKhamResponse
    {
        public Guid ThongTinHenKhamID { get; set; }
        public string? HoTen { get; set; }

        public string? SoDienThoai { get; set; }
        public DateTime? NgaySinh { get; set; }

        public string? GioiTinh { get; set; }
        public string? DiaChi { get; set; }
        public DateTime? NgayHenKham { get; set; }

        public string? LyDoKham { get; set; }

        public Guid? LoaiKhamID { get; set; }

        public string? LoaiKham { get; set; }

        public Guid? PhongKhamID { get; set; }

        public string? PhongKham { get; set; }

        public Guid? NguoiDungID { get; set; }

        public string? NguoiDung { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(ThongTinHenKhamResponse)) return false;
            ThongTinHenKhamResponse thongtinhenkham = (ThongTinHenKhamResponse)obj;
            return this.ThongTinHenKhamID == thongtinhenkham.ThongTinHenKhamID &&
                this.HoTen == thongtinhenkham.HoTen &&
                this.SoDienThoai == thongtinhenkham.SoDienThoai &&
                this.NgaySinh == thongtinhenkham.NgaySinh &&
                this.GioiTinh == thongtinhenkham.GioiTinh &&
                this.DiaChi == thongtinhenkham.DiaChi &&
                this.NgayHenKham == thongtinhenkham.NgayHenKham &&
                this.LyDoKham == thongtinhenkham.LyDoKham &&
                this.LoaiKhamID == thongtinhenkham.LoaiKhamID &&
                this.PhongKhamID == thongtinhenkham.PhongKhamID &&
                this.NguoiDungID == thongtinhenkham.NguoiDungID;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public static class ThongTinHenKhamExtension
    {
        public static ThongTinHenKhamResponse ToThongTinHenKhamResponse(this ThongTinHenKham thongtinhenkham)
        {
            return new ThongTinHenKhamResponse
            {
                ThongTinHenKhamID = thongtinhenkham.ThongTinHenKhamID,
                HoTen = thongtinhenkham.HoTen,
                SoDienThoai = thongtinhenkham.SoDienThoai,
                NgaySinh = thongtinhenkham.NgaySinh,
                GioiTinh = thongtinhenkham.GioiTinh,
                DiaChi = thongtinhenkham.DiaChi,
                NgayHenKham = thongtinhenkham.NgayHenKham,
                LyDoKham = thongtinhenkham.LyDoKham,
                LoaiKhamID = thongtinhenkham.LoaiKhamID,
                LoaiKham = thongtinhenkham.LoaiKham?.TenLoaiKham,
                PhongKhamID = thongtinhenkham.PhongKhamID,
                PhongKham = thongtinhenkham.PhongKham?.TenPhongKham,
                NguoiDungID = thongtinhenkham.NguoiDungID,
                NguoiDung = thongtinhenkham.NguoiDung?.HoTen
            };
        }
    }
}
