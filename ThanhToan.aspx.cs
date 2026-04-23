using System;
using System.Collections.Generic;
using System.Linq;

namespace WBDH_BTL
{
    public partial class ThanhToan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Nếu Session chứa object Account
                var accObj = Session["UserLogin"];
                if (accObj != null)
                {
                    Account acc = accObj as Account;
                    if (acc != null)
                    {
                        txtHoTen.Text = acc.TenDangNhap ?? "";
                        txtSoDienThoai.Text = acc.SoDienThoai ?? "";
                        txtEmail.Text = acc.Email ?? "";
                    }
                }
            }
        }

        private void HienThiGioHang()
        {
          
        }

        protected void btnDatHang_Click(object sender, EventArgs e)
        {
   
        }
    }
}
