using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WBDH_BTL
{
    public partial class DanhSachSp : System.Web.UI.Page
    {
        private int PageSize => 10;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NapThuongHieu();
                HienThiDanhSach();
            }
        }

        private void HienThiDanhSach()
        {
            var ds = Application["DanhSachSanPham"] as List<SanPham> ?? new List<SanPham>();

            // --- lọc + sắp xếp như bạn đang có ---
            string brand = ddlThuongHieu.SelectedValue;
            if (!string.IsNullOrEmpty(brand) && brand != "__ALL__")
                ds = ds.Where(sp => (sp.ThuongHieu ?? "")
                        .Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();

            string sort = ddlSort.SelectedValue;
            var query = ApplySort(ds, sort);

            // --- phân trang ---
            int pageSize = 10; // hoặc giá trị bạn muốn
            int page = 1; int.TryParse(Request["page"], out page);
            if (page < 1) page = 1;

            int total = query.Count();
            int totalPages = (int)Math.Ceiling(total / (double)pageSize);
            if (totalPages == 0) totalPages = 1;
            if (page > totalPages) page = totalPages;

            var pageData = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            rptTatCaSanPham.DataSource = pageData;
            rptTatCaSanPham.DataBind();

            litPager.Text = BuildPager(totalPages, page, pageSize);
        }

        private string BuildPager(int totalPages, int current, int pageSize)
        {
            // baseUrl = chính trang hiện tại (ví dụ /DanhSachSp.aspx, hoặc /Pages/DanhSachSp.aspx)
            string baseUrl = ResolveUrl(Request.Path);

            // giữ lại các tham số hiện có (brand/sort/…)
            var qs = System.Web.HttpUtility.ParseQueryString(Request.QueryString.ToString());
            qs.Set("pageSize", pageSize.ToString());

            string MakeUrl(int p)
            {
                qs.Set("page", p.ToString());
                return baseUrl + "?" + qs.ToString();
            }

            var sb = new System.Text.StringBuilder();
            sb.Append("<div>");

            // Prev
            sb.Append(current > 1
                ? $"<a href='{MakeUrl(current - 1)}'>‹ Trước</a>"
                : "<span class='disabled'>‹ Trước</span>");

            int window = 2;
            int start = Math.Max(1, current - window);
            int end = Math.Min(totalPages, current + window);

            if (start > 1)
            {
                sb.Append($"<a href='{MakeUrl(1)}'>1</a>");
                if (start > 2) sb.Append("<span>…</span>");
            }

            for (int i = start; i <= end; i++)
            {
                if (i == current) sb.Append($"<span class='current'>{i}</span>");
                else sb.Append($"<a href='{MakeUrl(i)}'>{i}</a>");
            }

            if (end < totalPages)
            {
                if (end < totalPages - 1) sb.Append("<span>…</span>");
                sb.Append($"<a href='{MakeUrl(totalPages)}'>{totalPages}</a>");
            }

            // Next
            sb.Append(current < totalPages
                ? $"<a href='{MakeUrl(current + 1)}'>Sau ›</a>"
                : "<span class='disabled'>Sau ›</span>");

            sb.Append("</div>");
            return sb.ToString();
        }


        private IEnumerable<SanPham> ApplySort(IEnumerable<SanPham> query, string sort)
        {
            switch (sort)
            {
                case "price_asc":
                    return query.OrderBy(x => x.Gia).ThenBy(x => x.TenSP);
                case "price_desc":
                    return query.OrderByDescending(x => x.Gia).ThenBy(x => x.TenSP);
                case "name_asc":
                    return query.OrderBy(x => x.TenSP);
                case "name_desc":
                    return query.OrderByDescending(x => x.TenSP);
                case "brand_asc":
                    return query.OrderBy(x => x.ThuongHieu).ThenBy(x => x.TenSP);
                case "brand_desc":
                    return query.OrderByDescending(x => x.ThuongHieu).ThenBy(x => x.TenSP);
                default:
                    // Mặc định: theo tên A→Z
                    return query.OrderBy(x => x.TenSP);
            }
        }

        private void NapThuongHieu()
        {
            var ds = Application["DanhSachSanPham"] as List<SanPham> ?? new List<SanPham>();
            var thuongHieuList = ds.Select(sp => sp.ThuongHieu)
                                   .Where(s => !string.IsNullOrWhiteSpace(s))
                                   .Distinct(StringComparer.OrdinalIgnoreCase)
                                   .OrderBy(x => x)
                                   .ToList();

            ddlThuongHieu.Items.Clear();
            ddlThuongHieu.Items.Add(new ListItem("Tất cả thương hiệu", "__ALL__"));
            foreach (var th in thuongHieuList)
                ddlThuongHieu.Items.Add(new ListItem(th, th));
        }

        protected void ddlThuongHieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        protected void ddlSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDanhSach();
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