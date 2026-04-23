using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace WBDH_BTL
{
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Nếu chưa đăng nhập, chuyển sang trang đăng nhập
            if (Session["UserLogin"] == null)
            {
                Response.Redirect("DangNhap.aspx");
                return;
            }

            if (!IsPostBack)
            {
                HienThiGioHang();
            }
        }

        // ================== HIỂN THỊ GIỎ HÀNG ==================
        private void HienThiGioHang()
        {
            if (Session["giohang"] != null)
            {
                List<GioHangItem> gioHang = (List<GioHangItem>)Session["giohang"];

                if (gioHang.Count > 0)
                {
                    pnlCart.Visible = true;
                    pnlEmpty.Visible = false;

                    rptGioHang.DataSource = gioHang;
                    rptGioHang.DataBind();

                    double tong = gioHang.Sum(x => x.ThanhTien);
                    lblTongTien.Text = tong.ToString("N0") + "₫";
                }
                else
                {
                    pnlCart.Visible = false;
                    pnlEmpty.Visible = true;
                    lblTongTien.Text = "";
                }
            }
            else
            {
                pnlCart.Visible = false;
                pnlEmpty.Visible = true;
                lblTongTien.Text = "";
            }
        }

        // ================== NÚT TĂNG / GIẢM / XÓA ==================
        protected void btnSoLuong_Command(object sender, CommandEventArgs e)
        {
            string maSP = e.CommandArgument.ToString();
            string lenh = e.CommandName;

            if (Session["giohang"] != null)
            {
                List<GioHangItem> gioHang = (List<GioHangItem>)Session["giohang"];
                var sp = gioHang.FirstOrDefault(x => x.MaSP == maSP);

                if (sp != null)
                {
                    if (lenh == "Tang")
                    {
                        sp.SoLuong += 1;
                        var m = this.Master as Site;
                        m?.UpdateCartCountFromSession();
                    }
                    else if (lenh == "Giam")
                    {
                        if (sp.SoLuong > 1)
                        {
                            sp.SoLuong -= 1;
                            var m = this.Master as Site;
                            m?.UpdateCartCountFromSession();
                        }
                        else { 
                            gioHang.Remove(sp); // Nếu còn 1 mà giảm nữa → xóa
                            var m = this.Master as Site;
                            m?.UpdateCartCountFromSession();
                        }
                    }
                    else if (lenh == "Xoa")
                    {
                        gioHang.Remove(sp);
                        var m = this.Master as Site;
                        m?.UpdateCartCountFromSession();
                    }
                }

                Session["giohang"] = gioHang;
                HienThiGioHang();
            }
        }

        // ================== NÚT CẬP NHẬT ==================
        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            HienThiGioHang();
            var m = this.Master as Site;
            m?.UpdateCartCountFromSession();
        }

        // ================== NÚT THANH TOÁN ==================
        protected void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Nếu giỏ hàng trống thì không cho thanh toán
            if (Session["giohang"] == null || ((List<GioHangItem>)Session["giohang"]).Count == 0)
            {
                lblTongTien.Text = "Giỏ hàng của bạn đang trống.";
                return;
            }

            Response.Redirect("ThanhToan.aspx");
        }
    }

}
