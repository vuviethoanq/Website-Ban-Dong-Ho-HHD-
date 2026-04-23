<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangnhap.aspx.cs" Inherits="WBDH_BTL.Dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Đăng nhập - HHD TIME</title>
    <link rel="stylesheet" href="Styles/dangnhap.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <!-- Cột chào mừng -->
            <div class="welcome-section">
                <h1 class="welcome">HHD TIME</h1>
                <p>Chào mừng đến với cửa hàng của chúng tôi!</p>
            </div>

            <!-- Cột form đăng nhập -->
            <div class="forms-container">
                <div class="form-container">
                    <h2>ĐĂNG NHẬP</h2>

                    <asp:TextBox ID="txtEmail" runat="server" CssClass="aspNetInput" placeholder="Enter your Email" TextMode="Email"></asp:TextBox>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="aspNetInput" placeholder="Enter your password" TextMode="Password"></asp:TextBox>

                    <asp:Button ID="btnDangNhap" runat="server" CssClass="btndangnhap" Text="Đăng nhập" OnClick="btnDangNhap_Click" />

                    <asp:Label ID="lblThongBao" runat="server" ForeColor="Red" EnableViewState="false"></asp:Label>

                    <p>
                        Bạn chưa có tài khoản?
                        <asp:HyperLink ID="lnkDangKy" runat="server" NavigateUrl="DangKy.aspx" CssClass="switch-form">Đăng ký</asp:HyperLink>
                    </p>
                    <p>
                        <asp:HyperLink ID="lnkQuenMK" runat="server" NavigateUrl="QuenMK.aspx" CssClass="switch-form">Quên mật khẩu</asp:HyperLink>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
