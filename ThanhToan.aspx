<%@ Page Title="Thanh toán" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ThanhToan.aspx.cs" Inherits="WBDH_BTL.ThanhToan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Styles/ThanhToan.css" />

    <div class="container thanhtoan-container">
        <h1>💳 Thanh Toán Đơn Hàng</h1>

        <asp:Panel ID="pnlEmpty" runat="server" Visible="false" CssClass="giohang-trong">
            <p>Giỏ hàng của bạn đang trống. Hãy quay lại mua hàng!</p>
            <a href="TrangChu.aspx" class="btn-tieptuc">⬅ Quay lại trang chủ</a>
        </asp:Panel>

        <asp:Panel ID="pnlThanhToan" runat="server">
            <div class="thongtin-nguoi-mua">
                <h3>Thông tin khách hàng</h3>
                <asp:TextBox ID="txtHoTen" runat="server" placeholder="Họ và tên" CssClass="input-box"></asp:TextBox>
                <asp:TextBox ID="txtDiaChi" runat="server" placeholder="Địa chỉ giao hàng" CssClass="input-box"></asp:TextBox>
                <asp:TextBox ID="txtSoDienThoai" runat="server" placeholder="Số điện thoại" CssClass="input-box"></asp:TextBox>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" CssClass="input-box"></asp:TextBox>
            </div>

            <div class="donhang-tongquat">
                <h3>Đơn hàng của bạn</h3>
                <asp:Repeater ID="rptGioHang" runat="server">
                    <HeaderTemplate>
                        <table class="bang-tomtat">
                            <tr>
                                <th>Tên sản phẩm</th>
                                <th>Số lượng</th>
                                <th>Thành tiền</th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                            <tr>
                                <td><%# Eval("TenSP") %></td>
                                <td><%# Eval("SoLuong") %></td>
                                <td><%# Eval("ThanhTien", "{0:N0}₫") %></td>
                            </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>

                <div class="tong-tien">
                    <strong>Tổng cộng: </strong>
                    <asp:Label ID="lblTongTien" runat="server" Text="0₫"></asp:Label>
                </div>

                <asp:Button ID="btnDatHang" runat="server" Text="Xác nhận đặt hàng" CssClass="btn-thanhtoan" OnClick="btnDatHang_Click" />
            </div>
        </asp:Panel>
    </div>
</asp:Content>
