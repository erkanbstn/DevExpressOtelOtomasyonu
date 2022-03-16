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

namespace HotelOtomasyonu.Rezervasyon
{
    public partial class FRezervasyonListe : Form
    {
        public FRezervasyonListe()
        {
            InitializeComponent();
        }

        private void FRezervasyonListe_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in Baglanti.db.TRezervasyon
                                       select new
                                       {
                                           x.RezervasyonID,
                                           x.RezervasyonKisi,
                                           x.Misafir,
                                           x.Kisi,
                                           x.TOda.OdaNo,
                                           x.GirisTarih,
                                           x.CikisTarih,
                                           x.Telefon,
                                           x.TDurum.DurumAd

                                       }).ToList();
        }
        FRezervasyonKart uk;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Baglanti.RID2 = byte.Parse(gridView1.GetFocusedRowCellValue("RezervasyonID").ToString());
            if (uk == null || uk.IsDisposed)
            {
                uk = new FRezervasyonKart();
                uk.Show();
            }
            else
            {
                uk.Focus();
            }
        }
    }
}
