using QLHK_Webapp.DTO;

namespace QLHK_Webapp.IServices
{
    public interface IThongTinHenKhamService
    {
        Task<ThongTinHenKhamResponse?> ThemThongTinHenKham(ThongTinHenKhamRequest? tinHenKhamRequest);
    }
}
