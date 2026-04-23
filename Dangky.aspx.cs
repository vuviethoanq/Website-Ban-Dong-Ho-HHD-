using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.UI;

namespace WBDH_BTL
{
    public partial class Dangky : Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = (txtFullname.Text ?? "").Trim();
            string email = (txtEmail.Text ?? "").Trim().ToLower();
            string phone = (txtPhone.Text ?? "").Trim();
            string password = (txtPassword.Text ?? "");
            string confirm = (txtConfirmPassword.Text ?? "");

            //===Que quan===
            string country = (txtCountry.Text ?? "").Trim();

            // ===== Validate server-side (dự phòng khi tắt JS) =====
            if (tenDangNhap.Length < 4)
            {
                lblThongBao.Text = "Tên đăng nhập tối thiểu 4 ký tự.";
                return;
            }
            if (!Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]{2,}$"))
            {
                lblThongBao.Text = "Email không hợp lệ.";
                return;
            }
            string compactPhone = Regex.Replace(phone, @"\s+", "");
            if (!Regex.IsMatch(compactPhone, @"^(0|\+84)(3|5|7|8|9)\d{8}$"))
            {
                lblThongBao.Text = "Số điện thoại không hợp lệ (0xxxxxxxxx hoặc +84xxxxxxxxx, đầu 3/5/7/8/9).";
                return;
            }
            if (password.Length < 6)
            {
                lblThongBao.Text = "Mật khẩu tối thiểu 6 ký tự.";
                return;
            }
            if (!string.Equals(password, confirm))
            {
                lblThongBao.Text = "Mật khẩu xác nhận không khớp.";
                return;
            }

            //===Que quan
            if (!Regex.IsMatch(txtCountry.Text.Trim(), @"^(\d{a}$)"))
            {
                lblThongBao.Text = "Que quan chi duoc nhap cac chu cai!";
                    return;
            }

                // ===== Lấy/khởi tạo danh sách tài khoản trong Application =====
                const string KEY = "DanhSachTaiKhoan";
            var ds = Application[KEY] as List<Account>;
            if (ds == null) ds = new List<Account>();

            // ===== Chống trùng =====
            if (ds.Any(a => a.TenDangNhap.Equals(tenDangNhap, StringComparison.OrdinalIgnoreCase)))
            {
                lblThongBao.Text = "Tên đăng nhập đã tồn tại!";
                return;
            }
            if (ds.Any(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
            {
                lblThongBao.Text = "Email này đã được đăng ký!";
                return;
            }
            if (ds.Any(a => !string.IsNullOrWhiteSpace(a.SoDienThoai) &&
                            a.SoDienThoai.Replace(" ", "") == compactPhone))
            {
                lblThongBao.Text = "Số điện thoại này đã được sử dụng!";
                return;
            }

            // ===== Tạo tài khoản =====
            var user = new Account
            {
                TenDangNhap = tenDangNhap,
                Email = email,
                SoDienThoai = compactPhone,   // cần property này trong Account.cs
                MatKhau = password,
                VaiTro = "User"
            };

            ds.Add(user);
            Application[KEY] = ds;

            Response.Redirect("DangNhap.aspx");
        }
    }
}
