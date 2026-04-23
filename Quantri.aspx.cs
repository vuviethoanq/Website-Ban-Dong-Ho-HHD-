using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;

namespace WBDH_BTL
{
    public partial class Quantri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Chỉ cho Admin vào
            var acc = Session["UserLogin"] as Account;
            if (acc == null) { Response.Redirect("Dangnhap.aspx"); return; }
            if (!string.Equals(acc.VaiTro, "Admin", StringComparison.OrdinalIgnoreCase))
            { Response.Redirect("TrangChu.aspx"); return; }

            if (!IsPostBack)
            {
                LoadSanPham();
            }
        }

        // Lấy danh sách sản phẩm từ Application
        private List<SanPham> Ds()
        {
            var ds = Application["DanhSachSanPham"] as List<SanPham>;
            if (ds == null)
            {
                ds = new List<SanPham>();
                Application["DanhSachSanPham"] = ds;
            }
            return ds;
        }

        private void LoadSanPham()
        {
            gvSanPham.DataSource = Ds();
            gvSanPham.DataBind();
        }

        /* ===================== MỞ POPUP SỬA ===================== */
        protected void gvSanPham_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editPopup")
            {
                string ma = Convert.ToString(e.CommandArgument);
                var sp = Ds().FirstOrDefault(x => x.MaSP == ma);
                if (sp == null) return;

                hfEditingId.Value = ma; // đang sửa
                lblPopupTitle.Text = "Sửa sản phẩm: " + ma;

                txtTen_Edit.Text = sp.TenSP;
                txtGia_Edit.Text = sp.Gia.ToString("0");
                txtThuongHieu_Edit.Text = sp.ThuongHieu;
                txtMoTa_Edit.Text = sp.MoTa;
                imgPreview.ImageUrl = ResolveUrl(sp.Anh ?? "~/images/default.jpg");

                ShowPopup(true);
            }
        }

        /* ===================== XÓA ===================== */
        protected void gvSanPham_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string ma = gvSanPham.DataKeys[e.RowIndex].Value.ToString();
            var ds = Ds();
            var sp = ds.FirstOrDefault(x => x.MaSP == ma);
            if (sp != null)
            {
                Application.Lock();
                try
                {
                    ds.Remove(sp);
                    Application["DanhSachSanPham"] = ds;
                }
                finally { Application.UnLock(); }
                lblMsg.Text = "Đã xóa sản phẩm.";
                lblMsg.CssClass = "ok";
            }
            LoadSanPham();
        }

        /* ===================== MỞ POPUP THÊM MỚI ===================== */
        protected void btnOpenAdd_Click(object sender, EventArgs e)
        {
            hfEditingId.Value = ""; // rỗng = thêm mới
            lblPopupTitle.Text = "Thêm sản phẩm mới";

            txtTen_Edit.Text = "";
            txtGia_Edit.Text = "";
            txtThuongHieu_Edit.Text = "";
            txtMoTa_Edit.Text = "";
            imgPreview.ImageUrl = ""; // chưa có ảnh

            ShowPopup(true);
        }

        /* ===================== LƯU (SỬA / THÊM) + UPLOAD ẢNH ===================== */
        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            lblMsg.CssClass = "";

            var ds = Ds();

            string ma = hfEditingId.Value;               // rỗng = thêm mới
            bool isAdd = string.IsNullOrEmpty(ma);

            // Parse giá
            if (!decimal.TryParse((txtGia_Edit.Text ?? "").Replace(",", "").Trim(), out decimal gia))
            {
                lblMsg.Text = "Giá không hợp lệ.";
                lblMsg.CssClass = "error";
                ShowPopup(true);
                return;
            }

            // ===== Upload ảnh nếu có =====
            string newImageUrl = null;
            if (fuAnh.HasFile)
            {
                if (!IsValidImage(fuAnh))
                {
                    lblMsg.Text = "Ảnh không hợp lệ (chỉ .jpg .jpeg .png .webp, ≤ 3MB).";
                    lblMsg.CssClass = "error";
                    ShowPopup(true);
                    return;
                }

                string uploads = Server.MapPath("~/images/uploads/");
                if (!Directory.Exists(uploads)) Directory.CreateDirectory(uploads);

                string ext = Path.GetExtension(fuAnh.FileName).ToLower();
                string safeName = Guid.NewGuid().ToString("N") + ext;
                string savePath = Path.Combine(uploads, safeName);

                fuAnh.SaveAs(savePath);
                newImageUrl = "~/images/uploads/" + safeName; // lưu dạng ảo
            }

            if (isAdd)
            {
                // Tự sinh Mã SP nếu bạn chưa có ô nhập Mã
                int next = ds.Count + 1;
                ma = "SP" + next.ToString("00");
                while (ds.Any(x => x.MaSP == ma))
                {
                    next++;
                    ma = "SP" + next.ToString("00");
                }

                var spNew = new SanPham
                {
                    MaSP = ma,
                    TenSP = txtTen_Edit.Text.Trim(),
                    Gia = (double)gia,
                    ThuongHieu = txtThuongHieu_Edit.Text.Trim(),
                    MoTa = txtMoTa_Edit.Text.Trim(),
                    Anh = newImageUrl ?? "~/images/default.jpg"
                };

                Application.Lock();
                try
                {
                    ds.Add(spNew);
                    Application["DanhSachSanPham"] = ds;
                }
                finally { Application.UnLock(); }

                lblMsg.Text = $"Đã thêm {ma}.";
                lblMsg.CssClass = "ok";
            }
            else
            {
                var sp = ds.FirstOrDefault(x => x.MaSP == ma);
                if (sp == null)
                {
                    lblMsg.Text = "Không tìm thấy sản phẩm.";
                    lblMsg.CssClass = "error";
                    ShowPopup(false);
                    LoadSanPham();
                    return;
                }

                sp.TenSP = txtTen_Edit.Text.Trim();
                sp.Gia = (double)gia;
                sp.ThuongHieu = txtThuongHieu_Edit.Text.Trim();
                sp.MoTa = txtMoTa_Edit.Text.Trim();
                if (newImageUrl != null) sp.Anh = newImageUrl;

                Application["DanhSachSanPham"] = ds;

                lblMsg.Text = "Đã lưu thay đổi.";
                lblMsg.CssClass = "ok";
            }

            // Đóng popup và refresh lưới
            ShowPopup(false);
            LoadSanPham();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ShowPopup(false);
        }

        /* ===================== TIỆN ÍCH ===================== */

        // Bật/tắt popup bằng inline style (khỏi phụ thuộc CSS)
        private void ShowPopup(bool show)
        {
            // luôn render div để có thể đổi display
            popup.Visible = true;
            popup.Style["display"] = show ? "flex" : "none";
        }

        // Kiểm tra file ảnh
        private bool IsValidImage(FileUpload fu)
        {
            var allowed = new[] { ".jpg", ".jpeg", ".png", ".webp" };
            string ext = Path.GetExtension(fu.FileName).ToLower();
            if (!allowed.Contains(ext)) return false;

            // Tối đa 3MB
            if (fu.PostedFile == null) return false;
            if (fu.PostedFile.ContentLength > 3 * 1024 * 1024) return false;

            return true;
        }
    }
}
