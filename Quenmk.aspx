<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quenmk.aspx.cs" Inherits="WBDH_BTL.Quenmk" %>
<!DOCTYPE html>
<html lang="vi">
<head runat="server">
    <meta charset="utf-8" />
    <title>Quên mật khẩu - HHD TIME</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
   <link id="resetCss" runat="server" rel="stylesheet" href="Styles/quenmk.css" />
</head>
<body>
<form id="form1" runat="server">
    <div class="container">
        <div class="reset-box">
            <h2>Khôi phục mật khẩu</h2>

            <asp:ValidationSummary ID="vsErrors"
                runat="server" CssClass="error-message"
                DisplayMode="BulletList" HeaderText="Vui lòng kiểm tra:" />

            <!-- Bước 1: Xác thực email + họ tên -->
            <asp:Panel ID="pnlVerify" runat="server" DefaultButton="btnVerify">
                <asp:TextBox ID="txtEmail" runat="server"
                    CssClass="aspNetInput" placeholder="Email đã đăng ký" />
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                    ControlToValidate="txtEmail" CssClass="error-message"
                    ErrorMessage="Vui lòng nhập email." Display="Dynamic" />
                <asp:RegularExpressionValidator ID="revEmail" runat="server"
                    ControlToValidate="txtEmail" CssClass="error-message" Display="Dynamic"
                    ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
                    ErrorMessage="Định dạng email không hợp lệ." />

                <asp:TextBox ID="txtFullName" runat="server"
                    CssClass="aspNetInput" placeholder="Họ và tên" />
                <asp:RequiredFieldValidator ID="rfvFullName" runat="server"
                    ControlToValidate="txtFullName" CssClass="error-message"
                    ErrorMessage="Vui lòng nhập họ tên." Display="Dynamic" />

                <asp:Button ID="btnVerify" runat="server"
                    Text="Xác thực thông tin"
                    OnClick="btnVerify_Click" />
            </asp:Panel>

            <!-- Bước 2: Đổi mật khẩu mới -->
            <asp:Panel ID="pnlReset" runat="server" Visible="false" DefaultButton="btnChange">
                <asp:TextBox ID="txtNewPass" runat="server" TextMode="Password"
                    CssClass="aspNetInput" placeholder="Mật khẩu mới" />
                <asp:RequiredFieldValidator ID="rfvNewPass" runat="server"
                    ControlToValidate="txtNewPass" CssClass="error-message"
                    ErrorMessage="Vui lòng nhập mật khẩu mới." Display="Dynamic" />
                <asp:RegularExpressionValidator ID="revNewPass" runat="server"
                    ControlToValidate="txtNewPass" CssClass="error-message" Display="Dynamic"
                    ValidationExpression="^.{6,}$"
                    ErrorMessage="Mật khẩu cần ít nhất 6 ký tự." />

                <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"
                    CssClass="aspNetInput" placeholder="Xác nhận mật khẩu mới" />
                <asp:RequiredFieldValidator ID="rfvConfirm" runat="server"
                    ControlToValidate="txtConfirm" CssClass="error-message"
                    ErrorMessage="Vui lòng nhập lại mật khẩu." Display="Dynamic" />
                <asp:CompareValidator ID="cvPass" runat="server"
                    ControlToValidate="txtConfirm" ControlToCompare="txtNewPass"
                    CssClass="error-message" Display="Dynamic"
                    ErrorMessage="Mật khẩu xác nhận không khớp." />

                <asp:Button ID="btnChange" runat="server"
                    Text="Đổi mật khẩu"
                    OnClick="btnChange_Click" />
            </asp:Panel>

            <asp:Label ID="lblThongBao" runat="server" EnableViewState="false"></asp:Label>

            <div class="links">
                <a href="Dangnhap.aspx">← Quay lại đăng nhập</a>
                <a href="Dangky.aspx">Tạo tài khoản mới →</a>
            </div>
        </div>
    </div>
</form>
</body>
</html>
