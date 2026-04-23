<%@ Page Title="Quản trị sản phẩm"
    Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Quantri.aspx.cs" Inherits="WBDH_BTL.Quantri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<link rel="stylesheet" href="Styles/Admin.css" />

<div class="admin-container">
  <h2>QUẢN LÝ SẢN PHẨM</h2>

  <div class="admin-bar">
    <asp:Button ID="btnOpenAdd" runat="server" Text="Thêm sản phẩm"
            CssClass="btn-admin" OnClick="btnOpenAdd_Click"
            CausesValidation="false" />

    <asp:Label ID="lblMsg" runat="server" />
  </div>

  <!-- BẢNG SẢN PHẨM -->
  <asp:GridView ID="gvSanPham" runat="server" AutoGenerateColumns="False" DataKeyNames="MaSP"
      OnRowCommand="gvSanPham_RowCommand"
      OnRowDeleting="gvSanPham_RowDeleting"
      CssClass="table-admin" GridLines="None" CellPadding="6" Width="100%">
    <Columns>
      <asp:BoundField DataField="MaSP" HeaderText="Mã SP" ReadOnly="True" />
      <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" />
      <asp:BoundField DataField="Gia" HeaderText="Giá (VNĐ)" DataFormatString="{0:N0}" />
      <asp:BoundField DataField="ThuongHieu" HeaderText="Thương hiệu" />
      <asp:TemplateField HeaderText="Ảnh">
        <ItemTemplate>
          <img src='<%# ResolveUrl(Convert.ToString(Eval("Anh"))) %>' 
     style="max-width:80px;max-height:80px;object-fit:cover;border-radius:8px;border:1px solid #eee" />
        </ItemTemplate>
      </asp:TemplateField>
      <asp:BoundField DataField="MoTa" HeaderText="Mô tả" />
      <asp:TemplateField>
        <ItemTemplate>
          <asp:LinkButton ID="btnSua" runat="server" Text="Sửa"
              CommandName="editPopup" CommandArgument='<%# Eval("MaSP") %>' />
        </ItemTemplate>
      </asp:TemplateField>
      <asp:TemplateField>
        <ItemTemplate>
          <asp:LinkButton ID="btnXoa" runat="server" Text="Xóa" CommandName="Delete"
            OnClientClick="return confirm('Xóa sản phẩm này?');" CssClass="delete-link" />
        </ItemTemplate>
      </asp:TemplateField>
    </Columns>
    <HeaderStyle BackColor="#002040" ForeColor="White" />
    <AlternatingRowStyle BackColor="#f6f8fb" />
  </asp:GridView>
</div>

<!-- ========== MODAL POPUP ========== -->
<style>
  .modal-mask{position:fixed;inset:0;background:rgba(0,0,0,.45);display:none;align-items:center;justify-content:center;z-index:9999}
  .modal{background:#fff;width:min(720px,94vw);border-radius:14px;box-shadow:0 10px 40px rgba(0,0,0,.2);padding:18px}
  .modal h3{margin:0 0 12px;color:#002040}
  .modal-grid{display:grid;grid-template-columns:1fr 1fr;gap:10px}
  .modal-grid .full{grid-column:1/-1}
  .modal .btns{display:flex;gap:8px;justify-content:flex-end;margin-top:12px}
</style>

<div id="popup" runat="server" class="modal-mask" visible="false">
  <div class="modal">
    <h3><asp:Label ID="lblPopupTitle" runat="server" Text="Sửa sản phẩm" /></h3>

    <!-- giữ mã SP đang sửa/đang thêm -->
    <asp:HiddenField ID="hfEditingId" runat="server" />

    <div class="modal-grid">
      <asp:TextBox ID="txtTen_Edit" runat="server" CssClass="input-admin" placeholder="Tên sản phẩm" />
      <asp:TextBox ID="txtGia_Edit" runat="server" CssClass="input-admin" placeholder="Giá (VNĐ)" />
      <asp:TextBox ID="txtThuongHieu_Edit" runat="server" CssClass="input-admin" placeholder="Thương hiệu" />
      <div class="full">
        <asp:TextBox ID="txtMoTa_Edit" runat="server" CssClass="input-admin" placeholder="Mô tả" />
      </div>

      <!-- ẢNH: chọn file từ máy người dùng -->
      <div class="full">
        <label>Ảnh sản phẩm (chọn file từ máy):</label><br />
        <asp:FileUpload ID="fuAnh" runat="server" />
        <small>Hỗ trợ: .jpg .jpeg .png .webp (tối đa 3MB)</small>
        <div style="margin-top:6px">
          Ảnh hiện tại:
          <asp:Image ID="imgPreview" runat="server" Style="max-width:120px;max-height:120px;border:1px solid #eee;border-radius:8px" />
        </div>
      </div>
    </div>

    <div class="btns">
      <asp:Button ID="btnSave" runat="server" Text="Lưu" CssClass="btn-admin" OnClick="btnSave_Click" />
      <asp:Button ID="btnCancel" runat="server" Text="Hủy" CssClass="btn-admin btn-danger" OnClick="btnCancel_Click" CausesValidation="false" />
    </div>
  </div>
</div>
</asp:Content>
