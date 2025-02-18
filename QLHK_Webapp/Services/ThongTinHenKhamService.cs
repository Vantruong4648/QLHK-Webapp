using Microsoft.EntityFrameworkCore;
using QLHK_Webapp.DTO;
using QLHK_Webapp.Helpers;
using QLHK_Webapp.IServices;
using QLHK_Webapp.Models;
using System.Reflection.Metadata.Ecma335;

namespace QLHK_Webapp.Services
{
    public class ThongTinHenKhamService : IThongTinHenKhamService
    {
        private readonly DangKyKhamDbContext _db;
        
        public ThongTinHenKhamService(DangKyKhamDbContext db)
        {
            _db = db;
        }

        public async Task<ThongTinHenKhamResponse> CapNhatThongTinHenKham(ThongTinHenKhamUpdateRequest? thongTinHenKhamUpdateRequest)
        {
            if(thongTinHenKhamUpdateRequest == null)
            {
                throw new ArgumentNullException(nameof(ThongTinHenKham));
            }

            //kiem tra thong tin
            ValidationHelper.ModelValidation(thongTinHenKhamUpdateRequest);

            //lay thong tin hen kham tu db
            ThongTinHenKham? thongTinHenKham = await _db.ThongTinHenKhams.FirstOrDefaultAsync(x => x.ThongTinHenKhamID == thongTinHenKhamUpdateRequest.ThongTinHenKhamID);
            if(thongTinHenKham == null)
            {
                throw new ArgumentException("Không tìm thấy thông tin hẹn khám");
            }

            //cap nhat thong tin
            thongTinHenKham.HoTen = thongTinHenKhamUpdateRequest.HoTen;
            thongTinHenKham.SoDienThoai = thongTinHenKhamUpdateRequest.SoDienThoai;
            thongTinHenKham.NgaySinh = thongTinHenKhamUpdateRequest.NgaySinh;
            thongTinHenKham.GioiTinh = thongTinHenKhamUpdateRequest.GioiTinh;
            thongTinHenKham.DiaChi = thongTinHenKhamUpdateRequest.DiaChi;
            thongTinHenKham.NgayHenKham = thongTinHenKhamUpdateRequest.NgayHenKham;
            thongTinHenKham.LyDoKham = thongTinHenKhamUpdateRequest.LyDoKham;
            thongTinHenKham.LoaiKhamID = thongTinHenKhamUpdateRequest.LoaiKhamID == Guid.Empty ? null : thongTinHenKhamUpdateRequest.LoaiKhamID;
            thongTinHenKham.PhongKhamID = thongTinHenKhamUpdateRequest.PhongKhamID == Guid.Empty ? null : thongTinHenKhamUpdateRequest.PhongKhamID;
            thongTinHenKham.TrangThai = thongTinHenKhamUpdateRequest.TrangThai;
            thongTinHenKham.NguoiDungID = thongTinHenKhamUpdateRequest.NguoiDungID;

            await _db.SaveChangesAsync(); // update

            return thongTinHenKham.ToThongTinHenKhamResponse();
        }

