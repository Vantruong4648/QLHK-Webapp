using QLHK_Webapp.Models;
using System.ComponentModel.DataAnnotations;

namespace QLHK_Webapp.DTO
{
    public class ThongTinHenKhamUpdateRequest
    {
        [Required(ErrorMessage = "Thông tin hẹn khám ID không thể trống")]
        public Guid? ThongTinHenKhamID { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string? HoTen { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Số điện thoại chỉ được chứa số")]
        public string? SoDienThoai { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]
        public DateTime? NgaySinh { get; set; }
        public string? GioiTinh { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string? DiaChi { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn ngày hẹn khám")]
        public DateTime? NgayHenKham { get; set; }
        public string? LyDoKham { get; set; }
        public Guid? LoaiKhamID { get; set; }
        public string? LoaiKham { get; set; }
        public virtual Guid? PhongKhamID { get; set; }
        public string? PhongKham { get; set; }

        public int? TrangThai { get; set; } = 0;

        public Guid? NguoiDungID { get; set; }

        public ThongTinHenKham ToThongTinHenKham()
        {
            return new ThongTinHenKham
            {
                ThongTinHenKhamID = ThongTinHenKhamID ?? Guid.Empty,
                HoTen = HoTen,
                SoDienThoai = SoDienThoai,
                NgaySinh = NgaySinh,
                GioiTinh = GioiTinh,
                DiaChi = DiaChi,
                NgayHenKham = NgayHenKham,
                LyDoKham = LyDoKham,
                LoaiKhamID = LoaiKhamID == Guid.Empty ? null : LoaiKhamID,
                PhongKhamID = PhongKhamID == Guid.Empty ? null : PhongKhamID,
                TrangThai = TrangThai,
                NguoiDungID = NguoiDungID,
            };
        }
    }
}
