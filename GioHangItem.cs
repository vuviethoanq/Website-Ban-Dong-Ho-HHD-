using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WBDH_BTL
{
    public class GioHangItem
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string Anh { get; set; }
        public double Gia { get; set; }
        public int SoLuong { get; set; }

        public double ThanhTien
        {
            get { return Gia * SoLuong; }
        }
    }

}