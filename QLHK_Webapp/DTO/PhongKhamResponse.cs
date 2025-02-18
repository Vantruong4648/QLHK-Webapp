using QLHK_Webapp.Models;

namespace QLHK_Webapp.DTO
{
    public class PhongKhamResponse
    {
        public Guid PhongKhamID { get; set; }
        public string? TenPhongKham { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(PhongKhamResponse)) return false;
            PhongKhamResponse other = (PhongKhamResponse)obj;
            return this.PhongKhamID == other.PhongKhamID && this.TenPhongKham == other.TenPhongKham;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public static class PhongKhamExtension
    {
        public static PhongKhamResponse ToPhongKhamResponse(this PhongKham phongKham)
        {
            return new PhongKhamResponse
            {
                PhongKhamID = phongKham.PhongKhamID,
                TenPhongKham = phongKham.TenPhongKham
            };
        }
    }
}
