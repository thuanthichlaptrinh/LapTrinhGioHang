using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using _31_NgoMinhThuan_THBuoi11.Models;

namespace _31_NgoMinhThuan_THBuoi11.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        private QLDonHangSachEntities db = new QLDonHangSachEntities();

        public ActionResult Index()
        {
            var ds = db.tbl_SanPham.ToList();

            return View(ds);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string tenKH = fc["txtTen"];
            string matKhau = fc["txtMatKhau"];

            var kh = db.tbl_KhachHang.FirstOrDefault(row =>
                row.TenKH == tenKH && row.MatKhau == matKhau);

            if (kh != null)
            {
                Session["kh"] = kh;
                return RedirectToAction("Index", "KhachHang");
            }
            else
            {
                ViewBag.Error = "Tài khoản hoặc mật khẩu không đúng!";
                return View();
            }
        }

        public ActionResult Logout()
        {
            // Xóa session
            Session["kh"] = null;
            // xóa session liên quan đến form authen
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}