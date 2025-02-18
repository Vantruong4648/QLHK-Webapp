using Microsoft.EntityFrameworkCore;
using QLHK_Webapp.DTO;
using QLHK_Webapp.IServices;
using QLHK_Webapp.Models;

namespace QLHK_Webapp.Services
{
    public class PhongKhamService : IPhongKhamService
    {
        private readonly DangKyKhamDbContext _db;

        public PhongKhamService(DangKyKhamDbContext db)
        {
            _db = db;
        }
        public async Task<List<PhongKhamResponse>> LayTatCaPhongKham()
        {
            return await _db.PhongKhams.Select(phongkham => phongkham.ToPhongKhamResponse()).ToListAsync();
        }
    }
}
