<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DanhSachSp.aspx.cs" Inherits="WBDH_BTL.DanhSachSp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <link rel="stylesheet" href="Styles/Danhsach.css" />
      <h2 class="tieude">TẤT CẢ SẢN PHẨM</h2>

    <!-- Ô lọc nhanh (tuỳ chọn) -->
    <div class="locnhanh">
        <asp:DropDownList ID="ddlThuongHieu" runat="server" AutoPostBack="true"
            OnSelectedIndexChanged="ddlThuongHieu_SelectedIndexChanged">
        </asp:DropDownList>

        <asp:DropDownList ID="ddlSort" runat="server" AutoPostBack="true"
        OnSelectedIndexChanged="ddlSort_SelectedIndexChanged">
        <asp:ListItem Text="Sắp xếp: Mặc định" Value=""></asp:ListItem>
        <asp:ListItem Text="Giá: Thấp → Cao" Value="price_asc"></asp:ListItem>
        <asp:ListItem Text="Giá: Cao → Thấp" Value="price_desc"></asp:ListItem>
        <asp:ListItem Text="Tên: A → Z" Value="name_asc"></asp:ListItem>
        <asp:ListItem Text="Tên: Z → A" Value="name_desc"></asp:ListItem>
        </asp:DropDownList>


    </div>

    <asp:Repeater ID="rptTatCaSanPham" runat="server">
        <HeaderTemplate>
            <div class="dong-ho-danhsach">
        </HeaderTemplate>

        <ItemTemplate>
                <div class="sanpham">
                    <!-- Ảnh + Tên: bấm vào để xem chi tiết -->
                    <a href='ChiTietSanPham.aspx?masp=<%# Eval("MaSP") %>' class="link-chitiet">
                        <div class="anh-sanpham">
                            <img src='<%# ResolveUrl(Convert.ToString(Eval("Anh"))) %>' alt='<%# Eval("TenSP") %>' />
                        </div>
                    </a>
                <div class="ten-sanpham"><%# Eval("TenSP") %></div>
                <div class="gia-sanpham"><%# Eval("Gia", "{0:N0}₫") %></div>
               <asp:Button ID="btnThemVaoGio" runat="server" Text="Thêm vào giỏ"
                                CommandArgument='<%# Eval("MaSP") %>'
                                OnCommand="btnThemVaoGio_Command" />
            </div>
        </ItemTemplate>

        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
<!-- Thanh phân trang -->
<div class="pager">
    <asp:Literal ID="litPager" runat="server" />
    </div>
</asp:Content>
