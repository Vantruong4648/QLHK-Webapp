using Microsoft.AspNetCore.Mvc;
using QLHK_Webapp.DTO;
using QLHK_Webapp.Helpers;
using QLHK_Webapp.IServices;
using System;

namespace QLHK_Webapp.Controllers
{
    public class NguoiDungController : Controller
    {
        private readonly INguoiDungService _nguoiDungService;


        public NguoiDungController(INguoiDungService nguoiDungService)
        {
            _nguoiDungService = nguoiDungService;
        }

        [Route("/")]
        [Route("/dangnhap")]
        public IActionResult Index()
        {
            ViewBag.Title = "Đăng nhập";
            ModelState.Clear();
            return View();
        }


        [Route("/dangky")]
        public async Task<IActionResult> DangKy(DangKyRequest dangKyRequest) { 
            ViewBag.Title = "Đăng ký";
            ModelState.Clear();
            return View();
        }

        [Route("dangkymoi")]
        [HttpPost]
        public async Task<IActionResult> DangKyMoi(DangKyRequest dangKyRequest)
        {
            ViewBag.Title = "Đăng ký";
            //if (!ModelState.IsValid)
            //{
            //    ViewBag.Errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            //    return RedirectToAction("DangKy");
            //}
            //cal service method
            NguoiDungResponse? dangkyResponse = await _nguoiDungService.DangKyMoi(dangKyRequest);
            if (dangkyResponse == null)
            {
                ViewBag.Message = "Đăng ký thất bại";
            }
            else
            {
                ViewBag.Message = "Đăng ký thành công";
                return View("DangKy");
            }
            return RedirectToAction("DangKy");
        }

        [Route("DangNhap")]
        [HttpPost]
        public async Task<IActionResult> DangNhap(DangNhapRequest dangNhapRequest)
        {
            //kiem tra cung nguoi dung la admin
            if (dangNhapRequest.SoDienThoai == "admin" && dangNhapRequest.MatKhau == "admin")
            {
                return RedirectToAction("DanhSachThongTinHenKham", "ThongTinHenKham");
            }
            NguoiDungResponse ? nguoiDung = await _nguoiDungService.DangNhap(dangNhapRequest);
            if (nguoiDung == null)
            {
                 ViewBag.ErrorMessage = "Lỗi tài khoản hoặc mật khẩu không đúng";
                 return View("Index");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(HttpContext.Session.GetString(CommonHelper.SessionKeyID)))
                {
                    HttpContext.Session.SetString(CommonHelper.SessionKeyUser, nguoiDung.SoDienThoai!.ToString());
                    HttpContext.Session.SetString(CommonHelper.SessionKeyID, nguoiDung.NguoiDungID.ToString());
                }
                return RedirectToAction("Index", "ThongTinHenKham");
            }
           
        }

    }
}
