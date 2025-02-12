using System.ComponentModel.DataAnnotations;

namespace QLHK_Webapp.Models
{
    public class LoaiKham
    {
        [Key]
        public Guid LoaiKhamID { get; set; }

        [StringLength(100)]
        public string? TenLoaiKham { get; set; }
    }
}
