using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WBDH_BTL
{
    public partial class Dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Lấy danh sách tài khoản từ Application
            var dsTaiKhoan = (List<Account>)Application["DanhSachTaiKhoan"];

            var user = dsTaiKhoan.FirstOrDefault(u =>
                u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                u.MatKhau == password);

            if (user != null)
            {
                // Lưu thông tin người dùng vào Session
                Session["UserLogin"] = user;
                Session["UserRole"] = user.VaiTro ?? "User";
                // Chuyển hướng sang trang chủ
                Response.Redirect("TrangChu.aspx");
            }
            else
            {
                lblThongBao.Text = "Email hoặc mật khẩu không đúng!";
            }
        }
    }
}