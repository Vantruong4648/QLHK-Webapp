using QLHK_Webapp.DTO;
using QLHK_Webapp.Helpers;
using QLHK_Webapp.IServices;
using QLHK_Webapp.Models;

namespace QLHK_Webapp.Services
{
    public class ThongTinHenKhamService : IThongTinHenKhamService
    {
        private readonly DangKyKhamDbContext _db;
        
        public ThongTinHenKhamService(DangKyKhamDbContext db)
        {
            _db = db;
        }

        public async Task<ThongTinHenKhamResponse?> ThemThongTinHenKham(ThongTinHenKhamRequest? thongTinHenKhamRequest)
        {
            if(thongTinHenKhamRequest == null)
            {
                throw new ArgumentNullException(nameof(thongTinHenKhamRequest));
            }
            ValidationHelper.ModelValidation(thongTinHenKhamRequest);

            ThongTinHenKham thongTinHenKham = thongTinHenKhamRequest.ToThongTinHenKham();

            thongTinHenKham.ThongTinHenKhamID = Guid.NewGuid();
            _db.ThongTinHenKhams.Add(thongTinHenKham);
            await _db.SaveChangesAsync();
            return thongTinHenKham.ToThongTinHenKhamResponse();
        }
    }
}
