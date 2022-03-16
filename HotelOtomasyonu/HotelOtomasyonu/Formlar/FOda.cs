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
    public partial class FOda : Form
    {
        public FOda()
        {
            InitializeComponent();
        }

        private void FOda_Load(object sender, EventArgs e)
        {
            Baglanti.db.TOda.Load();
            bindingSource1.DataSource = Baglanti.db.TOda.Local;
            repositoryItemLookUpEdit4.DataSource = (from x in Baglanti.db.TDurum select new { x.DurumID, x.DurumAd }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Baglanti.db.SaveChanges();

        }
    }
}
