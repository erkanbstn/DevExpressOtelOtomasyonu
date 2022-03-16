﻿using HotelOtomasyonu.Entity;
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
    public partial class FIptalRezervasyon : Form
    {
        public FIptalRezervasyon()
        {
            InitializeComponent();
        }

        private void FIptalRezervasyon_Load(object sender, EventArgs e)
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

                                       }).Where(b => b.DurumAd == "İptal Edildi").ToList();
        }
    }
}
