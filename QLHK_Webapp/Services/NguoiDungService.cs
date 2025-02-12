using Microsoft.EntityFrameworkCore;
using QLHK_Webapp.DTO;
using QLHK_Webapp.Helpers;
using QLHK_Webapp.IServices;
using QLHK_Webapp.Models;

namespace QLHK_Webapp.Services
{
    public class NguoiDungService : INguoiDungService
    {
        private readonly DangKyKhamDbContext _db;

        public NguoiDungService(DangKyKhamDbContext db)
        {
            _db = db;
        }

        public async Task<NguoiDungResponse?> DangKyMoi(DangKyRequest? dangkyRequest)
        {
            if(dangkyRequest == null)
            {
                throw new ArgumentNullException(nameof(dangkyRequest));
            }
            ValidationHelper.ModelValidation(dangkyRequest);

            NguoiDung nguoidung =  dangkyRequest.ToNguoiDung();

            nguoidung.NguoiDungID = Guid.NewGuid();
            _db.NguoiDungs.Add(nguoidung);
            await _db.SaveChangesAsync();
            return nguoidung.ToDangKyResponse();
        }

        public async Task<NguoiDungResponse?> DangNhap(DangNhapRequest? dangNhapRequest)
        {
            if (dangNhapRequest == null)
            {
                throw new ArgumentNullException(nameof(dangNhapRequest));
            }
            ValidationHelper.ModelValidation(dangNhapRequest);
            NguoiDung? nguoidung = await _db.NguoiDungs.FirstOrDefaultAsync(x => x.SoDienThoai == dangNhapRequest.SoDienThoai && x.MatKhau == dangNhapRequest.MatKhau);
            if (nguoidung != null)
            {
                return nguoidung.ToDangKyResponse();
            }
            else
            {
                return null;
            }
        }

        public async Task<NguoiDungResponse?> LayNguoiDungTheoID(Guid? nguoiDungID)
        {
            if (nguoiDungID == null)
                return null;
            NguoiDung? nguoidung = await _db.NguoiDungs.FirstOrDefaultAsync(x => x.NguoiDungID == nguoiDungID);

            if (nguoidung == null)
                return null;
            return nguoidung.ToNguoiDungResponse();
        }
    }
}
