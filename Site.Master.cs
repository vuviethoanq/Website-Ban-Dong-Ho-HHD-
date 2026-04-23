using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WBDH_BTL
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var acc = Session["UserLogin"] as Account;

                // Ẩn/hiện nút đăng nhập / tài khoản / đăng xuất
                bool isLogged = acc != null;
                lnkDangNhap.Visible = !isLogged;
                btnTaiKhoan.Visible = isLogged;

                // Chỉ Admin mới thấy menu QUẢN TRỊ
                bool isAdmin = acc != null && string.Equals(acc.VaiTro, "Admin", StringComparison.OrdinalIgnoreCase);
                menuAdmin.Visible = isAdmin;
            }

            // Luôn cập nhật số lượng giỏ (kể cả postback)
            UpdateCartCountFromSession();
        }


        public void UpdateCartCountFromSession()
        {
            var cart = Session["giohang"] as List<GioHangItem>;
            int count = cart?.Sum(x => x.SoLuong) ?? 0;
            lblCartCount.Text = count.ToString();
        }


        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            var q = txtTimKiem.Text?.Trim();
            if (string.IsNullOrWhiteSpace(q))
            {
                Response.Redirect("~/Danhmuc.aspx"); // hoặc TrangChu.aspx tùy ý
                return;
            }
            Response.Redirect("~/Danhmuc.aspx?q=" + Server.UrlEncode(q));
        }

        protected void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            Response.Redirect("Taikhoancanhan.aspx");
        }
    }
}