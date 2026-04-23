<%@ Page Title="Chi tiết sản phẩm" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="ChiTietSanPham.aspx.cs" Inherits="WBDH_BTL.ChiTietSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Styles/ChiTietSanPham.css" />

<div class="container-chitiet">
    <div class="khung-chitiet">
        <!-- ẢNH SẢN PHẨM -->
        <div class="cot-trai">
            <asp:Image ID="imgSanPham" runat="server" CssClass="anh-chinh" />
        </div>

        <!-- THÔNG TIN SẢN PHẨM -->
        <div class="cot-phai">
            <h1><asp:Label ID="lblTenSP" runat="server"></asp:Label></h1>
            <p class="gia">Giá: <asp:Label ID="lblGia" runat="server" CssClass="gia-so"></asp:Label></p>
            <p>Thương hiệu: <asp:Label ID="lblThuongHieu" runat="server"></asp:Label></p>

            <p class="mota"><asp:Label ID="lblMoTa" runat="server" /></p>

            <div class="chon-soluong">
                <label for="txtSoLuong">Số lượng:</label>
                <asp:TextBox ID="txtSoLuong" runat="server" Text="1" CssClass="txtSoLuong" />
            </div>

            <div class="khung-themgio">
                <asp:Button ID="btnThemVaoGio" runat="server" Text="🛒 Thêm vào giỏ hàng"
                    CssClass="btnThem" OnClick="btnThemVaoGio_Click" />
            </div>
        </div>
    </div>

    <!-- GỢI Ý SẢN PHẨM -->
    <h2 class="goi-y">SẢN PHẨM CÙNG THƯƠNG HIỆU</h2>
    <div class="goi-y-danhsach">
        <asp:Repeater ID="rptSanPhamLienQuan" runat="server">
            <ItemTemplate>
                <div class="sanpham-lienquan">
                    <img src='<%# Eval("Anh") %>' alt='<%# Eval("TenSP") %>' />
                    <p><%# Eval("TenSP") %></p>
                    <p class="gia"><%# Eval("Gia", "{0:N0}₫") %></p>
                    <a href='ChiTietSanPham.aspx?masp=<%# Eval("MaSP") %>' class="xemchitiet">Xem chi tiết</a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
    </asp:Content>