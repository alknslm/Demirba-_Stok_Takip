namespace Demirbas_Stok_Takip
{
    partial class Oda_Demirbas_Islem
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
            this.lblPadi = new System.Windows.Forms.Label();
            this.btnDKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDemirbaşİslemAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDmrbasAd = new System.Windows.Forms.ComboBox();
            this.comboPersonelAd = new System.Windows.Forms.ComboBox();
            this.comboOdaID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPadi
            // 
            this.lblPadi.AutoSize = true;
            this.lblPadi.Location = new System.Drawing.Point(178, 86);
            this.lblPadi.Name = "lblPadi";
            this.lblPadi.Size = new System.Drawing.Size(51, 13);
            this.lblPadi.TabIndex = 16;
            this.lblPadi.Text = "Oda Adı :";
            // 
            // btnDKaydet
            // 
            this.btnDKaydet.Location = new System.Drawing.Point(269, 211);
            this.btnDKaydet.Name = "btnDKaydet";
            this.btnDKaydet.Size = new System.Drawing.Size(89, 38);
            this.btnDKaydet.TabIndex = 24;
            this.btnDKaydet.Text = "Demirbaş Kaydet";
            this.btnDKaydet.UseVisualStyleBackColor = true;
            this.btnDKaydet.Click += new System.EventHandler(this.btnDKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = " Demirbaş Adet:";
            // 
            // txtDemirbaşİslemAdet
            // 
            this.txtDemirbaşİslemAdet.Location = new System.Drawing.Point(269, 144);
            this.txtDemirbaşİslemAdet.Name = "txtDemirbaşİslemAdet";
            this.txtDemirbaşİslemAdet.Size = new System.Drawing.Size(100, 20);
            this.txtDemirbaşİslemAdet.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 112);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Demirbaş Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "DEMİRBAŞ ATAMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Personel ";
            // 
            // comboDmrbasAd
            // 
            this.comboDmrbasAd.FormattingEnabled = true;
            this.comboDmrbasAd.Location = new System.Drawing.Point(269, 112);
            this.comboDmrbasAd.Name = "comboDmrbasAd";
            this.comboDmrbasAd.Size = new System.Drawing.Size(100, 21);
            this.comboDmrbasAd.TabIndex = 29;
            // 
            // comboPersonelAd
            // 
            this.comboPersonelAd.FormattingEnabled = true;
            this.comboPersonelAd.Location = new System.Drawing.Point(269, 173);
            this.comboPersonelAd.Name = "comboPersonelAd";
            this.comboPersonelAd.Size = new System.Drawing.Size(100, 21);
            this.comboPersonelAd.TabIndex = 30;
            // 
            // comboOdaID
            // 
            this.comboOdaID.FormattingEnabled = true;
            this.comboOdaID.Location = new System.Drawing.Point(269, 78);
            this.comboOdaID.Name = "comboOdaID";
            this.comboOdaID.Size = new System.Drawing.Size(100, 21);
            this.comboOdaID.TabIndex = 31;
            // 
            // Oda_Demirbas_Islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 361);
            this.Controls.Add(this.comboOdaID);
            this.Controls.Add(this.comboPersonelAd);
            this.Controls.Add(this.comboDmrbasAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDemirbaşİslemAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPadi);
            this.Name = "Oda_Demirbas_Islem";
            this.Text = "Oda_Demirbas_Islem";
            this.Load += new System.EventHandler(this.Oda_Demirbas_Islem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPadi;
        private System.Windows.Forms.Button btnDKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDemirbaşİslemAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboDmrbasAd;
        private System.Windows.Forms.ComboBox comboPersonelAd;
        private System.Windows.Forms.ComboBox comboOdaID;
    }
}