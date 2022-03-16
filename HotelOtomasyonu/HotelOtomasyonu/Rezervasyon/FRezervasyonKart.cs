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

namespace HotelOtomasyonu.Rezervasyon
{
    public partial class FRezervasyonKart : Form
    {
        public FRezervasyonKart()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LooksList()
        {


            lookUpEdit3.Properties.DataSource = (from x in Baglanti.db.TMisafir
                                                 select new
                                                 {
                                                     x.MisafirID,
                                                     x.Ad
                                                 }).ToList();
            lookUpEdit5.Properties.DataSource = (from x in Baglanti.db.TMisafir
                                                 select new
                                                 {
                                                     x.MisafirID,
                                                     x.Ad
                                                 }).ToList();
            lookUpEdit6.Properties.DataSource = (from x in Baglanti.db.TMisafir
                                                 select new
                                                 {
                                                     x.MisafirID,
                                                     x.Ad
                                                 }).ToList();








            lookUpEdit1.Properties.DataSource = (from x in Baglanti.db.TDurum
                                                 select new
                                                 {
                                                     x.DurumID,
                                                     x.DurumAd
                                                 }).ToList();

            lookUpEdit4.Properties.DataSource = (from x in Baglanti.db.TMisafir
                                                 select new
                                                 {
                                                     x.MisafirID,
                                                     x.Ad
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in Baglanti.db.TOda
                                                 select new
                                                 {
                                                     x.OdaID,
                                                     x.OdaNo,
                                                     x.TDurum.DurumAd
                                                 }).Where(b => b.DurumAd == "Aktif").ToList();
        }
        Repositories.Repository<TRezervasyon> p = new Repositories.Repository<TRezervasyon>();
        private void FRezervasyonKart_Load(object sender, EventArgs e)
        {
            if (Baglanti.RID2 > 0)
            {
                var x = Baglanti.db.TRezervasyon.Find(Baglanti.RID2);
                lookUpEdit4.EditValue = x.Misafir;
                lookUpEdit3.EditValue = x.Kisi2;
                lookUpEdit5.EditValue = x.Kisi3;
                lookUpEdit6.EditValue = x.Kisi4;
                textEdit2.Text = x.Telefon;
                lookUpEdit1.EditValue = x.Durum;
                dateEdit1.EditValue = x.GirisTarih;
                dateEdit2.EditValue = x.CikisTarih;
                lookUpEdit2.EditValue = x.Oda;
                numericUpDown1.Value = Convert.ToDecimal(x.Kisi);
                memoEdit1.Text = x.Aciklama;
            }
            LooksList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                TRezervasyon m = new TRezervasyon();
                switch (numericUpDown1.Value)
                {
                    case 1:
                        m.Misafir = byte.Parse(lookUpEdit4.EditValue.ToString());
                        break;
                    case 2:
                        m.Misafir = byte.Parse(lookUpEdit4.EditValue.ToString());
                        m.Kisi2 = byte.Parse(lookUpEdit3.EditValue.ToString());
                        break;
                    case 3:
                        m.Misafir = byte.Parse(lookUpEdit4.EditValue.ToString());
                        m.Kisi2 = byte.Parse(lookUpEdit3.EditValue.ToString());
                        m.Kisi3 = byte.Parse(lookUpEdit5.EditValue.ToString());
                        break;
                    case 4:
                        m.Misafir = byte.Parse(lookUpEdit4.EditValue.ToString());
                        m.Kisi2 = byte.Parse(lookUpEdit3.EditValue.ToString());
                        m.Kisi3 = byte.Parse(lookUpEdit5.EditValue.ToString());
                        m.Kisi4 = byte.Parse(lookUpEdit6.EditValue.ToString());
                        break;
                }
                m.Durum = byte.Parse(lookUpEdit1.EditValue.ToString());
                m.Oda = byte.Parse(lookUpEdit2.EditValue.ToString());
                m.GirisTarih = DateTime.Parse(dateEdit1.Text);
                m.CikisTarih = DateTime.Parse(dateEdit2.Text);
                m.Kisi = numericUpDown1.Value.ToString();
                m.Telefon = textEdit2.Text;
                m.Aciklama = memoEdit1.Text;
                m.RezervasyonKisi = lookUpEdit4.EditValue.ToString();
                p.TAdd(m);
                XtraMessageBox.Show("Rezervasyon Başarıyla Oluşturuldu.", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var m = Baglanti.db.TRezervasyon.Find(Baglanti.RID2);
                switch (numericUpDown1.Value)
                {
                    case 1:
                        m.Misafir = byte.Parse(lookUpEdit4.EditValue.ToString());
                        break;
                    case 2:
                        m.Misafir = byte.Parse(lookUpEdit4.EditValue.ToString());
                        m.Kisi2 = byte.Parse(lookUpEdit3.EditValue.ToString());
                        break;
                    case 3:
                        m.Misafir = byte.Parse(lookUpEdit4.EditValue.ToString());
                        m.Kisi2 = byte.Parse(lookUpEdit3.EditValue.ToString());
                        m.Kisi3 = byte.Parse(lookUpEdit5.EditValue.ToString());
                        break;
                    case 4:
                        m.Misafir = byte.Parse(lookUpEdit4.EditValue.ToString());
                        m.Kisi2 = byte.Parse(lookUpEdit3.EditValue.ToString());
                        m.Kisi3 = byte.Parse(lookUpEdit5.EditValue.ToString());
                        m.Kisi4 = byte.Parse(lookUpEdit6.EditValue.ToString());
                        break;
                }
                m.Durum = byte.Parse(lookUpEdit1.EditValue.ToString());
                m.Oda = byte.Parse(lookUpEdit2.EditValue.ToString());
                m.GirisTarih = DateTime.Parse(dateEdit1.Text);
                m.CikisTarih = DateTime.Parse(dateEdit2.Text);
                m.Kisi = numericUpDown1.Value.ToString();
                m.Telefon = textEdit2.Text;
                m.Aciklama = memoEdit1.Text;
                m.RezervasyonKisi = lookUpEdit4.EditValue.ToString();
                p.Update(m);
                XtraMessageBox.Show("Rezervasyon Başarıyla Oluşturuldu.", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hatalı Veri Girişi Lütfen Kontrol Edin", "Uyarı Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
