using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WBDH_BTL
{
    public class DataInitializer
    {
         public static List<SanPham> GetSanPhamList()
        {
            var list = new List<SanPham>
            {
                // --------- AUDEMARS PIGUET ----------
                new SanPham { MaSP = "SP01", TenSP = "Audemars Piguet Royal Oak Offshore Chronograph Black", Gia = 950000000, Anh = "images/audemarspiguet1.jpg", ThuongHieu = "Audemars Piguet" },
                new SanPham { MaSP = "SP02", TenSP = "Audemars Piguet Royal Oak Frosted Silver", Gia = 870000000, Anh = "images/audemarspiguet2.jpg", ThuongHieu = "Audemars Piguet" },
                new SanPham { MaSP = "SP03", TenSP = "Audemars Piguet Royal Oak Skeleton Blue Gems", Gia = 1250000000, Anh = "images/audemarspiguet3.jpg", ThuongHieu = "Audemars Piguet" },
                new SanPham { MaSP = "SP04", TenSP = "Audemars Piguet Royal Oak Blue Dial Diamonds", Gia = 1350000000, Anh = "images/audemarspiguet4.jpg", ThuongHieu = "Audemars Piguet" },
                new SanPham { MaSP = "SP05", TenSP = "Audemars Piguet Royal Oak Skeleton Gold", Gia = 1500000000, Anh = "images/audemarspiguet5.jpg", ThuongHieu = "Audemars Piguet" },
                new SanPham { MaSP = "SP06", TenSP = "Audemars Piguet Royal Oak Offshore Tourbillon Red", Gia = 1600000000, Anh = "images/audemarspiguet6.jpg", ThuongHieu = "Audemars Piguet" },
                new SanPham { MaSP = "SP07", TenSP = "Audemars Piguet Royal Oak Frosted Pink Gold", Gia = 1100000000, Anh = "images/audemarspiguet7.jpg", ThuongHieu = "Audemars Piguet" },
                new SanPham { MaSP = "SP08", TenSP = "Audemars Piguet Royal Oak Offshore Diver Red", Gia = 980000000, Anh = "images/audemarspiguet8.jpg", ThuongHieu = "Audemars Piguet" },
                new SanPham { MaSP = "SP09", TenSP = "Audemars Piguet Royal Oak Two-Tone Strap", Gia = 920000000, Anh = "images/audemarspiguet9.jpg", ThuongHieu = "Audemars Piguet" },
                new SanPham { MaSP = "SP10", TenSP = "Audemars Piguet Royal Oak Offshore Chronograph Blue", Gia = 1120000000, Anh = "images/audemarspiguet10.jpg", ThuongHieu = "Audemars Piguet" },

                // --------- BREITLING ----------
                new SanPham { MaSP = "SP11", TenSP = "Breitling Chronomat B01 Blue", Gia = 380000000, Anh = "images/b1.jpg", ThuongHieu = "Breitling" },
                new SanPham { MaSP = "SP12", TenSP = "Breitling Navitimer B01 Black", Gia = 410000000, Anh = "images/b2.jpg", ThuongHieu = "Breitling" },
                new SanPham { MaSP = "SP13", TenSP = "Breitling Chronomat B01 Rose Gold Blue", Gia = 550000000, Anh = "images/b3.jpg", ThuongHieu = "Breitling" },
                new SanPham { MaSP = "SP14", TenSP = "Breitling Navitimer B01 Blue Leather", Gia = 420000000, Anh = "images/b4.jpg", ThuongHieu = "Breitling" },
                new SanPham { MaSP = "SP15", TenSP = "Breitling Chronomat B01 Green", Gia = 390000000, Anh = "images/b5.jpg", ThuongHieu = "Breitling" },
                new SanPham { MaSP = "SP16", TenSP = "Breitling SuperOcean Heritage Blue", Gia = 370000000, Anh = "images/b6.jpg", ThuongHieu = "Breitling" },
                new SanPham { MaSP = "SP17", TenSP = "Breitling Chronomat Evolution Black", Gia = 350000000, Anh = "images/b7.jpg", ThuongHieu = "Breitling" },
                new SanPham { MaSP = "SP18", TenSP = "Breitling Navitimer B01 Brown Leather", Gia = 430000000, Anh = "images/b8.jpg", ThuongHieu = "Breitling" },
                new SanPham { MaSP = "SP19", TenSP = "Breitling Chronomat 44 Blue", Gia = 460000000, Anh = "images/b9.jpg", ThuongHieu = "Breitling" },
                new SanPham { MaSP = "SP20", TenSP = "Breitling Chronometer White Dial", Gia = 400000000, Anh = "images/b10.jpg", ThuongHieu = "Breitling" },

                // --------- HUBLOT ----------
                new SanPham { MaSP = "SP31", TenSP = "Hublot Big Bang Sang Bleu King Gold Diamonds", Gia = 1250000000, Anh = "images/h1.jpg", ThuongHieu = "Hublot" },
                new SanPham { MaSP = "SP32", TenSP = "Hublot Big Bang Unico Red Magic", Gia = 890000000, Anh = "images/h2.jpg", ThuongHieu = "Hublot" },
                new SanPham { MaSP = "SP33", TenSP = "Hublot Classic Fusion Titanium Diamonds", Gia = 920000000, Anh = "images/h3.jpg", ThuongHieu = "Hublot" },
                new SanPham { MaSP = "SP34", TenSP = "Hublot Classic Fusion Chronograph King Gold Diamonds", Gia = 1150000000, Anh = "images/h4.jpg", ThuongHieu = "Hublot" },
                new SanPham { MaSP = "SP35", TenSP = "Hublot Big Bang Unico Full Baguette Diamonds", Gia = 2500000000, Anh = "images/h5.jpg", ThuongHieu = "Hublot" },
                new SanPham { MaSP = "SP36", TenSP = "Hublot Classic Fusion Orlinski Sky Blue", Gia = 980000000, Anh = "images/h6.jpg", ThuongHieu = "Hublot" },
                new SanPham { MaSP = "SP37", TenSP = "Hublot Classic Fusion Titanium Grey", Gia = 670000000, Anh = "images/h7.jpg", ThuongHieu = "Hublot" },
                new SanPham { MaSP = "SP38", TenSP = "Hublot Classic Fusion Titanium Blue", Gia = 710000000, Anh = "images/h8.jpg", ThuongHieu = "Hublot" },
                new SanPham { MaSP = "SP39", TenSP = "Hublot Classic Fusion Orlinski Black Magic", Gia = 890000000, Anh = "images/h9.jpg", ThuongHieu = "Hublot" },
                new SanPham { MaSP = "SP40", TenSP = "Hublot Big Bang Steel Diamonds", Gia = 1200000000, Anh = "images/h10.jpg", ThuongHieu = "Hublot" },

                // --------- IWC ----------
                new SanPham { MaSP = "SP41", TenSP = "IWC Portugieser Tourbillon Perpetual Calendar Blue", Gia = 2100000000, Anh = "images/iwc1.jpg", ThuongHieu = "IWC Schaffhausen" },
                new SanPham { MaSP = "SP42", TenSP = "IWC Ingenieur Perpetual Calendar Blue Dial", Gia = 1750000000, Anh = "images/iwc2.jpg", ThuongHieu = "IWC Schaffhausen" },
                new SanPham { MaSP = "SP43", TenSP = "IWC Ingenieur Automatic 40 Gold", Gia = 1250000000, Anh = "images/iwc3.jpg", ThuongHieu = "IWC Schaffhausen" },
                new SanPham { MaSP = "SP44", TenSP = "IWC Portofino Automatic Blue", Gia = 520000000, Anh = "images/iwc4.jpg", ThuongHieu = "IWC Schaffhausen" },
                new SanPham { MaSP = "SP45", TenSP = "IWC Big Pilot Shock Absorber XPL", Gia = 1950000000, Anh = "images/iwc5.jpg", ThuongHieu = "IWC Schaffhausen" },
                new SanPham { MaSP = "SP46", TenSP = "IWC Pilot Watch Automatic White Ceramic", Gia = 780000000, Anh = "images/iwc6.jpg", ThuongHieu = "IWC Schaffhausen" },
                new SanPham { MaSP = "SP47", TenSP = "IWC Pilot Watch Chronograph Top Gun Ceratanium", Gia = 1200000000, Anh = "images/iwc7.jpg", ThuongHieu = "IWC Schaffhausen" },
                new SanPham { MaSP = "SP48", TenSP = "IWC Portugieser Chronograph Blue", Gia = 690000000, Anh = "images/iwc8.jpg", ThuongHieu = "IWC Schaffhausen" },
                new SanPham { MaSP = "SP49", TenSP = "IWC Portofino Chronograph Steel", Gia = 640000000, Anh = "images/iwc9.jpg", ThuongHieu = "IWC Schaffhausen" },
                new SanPham { MaSP = "SP50", TenSP = "IWC Big Pilot Shock Absorber Turquoise", Gia = 880000000, Anh = "images/iwc10.jpg", ThuongHieu = "IWC Schaffhausen" },
           
            // --------- LONGINES ----------
                new SanPham { MaSP = "SP51", TenSP = "Longines Ultra-Chron Diver Black", Gia = 69000000, Anh = "images/longines1.jpg", ThuongHieu = "Longines" },
                new SanPham { MaSP = "SP52", TenSP = "Longines Conquest Chronograph Automatic", Gia = 82000000, Anh = "images/longines2.jpg", ThuongHieu = "Longines" },
                new SanPham { MaSP = "SP53", TenSP = "Longines Conquest Automatic Diamond White", Gia = 98000000, Anh = "images/longines3.jpg", ThuongHieu = "Longines" },
                new SanPham { MaSP = "SP54", TenSP = "Longines Legend Diver Blue", Gia = 72000000, Anh = "images/longines4.jpg", ThuongHieu = "Longines" },
                new SanPham { MaSP = "SP55", TenSP = "Longines Master Collection White Diamond", Gia = 88000000, Anh = "images/longines5.jpg", ThuongHieu = "Longines" },
                new SanPham { MaSP = "SP56", TenSP = "Longines Master Collection Gold Dial", Gia = 94000000, Anh = "images/longines6.jpg", ThuongHieu = "Longines" },
                new SanPham { MaSP = "SP57", TenSP = "Longines HydroConquest Blue Diver", Gia = 75000000, Anh = "images/longines7.jpg", ThuongHieu = "Longines" },
                new SanPham { MaSP = "SP58", TenSP = "Longines Master Collection Silver Arabic", Gia = 97000000, Anh = "images/longines8.jpg", ThuongHieu = "Longines" },
                new SanPham { MaSP = "SP59", TenSP = "Longines Master Collection Black Diamond", Gia = 99000000, Anh = "images/longines9.jpg", ThuongHieu = "Longines" },
                new SanPham { MaSP = "SP60", TenSP = "Longines Conquest Heritage Red Dial", Gia = 86000000, Anh = "images/longines10.jpg", ThuongHieu = "Longines" },

// --------- MONTBLANC ----------
                new SanPham { MaSP = "SP61", TenSP = "Montblanc Star Legacy Chronograph Burgundy", Gia = 82000000, Anh = "images/montblanc1.jpg", ThuongHieu = "Montblanc" },
                new SanPham { MaSP = "SP62", TenSP = "Montblanc Star Legacy Automatic Day-Date", Gia = 69000000, Anh = "images/montblanc2.jpg", ThuongHieu = "Montblanc" },
                new SanPham { MaSP = "SP63", TenSP = "Montblanc 1858 Split Second Chronograph", Gia = 125000000, Anh = "images/montblanc3.jpg", ThuongHieu = "Montblanc" },
                new SanPham { MaSP = "SP64", TenSP = "Montblanc Star Legacy Automatic Green Dial", Gia = 72000000, Anh = "images/montblanc4.jpg", ThuongHieu = "Montblanc" },
                new SanPham { MaSP = "SP65", TenSP = "Montblanc TimeWalker TwinFly Chronograph", Gia = 97000000, Anh = "images/montblanc5.jpg", ThuongHieu = "Montblanc" },
                new SanPham { MaSP = "SP66", TenSP = "Montblanc Tradition Lady Blue Dial", Gia = 56000000, Anh = "images/montblanc6.jpg", ThuongHieu = "Montblanc" },
                new SanPham { MaSP = "SP67", TenSP = "Montblanc Heritage Chronométrie Moonphase", Gia = 88000000, Anh = "images/montblanc7.jpg", ThuongHieu = "Montblanc" },
                new SanPham { MaSP = "SP68", TenSP = "Montblanc Summit 2 Blue Chronograph", Gia = 93000000, Anh = "images/montblanc8.jpg", ThuongHieu = "Montblanc" },
                new SanPham { MaSP = "SP69", TenSP = "Montblanc Star Legacy Automatic Blue Dial", Gia = 76000000, Anh = "images/montblanc9.jpg", ThuongHieu = "Montblanc" },
                new SanPham { MaSP = "SP70", TenSP = "Montblanc Heritage Spirit Moonphase Blue", Gia = 99000000, Anh = "images/montblanc10.jpg", ThuongHieu = "Montblanc" },

// --------- OMEGA ----------
                new SanPham { MaSP = "SP71", TenSP = "Omega Seamaster Aqua Terra Green Gold", Gia = 310000000, Anh = "images/omega1.jpg", ThuongHieu = "OMEGA" },
                new SanPham { MaSP = "SP72", TenSP = "Omega Constellation Co-Axial Blue Bezel", Gia = 185000000, Anh = "images/omega2.jpg", ThuongHieu = "OMEGA" },
                new SanPham { MaSP = "SP73", TenSP = "Omega Seamaster Diver 300M White Blue Rubber", Gia = 165000000, Anh = "images/omega3.jpg", ThuongHieu = "OMEGA" },
                new SanPham { MaSP = "SP74", TenSP = "Omega Seamaster Diver 300M Black NATO", Gia = 150000000, Anh = "images/omega4.jpg", ThuongHieu = "OMEGA" },
                new SanPham { MaSP = "SP75", TenSP = "Omega Seamaster 300 Green Bronze Gold", Gia = 230000000, Anh = "images/omega5.jpg", ThuongHieu = "OMEGA" },
                new SanPham { MaSP = "SP76", TenSP = "Omega Seamaster Diver 300M Blue Steel", Gia = 180000000, Anh = "images/omega6.jpg", ThuongHieu = "OMEGA" },
                new SanPham { MaSP = "SP77", TenSP = "Omega Speedmaster Moonwatch Professional Blue", Gia = 210000000, Anh = "images/omega7.jpg", ThuongHieu = "OMEGA" },
                new SanPham { MaSP = "SP78", TenSP = "Omega Seamaster Planet Ocean Grey Strap", Gia = 190000000, Anh = "images/omega8.jpg", ThuongHieu = "OMEGA" },
                new SanPham { MaSP = "SP79", TenSP = "Omega Seamaster Aqua Terra Diamond Blue", Gia = 280000000, Anh = "images/omega9.jpg", ThuongHieu = "OMEGA" },
                new SanPham { MaSP = "SP80", TenSP = "Omega Seamaster Aqua Terra Paved Diamond", Gia = 350000000, Anh = "images/omega10.jpg", ThuongHieu = "OMEGA" },

// --------- PATEK PHILIPPE ----------
                new SanPham { MaSP = "SP81", TenSP = "Patek Philippe Calatrava Weekly Calendar Blue", Gia = 950000000, Anh = "images/p1.jpg", ThuongHieu = "Patek Philippe" },
                new SanPham { MaSP = "SP82", TenSP = "Patek Philippe Aquanaut Diamond Black", Gia = 890000000, Anh = "images/p2.jpg", ThuongHieu = "Patek Philippe" },
                new SanPham { MaSP = "SP83", TenSP = "Patek Philippe Nautilus Full Diamond Chronograph", Gia = 1600000000, Anh = "images/p3.jpg", ThuongHieu = "Patek Philippe" },
                new SanPham { MaSP = "SP84", TenSP = "Patek Philippe Grand Complications Rose Gold", Gia = 1350000000, Anh = "images/p4.jpg", ThuongHieu = "Patek Philippe" },
                new SanPham { MaSP = "SP85", TenSP = "Patek Philippe Aquanaut Diamond White", Gia = 870000000, Anh = "images/p5.jpg", ThuongHieu = "Patek Philippe" },
                new SanPham { MaSP = "SP86", TenSP = "Patek Philippe Nautilus Perpetual Calendar Blue", Gia = 1200000000, Anh = "images/p6.jpg", ThuongHieu = "Patek Philippe" },
                new SanPham { MaSP = "SP87", TenSP = "Patek Philippe Grandmaster Chime Platinum", Gia = 1900000000, Anh = "images/p7.jpg", ThuongHieu = "Patek Philippe" },
                new SanPham { MaSP = "SP88", TenSP = "Patek Philippe Annual Calendar Chronograph Brown", Gia = 980000000, Anh = "images/p8.jpg", ThuongHieu = "Patek Philippe" },
                new SanPham { MaSP = "SP89", TenSP = "Patek Philippe Grandmaster Chime Rose Gold", Gia = 1850000000, Anh = "images/p9.jpg", ThuongHieu = "Patek Philippe" },
                new SanPham { MaSP = "SP90", TenSP = "Patek Philippe Grand Complications Perpetual Calendar", Gia = 1100000000, Anh = "images/p10.jpg", ThuongHieu = "Patek Philippe" },

// --------- PIAGET ----------
                new SanPham { MaSP = "SP101", TenSP = "Piaget Polo S Automatic Black Dial", Gia = 420000000, Anh = "images/piaget1.jpg", ThuongHieu = "Piaget" },
                new SanPham { MaSP = "SP102", TenSP = "Piaget Polo Perpetual Calendar Green", Gia = 680000000, Anh = "images/piaget2.jpg", ThuongHieu = "Piaget" },
                new SanPham { MaSP = "SP103", TenSP = "Piaget Polo Skeleton Blue", Gia = 720000000, Anh = "images/piaget3.jpg", ThuongHieu = "Piaget" },
                new SanPham { MaSP = "SP104", TenSP = "Piaget Polo Perpetual Calendar Blue", Gia = 670000000, Anh = "images/piaget4.jpg", ThuongHieu = "Piaget" },
                new SanPham { MaSP = "SP105", TenSP = "Piaget Altiplano Automatic Rose Gold", Gia = 580000000, Anh = "images/piaget5.jpg", ThuongHieu = "Piaget" },
                new SanPham { MaSP = "SP106", TenSP = "Piaget Limelight Gala Silver Mesh", Gia = 950000000, Anh = "images/piaget6.jpg", ThuongHieu = "Piaget" },
                new SanPham { MaSP = "SP107", TenSP = "Piaget Limelight Gala Gold Mesh", Gia = 980000000, Anh = "images/piaget7.jpg", ThuongHieu = "Piaget" },
                new SanPham { MaSP = "SP108", TenSP = "Piaget Polo Skeleton Black Ceramic", Gia = 740000000, Anh = "images/piaget8.jpg", ThuongHieu = "Piaget" },
                new SanPham { MaSP = "SP109", TenSP = "Piaget Altiplano Ultimate Concept", Gia = 1250000000, Anh = "images/piaget9.jpg", ThuongHieu = "Piaget" },
                new SanPham { MaSP = "SP110", TenSP = "Piaget Polo Date Rose Gold Diamond", Gia = 890000000, Anh = "images/piaget10.jpg", ThuongHieu = "Piaget" },

// --------- ROLEX ----------
                new SanPham { MaSP = "SP111", TenSP = "Rolex Oyster Perpetual Mint Green", Gia = 380000000, Anh = "images/rolex1.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP112", TenSP = "Rolex Cosmograph Daytona Everose Meteorite", Gia = 950000000, Anh = "images/rolex2.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP113", TenSP = "Rolex Oyster Perpetual Silver Dial", Gia = 360000000, Anh = "images/rolex3.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP114", TenSP = "Rolex Datejust Red Diamond Bezel", Gia = 520000000, Anh = "images/rolex4.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP115", TenSP = "Rolex Land-Dweller Ice Blue Dial", Gia = 1100000000, Anh = "images/rolex5.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP116", TenSP = "Rolex Day-Date White Mother of Pearl", Gia = 970000000, Anh = "images/rolex6.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP117", TenSP = "Rolex Deepsea Challenge Titanium", Gia = 580000000, Anh = "images/rolex7.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP118", TenSP = "Rolex Sky-Dweller Yellow Gold White Dial", Gia = 890000000, Anh = "images/rolex8.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP119", TenSP = "Rolex Day-Date Blue Diamond Bezel", Gia = 1250000000, Anh = "images/rolex9.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP120", TenSP = "Rolex Day-Date Yellow Gold Diamond Bezel", Gia = 1300000000, Anh = "images/rolex10.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP121", TenSP = "Rolex Day-Date Pink Diamond Bezel", Gia = 1350000000, Anh = "images/rolex11.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP122", TenSP = "Rolex Day-Date Rainbow Diamond Dial", Gia = 1500000000, Anh = "images/rolex12.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP123", TenSP = "Rolex Day-Date Everose Black Dial", Gia = 980000000, Anh = "images/rolex13.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP124", TenSP = "Rolex Day-Date Gold Roman Diamond", Gia = 1200000000, Anh = "images/rolex14.jpg", ThuongHieu = "Rolex" },
                new SanPham { MaSP = "SP125", TenSP = "Rolex Day-Date Pink Dial Fluted Bezel", Gia = 990000000, Anh = "images/rolex15.jpg", ThuongHieu = "Rolex" },

            // --------- TUDOR ----------
                new SanPham { MaSP = "SP126", TenSP = "Tudor Royal Mother of Pearl Diamond", Gia = 210000000, Anh = "images/tudor1.jpg", ThuongHieu = "Tudor" },
                new SanPham { MaSP = "SP127", TenSP = "Tudor Clair de Rose Blue Dial", Gia = 180000000, Anh = "images/tudor2.jpg", ThuongHieu = "Tudor" },
                new SanPham { MaSP = "SP128", TenSP = "Tudor Black Bay Rubber Strap", Gia = 150000000, Anh = "images/tudor3.jpg", ThuongHieu = "Tudor" },
                new SanPham { MaSP = "SP129", TenSP = "Tudor Pelagos FXD GMT", Gia = 165000000, Anh = "images/tudor4.jpg", ThuongHieu = "Tudor" },
                new SanPham { MaSP = "SP130", TenSP = "Tudor Black Chrono Ceramic", Gia = 220000000, Anh = "images/tudor5.jpg", ThuongHieu = "Tudor" },
            };

            foreach (var sp in list)
            {
                if (string.IsNullOrWhiteSpace(sp.MoTa))
                    sp.MoTa = BuildMoTa(sp);

                // Nếu bạn đã thêm property CauChuyen trong class SanPham:
                // if (string.IsNullOrWhiteSpace(sp.CauChuyen))
                //     sp.CauChuyen = BuildCauChuyen(sp);
            }

            return list;
        }


        // ==================== Helpers ====================

        private static string BuildMoTa(SanPham sp)
        {
            string style = StyleFromName(sp.TenSP);
            string chatlieu = MaterialFromName(sp.TenSP);
            string day = StrapFromName(sp.TenSP);
            string may = MovementFromName(sp.TenSP);
            string brandTone = BrandTone(sp.ThuongHieu);

            return sp.TenSP + " của " + sp.ThuongHieu + ": " + brandTone + ". " +
                   style + ". Kính sapphire" + chatlieu + (string.IsNullOrEmpty(day) ? "" : ", " + day) +
                   ". Bộ máy " + may + ", bền bỉ và chuẩn xác.";
        }

        // C# 7.3: viết if/else thay cho switch-expression
        private static string BrandTone(string thuongHieu)
        {
            if (thuongHieu == "Audemars Piguet") return "biểu tượng Haute Horlogerie, chất cơ khí mạnh mẽ";
            if (thuongHieu == "Breitling") return "DNA hàng không – thể thao, chính xác và nam tính";
            if (thuongHieu == "Hublot") return "Art of Fusion – vật liệu táo bạo, hình khối hiện đại";
            if (thuongHieu == "IWC Schaffhausen") return "công cụ – kỹ thuật, sang trọng thực dụng";
            if (thuongHieu == "Longines") return "thanh lịch cổ điển, dễ đeo hằng ngày";
            if (thuongHieu == "Montblanc") return "đương đại tinh giản, chuẩn xác lịch lãm";
            if (thuongHieu == "OMEGA") return "đáng tin, gắn với biển cả và vũ trụ";
            if (thuongHieu == "Patek Philippe") return "đỉnh cao sưu tầm, hoàn thiện tinh xảo";
            if (thuongHieu == "Piaget") return "mỏng thanh lịch, mỹ học tinh tế";
            if (thuongHieu == "Rolex") return "biểu tượng độ bền và sự chuẩn xác";
            if (thuongHieu == "Tudor") return "trẻ trung, thực dụng, hiệu năng tốt";
            return "sang trọng và tinh xảo";
        }

        private static string MovementFromName(string name)
        {
            return Contains(name, "Quartz") ? "quartz Thụy Sĩ" : "automatic Thụy Sĩ";
        }

        private static string StyleFromName(string name)
        {
            bool chronograph = Contains(name, "Chronograph") || Contains(name, "Chrono");
            bool diver = Contains(name, "Diver") || Contains(name, "Pelagos") || Contains(name, "HydroConquest") || Contains(name, "Seamaster");
            bool skeleton = Contains(name, "Skeleton") || Contains(name, "Openworked");
            bool tourbillon = Contains(name, "Tourbillon");
            bool calendar = Contains(name, "Perpetual Calendar") || Contains(name, "Annual Calendar") || Contains(name, "Calendar");
            bool moonphase = Contains(name, "Moonphase") || Contains(name, "Moonwatch");
            bool pilot = Contains(name, "Pilot") || Contains(name, "Navitimer") || Contains(name, "Top Gun") || Contains(name, "Sky-Dweller");
            bool elegant = Contains(name, "Datejust") || Contains(name, "Day-Date") || Contains(name, "Calatrava") || Contains(name, "Portofino") || Contains(name, "Heritage") || Contains(name, "Classic Fusion") || Contains(name, "Polo");

            var tags = new List<string>();
            if (tourbillon) tags.Add("cơ chế tourbillon cao cấp");
            if (skeleton) tags.Add("lộ máy (skeleton) ấn tượng");
            if (chronograph) tags.Add("chronograph thể thao");
            if (diver) tags.Add("thiết kế diver chắc chắn");
            if (pilot) tags.Add("phong cách pilot/instrument");
            if (calendar) tags.Add("lịch phức tạp");
            if (moonphase) tags.Add("có yếu tố thiên văn");
            if (elegant && tags.Count == 0) tags.Add("thanh lịch cổ điển");

            return tags.Count > 0 ? string.Join(", ", tags) : "thanh lịch, dễ phối trang phục";
        }

        private static string MaterialFromName(string name)
        {
            bool ceramic = Contains(name, "Ceramic") || Contains(name, "Black Magic");
            bool titanium = Contains(name, "Titanium") || Contains(name, "Ceratanium");
            bool gold = Contains(name, "Gold") || Contains(name, "Everose") || Contains(name, "Yellow Gold") || Contains(name, "Rose Gold") || Contains(name, "Pink Gold");
            bool diamond = Contains(name, "Diamond") || Contains(name, "Diamonds") || Contains(name, "Baguette");
            bool bronze = Contains(name, "Bronze");

            var parts = new List<string>();
            if (ceramic) parts.Add("gốm (ceramic)");
            if (titanium) parts.Add("titanium");
            if (gold) parts.Add("vàng cao cấp");
            if (bronze) parts.Add("hợp kim bronze");
            if (diamond) parts.Add("đính kim cương");

            return parts.Count > 0 ? ", chất liệu " + string.Join(", ", parts) : "";
        }

        private static string StrapFromName(string name)
        {
            if (Contains(name, "Rubber")) return "dây cao su thoải mái";
            if (Contains(name, "Leather")) return "dây da êm tay";
            if (Contains(name, "NATO")) return "dây NATO trẻ trung";
            if (Contains(name, "Mesh")) return "dây lưới (mesh) tinh tế";
            return "dây kim loại chắc chắn";
        }

        private static bool Contains(string input, string token)
        {
            return (input ?? "").IndexOf(token, StringComparison.OrdinalIgnoreCase) >= 0;
        }



        public static List<SanPham> GetSanPhamTheoThuongHieu(string thuongHieu)
        {
            return GetSanPhamList()
                .Where(sp => sp.ThuongHieu.Equals(thuongHieu, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

    }
}