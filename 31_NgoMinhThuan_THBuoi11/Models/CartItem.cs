using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _31_NgoMinhThuan_THBuoi11.Models
{
    public class CartItem
    {
        public int iMaSach {  get; set; }
        public string sTenSach {  get; set; }
        public string sAnhBia {  get; set; }
        public double dDonGia {  get; set; }
        public int iSoLuong {  get; set; }
        public double ThanhTien 
        {
            get { return iSoLuong * dDonGia; }
        }

        QLDonHangSachEntities db = new QLDonHangSachEntities();

        // Hàm tạo cho giỏ hàng
        public CartItem(int MaSach)
        {
            tbl_SanPham sach = db.tbl_SanPham.Single(row => row.MaSanPham == MaSach); 
            if(sach != null)
            {
                iMaSach = MaSach;
                sTenSach = sach.TenSP;
                sAnhBia = sach.HinhAnh;
                dDonGia = double.Parse(sach.DonGia.ToString());
                iSoLuong = 1;
            }
        }
    }
}