namespace Vektorel.KitapBankosuApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnYazarEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayınEvleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayınEviEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayınEvleriniListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.grdKitaplar = new System.Windows.Forms.DataGridView();
            this.clmIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKitapAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBasimYil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapİşlemleriToolStripMenuItem,
            this.yazarlarToolStripMenuItem,
            this.türİşlemleriToolStripMenuItem,
            this.yayınEvleriToolStripMenuItem,
            this.btnCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem});
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitaplar";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            // 
            // yazarlarToolStripMenuItem
            // 
            this.yazarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYazarEkle,
            this.yazarlarıListeleToolStripMenuItem});
            this.yazarlarToolStripMenuItem.Name = "yazarlarToolStripMenuItem";
            this.yazarlarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.yazarlarToolStripMenuItem.Text = "Yazarlar";
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(153, 22);
            this.btnYazarEkle.Text = "Yazar Ekle";
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // yazarlarıListeleToolStripMenuItem
            // 
            this.yazarlarıListeleToolStripMenuItem.Name = "yazarlarıListeleToolStripMenuItem";
            this.yazarlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.yazarlarıListeleToolStripMenuItem.Text = "Yazarları Listele";
            // 
            // türİşlemleriToolStripMenuItem
            // 
            this.türİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.türEkleToolStripMenuItem,
            this.türleriListeleToolStripMenuItem});
            this.türİşlemleriToolStripMenuItem.Name = "türİşlemleriToolStripMenuItem";
            this.türİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.türİşlemleriToolStripMenuItem.Text = "Türler";
            // 
            // türEkleToolStripMenuItem
            // 
            this.türEkleToolStripMenuItem.Name = "türEkleToolStripMenuItem";
            this.türEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.türEkleToolStripMenuItem.Text = "Tür Ekle";
            // 
            // türleriListeleToolStripMenuItem
            // 
            this.türleriListeleToolStripMenuItem.Name = "türleriListeleToolStripMenuItem";
            this.türleriListeleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.türleriListeleToolStripMenuItem.Text = "Türleri Listele";
            // 
            // yayınEvleriToolStripMenuItem
            // 
            this.yayınEvleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yayınEviEkleToolStripMenuItem,
            this.yayınEvleriniListeleToolStripMenuItem});
            this.yayınEvleriToolStripMenuItem.Name = "yayınEvleriToolStripMenuItem";
            this.yayınEvleriToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.yayınEvleriToolStripMenuItem.Text = "Yayın Evleri";
            // 
            // yayınEviEkleToolStripMenuItem
            // 
            this.yayınEviEkleToolStripMenuItem.Name = "yayınEviEkleToolStripMenuItem";
            this.yayınEviEkleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.yayınEviEkleToolStripMenuItem.Text = "Yayın Evi Ekle";
            // 
            // yayınEvleriniListeleToolStripMenuItem
            // 
            this.yayınEvleriniListeleToolStripMenuItem.Name = "yayınEvleriniListeleToolStripMenuItem";
            this.yayınEvleriniListeleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.yayınEvleriniListeleToolStripMenuItem.Text = "Yayın Evlerini Listele";
            // 
            // btnCikis
            // 
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(44, 20);
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // grdKitaplar
            // 
            this.grdKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdKitaplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIsbn,
            this.clmKitapAd,
            this.clmBasimYil,
            this.clmTur,
            this.clmYayinEvi});
            this.grdKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKitaplar.Location = new System.Drawing.Point(0, 24);
            this.grdKitaplar.Name = "grdKitaplar";
            this.grdKitaplar.ReadOnly = true;
            this.grdKitaplar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grdKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdKitaplar.Size = new System.Drawing.Size(800, 426);
            this.grdKitaplar.TabIndex = 2;
            this.grdKitaplar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdKitaplar_CellDoubleClick);
            // 
            // clmIsbn
            // 
            this.clmIsbn.DataPropertyName = "ISBN";
            this.clmIsbn.FillWeight = 54.52399F;
            this.clmIsbn.HeaderText = "ISBN";
            this.clmIsbn.Name = "clmIsbn";
            this.clmIsbn.ReadOnly = true;
            // 
            // clmKitapAd
            // 
            this.clmKitapAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.clmKitapAd.DataPropertyName = "KitapAd";
            this.clmKitapAd.HeaderText = "Kitap Adı";
            this.clmKitapAd.Name = "clmKitapAd";
            this.clmKitapAd.ReadOnly = true;
            this.clmKitapAd.Width = 21;
            // 
            // clmBasimYil
            // 
            this.clmBasimYil.DataPropertyName = "BasimYil";
            this.clmBasimYil.FillWeight = 51.92762F;
            this.clmBasimYil.HeaderText = "Basım Yılı";
            this.clmBasimYil.Name = "clmBasimYil";
            this.clmBasimYil.ReadOnly = true;
            // 
            // clmTur
            // 
            this.clmTur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.clmTur.DataPropertyName = "TurAd";
            this.clmTur.FillWeight = 193.5484F;
            this.clmTur.HeaderText = "Türü";
            this.clmTur.Name = "clmTur";
            this.clmTur.ReadOnly = true;
            this.clmTur.Width = 21;
            // 
            // clmYayinEvi
            // 
            this.clmYayinEvi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmYayinEvi.DataPropertyName = "YayinEviAd";
            this.clmYayinEvi.HeaderText = "Yayın Evi";
            this.clmYayinEvi.Name = "clmYayinEvi";
            this.clmYayinEvi.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdKitaplar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnYazarEkle;
        private System.Windows.Forms.ToolStripMenuItem yazarlarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yayınEvleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yayınEviEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yayınEvleriniListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCikis;
        private System.Windows.Forms.DataGridView grdKitaplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKitapAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBasimYil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYayinEvi;
    }
}