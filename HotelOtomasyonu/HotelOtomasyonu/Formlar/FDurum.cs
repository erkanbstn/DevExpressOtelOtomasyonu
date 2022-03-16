using DevExpress.XtraEditors;
using HotelOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelOtomasyonu.Formlar
{
    public partial class FDurum : Form
    {
        public FDurum()
        {
            InitializeComponent();
        }

        private void FDurum_Load(object sender, EventArgs e)
        {
            Baglanti.db.TDurum.Load();
            bindingSource1.DataSource = Baglanti.db.TDurum.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Baglanti.db.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lütfen Değerleri Kontrol Edin Ve Yeniden Deneyin.", "Hata Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
        }
    }
}
