using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace WBDH_BTL
{
    public partial class Quenmk : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            // Nếu bạn không dùng jQuery mapping, tắt unobtrusive để tránh lỗi
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            // Đảm bảo đường dẫn CSS luôn đúng

        }
        // Lưu username/email đã xác thực qua ViewState để dùng ở bước 2
        private string VerifiedEmail
        {
            get => ViewState["VerifiedEmail"] as string;
            set => ViewState["VerifiedEmail"] = value;
        }



        // BƯỚC 1: Xác thực Email + Họ tên
        protected void btnVerify_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = string.Empty;

            var email = (txtEmail.Text ?? "").Trim();
            var fullName = (txtFullName.Text ?? "").Trim();

            if (!Page.IsValid) return;

            var ds = Application["DanhSachTaiKhoan"] as List<Account>;
            if (ds == null || ds.Count == 0)
            {
                lblThongBao.Text = "Hệ thống chưa có dữ liệu tài khoản.";
                return;
            }

            // MẶC ĐỊNH DÙNG u.HoTen – nếu lớp Account của bạn dùng FullName, đổi u.HoTen -> u.FullName
            var user = ds.FirstOrDefault(u =>
                !string.IsNullOrEmpty(u.Email) &&
                u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                !string.IsNullOrEmpty(u.TenDangNhap) &&
                u.TenDangNhap.Equals(fullName, StringComparison.OrdinalIgnoreCase)
            );

            if (user == null)
            {
                lblThongBao.Text = "Email hoặc họ tên không khớp. Vui lòng kiểm tra lại.";
                return;
            }

            // Lưu email đã xác thực, chuyển sang panel đổi mật khẩu
            VerifiedEmail = user.Email;
            pnlVerify.Visible = false;
            pnlReset.Visible = true;
            lblThongBao.Text = "Xác thực thành công. Vui lòng nhập mật khẩu mới.";
        }

        // BƯỚC 2: Đổi mật khẩu mới
        protected void btnChange_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = string.Empty;

            if (!Page.IsValid) return;

            var newPass = (txtNewPass.Text ?? "").Trim();
            var confirm = (txtConfirm.Text ?? "").Trim();

            if (string.IsNullOrEmpty(VerifiedEmail))
            {
                lblThongBao.Text = "Phiên xác thực đã hết hoặc không hợp lệ. Vui lòng xác thực lại.";
                pnlVerify.Visible = true;
                pnlReset.Visible = false;
                return;
            }

            var ds = Application["DanhSachTaiKhoan"] as List<Account>;
            if (ds == null)
            {
                lblThongBao.Text = "Không tìm thấy dữ liệu tài khoản.";
                return;
            }

            var user = ds.FirstOrDefault(u =>
                !string.IsNullOrEmpty(u.Email) &&
                u.Email.Equals(VerifiedEmail, StringComparison.OrdinalIgnoreCase)
            );

            if (user == null)
            {
                lblThongBao.Text = "Không tìm thấy tài khoản tương ứng.";
                return;
            }

            // CẬP NHẬT MẬT KHẨU (ở đây là demo: gán trực tiếp. Thực tế nên mã hóa/hash)
            user.MatKhau = newPass;

            // Ghi đè lại danh sách (không bắt buộc, nhưng đảm bảo Application reference không bị thay)
            Application["DanhSachTaiKhoan"] = ds;

            // Reset trạng thái
            VerifiedEmail = null;
            pnlVerify.Visible = true;
            pnlReset.Visible = false;

            lblThongBao.Text = "Đổi mật khẩu thành công. Bạn có thể đăng nhập bằng mật khẩu mới.";
        }
    }
}


