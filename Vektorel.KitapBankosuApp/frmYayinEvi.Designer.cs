namespace Vektorel.KitapBankosuApp
{
    partial class frmYayinEvi
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblAd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdres, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAdres, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 84);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAd
            // 
            this.lblAd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(3, 6);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(69, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Yayın Evi Adı";
            // 
            // lblTel
            // 
            this.lblTel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(29, 61);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(43, 13);
            this.lblTel.TabIndex = 1;
            this.lblTel.Text = "Telefon";
            // 
            // lblAdres
            // 
            this.lblAdres.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(38, 32);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 2;
            this.lblAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAdres.Location = new System.Drawing.Point(78, 29);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(204, 20);
            this.txtAdres.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAd.Location = new System.Drawing.Point(78, 3);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(204, 20);
            this.txtAd.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTel.Location = new System.Drawing.Point(78, 58);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(204, 20);
            this.txtTel.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(54, 95);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // frmYayinEvi
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 122);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmYayinEvi";
            this.Text = "Yayın Evi Ekleme Formu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Button btnEkle;
    }
}