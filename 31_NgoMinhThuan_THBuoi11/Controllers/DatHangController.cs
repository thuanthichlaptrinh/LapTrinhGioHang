using _31_NgoMinhThuan_THBuoi11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31_NgoMinhThuan_THBuoi11.Controllers
{
    public class DatHangController : Controller
    {
        // GET: DatHang
        private QLDonHangSachEntities db = new QLDonHangSachEntities();

        public ActionResult ThemVaoGioHang(int msp)
        {
            GioHang gioHang = (GioHang)Session["gh"];

            if (gioHang == null)
            {
                gioHang = new GioHang();
            }

            int kq = gioHang.Them(msp);

            Session["gh"] = gioHang;
            return RedirectToAction("Index", "KhachHang");
        }

        public ActionResult XemGioHang()
        {
            // Lấy giỏ hàng từ session
            GioHang gh = (GioHang)Session["gh"];

            if (gh == null)
            {
                gh = new GioHang();
                Session["gh"] = gh;
            }

            ViewBag.SoLuong = gh.TongSLHang();

            return View(gh);
        }

        public ActionResult XacNhanDatHang()
        {
            tbl_KhachHang k = (tbl_KhachHang)Session["kh"];
            ViewBag.k = k;

            GioHang gh = (GioHang)Session["gh"];
            return View(gh);
        }

        public ActionResult DatHang(FormCollection fc)
        {
            string txtngayGiao = fc["txtNgayGiao"];
            var khach = (tbl_KhachHang)Session["kh"];
            GioHang gh = (GioHang)Session["gh"];

            // Lưu thông tin hóa đơn
            tbl_HoaDon hoaDon = new tbl_HoaDon();
            hoaDon.MaKH = khach.MaKhachHang;
            hoaDon.NgayHoaDon = DateTime.Now;
            hoaDon.NgayGiao = DateTime.Parse(txtngayGiao);

            db.tbl_HoaDon.Add(hoaDon);
            db.SaveChanges();

            foreach (var item in gh.lst)
            {
                tbl_ChiTiet ct = new tbl_ChiTiet();
                ct.MaHD = hoaDon.MaHoaDon;
                ct.MaSP = item.iMaSach;
                ct.SoLuong = item.iSoLuong;

                db.tbl_ChiTiet.Add(ct);
                db.SaveChanges();
            }

            return View();
        }
    }
}