namespace Vektorel.KitapBankosuApp
{
    partial class frmKitapIslemleri
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYayinevleri = new System.Windows.Forms.ComboBox();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtBasimYil = new System.Windows.Forms.TextBox();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtSayfaSayi = new System.Windows.Forms.TextBox();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbYazarlar = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnYayinEkle = new System.Windows.Forms.Button();
            this.btnTurEkle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(97, 347);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(181, 49);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Kitap Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(46, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Türü";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(43, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(46, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Adet";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Basım Yılı";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sayfa Sayısı";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Yayın Evi";
            // 
            // cmbYayinevleri
            // 
            this.cmbYayinevleri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbYayinevleri.FormattingEnabled = true;
            this.cmbYayinevleri.Location = new System.Drawing.Point(85, 163);
            this.cmbYayinevleri.Name = "cmbYayinevleri";
            this.cmbYayinevleri.Size = new System.Drawing.Size(151, 21);
            this.cmbYayinevleri.TabIndex = 7;
            // 
            // cmbTurler
            // 
            this.cmbTurler.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(85, 134);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(151, 21);
            this.cmbTurler.TabIndex = 6;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtIsbn, 2);
            this.txtIsbn.Location = new System.Drawing.Point(85, 107);
            this.txtIsbn.MaxLength = 13;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(190, 20);
            this.txtIsbn.TabIndex = 5;
            // 
            // txtAdet
            // 
            this.txtAdet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtAdet, 2);
            this.txtAdet.Location = new System.Drawing.Point(85, 81);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(190, 20);
            this.txtAdet.TabIndex = 4;
            // 
            // txtBasimYil
            // 
            this.txtBasimYil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtBasimYil, 2);
            this.txtBasimYil.Location = new System.Drawing.Point(85, 55);
            this.txtBasimYil.Name = "txtBasimYil";
            this.txtBasimYil.Size = new System.Drawing.Size(190, 20);
            this.txtBasimYil.TabIndex = 3;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtKitapAd, 2);
            this.txtKitapAd.Location = new System.Drawing.Point(85, 3);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(190, 20);
            this.txtKitapAd.TabIndex = 1;
            // 
            // txtSayfaSayi
            // 
            this.txtSayfaSayi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtSayfaSayi, 2);
            this.txtSayfaSayi.Location = new System.Drawing.Point(85, 29);
            this.txtSayfaSayi.Name = "txtSayfaSayi";
            this.txtSayfaSayi.Size = new System.Drawing.Size(190, 20);
            this.txtSayfaSayi.TabIndex = 2;
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.lstYazarlar, 2);
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.Location = new System.Drawing.Point(85, 220);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(190, 108);
            this.lstYazarlar.TabIndex = 10;
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarEkle.Location = new System.Drawing.Point(242, 191);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(33, 23);
            this.btnYazarEkle.TabIndex = 9;
            this.btnYazarEkle.Text = "+";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.BtnYazarEkle_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(40, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Yazar";
            // 
            // cmbYazarlar
            // 
            this.cmbYazarlar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbYazarlar.FormattingEnabled = true;
            this.cmbYazarlar.Location = new System.Drawing.Point(85, 192);
            this.cmbYazarlar.Name = "cmbYazarlar";
            this.cmbYazarlar.Size = new System.Drawing.Size(151, 21);
            this.cmbYazarlar.TabIndex = 8;
            this.cmbYazarlar.SelectedIndexChanged += new System.EventHandler(this.cmbYazarlar_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cmbYayinevleri, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lstYazarlar, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnYazarEkle, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbYazarlar, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbTurler, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtKitapAd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtIsbn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSayfaSayi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAdet, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBasimYil, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnYayinEkle, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnTurEkle, 2, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 329);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // btnYayinEkle
            // 
            this.btnYayinEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYayinEkle.Location = new System.Drawing.Point(242, 162);
            this.btnYayinEkle.Name = "btnYayinEkle";
            this.btnYayinEkle.Size = new System.Drawing.Size(33, 23);
            this.btnYayinEkle.TabIndex = 7;
            this.btnYayinEkle.Text = "+";
            this.btnYayinEkle.UseVisualStyleBackColor = true;
            this.btnYayinEkle.Click += new System.EventHandler(this.btnYayinEkle_Click);
            // 
            // btnTurEkle
            // 
            this.btnTurEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTurEkle.Location = new System.Drawing.Point(242, 133);
            this.btnTurEkle.Name = "btnTurEkle";
            this.btnTurEkle.Size = new System.Drawing.Size(33, 23);
            this.btnTurEkle.TabIndex = 6;
            this.btnTurEkle.Text = "+";
            this.btnTurEkle.UseVisualStyleBackColor = true;
            this.btnTurEkle.Click += new System.EventHandler(this.btnTurEkle_Click);
            // 
            // frmKitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 401);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKitapIslemleri";
            this.Text = "Kitap Ekleme Formu";
            this.Load += new System.EventHandler(this.FrmKitapIslemleri_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYayinevleri;
        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtBasimYil;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtSayfaSayi;
        private System.Windows.Forms.ListBox lstYazarlar;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbYazarlar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnYayinEkle;
        private System.Windows.Forms.Button btnTurEkle;
    }
}