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
    public partial class FUrunHareketTanim : Form
    {
        public FUrunHareketTanim()
        {
            InitializeComponent();
        }
        Repositories.Repository<THareket> p = new Repositories.Repository<THareket>();
        private void FUrunHareketTanim_Load(object sender, EventArgs e)
        {
            if (Baglanti.HID > 0)
            {
                var x = p.Find(b => b.HareketID == Baglanti.HID);
                lookUpEdit3.EditValue = x.Urun;
                textEdit3.Text = x.Miktar.ToString();
                dateEdit1.EditValue = x.Tarih.ToString();
                comboBox1.Text = x.HareketTur;
                memoEdit1.Text = x.Aciklama;
            }
            lookUpEdit3.Properties.DataSource = (from x in Baglanti.db.TUrun
                                                 select new
                                                 {
                                                     x.UrunID,
                                                     x.Urun
                                                 }).ToList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                THareket m = new THareket();
                m.Urun = Convert.ToByte(lookUpEdit3.EditValue);
                m.Tarih = DateTime.Parse(dateEdit1.Text);
                m.HareketTur = comboBox1.Text;
                m.Miktar = decimal.Parse(textEdit3.Text);
                m.Aciklama = memoEdit1.Text;
                if (comboBox1.Text != "")
                {
                    p.TAdd(m);
                    XtraMessageBox.Show("Hareket Tanımı Başarıyla Eklendi.", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Hareket Türünüzü Lütfen Kontrol Edin", "Uyarı Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hatalı Veri Girişi Lütfen Kontrol Edin", "Uyarı Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void Otomatize()
        {
            byte id = byte.Parse(lookUpEdit3.EditValue.ToString());
            var x = Baglanti.db.TUrun.Where(b => b.UrunID == id).Select(b => b.Birim).FirstOrDefault();
            var x2 = Baglanti.db.TBirim.Where(b => b.BirimID == x).Select(b => b.Ad).FirstOrDefault();
            var x3 = Baglanti.db.TUrun.Where(b => b.UrunID == id).Select(b => b.Urun).FirstOrDefault();
            memoEdit1.Text = $"{textEdit3.Text} {x2} {x3} {dateEdit1.Text} Tarihinde {comboBox1.Text}  Yapıldı. ";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Otomatize();
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            Otomatize();
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Otomatize();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var x = p.Find(b => b.HareketID == Baglanti.HID);
                x.Aciklama = memoEdit1.Text;
                x.Tarih = Convert.ToDateTime(dateEdit1.Text);
                x.Miktar = decimal.Parse(textEdit3.Text);
                x.Urun = byte.Parse(lookUpEdit3.EditValue.ToString());
                x.HareketTur = comboBox1.Text;
                p.Update(x);
                XtraMessageBox.Show("Hareket Tanımı Başarıyla Güncellendi.", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
