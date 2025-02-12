using QLHK_Webapp.Models;
using System.ComponentModel.DataAnnotations;

namespace QLHK_Webapp.DTO
{
    public class DangKyRequest
    {
        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string? HoTen { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Số điện thoại chỉ được chứa số")]
        public string? SoDienThoai { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập mật khẩu")]
        public string? MatKhau { get; set; }

        [Required(ErrorMessage = "Vui lòng xác nhận mật khẩu")]
        [Compare("MatKhau", ErrorMessage = "Mật khẩu không khớp")]
        public string? XacNhanMatKhau { get; set; }

        public string? DiaChi { get; set; }

        public NguoiDung ToNguoiDung()
        {
            return new NguoiDung
            {
                HoTen = HoTen,
                SoDienThoai = SoDienThoai,
                MatKhau = MatKhau,
                DiaChi = DiaChi
            };
        }
    }
}
