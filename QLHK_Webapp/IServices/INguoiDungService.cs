using QLHK_Webapp.DTO;

namespace QLHK_Webapp.IServices
{
    public interface INguoiDungService
    {
        Task<NguoiDungResponse?> DangKyMoi(DangKyRequest? dangkyRequest);

        Task<NguoiDungResponse?> DangNhap(DangNhapRequest? dangNhapRequest);

        Task<NguoiDungResponse?> LayNguoiDungTheoID(Guid? nguoiDungID);
    }
}
