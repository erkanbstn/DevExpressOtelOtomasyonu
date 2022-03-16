using DevExpress.XtraEditors;
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
    public partial class FUrunKart : Form
    {
        public FUrunKart()
        {
            InitializeComponent();
        }
        void LooksList()
        {
            lookUpEdit3.Properties.DataSource = (from x in Baglanti.db.TUrunGrup
                                                 select new
                                                 {
                                                     x.UrunGrupID,
                                                     x.Ad
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in Baglanti.db.TBirim
                                                 select new
                                                 {
                                                     x.BirimID,
                                                     x.Ad
                                                 }).ToList();

            lookUpEdit1.Properties.DataSource = (from x in Baglanti.db.TDurum
                                                 select new
                                                 {
                                                     x.DurumID,
                                                     x.DurumAd
                                                 }).ToList();
        }

        void RadioKontrol()
        {
            foreach (var i in groupControl1.Controls)
            {
                if (i is RadioButton && ((RadioButton)i).Checked)
                {
                    RadioButton r = i as RadioButton;
                    switch (r.Text)
                    {
                        case "%1":
                            textEdit5.Text = "1";
                            break;
                        case "%10":
                            textEdit5.Text = "10";
                            break;
                        case "%18":
                            textEdit5.Text = "18";
                            break;
                        case "%8":
                            textEdit5.Text = "8";
                            break;
                    }
                }
            }
        }
        private void FUrunKart_Load(object sender, EventArgs e)
        {
            if (Baglanti.UID > 0)
            {
                var x = p.Find(b => b.UrunID == Baglanti.UID);
                switch (x.Kdv)
                {
                    case 18:
                        radioButton4.Checked = true;
                        break;
                    case 1:
                        radioButton1.Checked = true;
                        break;
                    case 10:
                        radioButton3.Checked = true;
                        break;
                    case 8:
                        radioButton2.Checked = true;
                        break;
                }
                textEdit1.Text = x.Urun;
                textEdit2.Text = x.Fiyat.ToString();
                textEdit3.Text = x.Toplam.ToString();
                textEdit5.Text = x.Kdv.ToString();
                lookUpEdit3.EditValue = x.UrunGrup;
                lookUpEdit2.EditValue = x.Birim;
                lookUpEdit1.EditValue = x.Durum;
            }
            LooksList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Repositories.Repository<TUrun> p = new Repositories.Repository<TUrun>();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                TUrun m = new TUrun();
                m.Urun = textEdit1.Text;
                m.Fiyat = decimal.Parse(textEdit2.Text);
                m.Toplam = decimal.Parse(textEdit3.Text);
                m.Kdv = byte.Parse(textEdit5.Text);
                m.UrunGrup = Convert.ToByte(lookUpEdit3.EditValue);
                m.Birim = Convert.ToByte(lookUpEdit2.EditValue);
                m.Durum = Convert.ToByte(lookUpEdit1.EditValue);
                p.TAdd(m);
                XtraMessageBox.Show("Ürün Başarıyla Eklendi.", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hatalı Veri Girişi Lütfen Kontrol Edin", "Uyarı Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var x = p.Find(n => n.UrunID == Baglanti.UID);
                x.Urun = textEdit1.Text;
                x.Fiyat = decimal.Parse(textEdit2.Text);
                x.Toplam = decimal.Parse(textEdit3.Text);
                x.Kdv = byte.Parse(textEdit5.Text);
                x.UrunGrup = Convert.ToByte(lookUpEdit3.EditValue);
                x.Birim = Convert.ToByte(lookUpEdit2.EditValue);
                x.Durum = Convert.ToByte(lookUpEdit1.EditValue);
                p.Update(x);
                XtraMessageBox.Show("Ürün Başarıyla Güncellendi.", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hatalı Veri Girişi Lütfen Kontrol Edin", "Uyarı Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioKontrol();
        }
    }
}
