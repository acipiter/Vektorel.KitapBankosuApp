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
    public partial class frmKitapIslemleri : Form
    {
        public frmKitapIslemleri()
        {
            InitializeComponent();
        }
        List<Yazar> yazarlar;
        private void FrmKitapIslemleri_Load(object sender, EventArgs e)
        {
            YazarBL yb = new YazarBL();
            TurBL tb = new TurBL();
            YayinEviBL yeb = new YayinEviBL();

            cmbTurler.DisplayMember = "Turad";
            cmbTurler.ValueMember = "Turid";
            cmbTurler.DataSource = tb.TurListesi();

            cmbYayinevleri.DisplayMember = "Ad";
            cmbYayinevleri.ValueMember = "YayinEviId";
            cmbYayinevleri.DataSource = yeb.YayinEviListesi();

            yazarlar = yb.YazarListesi();
            cmbYazarlar.DisplayMember = "AdSoyad";
            //yazarlar.Insert(0, new Yazar)
            cmbYazarlar.ValueMember = "Yazarid";
            cmbYazarlar.DataSource = yazarlar;
        }

        private void BtnYazarEkle_Click(object sender, EventArgs e)
        {
            frmYazar yz = new frmYazar();
            yz.ShowDialog();
        }

        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            frmTur tur = new frmTur();
            tur.ShowDialog();
        }

        private void btnYayinEkle_Click(object sender, EventArgs e)
        {
            frmYayinEvi yayinEvi = new frmYayinEvi();
            yayinEvi.ShowDialog();
        }

        private void cmbYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (true)
            {

            }
            Yazar yz = new Yazar();
            yz.AdSoyad = cmbYazarlar.Text;
            yz.Yazarid = (int)cmbYazarlar.SelectedValue;

            lstYazarlar.DisplayMember = "AdSoyad";
            lstYazarlar.ValueMember = "Yazarid";

            if (YazarKontrol(yz))
            {
                lstYazarlar.Items.Add(yz);
            }
        }

        bool YazarKontrol(Yazar yz)
        {
            foreach (Yazar item in lstYazarlar.Items)
            {
                if (yz.Yazarid == item.Yazarid)
                {
                    MessageBox.Show("Yazar Eklenmiş");
                    return false;
                }
            }
            return true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kitap ktp = new Kitap();
            KitapYazar ky = new KitapYazar();
            KitapBL ktpbl = new KitapBL();
            KitapYazarBL kybl = new KitapYazarBL();

            ktp.KitapAd = txtKitapAd.Text;
            ktp.SayfaSayi = Convert.ToInt16(txtSayfaSayi.Text);
            ktp.BasimYil = Convert.ToInt16(txtBasimYil.Text);
            ktp.Adet = Convert.ToInt16(txtAdet.Text);
            ktp.Isbn = txtIsbn.Text;
            ktp.TurId = Convert.ToInt16(cmbTurler.SelectedValue);
            ktp.YayinEviId = Convert.ToInt16(cmbYayinevleri.SelectedValue);

            bool kitapekle = ktpbl.KitapEkle(ktp);

            short kitapid = ktpbl.SonEklenenKitap();

            bool kitapyazar = false;
            if (kitapid !=0)
            {
                foreach (Yazar yazar in lstYazarlar.Items)
                {
                    kitapyazar = kybl.KitapYazarEkle(new KitapYazar { KitapId = kitapid, YazarId = Convert.ToInt16(yazar.Yazarid) });
                }
            }

            if (kitapekle&&kitapyazar)
            {
                MessageBox.Show("Ekleme Başarılı");
            }
        }
    }
}
