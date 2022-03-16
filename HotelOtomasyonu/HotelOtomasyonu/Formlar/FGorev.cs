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
    public partial class FGorev : Form
    {
        public FGorev()
        {
            InitializeComponent();
        }

        private void FGorev_Load(object sender, EventArgs e)
        {
            Baglanti.db.TGorev.Load();
            bindingSource1.DataSource = Baglanti.db.TGorev.Local;
            repositoryItemLookUpEdit1.DataSource = (from x in Baglanti.db.TDurum select new { x.DurumID, x.DurumAd }).ToList();
            repositoryItemLookUpEdit3.DataSource = (from x in Baglanti.db.TDepartman select new { x.DepartmanID, x.Ad }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Baglanti.db.SaveChanges();
        }
    }
}
