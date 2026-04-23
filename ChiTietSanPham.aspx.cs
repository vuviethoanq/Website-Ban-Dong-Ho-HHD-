using System;
using System.Collections.Generic;
using System.Linq;

namespace WBDH_BTL
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string maSP = Request.QueryString["masp"];
                if (!string.IsNullOrEmpty(maSP))
                {
                    List<SanPham> dsSanPham = (List<SanPham>)Application["danhsachsanpham"];
                    var sp = dsSanPham.FirstOrDefault(s => s.MaSP == maSP);
                    if (sp != null)
                    {
                        imgSanPham.ImageUrl = sp.Anh;
                        lblTenSP.Text = sp.TenSP;
                        lblGia.Text = sp.Gia.ToString("N0") + "₫";
                        lblThuongHieu.Text = sp.ThuongHieu;
                        lblMoTa.Text = sp.MoTa ?? "Sản phẩm cao cấp chính hãng, bảo hành 5 năm.";

                        // Gợi ý sản phẩm cùng thương hiệu
                        var goiY = dsSanPham.Where(x => x.ThuongHieu == sp.ThuongHieu && x.MaSP != maSP).Take(4).ToList();
                        rptSanPhamLienQuan.DataSource = goiY;
                        rptSanPhamLienQuan.DataBind();
                    }
                }
            }
        }

        protected void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            string maSP = Request.QueryString["masp"];
            int soLuong = int.Parse(txtSoLuong.Text);
            List<GioHangItem> gioHang = Session["giohang"] as List<GioHangItem> ?? new List<GioHangItem>();

            List<SanPham> dsSanPham = (List<SanPham>)Application["danhsachsanpham"];
            var sp = dsSanPham.FirstOrDefault(x => x.MaSP == maSP);

            if (sp != null)
            {
                var item = gioHang.FirstOrDefault(x => x.MaSP == maSP);
                if (item != null)
                    item.SoLuong += soLuong;
                else
                    gioHang.Add(new GioHangItem { MaSP = sp.MaSP, TenSP = sp.TenSP, Gia = sp.Gia, SoLuong = soLuong, Anh = sp.Anh });
            }

            Session["giohang"] = gioHang;
            Response.Redirect("GioHang.aspx");
        }
    }
}
