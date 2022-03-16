using HotelOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelOtomasyonu.Formlar
{
    public partial class FHizliBakis : Form
    {
        public FHizliBakis()
        {
            InitializeComponent();
        }

        private void FHizliBakis_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = (from x in Baglanti.db.TMisafir
                                       select new
                                       {
                                           x.Ad
                                       }).ToList();
            gridControl3.DataSource = (from x in Baglanti.db.TRezervasyon
                                       select new
                                       {
                                           x.TMisafir.Ad,
                                       }).ToList();
            gridControl4.DataSource = (from x in Baglanti.db.TMesajSite
                                       select new
                                       {
                                           x.Gonderen,
                                           x.Mail,
                                           x.Konu,
                                           x.Mesaj
                                       }).ToList();
            gridControl1.DataSource = (from x in Baglanti.db.TUrun
                                       select new
                                       {
                                           x.Urun,
                                           x.Toplam
                                       }).ToList();

            var c = Baglanti.db.TUrun.ToList();
            foreach (var i in c)
            {
                chartControl1.Series["Urun-Stok"].Points.AddPoint(i.Urun, double.Parse(i.Toplam.ToString()));
            }

            var d = Baglanti.db.OdaDurum();
            foreach (var i in d)
            {
                chartControl2.Series["Oda - Durum"].Points.AddPoint(i.DurumAd, double.Parse(i.Sayı.ToString()));
            }

        }
    }
}
