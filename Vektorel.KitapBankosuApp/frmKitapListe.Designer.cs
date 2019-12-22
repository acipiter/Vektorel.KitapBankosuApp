namespace Vektorel.KitapBankosuApp
{
    partial class frmKitapListe
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
            this.grdYazarlar = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.clmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDogum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdYazarlar)).BeginInit();
            this.SuspendLayout();
            // 
            // grdYazarlar
            // 
            this.grdYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYazarlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAd,
            this.clmSoyad,
            this.clmDogum,
            this.clmOlum});
            this.grdYazarlar.Location = new System.Drawing.Point(108, 72);
            this.grdYazarlar.Name = "grdYazarlar";
            this.grdYazarlar.Size = new System.Drawing.Size(599, 150);
            this.grdYazarlar.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(108, 228);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(189, 23);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Değişiklikleri Kaydet";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // clmAd
            // 
            this.clmAd.DataPropertyName = "Ad";
            this.clmAd.HeaderText = "Ad";
            this.clmAd.Name = "clmAd";
            // 
            // clmSoyad
            // 
            this.clmSoyad.DataPropertyName = "Soyad";
            this.clmSoyad.HeaderText = "Soyad";
            this.clmSoyad.Name = "clmSoyad";
            // 
            // clmDogum
            // 
            this.clmDogum.DataPropertyName = "Dtar";
            this.clmDogum.HeaderText = "Doğum Tarihi";
            this.clmDogum.Name = "clmDogum";
            // 
            // clmOlum
            // 
            this.clmOlum.DataPropertyName = "OlumTarih";
            this.clmOlum.HeaderText = "Ölüm Tarihi";
            this.clmOlum.Name = "clmOlum";
            // 
            // frmKitapListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.grdYazarlar);
            this.Name = "frmKitapListe";
            this.Text = "frmKitapListe";
            this.Load += new System.EventHandler(this.FrmKitapListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdYazarlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdYazarlar;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDogum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOlum;
    }
}