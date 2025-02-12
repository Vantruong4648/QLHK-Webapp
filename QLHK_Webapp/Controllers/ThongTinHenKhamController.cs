using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QLHK_Webapp.DTO;
using QLHK_Webapp.Helpers;
using QLHK_Webapp.IServices;

namespace QLHK_Webapp.Controllers
{
    public class ThongTinHenKhamController : Controller
    {
        private readonly IThongTinHenKhamService _thongTinHenKhamService;
        private readonly INguoiDungService _nguoiDungService;

        public ThongTinHenKhamController(IThongTinHenKhamService thongTinHenKhamService, INguoiDungService nguoiDungService)
        {
            _thongTinHenKhamService = thongTinHenKhamService;
            _nguoiDungService = nguoiDungService;
        }
        [Route("/")]
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
                new SelectListItem { Value = "Nu", Text = "Nữ" },
                new SelectListItem { Value = "Khac", Text = "Khác" }
            };
            //neu chua dang nhap thi chuyen ve trang dang nhap
            return View();
        }

        [Route("thongtinhenkham/them")]
        public IActionResult ThemThongTinHenKham(ThongTinHenKhamRequest thongTinHenKhamRequest)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                return View();
            }

            // chuyen sang view xac nhan

            return View();
        }

        [Route("thongtinhenkham/xacnhan")]
        public IActionResult XacNhanThongTinHenKham()
        {
            return View();
        }
    }
}
