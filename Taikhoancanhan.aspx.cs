using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WBDH_BTL
{
    public partial class Taikhoancanhan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa đăng nhập thì quay về trang đăng nhập
            if (Session["UserLogin"] == null)
            {
                Response.Redirect("DangNhap.aspx");
                return;
            }

            if (!IsPostBack)
            {
                var currentUser = (Account)Session["UserLogin"];
                lblHoTen.Text = currentUser.TenDangNhap;
                lblEmail.Text = currentUser.Email;
            }
        }

        // 🟢 Nút Đăng xuất
        protected void btnDangXuat_Click(object sender, EventArgs e)
        {
            Session.Remove("UserLogin");
            Response.Redirect("DangNhap.aspx");
        }

        // 🟡 Nút Đổi mật khẩu
        protected void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            var currentUser = (Account)Session["UserLogin"];
            string oldPass = txtOldPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass))
            {
                lblThongBao.Text = "Vui lòng nhập đầy đủ thông tin!";
                return;
            }

            if (oldPass != currentUser.MatKhau)
            {
                lblThongBao.Text = "Mật khẩu cũ không đúng!";
                return;
            }

            if (newPass != confirm)
            {
                lblThongBao.Text = "Mật khẩu nhập lại không khớp!";
                return;
            }

            // Cập nhật mật khẩu trong Application
            var dsTaiKhoan = (List<Account>)Application["DanhSachTaiKhoan"];
            var user = dsTaiKhoan.FirstOrDefault(u => u.Email == currentUser.Email);

            if (user != null)
            {
                user.MatKhau = newPass;
                Application["DanhSachTaiKhoan"] = dsTaiKhoan;
                currentUser.MatKhau = newPass;
                Session["UserLogin"] = currentUser;

                lblThongBao.CssClass = "thongbao success";
                lblThongBao.Text = "Đổi mật khẩu thành công!";
            }
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
 
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
        }

        // Mock DB
        private NguoiDung GetUserByEmail(string email)
        {
            return new NguoiDung
            {
            };
        }

        private void SaveUser(NguoiDung user)
        {
            // TODO: Lưu thông tin user xuống DB
        }

        private void DeleteUser(string email)
        {
            // TODO: Xóa user khỏi DB nếu cần
        }

        public class NguoiDung
        {

        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
        /*hoạt động lỗi */
        protected void btnThemVaoGio_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
        }

        protected void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            Response.Redirect("TKCaNhan.aspx");
        }
    }
}