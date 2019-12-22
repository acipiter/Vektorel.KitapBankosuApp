using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Vektorel.KitapBankosuApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            frmYazar frm = new frmYazar();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
