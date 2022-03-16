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

namespace HotelOtomasyonu.Misafir
{
    public partial class FMisafirKart : Form
    {
        public FMisafirKart()
        {
            InitializeComponent();
        }

        private void FMisafirKart_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in Baglanti.db.TUlke select new { x.UlkeID, x.UlkeAd }).ToList();
            lookUpEdit3.Properties.DataSource = (from x in Baglanti.db.TIl select new { x.ID, x.Sehir }).ToList();

            try
            {
                if (Baglanti.MID != 0)
                {
                    var d = p.Find(c => c.MisafirID == Baglanti.MID);
                    textEdit1.Text = d.Ad;
                    textEdit2.Text = d.TC;
                    memoEdit1.Text = d.Aciklama;
                    memoEdit2.Text = d.Adres;
                    textEdit7.Text = d.Mail;
                    maskedTextBox1.Text = d.Telefon;
                    pictureEdit9.Image = Image.FromFile(d.KimlikFoto1);
                    pictureEdit10.Image = Image.FromFile(d.KimlikFoto2);
                    lookUpEdit1.EditValue = d.Ulke;
                    lookUpEdit2.EditValue = d.Ilce;
                    lookUpEdit3.EditValue = d.Sehir;
                    labelControl15.Text = d.KimlikFoto1;
                    labelControl16.Text = d.KimlikFoto2;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Seçilen Sütunda Eksik Veya Hatalı Veri Mevcut Lütfen Kontrol Edin", "Uyarı Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
            int secilen = int.Parse(lookUpEdit3.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from x in Baglanti.db.TIlce select new { x.ID, x.Ilce, x.Sehir }).Where(c => c.Sehir == secilen).ToList();
        }
        Repositories.Repository<TMisafir> p = new Repositories.Repository<TMisafir>();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                TMisafir m = new TMisafir();
                m.Ad = textEdit1.Text;
                m.TC = textEdit2.Text;
                m.Telefon = maskedTextBox1.Text;
                m.Adres = memoEdit2.Text;
                m.Aciklama = maskedTextBox1.Text;
                m.KimlikFoto1 = pictureEdit9.GetLoadedImageLocation();
                m.KimlikFoto2 = pictureEdit10.GetLoadedImageLocation();
                m.Ulke = Convert.ToByte(lookUpEdit1.EditValue);
                m.Sehir = Convert.ToByte(lookUpEdit3.EditValue);
                m.Ilce = Convert.ToByte(lookUpEdit2.EditValue);
                p.TAdd(m);
                XtraMessageBox.Show("Ekleme İşlemi Başarılı", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hatalı Veri Girişi Lütfen Kontrol Edin", "Uyarı Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //try
            //{
            var x = Baglanti.db.TMisafir.Find(Baglanti.MID);
            x.Ad = textEdit1.Text;
            x.TC = textEdit2.Text;
            x.Telefon = maskedTextBox1.Text;
            x.Adres = memoEdit2.Text;
            x.Aciklama = maskedTextBox1.Text;
            x.KimlikFoto1 = labelControl15.Text;
            x.KimlikFoto2 = labelControl16.Text;
            x.Ulke = Convert.ToByte(lookUpEdit1.EditValue);
            x.Sehir = Convert.ToByte(lookUpEdit3.EditValue);
            x.Ilce = Convert.ToByte(lookUpEdit2.EditValue);
            p.Update(x);
            XtraMessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //catch (Exception)
            //{
            //    XtraMessageBox.Show("Hatalı Veri Girişi Lütfen Kontrol Edin", "Uyarı Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void pictureEdit9_EditValueChanged(object sender, EventArgs e)
        {
            labelControl15.Text = pictureEdit9.GetLoadedImageLocation();
        }

        private void pictureEdit10_EditValueChanged(object sender, EventArgs e)
        {
            labelControl16.Text = pictureEdit10.GetLoadedImageLocation();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
