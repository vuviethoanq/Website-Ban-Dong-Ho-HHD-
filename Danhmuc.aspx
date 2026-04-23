<%@ Page Title="Danh mục sản phẩm" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Danhmuc.aspx.cs" Inherits="WBDH_BTL.Danhmuc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="Styles/Trangchu.css" />

    <!-- =================== NỘI DUNG CHÍNH =================== -->
    <h2 class="tieude">
        <asp:Label ID="lblThuongHieu" runat="server" Text=""></asp:Label>
    </h2>

    <div class="dong-ho-danhsach">
        <asp:Repeater ID="rptSanPhamThuongHieu" runat="server">
            <ItemTemplate>
                <div class="sanpham">
                    <!-- Ảnh + Tên: bấm vào để xem chi tiết -->
                    <a href='ChiTietSanPham.aspx?masp=<%# Eval("MaSP") %>' class="link-chitiet">
                        <div class="anh-sanpham">
                            <img src='<%# ResolveUrl(Convert.ToString(Eval("Anh"))) %>' alt='<%# Eval("TenSP") %>' />
                        </div>
                    </a>
                    <div class="tensanpham"><%# Eval("TenSP") %></div>
                    <div class="gia"><%# Eval("Gia", "{0:N0}₫") %></div>
                    <asp:Button ID="btnThemVaoGio" runat="server" Text="Thêm vào giỏ"
                                CommandArgument='<%# Eval("MaSP") %>'
                                OnCommand="btnThemVaoGio_Command" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>


