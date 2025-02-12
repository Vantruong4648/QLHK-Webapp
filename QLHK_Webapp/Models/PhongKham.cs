using System.ComponentModel.DataAnnotations;

namespace QLHK_Webapp.Models
{
    public class PhongKham
    {
        [Key]
        public Guid PhongKhamID { get; set; }

        [StringLength(100)]
        public string? TenPhongKham { get; set; }
    }
}
