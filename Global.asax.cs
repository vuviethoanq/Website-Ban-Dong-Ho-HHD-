using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WBDH_BTL
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["DanhSachSanPham"] = DataInitializer.GetSanPhamList();
            Application["DanhSachTaiKhoan"] = new List<Account>();
            Application["SoNguoiTruyCap"] = 0;
            Application.Lock();
            try
            {
                var ds = Application["DanhSachTaiKhoan"] as List<Account>;
                if (ds == null)
                {
                    ds = new List<Account>();
                }

                // Nếu chưa có admin thì thêm một tài khoản admin mặc định
                bool hasAdmin = ds.Any(a => string.Equals(a.VaiTro, "Admin", StringComparison.OrdinalIgnoreCase));
                if (!hasAdmin)
                {
                    ds.Add(new Account
                    {
                        TenDangNhap = "admin",
                        Email = "admin@gmail.com",
                        MatKhau = "123456", // Demo; khi triển khai thực tế hãy dùng hash (BCrypt)
                        VaiTro = "Admin"
                    });
                }

                Application["DanhSachTaiKhoan"] = ds;
            }
            finally
            {
                Application.UnLock();
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}