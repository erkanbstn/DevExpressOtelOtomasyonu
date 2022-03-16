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
    public partial class FUlke : Form
    {
        public FUlke()
        {
            InitializeComponent();
        }

        private void ülkeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            Baglanti.db.SaveChanges();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Baglanti.db.SaveChanges();
        }

        private void FUlke_Load(object sender, EventArgs e)
        {
            Baglanti.db.TUlke.Load();
            bindingSource1.DataSource = Baglanti.db.TUlke.Local;
        }
    }
}
