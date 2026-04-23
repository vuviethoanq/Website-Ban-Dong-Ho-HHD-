<%@ Page Title="Trang chủ" Language="C#" MasterPageFile="~/Site.master"
    AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="WBDH_BTL.TrangChu" %>

<asp:Content ID="ContentMain" ContentPlaceHolderID="MainContent" runat="server">
    <!-- CSS riêng cho trang chủ -->
    <link rel="stylesheet" href="Styles/TrangChu.css" />


            <!-- ========== BANNER ========== -->
        <div class="banner">
            <button class="prev">❮</button>
            <div class="slider-wrapper">
                <div class="slider" id="slider">
                    <img src="logo/banner1.jpg" alt="Banner 1" />
                    <img src="logo/banner2.jpg" alt="Banner 2" />
                    <img src="logo/banner3.jpg" alt="Banner 3" />
                </div>
            </div>
            <button class="next">❯</button>
        </div>

        <!-- ========== LOGO THƯƠNG HIỆU ========== -->
        <div class="danh-sach-logo">
            <div class="thuong-hieu"><img src="logo/tudor.png" alt="Tudor" /></div>
            <div class="thuong-hieu"><img src="logo/speake-marin.png" alt="Speake Marin" /></div>
            <div class="thuong-hieu"><img src="logo/iwc.png" alt="IWC" /></div>
            <div class="thuong-hieu"><img src="logo/rolex.png" alt="Rolex" /></div>
            <div class="thuong-hieu"><img src="logo/patek.png" alt="Patek" /></div>
            <div class="thuong-hieu"><img src="logo/vacheron.png" alt="VC" /></div>
            <div class="thuong-hieu"><img src="logo/blancpain.png" alt="Blancpain" /></div>
            <div class="thuong-hieu"><img src="logo/breguet.png" alt="Breguet" /></div>
            <div class="thuong-hieu"><img src="logo/breitling.png" alt="Breitling" /></div>
            <div class="thuong-hieu"><img src="logo/girard.png" alt="Girard" /></div>
        </div>


    <!-- =================== SẢN PHẨM NỔI BẬT =================== -->
    <h2 class="tieude">SẢN PHẨM NỔI BẬT</h2>
    <div class="dong-ho-danhsach">
        <asp:Repeater ID="rptSanPham" runat="server">
            <ItemTemplate>
                <div class="sanpham">
                    <!-- Ảnh + Tên: bấm vào để xem chi tiết -->
                    <a href='ChiTietSanPham.aspx?masp=<%# Eval("MaSP") %>' class="link-chitiet">
                        <div class="anh-sanpham">
                            <img src='<%# ResolveUrl(Convert.ToString(Eval("Anh"))) %>' alt='<%# Eval("TenSP") %>' />
                        </div>
                    </a>
                    <div class="tensanpham"><%# Eval("TenSP") %></div>
                    <!-- Giá -->
                    <div class="gia"><%# Eval("Gia", "{0:N0}₫") %></div>

                    <!-- Nút thêm vào giỏ -->
                    <asp:Button ID="btnThemVaoGio" runat="server" Text="Thêm vào giỏ"
                        CommandArgument='<%# Eval("MaSP") %>'
                        OnCommand="btnThemVaoGio_Command" CssClass="aspNetButton" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <!-- =================== BÀI VIẾT MỚI =================== -->
<h2 class="tieude">BÀI VIẾT MỚI</h2>
<div class="posts-grid">
  <article class="post-card">
    <img src="logo/baiviet1.jpg" alt="Thay pin đồng hồ" />
    <h3><a href="#">Thay pin đồng hồ hết bao nhiêu tiền là hợp lý</a></h3>
  </article>

  <article class="post-card">
    <img src="logo/baiviet2.jpg" alt="Giá Rolex 2025" />
    <h3><a href="#">Giá đồng hồ Rolex 2025 – Cập nhật mới nhất</a></h3>
  </article>

  <article class="post-card">
    <img src="logo/baiviet3.jpg" alt="Blancpain 38mm" />
    <h3><a href="#">Blancpain bổ sung sản phẩm 38mm đầy ấn tượng</a></h3>
  </article>

  <article class="post-card">
    <img src="logo/baiviet4.jpg" alt="Omega 8939" />
    <h3><a href="#">Thay đáy, đánh bóng đồng hồ Omega 8939</a></h3>
  </article>
</div>

<!-- =================== TIN TỨC & VIDEO =================== -->
<h2 class="tieude">TIN TỨC & VIDEO</h2>
<div class="khung-tin-video">
    <!-- CỘT TRÁI: BÀI VIẾT -->
    <div class="cot-trai">
        <div class="bai-viet">
            <img src="logo/baiviet5.jpg" alt="Frederique Constant" />
            <div class="noi-dung">
                <p class="tieu-de-nho"><strong>Thương hiệu Frederique Constant (FC)</strong></p>
                <p class="mo-ta">Những mẫu Dress Watch thanh lịch, tinh tế cho doanh nhân.</p>
            </div>
        </div>

        <div class="bai-viet">
            <img src="logo/baiviet6.jpg" alt="Seiko Presage SPB497" />
            <div class="noi-dung">
                <p class="tieu-de-nho"><strong>Seiko ra mắt đồng hồ sứ Arita Presage Classic</strong></p>
                <p class="mo-ta">Giới thiệu phiên bản giới hạn Presage SPB497.</p>
            </div>
        </div>

        <div class="bai-viet">
            <img src="logo/baiviet7.jpg" alt="Seiko Presage Classic Edo Silk" />
            <div class="noi-dung">
                <p class="tieu-de-nho"><strong>Dòng Seiko Presage Classic mới “Edo Silk”</strong></p>
                <p class="mo-ta">Kết hợp tinh hoa thẩm mỹ Nhật Bản trong từng chi tiết.</p>
            </div>
        </div>
    </div>

    <!-- CỘT PHẢI: VIDEO -->
    <div class="cot-phai">
        <div class="khung-video">
            <video controls poster="logo/baiviet2.jpg">
                <source src="images/Rolex.mp4" type="video/mp4" />
                Trình duyệt của bạn không hỗ trợ phát video.
            </video>
            <div class="mo-ta-video">
                <p class="tieu-de-video"><strong>2025 – The Land-Dweller</strong></p>
                <p class="phu-de-video">Rolex new watches</p>
            </div>
        </div>
    </div>
</div>

    <!-- =================== CAM KẾT DỊCH VỤ =================== -->
    <div class="section cam-ket">
        <div>
            <img src="logo/authenticity.png" alt="Chính hãng" />
            <h4>CAM KẾT CHÍNH HÃNG</h4>
            <p>Phát hiện hàng giả đền gấp 10 lần giá trị.</p>
        </div>
        <div>
            <img src="logo/free-delivery.png" alt="Miễn phí vận chuyển" />
            <h4>MIỄN PHÍ VẬN CHUYỂN</h4>
            <p>Toàn quốc, đổi trả dễ dàng.</p>
        </div>
        <div>
            <img src="logo/waranty.png" alt="Bảo hành" />
            <h4>BẢO HÀNH 5 NĂM</h4>
            <p>Phòng kỹ thuật đạt chuẩn, hậu mãi tận tâm.</p>
        </div>
    </div>
</asp:Content>
