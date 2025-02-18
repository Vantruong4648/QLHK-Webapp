using QLHK_Webapp.DTO;
using QLHK_Webapp.Helpers;

namespace QLHK_Webapp.IServices
{
    public interface IThongTinHenKhamService
    {
        Task<ThongTinHenKhamResponse> ThemThongTinHenKham(ThongTinHenKhamRequest? tinHenKhamRequest);

        Task<List<ThongTinHenKhamResponse>> LayTatCaThongTinHenKham();

        Task<List<ThongTinHenKhamResponse>> TimThongTinHenKham(string searchBy, string? searchString);

        Task<List<ThongTinHenKhamResponse>> SapXepThongTinHenKham(List<ThongTinHenKhamResponse> dsThongTin, string sortBy, SortOrderOptions sortOrder);

        Task<ThongTinHenKhamResponse> CapNhatThongTinHenKham(ThongTinHenKhamUpdateRequest? thongTinHenKhamUpdateRequest);

        Task<ThongTinHenKhamResponse?> LayThongTinHenKhamTheoID(Guid? ThongTinHenKhamID);

        Task<bool> CapNhatThongTinTrangThai(Guid ThongTinHenKhamID, int TrangThai);
    }
}
