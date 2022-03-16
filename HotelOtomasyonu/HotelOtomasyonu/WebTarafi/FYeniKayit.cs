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

namespace HotelOtomasyonu.WebTarafi
{
    public partial class FYeniKayit : Form
    {
        public FYeniKayit()
        {
            InitializeComponent();
        }

        private void FYeniKayit_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in Baglanti.db.TKullaniciSite
                                       select new
                                       {
                                           x.KullaniciID,
                                           x.İsim,
                                           x.Email,
                                           x.Telefon,
                                       }).ToList();
        }
    }
}
