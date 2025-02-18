using QLHK_Webapp.DTO;
using QLHK_Webapp.Models;

namespace QLHK_Webapp.IServices
{
    public interface IPhongKhamService
    {
        Task<List<PhongKhamResponse>> LayTatCaPhongKham();
    }
}
