using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WBDH_BTL
{
    public class Account
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }

        public string SoDienThoai { get; set; }
        public string VaiTro { get; set; } = "User"; // "Admin" | "User"
    }
}