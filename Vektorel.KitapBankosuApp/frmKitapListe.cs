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
using Vektorel.KitapBankosu.Models;

namespace Vektorel.KitapBankosuApp
{
    public partial class frmKitapListe : Form
    {
        YazarBL yz = new YazarBL();
        Yazar y = new Yazar();
        DataTable dt;
        public frmKitapListe()
        {
            InitializeComponent();
            grdYazarlar.AutoGenerateColumns = false;
        }

        private void FrmKitapListe_Load(object sender, EventArgs e)
        {
            dt = yz.YazarTablosu();
            grdYazarlar.DataSource = dt;
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            foreach (DataRow item in dt.Rows)
            {
                if (item.RowState!=DataRowState.Deleted)
                {
                    y.Ad = item["Ad"].ToString();
                    y.Soyad = item["Soyad"].ToString();
                    y.DTar = Convert.ToDateTime(item["Dtar"]);
                    if (item["OlumTarih"].ToString() != "")
                    {
                        y.OlumTarih = Convert.ToDateTime(item["OlumTarih"]);
                    }
                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        yz.YazarEkle(y);
                        break;
                    case DataRowState.Deleted:
                        yz.YazarSil(Convert.ToInt32(item["YazarId"]));
                        break;
                    case DataRowState.Modified:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
