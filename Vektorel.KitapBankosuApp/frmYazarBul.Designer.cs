namespace Vektorel.KitapBankosuApp
{
    partial class frmYazarBul
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
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.btnYazarBul = new System.Windows.Forms.Button();
            this.lblYazarAd = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtYazarAd.Location = new System.Drawing.Point(119, 11);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(179, 20);
            this.txtYazarAd.TabIndex = 0;
            // 
            // btnYazarBul
            // 
            this.btnYazarBul.Location = new System.Drawing.Point(131, 61);
            this.btnYazarBul.Name = "btnYazarBul";
            this.btnYazarBul.Size = new System.Drawing.Size(99, 23);
            this.btnYazarBul.TabIndex = 1;
            this.btnYazarBul.Text = "Yazar Bul";
            this.btnYazarBul.UseVisualStyleBackColor = true;
            this.btnYazarBul.Click += new System.EventHandler(this.BtnYazarBul_Click);
            // 
            // lblYazarAd
            // 
            this.lblYazarAd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblYazarAd.AutoSize = true;
            this.lblYazarAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarAd.Location = new System.Drawing.Point(3, 15);
            this.lblYazarAd.Name = "lblYazarAd";
            this.lblYazarAd.Size = new System.Drawing.Size(110, 13);
            this.lblYazarAd.TabIndex = 2;
            this.lblYazarAd.Text = "Yazar Adını Giriniz";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblYazarAd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtYazarAd, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 43);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // frmYazarBul
            // 
            this.AcceptButton = this.btnYazarBul;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 86);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnYazarBul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmYazarBul";
            this.Text = "Yazar Arama Formu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.Button btnYazarBul;
        private System.Windows.Forms.Label lblYazarAd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}