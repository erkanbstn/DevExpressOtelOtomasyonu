using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelOtomasyonu.Entity;

namespace HotelOtomasyonu.Urun
{
    public partial class FUrunListe : Form
    {
        public FUrunListe()
        {
            InitializeComponent();
        }

        private void FUrunListe_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in Baglanti.db.TUrun
                                       select new
                                       {
                                           x.UrunID,
                                           x.TUrunGrup.Ad,
                                           x.Urun,
                                           x.Fiyat,
                                           x.Birim,
                                           x.Toplam

                                       }).ToList();
        }

        FUrunKart uk;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Baglanti.UID = byte.Parse(gridView1.GetFocusedRowCellValue("UrunID").ToString());
            if (uk == null || uk.IsDisposed)
            {
                uk = new Urun.FUrunKart();
                uk.Show();
            }
            else
            {
                uk.Focus();
            }
        }
    }
}
