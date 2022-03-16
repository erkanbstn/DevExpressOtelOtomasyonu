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

namespace HotelOtomasyonu.Personel
{
    public partial class FPersonelKart : Form
    {
        public FPersonelKart()
        {
            InitializeComponent();
        }

        private void FPersonelKart_Load(object sender, EventArgs e)
        {

            if (Baglanti.ID != 0)
            {
                var d = p.Find(c => c.PersonelID == Baglanti.ID);
                textEdit1.Text = d.Personel;
                textEdit2.Text = d.TC;
                textEdit5.Text = d.GirisTarih.ToString();
                textEdit4.Text = d.CikisTarih.ToString();
                memoEdit1.Text = d.Aciklama;
                memoEdit2.Text = d.Adres;
                textEdit7.Text = d.Mail;
                maskedTextBox1.Text = d.Telefon;
                pictureEdit9.Image = Image.FromFile(d.KimlikOn);
                pictureEdit10.Image = Image.FromFile(d.KimlikArka);
                lookUpEdit1.EditValue = d.Departman;
                lookUpEdit2.EditValue = d.Gorev;
                labelControl15.Text = d.KimlikOn;
                labelControl16.Text = d.KimlikArka;
            }



            lookUpEdit1.Properties.DataSource = (from x in Baglanti.db.TDepartman select new { x.DepartmanID, x.Ad }).ToList();
            lookUpEdit2.Properties.DataSource = (from x in Baglanti.db.TGorev select new { x.GorevID, x.GorevAd }).ToList();
        }
        Repositories.Repository<TPersonel> p = new Repositories.Repository<TPersonel>();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                TPersonel t = new TPersonel();
                t.Personel = textEdit1.Text;
                t.TC = textEdit2.Text;
                t.Departman = byte.Parse(lookUpEdit1.EditValue.ToString());
                t.Gorev = byte.Parse(lookUpEdit2.EditValue.ToString());
                t.GirisTarih = DateTime.Parse(textEdit5.Text);
                t.CikisTarih = DateTime.Parse(textEdit4.Text);
                t.Telefon = maskedTextBox1.Text;
                t.Adres = memoEdit2.Text;
                t.Aciklama = memoEdit1.Text;
                t.Mail = textEdit7.Text;
                t.Durum = 1;
                t.KimlikOn = pictureEdit9.GetLoadedImageLocation();
                t.KimlikArka = pictureEdit10.GetLoadedImageLocation();
                t.Sifre = textEdit3.Text;
                p.TAdd(t);
                XtraMessageBox.Show("Personel Başarıyla Eklendi", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hatalı Veri Girişi Lütfen Kontrol Edin", "Uyarı Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var c = p.Find(x => x.PersonelID == Baglanti.ID);
                c.Personel = textEdit1.Text;
                c.TC = textEdit2.Text;
                c.Departman = byte.Parse(lookUpEdit1.EditValue.ToString());
                c.Gorev = byte.Parse(lookUpEdit2.EditValue.ToString());
                c.GirisTarih = DateTime.Parse(textEdit5.Text);
                c.CikisTarih = DateTime.Parse(textEdit4.Text);
                c.Telefon = maskedTextBox1.Text;
                c.Adres = memoEdit2.Text;
                c.Aciklama = memoEdit1.Text;
                c.Mail = textEdit7.Text;
                c.Durum = 1;
                c.KimlikOn = labelControl15.Text;
                c.KimlikArka = labelControl16.Text;
                c.Sifre = textEdit3.Text;
                p.Update(c);
                XtraMessageBox.Show("Personel Bilgileri Başarıyla Güncellendi", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hatalı Veri Girişi Lütfen Kontrol Edin", "Uyarı Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureEdit9_EditValueChanged(object sender, EventArgs e)
        {
            labelControl15.Text = pictureEdit9.GetLoadedImageLocation();
        }

        private void pictureEdit10_EditValueChanged(object sender, EventArgs e)
        {
            labelControl16.Text = pictureEdit10.GetLoadedImageLocation();
        }
    }
}
