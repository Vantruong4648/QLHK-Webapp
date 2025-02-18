using Microsoft.EntityFrameworkCore;
using QLHK_Webapp.DTO;
using QLHK_Webapp.IServices;
using QLHK_Webapp.Models;

namespace QLHK_Webapp.Services
{
    public class LoaiKhamService : ILoaiKhamService
    {
        private readonly DangKyKhamDbContext _db;

        public LoaiKhamService(DangKyKhamDbContext db)
        {
            _db = db;
        }
        public async Task<List<LoaiKhamResponse>> LayTatCaLoaiKham()
        {
            return await _db.LoaiKhams.Select(x => x.ToLoaiKhamResponse()).ToListAsync();
        }
    }
}
