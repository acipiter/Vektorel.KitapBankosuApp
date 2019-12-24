using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.KitapBankosu.BLL;

namespace Vektorel.KitapBankosuApp
{
    public partial class frmMain : Form
    {
        DataTable dt;
        public frmMain()
        {
            InitializeComponent();
            grdKitaplar.AutoGenerateColumns = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            frmYazar frm = new frmYazar();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            KitapBL kbl = new KitapBL();
            dt = kbl.KitapTablosu();
            grdKitaplar.DataSource = dt;
        }

        private void grdKitaplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int kitapid = Convert.ToInt32(dt.Rows[e.RowIndex]["KitapId"]);
            frmKitapIslemleri frm = new frmKitapIslemleri(kitapid);
            frm.ShowDialog();
        }
    }
}
