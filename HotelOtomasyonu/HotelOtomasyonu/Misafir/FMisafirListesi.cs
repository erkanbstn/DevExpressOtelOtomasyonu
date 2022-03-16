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

namespace HotelOtomasyonu.Misafir
{
    public partial class FMisafirListesi : Form
    {
        public FMisafirListesi()
        {
            InitializeComponent();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FMisafirKart f = new FMisafirKart();
            Baglanti.MID = Convert.ToByte(gridView1.GetFocusedRowCellValue("MisafirID").ToString());
            f.Show();
        }

        private void FMisafirListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in Baglanti.db.TMisafir select new { x.MisafirID,x.Ad, x.TC, x.Mail, x.Telefon, x.Adres, x.Aciklama, x.TDurum.DurumAd }).ToList();
        }
    }
}
