using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraEditors;
using HotelOtomasyonu.Formlar;

namespace HotelOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FDurum f;
        FBirim f2;
        FDepartman f3;
        FGorev f4;
        FKasa f5;
        FKur f6;
        FOda f7;
        FTelefon f8;
        FUlke f9;
        FUrun f10;
        Personel.FPersonelKart f11;
        Personel.FPersonelListe f12;
        Misafir.FMisafirKart f13;
        Misafir.FMisafirListesi f14;
        Urun.FUrunListe f15;
        Urun.FUrunKart f16;
        Urun.FGirisHareket f17;
        Urun.FCikisHareket f18;
        Urun.FUrunHareketTanim f19;
        Rezervasyon.FRezervasyonKart f20;
        Rezervasyon.FRezervasyonListe f21;
        Rezervasyon.FAktifRezervasyon f22;
        Rezervasyon.FIptalRezervasyon f23;
        Rezervasyon.FGecmisRezervasyon f24;
        Rezervasyon.FGelecekRezervasyon f25;
        Formlar.FKurTcmb f26;
        WebTarafi.FYeniKayit f27;
        FHizliBakis f28;
        Raporlar.FRapor f29;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new Formlar.FDurum();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.Focus();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new Formlar.FBirim();
                f2.MdiParent = this;
                f2.Show();
            }
            else
            {
                f2.Focus();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f3 == null || f3.IsDisposed)
            {
                f3 = new Formlar.FDepartman();
                f3.MdiParent = this;
                f3.Show();
            }
            else
            {
                f3.Focus();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f4 == null || f4.IsDisposed)
            {
                f4 = new Formlar.FGorev();
                f4.MdiParent = this;
                f4.Show();
            }
            else
            {
                f4.Focus();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f5 == null || f5.IsDisposed)
            {
                f5 = new Formlar.FKasa();
                f5.MdiParent = this;
                f5.Show();
            }
            else
            {
                f5.Focus();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f6 == null || f6.IsDisposed)
            {
                f6 = new Formlar.FKur();
                f6.MdiParent = this;
                f6.Show();
            }
            else
            {
                f6.Focus();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f7 == null || f7.IsDisposed)
            {
                f7 = new Formlar.FOda();
                f7.MdiParent = this;
                f7.Show();
            }
            else
            {
                f7.Focus();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f8 == null || f8.IsDisposed)
            {
                f8 = new Formlar.FTelefon();
                f8.MdiParent = this;
                f8.Show();
            }
            else
            {
                f8.Focus();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f9 == null || f9.IsDisposed)
            {
                f9 = new Formlar.FUlke();
                f9.MdiParent = this;
                f9.Show();
            }
            else
            {
                f9.Focus();
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f10 == null || f10.IsDisposed)
            {
                f10 = new Formlar.FUrun();
                f10.MdiParent = this;
                f10.Show();
            }
            else
            {
                f10.Focus();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f11 == null || f11.IsDisposed)
            {
                f11 = new Personel.FPersonelKart();
                f11.Show();
            }
            else
            {
                f11.Focus();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f12 == null || f12.IsDisposed)
            {
                f12 = new Personel.FPersonelListe();
                f12.MdiParent = this;
                f12.Show();
            }
            else
            {
                f12.Focus();
            }

        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f13 == null || f13.IsDisposed)
            {
                f13 = new Misafir.FMisafirKart();
                f13.Show();
            }
            else
            {
                f13.Focus();
            }
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (f14 == null || f14.IsDisposed)
            {
                f14 = new Misafir.FMisafirListesi();
                f14.MdiParent = this;
                f14.Show();
            }
            else
            {
                f14.Focus();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f15 == null || f15.IsDisposed)
            {
                f15 = new Urun.FUrunListe();
                f15.MdiParent = this;
                f15.Show();
            }
            else
            {
                f15.Focus();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f16 == null || f16.IsDisposed)
            {
                f16 = new Urun.FUrunKart();
                f16.Show();
            }
            else
            {
                f14.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            f28 = new FHizliBakis();
            f28.MdiParent = this;
            f28.Show();

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f17 == null || f17.IsDisposed)
            {
                f17 = new Urun.FGirisHareket();
                f17.MdiParent = this;
                f17.Show();
            }
            else
            {
                f17.Focus();
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f18 == null || f18.IsDisposed)
            {
                f18 = new Urun.FCikisHareket();
                f18.MdiParent = this;
                f18.Show();
            }
            else
            {
                f18.Focus();
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f19 == null || f19.IsDisposed)
            {
                f19 = new Urun.FUrunHareketTanim();
                f19.Show();
            }
            else
            {
                f19.Focus();
            }
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f20 == null || f20.IsDisposed)
            {
                f20 = new Rezervasyon.FRezervasyonKart();
                f20.Show();
            }
            else
            {
                f20.Focus();
            }
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f21 == null || f21.IsDisposed)
            {
                f21 = new Rezervasyon.FRezervasyonListe();
                f21.MdiParent = this;
                f21.Show();
            }
            else
            {
                f21.Focus();
            }
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f22 == null || f22.IsDisposed)
            {
                f22 = new Rezervasyon.FAktifRezervasyon();
                f22.MdiParent = this;
                f22.Show();
            }
            else
            {
                f22.Focus();
            }
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f23 == null || f23.IsDisposed)
            {
                f23 = new Rezervasyon.FIptalRezervasyon();
                f23.MdiParent = this;
                f23.Show();
            }
            else
            {
                f23.Focus();
            }
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f24 == null || f24.IsDisposed)
            {
                f24 = new Rezervasyon.FGecmisRezervasyon();
                f24.MdiParent = this;
                f24.Show();
            }
            else
            {
                f24.Focus();
            }
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f25 == null || f25.IsDisposed)
            {
                f25 = new Rezervasyon.FGelecekRezervasyon();
                f25.MdiParent = this;
                f25.Show();
            }
            else
            {
                f25.Focus();
            }
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("https://www.Youtube.com");
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("https://www.Google.com");
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("EXCEL.EXE");

        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Bu Projeyi Erkan Bostan Geliştirmiştir.", "0(536)-321-7219 Numarası Üzerinden İletişime Geçebilirsiniz.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("CALC.EXE");
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("NOTEPAD.EXE");
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f26 == null || f26.IsDisposed)
            {
                f26 = new Formlar.FKurTcmb();
                f26.MdiParent = this;
                f26.Show();
            }
            else
            {
                f26.Focus();
            }
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f27 == null || f27.IsDisposed)
            {
                f27 = new WebTarafi.FYeniKayit();
                f27.MdiParent = this;
                f27.Show();
            }
            else
            {
                f27.Focus();
            }
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f28 == null || f28.IsDisposed)
            {
                f28 = new FHizliBakis();
                f28.MdiParent = this;
                f28.Show();
            }
            else
            {
                f28.Focus();
            }
        }

        private void R_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f29 == null || f29.IsDisposed)
            {
                f29 = new Raporlar.FRapor();
                f29.MdiParent = this;
                f29.Show();
            }
            else
            {
                f29.Focus();
            }
        }
    }
}
