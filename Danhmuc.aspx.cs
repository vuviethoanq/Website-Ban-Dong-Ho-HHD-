using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Web;
using System.Web.UI;

namespace WBDH_BTL
{
    public partial class Danhmuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 1) Lấy danh sách từ Application
                var danhSachSanPham = Application["DanhSachSanPham"] as List<SanPham> ?? new List<SanPham>();

                // 2) Đọc tham số
                string thuongHieu = (Request.QueryString["thuonghieu"] ?? "").Trim();
                string q = (Request.QueryString["q"] ?? "").Trim();

                // 3) Bắt đầu từ toàn bộ DS
                IEnumerable<SanPham> query = danhSachSanPham;

                // 3a) Nếu có từ khóa => ưu tiên tìm kiếm, BỎ QUA lọc thương hiệu
                if (!string.IsNullOrEmpty(q))
                {
                    string needle = NormalizeNoDiacritics(q);
                    query = query.Where(sp =>
                    {
                        string ten = NormalizeNoDiacritics(sp.TenSP ?? "");
                        string th = NormalizeNoDiacritics(sp.ThuongHieu ?? "");
                        string mt = NormalizeNoDiacritics(sp.MoTa ?? "");
                        return ten.Contains(needle) || th.Contains(needle) || mt.Contains(needle);
                    });

                    // Tiêu đề cho tìm kiếm
                    lblThuongHieu.Text = $"Kết quả cho: “{Server.HtmlEncode(q)}”";
                }
                // 3b) Chỉ khi KHÔNG có từ khóa mới lọc theo thương hiệu
                else if (!string.IsNullOrEmpty(thuongHieu))
                {
                    query = query.Where(sp =>
                        (sp.ThuongHieu ?? "").Equals(thuongHieu, StringComparison.OrdinalIgnoreCase));

                    // Tiêu đề cho thương hiệu
                    lblThuongHieu.Text = $"Sản phẩm thuộc thương hiệu: {thuongHieu}";
                }
                else
                {
                    // Không có q, không có thương hiệu
                    lblThuongHieu.Text = "Tất cả sản phẩm";
                }

                // 4) Sắp xếp mặc định theo tên (nếu bạn có ApplySortRobust thì thay bằng hàm đó)
                var dsLoc = query.OrderBy(sp => sp.TenSP).ToList();

                // 5) Bind dữ liệu
                rptSanPhamThuongHieu.DataSource = dsLoc;
                rptSanPhamThuongHieu.DataBind();

                // (tuỳ chọn) hiện panel thông báo khi rỗng
                // pnlNoResult.Visible = dsLoc.Count == 0;
            }
        }


        protected void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            Response.Redirect("TKCaNhan.aspx");
        }

        /// <summary>
        /// Bỏ dấu tiếng Việt + đưa về chữ thường (để so khớp không dấu).
        /// </summary>
        private static string NormalizeNoDiacritics(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            string formD = input.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var ch in formD)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (uc != UnicodeCategory.NonSpacingMark)
                    sb.Append(ch);
            }

            return sb.ToString()
                     .Replace('đ', 'd').Replace('Đ', 'D')
                     .ToLowerInvariant()
                     .Normalize(NormalizationForm.FormC);
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
    }
}
