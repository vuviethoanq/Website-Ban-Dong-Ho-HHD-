<%@ Page Title="Điều khoản & Chính sách" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Dieukhoan.aspx.cs" Inherits="WBDH_BTL.Dieukhoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Styles/Dieukhoan.css" />

    <div class="container">
        <div class="dieukhoan-container">
            <h1>CHÍNH SÁCH VÀ ĐIỀU KHOẢN</h1>
            <p>
                Cảm ơn quý khách đã tin tưởng và mua sắm tại <strong>HHD TIME</strong>.
                Dưới đây là các chính sách quan trọng mà quý khách nên đọc kỹ trước khi giao dịch.
            </p>

            <!-- Chính sách bảo hành -->
            <section>
                <h2>1. Chính sách bảo hành</h2>
                <ol>
                    <li>Sản phẩm được bảo hành 5 năm kể từ ngày mua hàng.</li>
                    <li>Chỉ áp dụng bảo hành cho lỗi kỹ thuật do nhà sản xuất.</li>
                    <li>Không áp dụng cho sản phẩm hư hỏng do rơi vỡ, va chạm hoặc nước.</li>
                    <li>Khi bảo hành, khách hàng cần xuất trình hóa đơn hoặc phiếu bảo hành hợp lệ.</li>
                </ol>
            </section>

            <!-- Chính sách đổi trả -->
            <section>
                <h2>2. Chính sách đổi trả</h2>
                <ol>
                    <li>Đổi trả trong vòng 7 ngày kể từ ngày nhận hàng.</li>
                    <li>Sản phẩm còn nguyên tem, hộp và chưa qua sử dụng.</li>
                    <li>Chi phí vận chuyển đổi trả được HHD TIME hỗ trợ 50%.</li>
                    <li>Không áp dụng đổi trả với sản phẩm giảm giá trên 50%.</li>
                </ol>
            </section>

            <!-- Chính sách thanh toán -->
            <section>
                <h2>3. Phương thức thanh toán</h2>
                <ol>
                    <li>Thanh toán khi nhận hàng (COD).</li>
                    <li>Chuyển khoản qua ngân hàng hoặc ví điện tử.</li>
                    <li>Thanh toán online qua thẻ Visa, MasterCard.</li>
                </ol>
            </section>

            <!-- Hướng dẫn mua hàng -->
            <section>
                <h2>4. Hướng dẫn mua hàng</h2>
                <ol>
                    <li>Truy cập website <a href="TrangChu.aspx">hhdtime.vn</a> để chọn sản phẩm.</li>
                    <li>Thêm sản phẩm vào giỏ hàng và tiến hành thanh toán.</li>
                    <li>Nhân viên HHD TIME sẽ liên hệ xác nhận đơn hàng trong 24h.</li>
                    <li>Giao hàng toàn quốc, thời gian từ 2-5 ngày làm việc.</li>
                </ol>
            </section>

            <!-- Điều khoản sử dụng -->
            <section>
                <h2>5. Điều khoản sử dụng website</h2>
                <ol>
                    <li>Người dùng không được sao chép hoặc sử dụng lại nội dung nếu không có sự đồng ý của HHD TIME.</li>
                    <li>HHD TIME có quyền thay đổi, tạm ngừng hoặc chấm dứt dịch vụ bất kỳ lúc nào mà không cần thông báo.</li>
                    <li>Thông tin cá nhân của khách hàng được bảo mật tuyệt đối và chỉ dùng cho mục đích giao dịch.</li>
                </ol>
            </section>

            <hr />

            <p class="ket-luan">
                Mọi thắc mắc xin liên hệ <strong>Hotline: 098.777.9999</strong> hoặc email
                <a href="mailto:hhdtime@gmail.com">hhdtime@gmail.com</a> để được hỗ trợ nhanh nhất.
            </p>
        </div>
    </div>
</asp:Content>
