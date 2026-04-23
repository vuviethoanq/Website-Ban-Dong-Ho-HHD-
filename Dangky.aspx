<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangky.aspx.cs" Inherits="WBDH_BTL.Dangky" %>

<!DOCTYPE html>
<html lang="vi">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Đăng ký - HHD TIME</title>
    <link rel="stylesheet" href="Styles/dangky.css" />
    <script src="Scripts/dangky-validation.js"></script>
</head>
<body class="page-signup">
<form id="form1" runat="server">
    <div class="container">
        <!-- Cột chào mừng -->
        <div class="welcome-section">
            <h1 class="welcome">HHD TIME</h1>
            <p>Đồng hồ chính hãng – Bảo hành chuẩn xác</p>
        </div>

        <!-- Cột form đăng ký -->
        <div class="form-section">
            <h2 class ="dktk">Đăng ký tài khoản</h2>

            <!-- Tên đăng nhập -->
            <asp:TextBox ID="txtFullname" runat="server" CssClass="aspNetInput" placeholder="Tên đăng nhập" />
            <asp:Label ID="errFullname" runat="server" ClientIDMode="Static"
           CssClass="error" Text="&nbsp;" />

            <!-- Email -->
            <asp:TextBox ID="txtEmail" runat="server" CssClass="aspNetInput" TextMode="Email" placeholder="Email" />
            <asp:Label ID="errEmail" runat="server" ClientIDMode="Static"
           CssClass="error" Text="&nbsp;" />

            <!-- Số điện thoại (MỚI) -->
            <asp:TextBox ID="txtPhone" runat="server" CssClass="aspNetInput" TextMode="Phone" placeholder="Số điện thoại" />
            <asp:Label ID="errPhone" runat="server" ClientIDMode="Static"
           CssClass="error" Text="&nbsp;" />

            <!--Que quan-->
            <asp:TextBox ID="txtCountry" runat="server" CssClass="aspNetInput" placeholder="Quê quán" />
            <asp:Label ID="errCountry" runat="server" ClientIDMode="Static"
                CssClass="error" Text="&nbsp;" />

            <!-- Mật khẩu -->
            <asp:TextBox ID="txtPassword" runat="server" CssClass="aspNetInput" TextMode="Password" placeholder="Mật khẩu" />
           <asp:Label ID="errPassword" runat="server" ClientIDMode="Static"
           CssClass="error" Text="&nbsp;" />

            <!-- Nhập lại mật khẩu -->
            <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="aspNetInput" TextMode="Password" placeholder="Nhập lại mật khẩu" />
         <asp:Label ID="errConfirm" runat="server" ClientIDMode="Static"
           CssClass="error" Text="&nbsp;" />

            <!-- Nút / Thông báo -->
            <asp:Button ID="btnDangKy" runat="server" CssClass="btndangky" Text="Đăng ký"
                        OnClick="btnDangKy_Click"
                        OnClientClick="return validateRegisterForm();" />

            <asp:Label ID="lblThongBao" runat="server" CssClass="server-msg" ForeColor="Red"></asp:Label>

            <p class ="DaCoTK">
                Bạn đã có tài khoản?
                <asp:HyperLink ID="lnkDangNhap" runat="server" NavigateUrl="DangNhap.aspx" CssClass="switch-form">Đăng nhập</asp:HyperLink>
            </p>
        </div>
    </div>
</form>
</body>
</html>
