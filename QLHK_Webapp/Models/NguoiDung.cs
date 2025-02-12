using System.ComponentModel.DataAnnotations;

namespace QLHK_Webapp.Models
{
    public class NguoiDung
    {
        [Key]
        public Guid NguoiDungID { get; set; }

        [StringLength(40)]
        public string? HoTen { get; set; }

        [StringLength(15)]
        public string? SoDienThoai { get; set; }

        [StringLength(100)]
        public string? MatKhau { get; set; }

        [StringLength(200)]
        public string? DiaChi { get; set; }

        public virtual ICollection<ThongTinHenKham>? ThongTinHenKhams { get; set; }

    }
}
