using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using QLHK_Webapp.DTO;
using QLHK_Webapp.Helpers;
using QLHK_Webapp.IServices;
using QLHK_Webapp.Models;
using System.Globalization;
using System.Text.Json.Serialization;

namespace QLHK_Webapp.Controllers
{
    public class ThongTinHenKhamController : Controller
    {
        private readonly IThongTinHenKhamService _thongTinHenKhamService;
        private readonly INguoiDungService _nguoiDungService;
        private readonly IPhongKhamService _phongKhamService;
        private readonly ILoaiKhamService _loaiKhamService;

        public ThongTinHenKhamController(IThongTinHenKhamService thongTinHenKhamService, INguoiDungService nguoiDungService,
            IPhongKhamService phongKhamService, ILoaiKhamService loaiKhamService)
        {
            _thongTinHenKhamService = thongTinHenKhamService;
            _nguoiDungService = nguoiDungService;
            _phongKhamService = phongKhamService;
            _loaiKhamService = loaiKhamService;
        }

        [Route("thongtinhenkham")]
        public async Task<IActionResult> Index()
        {
            //lay thong tin session dang nhap
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString(CommonHelper.SessionKeyID)))
            {
                Guid? NguoiDungID = new Guid(HttpContext.Session.GetString(CommonHelper.SessionKeyID));
                NguoiDungResponse? nguoiDung = await _nguoiDungService.LayNguoiDungTheoID(NguoiDungID);
                ViewBag.NguoiDung = nguoiDung;

            }
            ViewBag.GioiTinhOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "Nam", Text = "Nam" },
                new SelectListItem { Value = "Nữ", Text = "Nữ" },
                new SelectListItem { Value = "Khác", Text = "Khác" }
            };
            //load danh sach phong kham
            List<PhongKhamResponse> dsPhongKham = await _phongKhamService.LayTatCaPhongKham();
            dsPhongKham.Insert(0, new PhongKhamResponse { PhongKhamID = Guid.Empty, TenPhongKham = "Chọn phòng khám" });
            ViewBag.PhongKhamOptions = new SelectList(dsPhongKham, "PhongKhamID", "TenPhongKham");
            TempData["dsPhongKham"] = JsonConvert.SerializeObject(dsPhongKham);
            //load danh sach loai kham
            List<LoaiKhamResponse> dsLoaiKham = await _loaiKhamService.LayTatCaLoaiKham();
            dsLoaiKham.Insert(0, new LoaiKhamResponse { LoaiKhamID = Guid.Empty, TenLoaiKham = "Chọn loại khám" });
            ViewBag.LoaiKhamOptions = new SelectList(dsLoaiKham, "LoaiKhamID", "TenLoaiKham");
            TempData["dsLoaiKham"] = JsonConvert.SerializeObject(dsLoaiKham);

            //neu chua dang nhap thi chuyen ve trang dang nhap
            return View();
        }

        [Route("thongtinhenkham/them")]
        [HttpPost]
        public IActionResult ThemThongTinHenKham(ThongTinHenKhamRequest thongTinHenKhamRequest)
        {


            // chuyen sang view xac nhan
            //TempData["ThongTinHenKhamRequest"] = thongTinHenKhamRequest;
            ViewBag.PhongKham = (JsonConvert.DeserializeObject<List<PhongKhamResponse>>(TempData["dsPhongKham"].ToString())).FirstOrDefault(q => q.PhongKhamID == thongTinHenKhamRequest.PhongKhamID);
            ViewBag.LoaiKham = (JsonConvert.DeserializeObject<List<LoaiKhamResponse>>(TempData["dsLoaiKham"].ToString())).FirstOrDefault(q => q.LoaiKhamID == thongTinHenKhamRequest.LoaiKhamID);
            return View("ThemThongTinHenKham", thongTinHenKhamRequest);
        }

        [Route("thongtinhenkham/xemlai")]
        public async Task<IActionResult> XacNhanThongTinHenKham(ThongTinHenKhamRequest thongTinHenKhamRequest)
        {
            ThongTinHenKhamResponse thongTinHenKhamResponse = await _thongTinHenKhamService.ThemThongTinHenKham(thongTinHenKhamRequest);
            return View(thongTinHenKhamResponse);
        }

        
        [Route("admin/danhsachhenkham")]
        public async Task<IActionResult> DanhSachThongTinHenKham(string searchBy, string? searchString, string sortBy = nameof(ThongTinHenKhamResponse.NgayHenKham), SortOrderOptions sortOrder = SortOrderOptions.ASC)
        {
            //Search
            ViewBag.SearchFields = new Dictionary<string, string>()
            {
                { nameof(ThongTinHenKhamResponse.HoTen), "Họ tên" },
                { nameof(ThongTinHenKhamResponse.SoDienThoai), "Số ĐT" },
                { nameof(ThongTinHenKhamResponse.NgayHenKham), "Ngày hẹn khám" },
                { nameof(ThongTinHenKhamResponse.TrangThai), "Trạng thái" },
            };

            // Convert date format if searching by NgayHenKham
            if (searchBy == nameof(ThongTinHenKhamResponse.NgayHenKham) && !string.IsNullOrEmpty(searchString))
            {
                if (DateTime.TryParseExact(searchString, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                {
                    searchString = parsedDate.ToString("MM/dd/yyyy");
                }
            }

            //List<ThongTinHenKhamResponse> dsThongTinHenKham = await _thongTinHenKhamService.LayTatCaThongTinHenKham();
            List<ThongTinHenKhamResponse> dsThongTinHenKham = await _thongTinHenKhamService.TimThongTinHenKham(searchBy, searchString);
            ViewBag.CurrentSearchBy = searchBy;
            ViewBag.CurrentSearchString = searchString;

            //Sort
            List<ThongTinHenKhamResponse> dsThongTinHenKhamDaSapXep = await _thongTinHenKhamService.SapXepThongTinHenKham(dsThongTinHenKham, sortBy, sortOrder);
            ViewBag.CurrentSortBy = sortBy;
            ViewBag.CurrentSortOrder = sortOrder.ToString();



            return View(dsThongTinHenKhamDaSapXep);
        }

        [HttpGet]
        [Route("admin/danhsachhenkham/capnhat")]
        public async Task<IActionResult> CapNhatThongTinHenKham(Guid ThongTinHenKhamID)
        {
            ThongTinHenKhamResponse thongTinHenKhamResponse = await _thongTinHenKhamService.LayThongTinHenKhamTheoID(ThongTinHenKhamID);
            if(thongTinHenKhamResponse == null)
            {
                return RedirectToAction("DanhSachThongTinHenKham");
            }

            ThongTinHenKhamUpdateRequest thongTinHenKhamUpdateRequest = thongTinHenKhamResponse.ToThongTinHenKhamUpdateRequest();

            ViewBag.GioiTinhOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "Nam", Text = "Nam" },
                new SelectListItem { Value = "Nữ", Text = "Nữ" },
                new SelectListItem { Value = "Khác", Text = "Khác" }
            };

            //load danh sach phong kham
            List<PhongKhamResponse> dsPhongKham = await _phongKhamService.LayTatCaPhongKham();
            dsPhongKham.Insert(0, new PhongKhamResponse { PhongKhamID = Guid.Empty, TenPhongKham = "Chọn phòng khám" });
            ViewBag.PhongKhamOptions = new SelectList(dsPhongKham, "PhongKhamID", "TenPhongKham");
            TempData["dsPhongKham"] = JsonConvert.SerializeObject(dsPhongKham);
            //load danh sach loai kham
            List<LoaiKhamResponse> dsLoaiKham = await _loaiKhamService.LayTatCaLoaiKham();
            dsLoaiKham.Insert(0, new LoaiKhamResponse { LoaiKhamID = Guid.Empty, TenLoaiKham = "Chọn loại khám" });
            ViewBag.LoaiKhamOptions = new SelectList(dsLoaiKham, "LoaiKhamID", "TenLoaiKham");
            TempData["dsLoaiKham"] = JsonConvert.SerializeObject(dsLoaiKham);

            return View(thongTinHenKhamUpdateRequest);
        }

        [HttpPost]
        [Route("admin/danhsachhenkham/capnhat")]
        public async Task<IActionResult> CapNhatThongTinHenKham(ThongTinHenKhamUpdateRequest thongTinHenKhamUpdateRequest)
        {
            ThongTinHenKhamResponse? thongTinHenKhamResponse = await _thongTinHenKhamService.LayThongTinHenKhamTheoID(thongTinHenKhamUpdateRequest.ThongTinHenKhamID);
            if (thongTinHenKhamResponse == null)
            {
                return RedirectToAction("DanhSachThongTinHenKham");
            }

            if(ModelState.IsValid)
            {
                ThongTinHenKhamResponse thongTinHenKhamResponseUpdated = await _thongTinHenKhamService.CapNhatThongTinHenKham(thongTinHenKhamUpdateRequest);
                return RedirectToAction("DanhSachThongTinHenKham");
            }
            else
            {
                ViewBag.GioiTinhOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "Nam", Text = "Nam" },
                new SelectListItem { Value = "Nữ", Text = "Nữ" },
                new SelectListItem { Value = "Khác", Text = "Khác" }
            };

                //load danh sach phong kham
                List<PhongKhamResponse> dsPhongKham = await _phongKhamService.LayTatCaPhongKham();
                dsPhongKham.Insert(0, new PhongKhamResponse { PhongKhamID = Guid.Empty, TenPhongKham = "Chọn phòng khám" });
                ViewBag.PhongKhamOptions = new SelectList(dsPhongKham, "PhongKhamID", "TenPhongKham");
                TempData["dsPhongKham"] = JsonConvert.SerializeObject(dsPhongKham);
                //load danh sach loai kham
                List<LoaiKhamResponse> dsLoaiKham = await _loaiKhamService.LayTatCaLoaiKham();
                dsLoaiKham.Insert(0, new LoaiKhamResponse { LoaiKhamID = Guid.Empty, TenLoaiKham = "Chọn loại khám" });
                ViewBag.LoaiKhamOptions = new SelectList(dsLoaiKham, "LoaiKhamID", "TenLoaiKham");
                TempData["dsLoaiKham"] = JsonConvert.SerializeObject(dsLoaiKham);

                ViewBag.Errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                return View("CapNhatThongTinHenKham", thongTinHenKhamUpdateRequest);
            }
        }

        [HttpGet]
        [Route("admin/danhsachhenkham/capnhattrangthai")]
        public async Task<IActionResult> CapNhatTrangThai(Guid ThongTinHenKhamID)
        {
            ThongTinHenKhamResponse thongTinHenKhamResponse = await _thongTinHenKhamService.LayThongTinHenKhamTheoID(ThongTinHenKhamID);
            if (thongTinHenKhamResponse == null)
            {
                return RedirectToAction("DanhSachThongTinHenKham");
            }
            ViewBag.DSTrangThai = new List<SelectListItem>
            {
                new SelectListItem { Value = "0", Text = "Chờ xác nhận" },
                new SelectListItem { Value = "1", Text = "Đã xác nhận" },
                new SelectListItem { Value = "2", Text = "Đã khám" },
                new SelectListItem { Value = "3", Text = "Đã Hủy" }
            };



            //load danh sach phong kham
            List<PhongKhamResponse> dsPhongKham = await _phongKhamService.LayTatCaPhongKham();
            dsPhongKham.Insert(0, new PhongKhamResponse { PhongKhamID = Guid.Empty, TenPhongKham = "Chọn phòng khám" });
            //load danh sach loai kham
            List<LoaiKhamResponse> dsLoaiKham = await _loaiKhamService.LayTatCaLoaiKham();
            dsLoaiKham.Insert(0, new LoaiKhamResponse { LoaiKhamID = Guid.Empty, TenLoaiKham = "Chọn loại khám" });

            ViewBag.PhongKham = dsPhongKham.FirstOrDefault(q => q.PhongKhamID == thongTinHenKhamResponse.PhongKhamID);
            ViewBag.LoaiKham = dsLoaiKham.FirstOrDefault(q => q.LoaiKhamID == thongTinHenKhamResponse.LoaiKhamID);


            return View(thongTinHenKhamResponse.ToThongTinHenKhamUpdateRequest());
        }

        [HttpPost]
        [Route("admin/danhsachhenkham/capnhattrangthai")]
        public async Task<IActionResult> CapNhatTrangThai(ThongTinHenKhamUpdateRequest thongTinHenKhamUpdateRequest)
        {
            ThongTinHenKhamResponse? thongTinHenKhamResponse = await _thongTinHenKhamService.LayThongTinHenKhamTheoID(thongTinHenKhamUpdateRequest.ThongTinHenKhamID);
            if (thongTinHenKhamResponse == null)
            {
                return RedirectToAction("DanhSachThongTinHenKham");
            }

            if (thongTinHenKhamResponse.TrangThai.HasValue)
            {
                bool result = await _thongTinHenKhamService.CapNhatThongTinTrangThai(thongTinHenKhamUpdateRequest.ThongTinHenKhamID.HasValue ? thongTinHenKhamUpdateRequest.ThongTinHenKhamID!.Value : Guid.Empty
                    , thongTinHenKhamUpdateRequest!.TrangThai.HasValue ? thongTinHenKhamUpdateRequest!.TrangThai.Value : 0 );
                if (result)
                {
                    return RedirectToAction("DanhSachThongTinHenKham");
                }
            }
            ViewBag.Errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return View("CapNhatTrangThai", thongTinHenKhamUpdateRequest);
        }

        [HttpGet]
        [Route("/lichsuhenkham")]
        public async Task<IActionResult> LichSuThongTinHenKham(string? searchString)
        {
            //kiem tra dang dang nhap thi lay lich su cua user do
            //lay thong tin session dang nhap
            if (string.IsNullOrEmpty(searchString))
            {
                if (!String.IsNullOrEmpty(HttpContext.Session.GetString(CommonHelper.SessionKeyID)))
                {
                    Guid? NguoiDungID = new Guid(HttpContext.Session.GetString(CommonHelper.SessionKeyID));
                    NguoiDungResponse? nguoiDung = await _nguoiDungService.LayNguoiDungTheoID(NguoiDungID);
                    ViewBag.NguoiDung = nguoiDung;

                    List<ThongTinHenKhamResponse> dsThongTinHenKham = await _thongTinHenKhamService.TimThongTinHenKham(nameof(ThongTinHenKham.SoDienThoai), nguoiDung?.SoDienThoai);
                    //Sort
                    List<ThongTinHenKhamResponse> dsThongTinHenKhamDaSapXep = await _thongTinHenKhamService.SapXepThongTinHenKham(dsThongTinHenKham, nameof(ThongTinHenKham.NgayHenKham), SortOrderOptions.DESC);
                    return View(dsThongTinHenKhamDaSapXep);
                }
            }
            else
            {
                List<ThongTinHenKhamResponse> dsThongTinHenKham = await _thongTinHenKhamService.TimThongTinHenKham(nameof(ThongTinHenKham.SoDienThoai), searchString);
                //Sort
                List<ThongTinHenKhamResponse> dsThongTinHenKhamDaSapXep = await _thongTinHenKhamService.SapXepThongTinHenKham(dsThongTinHenKham, nameof(ThongTinHenKham.NgayHenKham), SortOrderOptions.DESC);
                ViewBag.CurrentSearchString = searchString;
                ViewBag.NguoiDung = null;
                return View(dsThongTinHenKhamDaSapXep);
            }
            return View();
        }
    }
}
