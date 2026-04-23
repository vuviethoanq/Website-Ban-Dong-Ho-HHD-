<%@ Page Title="Giỏ hàng" Language="C#" MasterPageFile="~/Site.master"
    AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="WBDH_BTL.GioHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Styles/GioHang.css" />

    <div class="container giohang-container">
        <h1>🛒 GIỎ HÀNG CỦA BẠN</h1>

        <!-- Khi giỏ hàng trống -->
        <asp:Panel ID="pnlEmpty" runat="server" Visible="false" CssClass="giohang-trong">
            <p>Giỏ hàng của bạn đang trống.</p>
            <a href="TrangChu.aspx" class="btn-tieptuc">Tiếp tục mua sắm</a>
        </asp:Panel>

        <!-- Khi có sản phẩm trong giỏ -->
        <asp:Panel ID="pnlCart" runat="server">
            <table class="bang-giohang">
                <thead>
                    <tr>
                        <th>Ảnh</th>
                        <th>Tên sản phẩm</th>
                        <th>Giá</th>
                        <th>Số lượng</th>
                        <th>Thành tiền</th>
                        <th>Xóa</th>
                    </tr>
                </thead>

                <tbody>
                    <asp:Repeater ID="rptGioHang" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><img src='<%# ResolveUrl(Convert.ToString(Eval("Anh"))) %>' width="80" /></td>
                                <td><%# Eval("TenSP") %></td>
                                <td><%# Eval("Gia", "{0:N0}₫") %></td>

                                <td class="soluong">
                                    <asp:Button ID="btnGiam" runat="server" Text="−" CssClass="btn-qty"
                                        CommandName="Giam" CommandArgument='<%# Eval("MaSP") %>'
                                        OnCommand="btnSoLuong_Command" />
                                    <asp:Label ID="lblSoLuong" runat="server" Text='<%# Eval("SoLuong") %>' CssClass="lblSoLuong" />
                                    <asp:Button ID="btnTang" runat="server" Text="+" CssClass="btn-qty"
                                        CommandName="Tang" CommandArgument='<%# Eval("MaSP") %>'
                                        OnCommand="btnSoLuong_Command" />
                                </td>

                                <td><%# Eval("ThanhTien", "{0:N0}₫") %></td>

                                <td>
                                    <asp:Button ID="btnXoa" runat="server" Text="X" CssClass="btn-delete"
                                        CommandName="Xoa" CommandArgument='<%# Eval("MaSP") %>'
                                        OnCommand="btnSoLuong_Command" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>

            <div class="tong-tien">
                Tổng cộng: <strong><asp:Label ID="lblTongTien" runat="server" Text="0₫"></asp:Label></strong>
            </div>

            <div class="nut-giohang">
                <asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật giỏ hàng"
                    CssClass="btn-capnhat" OnClick="btnCapNhat_Click" />
                <asp:Button ID="btnThanhToan" runat="server" Text="Thanh toán"
                    CssClass="btn-thanhtoan" OnClick="btnThanhToan_Click" />
            </div>
        </asp:Panel>
    </div>
</asp:Content>
