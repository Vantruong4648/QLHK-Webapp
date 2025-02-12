using System.ComponentModel.DataAnnotations;

namespace QLHK_Webapp.DTO
{
    public class DangNhapRequest
    {
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        public string? SoDienThoai { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string? MatKhau { get; set; }
    }
}
