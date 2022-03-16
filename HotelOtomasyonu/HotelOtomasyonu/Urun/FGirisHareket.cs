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

namespace HotelOtomasyonu.Urun
{
    public partial class FGirisHareket : Form
    {
        public FGirisHareket()
        {
            InitializeComponent();
        }


        private void FGirisHareket_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in Baglanti.db.THareket
                                       select new
                                       {
                                           x.HareketID,
                                           x.TUrun.Urun,
                                           x.Miktar,
                                           x.Tarih,
                                           x.HareketTur
                                       }).Where(b => b.HareketTur == "Giriş").ToList();
        }
        FUrunHareketTanim uk;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Baglanti.HID = int.Parse(gridView1.GetFocusedRowCellValue("HareketID").ToString());
            if (uk == null || uk.IsDisposed)
            {
                uk = new Urun.FUrunHareketTanim();
                uk.Show();
            }
            else
            {
                uk.Focus();
            }
        }
    }
}
