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

namespace HotelOtomasyonu.Personel
{
    public partial class FPersonelListe : Form
    {
        public FPersonelListe()
        {
            InitializeComponent();
        }

        private void FPersonelListe_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in Baglanti.db.TPersonel select new { x.PersonelID,x.Personel, x.TC, x.Telefon, x.Mail, x.TDepartman.Ad, x.TGorev.GorevAd, x.TDurum.DurumAd }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FPersonelKart f = new FPersonelKart();
            Baglanti.ID = Convert.ToByte(gridView1.GetFocusedRowCellValue("PersonelID").ToString());
            f.Show();
        }
    }
}
