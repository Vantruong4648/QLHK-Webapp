using QLHK_Webapp.DTO;

namespace QLHK_Webapp.IServices
{
    public interface ILoaiKhamService
    {
        Task<List<LoaiKhamResponse>> LayTatCaLoaiKham();
    }
}
