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
    public partial class FUrun : Form
    {
        public FUrun()
        {
            InitializeComponent();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Baglanti.db.SaveChanges();
        }

        private void FUrun_Load(object sender, EventArgs e)
        {
            Baglanti.db.TUrunGrup.Load();
            bindingSource1.DataSource = Baglanti.db.TUrunGrup.Local;
            repositoryItemLookUpEdit5.DataSource = (from x in Baglanti.db.TDurum select new { x.DurumID, x.DurumAd }).ToList();
        }
    }
}
