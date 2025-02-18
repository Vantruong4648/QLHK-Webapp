using QLHK_Webapp.Models;

namespace QLHK_Webapp.DTO
{
    public class LoaiKhamResponse
    {
        public Guid LoaiKhamID { get; set; }
        public string? TenLoaiKham { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj == null) return false;
            if (obj.GetType() != typeof(LoaiKhamResponse)) return false;
            LoaiKhamResponse other = (LoaiKhamResponse)obj;

            return this.LoaiKhamID == other.LoaiKhamID && this.TenLoaiKham == other.TenLoaiKham;
        }

        public override int GetHashCode()
        {
           return base.GetHashCode();
        }
    }

    public static class LoaiKhamExtension
    {
        public static LoaiKhamResponse ToLoaiKhamResponse(this LoaiKham loaiKham)
        {
            return new LoaiKhamResponse
            {
                LoaiKhamID = loaiKham.LoaiKhamID,
                TenLoaiKham = loaiKham.TenLoaiKham
            };
        }
    }
}
