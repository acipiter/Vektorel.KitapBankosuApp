﻿namespace Vektorel.KitapBankosuApp
{
    partial class frmYazar
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDtar = new System.Windows.Forms.Label();
            this.lblOlumTarih = new System.Windows.Forms.Label();
            this.dtDTar = new System.Windows.Forms.DateTimePicker();
            this.dtOlumTar = new System.Windows.Forms.DateTimePicker();
            this.chkYasiyor = new System.Windows.Forms.CheckBox();
            this.btnYazarBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtAd, 2);
            this.txtAd.Location = new System.Drawing.Point(79, 3);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(233, 20);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtSoyad, 2);
            this.txtSoyad.Location = new System.Drawing.Point(79, 29);
            this.txtSoyad.MaxLength = 75;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(233, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 126);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // lblAd
            // 
            this.lblAd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(53, 6);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(36, 32);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblDtar
            // 
            this.lblDtar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDtar.AutoSize = true;
            this.lblDtar.Location = new System.Drawing.Point(3, 58);
            this.lblDtar.Name = "lblDtar";
            this.lblDtar.Size = new System.Drawing.Size(70, 13);
            this.lblDtar.TabIndex = 7;
            this.lblDtar.Text = "Doğum Tarihi";
            // 
            // lblOlumTarih
            // 
            this.lblOlumTarih.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOlumTarih.AutoSize = true;
            this.lblOlumTarih.Location = new System.Drawing.Point(13, 86);
            this.lblOlumTarih.Name = "lblOlumTarih";
            this.lblOlumTarih.Size = new System.Drawing.Size(60, 13);
            this.lblOlumTarih.TabIndex = 8;
            this.lblOlumTarih.Text = "Ölüm Tarihi";
            // 
            // dtDTar
            // 
            this.dtDTar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.dtDTar, 2);
            this.dtDTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDTar.Location = new System.Drawing.Point(79, 55);
            this.dtDTar.Name = "dtDTar";
            this.dtDTar.Size = new System.Drawing.Size(233, 20);
            this.dtDTar.TabIndex = 3;
            // 
            // dtOlumTar
            // 
            this.dtOlumTar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtOlumTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOlumTar.Location = new System.Drawing.Point(79, 83);
            this.dtOlumTar.Name = "dtOlumTar";
            this.dtOlumTar.Size = new System.Drawing.Size(167, 20);
            this.dtOlumTar.TabIndex = 4;
            // 
            // chkYasiyor
            // 
            this.chkYasiyor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkYasiyor.AutoSize = true;
            this.chkYasiyor.Location = new System.Drawing.Point(252, 84);
            this.chkYasiyor.Name = "chkYasiyor";
            this.chkYasiyor.Size = new System.Drawing.Size(60, 17);
            this.chkYasiyor.TabIndex = 5;
            this.chkYasiyor.Text = "Yaşıyor";
            this.chkYasiyor.UseVisualStyleBackColor = true;
            this.chkYasiyor.CheckedChanged += new System.EventHandler(this.ChkYasiyor_CheckedChanged);
            // 
            // btnYazarBul
            // 
            this.btnYazarBul.Location = new System.Drawing.Point(121, 126);
            this.btnYazarBul.Name = "btnYazarBul";
            this.btnYazarBul.Size = new System.Drawing.Size(100, 23);
            this.btnYazarBul.TabIndex = 7;
            this.btnYazarBul.Text = "Yazar Bul";
            this.btnYazarBul.UseVisualStyleBackColor = true;
            this.btnYazarBul.Click += new System.EventHandler(this.BtnYazarBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkRed;
            this.btnSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSil.Location = new System.Drawing.Point(227, 126);
            this.btnSil.Margin = new System.Windows.Forms.Padding(0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblAd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSoyad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkYasiyor, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSoyad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtOlumTar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDtar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblOlumTarih, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtDTar, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 108);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // frmYazar
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 155);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYazarBul);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmYazar";
            this.Text = "Yazar Ekleme Formu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDtar;
        private System.Windows.Forms.Label lblOlumTarih;
        private System.Windows.Forms.Button btnYazarBul;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.DateTimePicker dtDTar;
        public System.Windows.Forms.DateTimePicker dtOlumTar;
        public System.Windows.Forms.CheckBox chkYasiyor;
        public System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}