        public async Task<bool> CapNhatThongTinTrangThai(Guid ThongTinHenKhamID, int TrangThai)
        {
            if (ThongTinHenKhamID == null)
            {
                return false;
            }
            ThongTinHenKham? thongTinHenKham = await _db.ThongTinHenKhams.FirstOrDefaultAsync(x => x.ThongTinHenKhamID == ThongTinHenKhamID);
            if (thongTinHenKham == null)
            {
                return false;
            }
            thongTinHenKham.TrangThai = TrangThai;
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<List<ThongTinHenKhamResponse>> LayTatCaThongTinHenKham()
        {
            var thongTinHenKhams = await _db.ThongTinHenKhams.Include("PhongKham").Include("LoaiKham").ToListAsync();
            return thongTinHenKhams.Select(x => x.ToThongTinHenKhamResponse()).ToList();
        }

        public async Task<ThongTinHenKhamResponse?> LayThongTinHenKhamTheoID(Guid? ThongTinHenKhamID)
        {
            if(ThongTinHenKhamID == null)
                return null;
            ThongTinHenKham? thongTinHenKham = await _db.ThongTinHenKhams.Include("PhongKham").Include("LoaiKham").FirstOrDefaultAsync(x => x.ThongTinHenKhamID == ThongTinHenKhamID);
            if (thongTinHenKham == null)
                return null;

        return thongTinHenKham.ToThongTinHenKhamResponse();
        }

        public async Task<List<ThongTinHenKhamResponse>> SapXepThongTinHenKham(List<ThongTinHenKhamResponse> dsThongTin, string sortBy, SortOrderOptions sortOrder)
        {
            if (string.IsNullOrEmpty(sortBy))
                return dsThongTin;
            List<ThongTinHenKhamResponse> dsThongTinHenKhamDaSapXep = (sortBy, sortOrder) switch
            {
                (nameof(ThongTinHenKham.HoTen), SortOrderOptions.ASC) => dsThongTin.OrderBy(temp => temp.HoTen, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(ThongTinHenKham.HoTen), SortOrderOptions.DESC) => dsThongTin.OrderByDescending(temp => temp.HoTen, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(ThongTinHenKham.SoDienThoai), SortOrderOptions.ASC) => dsThongTin.OrderBy(temp => temp.SoDienThoai, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(ThongTinHenKham.SoDienThoai), SortOrderOptions.DESC) => dsThongTin.OrderByDescending(temp => temp.SoDienThoai, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(ThongTinHenKham.DiaChi), SortOrderOptions.ASC) => dsThongTin.OrderBy(temp => temp.DiaChi, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(ThongTinHenKham.DiaChi), SortOrderOptions.DESC) => dsThongTin.OrderByDescending(temp => temp.DiaChi, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(ThongTinHenKham.NgayHenKham), SortOrderOptions.ASC) => dsThongTin.OrderBy(temp => temp.NgayHenKham).ToList(),
                (nameof(ThongTinHenKham.NgayHenKham), SortOrderOptions.DESC) => dsThongTin.OrderByDescending(temp => temp.NgayHenKham).ToList(),
                (nameof(ThongTinHenKham.TrangThai), SortOrderOptions.ASC) => dsThongTin.OrderBy(temp => temp.TrangThai).ToList(),
                (nameof(ThongTinHenKham.TrangThai), SortOrderOptions.DESC) => dsThongTin.OrderByDescending(temp => temp.TrangThai).ToList(),
                _ => dsThongTin
            };

            return dsThongTinHenKhamDaSapXep;
        }

        public async Task<ThongTinHenKhamResponse> ThemThongTinHenKham(ThongTinHenKhamRequest? thongTinHenKhamRequest)
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

        public async Task<List<ThongTinHenKhamResponse>> TimThongTinHenKham(string searchBy, string? searchString)
        {
            List<ThongTinHenKhamResponse> dsThongTinHenKham = await LayTatCaThongTinHenKham();
            List<ThongTinHenKhamResponse> dsThongTinTimKiem = dsThongTinHenKham;
            if (string.IsNullOrEmpty(searchBy) || string.IsNullOrEmpty(searchString))
                return dsThongTinTimKiem;
            switch (searchBy)
            {
                case nameof(ThongTinHenKham.HoTen):
                    dsThongTinTimKiem = dsThongTinHenKham.Where(temp => (!string.IsNullOrEmpty(temp.HoTen) ? temp.HoTen.Contains(searchString, StringComparison.OrdinalIgnoreCase) : true)).ToList();
                    break;
                case nameof(ThongTinHenKham.SoDienThoai):
                    dsThongTinTimKiem = dsThongTinHenKham.Where(temp => (!string.IsNullOrEmpty(temp.SoDienThoai) ? temp.SoDienThoai.Contains(searchString, StringComparison.OrdinalIgnoreCase) : true)).ToList();
                    break;
                case nameof(ThongTinHenKham.DiaChi):
                    dsThongTinTimKiem = dsThongTinHenKham.Where(temp => (!string.IsNullOrEmpty(temp.DiaChi) ? temp.DiaChi.Contains(searchString, StringComparison.OrdinalIgnoreCase) : true)).ToList();
                    break;
                case nameof(ThongTinHenKham.NgayHenKham):
                    dsThongTinTimKiem = dsThongTinHenKham.Where(temp => temp.NgayHenKham.HasValue ? temp.NgayHenKham.Value.Date == DateTime.Parse(searchString).Date : false).ToList();
                    break;
                case nameof(ThongTinHenKham.TrangThai):
                    dsThongTinTimKiem = dsThongTinHenKham.Where(temp => temp.TrangThai.HasValue ? temp.TrangThai.Value.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase) : false).ToList();
                    break;
                default:
                    dsThongTinTimKiem = dsThongTinHenKham;
                    break;
            }
            return dsThongTinTimKiem;
        }
    }
}
