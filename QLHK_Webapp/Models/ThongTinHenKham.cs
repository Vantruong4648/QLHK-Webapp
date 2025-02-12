using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHK_Webapp.Models
{
    public class ThongTinHenKham
    {
        [Key]
        public Guid ThongTinHenKhamID { get; set; }

        [StringLength(200)]
        public string? HoTen { get; set; }

        [StringLength(15)]
        public string? SoDienThoai { get; set; }
        public DateTime? NgaySinh { get; set; }

        [StringLength(10)]
        public string? GioiTinh { get; set; }

        [StringLength(200)]
        public string? DiaChi { get; set; }
        public DateTime? NgayHenKham { get; set; }

        [StringLength(200)]
        public string? LyDoKham { get; set; }

        public  Guid? LoaiKhamID { get; set; }

        [ForeignKey("LoaiKhamID")]
        public virtual LoaiKham? LoaiKham { get; set; }

        public virtual Guid? PhongKhamID { get; set; }

        [ForeignKey("PhongKhamID")]
        public virtual PhongKham? PhongKham { get; set; }

        public Guid? NguoiDungID { get; set; }

        [ForeignKey("NguoiDungID")]
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
