using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _31_NgoMinhThuan_THBuoi11.Models
{
    public class GioHang
    {
        public List<CartItem> lst;
        public GioHang()
        {
            lst = new List<CartItem>();
        }
        public GioHang(List<CartItem> lstGH)
        {
            lstGH = lst;
        }

        public int SoMatHang()
        {
            return lst.Count();
        }
        public int TongSLHang()
        {
            return lst.Sum(t => t.iSoLuong);
        }

        public double TongThanhTien()
        {
            return lst.Sum(t => t.ThanhTien);
        }

        // Thêm sản phẩm vào giỏ hàng
        public int Them(int iMaSach)
        {
            // Kiểm tra sản phẩm có trong ds chưa
            CartItem sanPham = lst.Find(row => row.iMaSach == iMaSach);

            if(sanPham == null)
            {
                CartItem sach = new CartItem(iMaSach);
                if(sach == null)
                {
                    return -1;
                }
                lst.Add(sach);
            }
            else // đã có
            {
                sanPham.iSoLuong++;
            }
            return 1;
        }
    }
}