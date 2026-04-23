using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WBDH_BTL
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Lấy danh sách sản phẩm từ Application
                var ds = (List<SanPham>)Application["DanhSachSanPham"];

                // Lọc 10 sản phẩm có giá cao nhất
                var top10 = ds
                    .OrderByDescending(sp => sp.Gia) // Sắp xếp giảm dần theo giá
                    .Take(10)                         // Lấy 12 sản phẩm đầu tiên
                    .ToList();

                rptSanPham.DataSource = top10;
                rptSanPham.DataBind();
            }
        }
        protected void btnThemVaoGio_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            if (Session["UserLogin"] == null)
            {
                Response.Redirect("DangNhap.aspx");
                return;
            }
            string sanPhamId = e.CommandArgument.ToString();
            var dsSanPham = (List<SanPham>)Application["DanhSachSanPham"];
            var sanPham = dsSanPham.FirstOrDefault(sp => sp.MaSP == sanPhamId); // kiểm tra trong ds sản phẩm có sp nào = spid không
            if (sanPham != null)
            {
                List<GioHangItem> gioHang;
                if (Session["giohang"] == null)
                {
                    gioHang = new List<GioHangItem>();
                }
                else
                {
                    gioHang = (List<GioHangItem>)Session["giohang"];
                }
                var existingItem = gioHang.FirstOrDefault(item => item.MaSP == sanPhamId);
                if (existingItem != null)
                {
                    existingItem.SoLuong++;
                }
                else
                {
                    gioHang.Add(new GioHangItem
                    {
                        MaSP = sanPham.MaSP,
                        TenSP = sanPham.TenSP,
                        Gia = sanPham.Gia,
                        Anh = sanPham.Anh,
                        SoLuong = 1 
                    });
                }
                Session["giohang"] = gioHang;
                var m = this.Master as Site;    
                m?.UpdateCartCountFromSession();
            }
        }

        protected void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            Response.Redirect("TKCaNhan.aspx");
        }

    }
}