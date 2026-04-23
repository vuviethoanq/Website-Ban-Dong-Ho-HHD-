<%@ Page Title="Tài khoản cá nhân" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Taikhoancanhan.aspx.cs" Inherits="WBDH_BTL.Taikhoancanhan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="Styles/tkcanhan.css" />

    <!-- =================== NỘI DUNG CHÍNH =================== -->
    <div class="account-container">
        <h2>👤 TÀI KHOẢN CÁ NHÂN</h2>

        <asp:Panel ID="pnlInfo" runat="server">
            <p><strong>Họ tên:</strong> <asp:Label ID="lblHoTen" runat="server" /></p>
            <p><strong>Email:</strong> <asp:Label ID="lblEmail" runat="server" /></p>

            <asp:Button ID="btnDangXuat" runat="server" Text="Đăng xuất" CssClass="btnLogout" OnClick="btnDangXuat_Click" />
        </asp:Panel>

        <div class="doi-mk">
            <h3>🔑 ĐỔI MẬT KHẨU</h3>
            <asp:TextBox ID="txtOldPass" runat="server" TextMode="Password" CssClass="input-box" placeholder="Mật khẩu cũ"></asp:TextBox>
            <asp:TextBox ID="txtNewPass" runat="server" TextMode="Password" CssClass="input-box" placeholder="Mật khẩu mới"></asp:TextBox>
            <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password" CssClass="input-box" placeholder="Nhập lại mật khẩu mới"></asp:TextBox>

            <asp:Button ID="btnDoiMatKhau" runat="server" Text="Đổi mật khẩu" CssClass="btnChangePass" OnClick="btnDoiMatKhau_Click" />
            <asp:Label ID="lblThongBao" runat="server" CssClass="thongbao"></asp:Label>
        </div>
    </div>

</asp:Content>
