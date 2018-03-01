namespace Demirbas_Stok_Takip
{
    partial class Oda_Tanımla
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
            this.btnOdaKaydet = new System.Windows.Forms.Button();
            this.lblPsoyad = new System.Windows.Forms.Label();
            this.lblPadi = new System.Windows.Forms.Label();
            this.txtOdaAdi = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.comboDep = new System.Windows.Forms.ComboBox();
            this.comboSorum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOdaKaydet
            // 
            this.btnOdaKaydet.Location = new System.Drawing.Point(103, 139);
            this.btnOdaKaydet.Name = "btnOdaKaydet";
            this.btnOdaKaydet.Size = new System.Drawing.Size(89, 38);
            this.btnOdaKaydet.TabIndex = 14;
            this.btnOdaKaydet.Text = "Oda Kaydet";
            this.btnOdaKaydet.UseVisualStyleBackColor = true;
            this.btnOdaKaydet.Click += new System.EventHandler(this.btnOdaKaydet_Click);
            // 
            // lblPsoyad
            // 
            this.lblPsoyad.AutoSize = true;
            this.lblPsoyad.Location = new System.Drawing.Point(58, 94);
            this.lblPsoyad.Name = "lblPsoyad";
            this.lblPsoyad.Size = new System.Drawing.Size(85, 13);
            this.lblPsoyad.TabIndex = 13;
            this.lblPsoyad.Text = "Oda Sorumlusu :";
            // 
            // lblPadi
            // 
            this.lblPadi.AutoSize = true;
            this.lblPadi.Location = new System.Drawing.Point(58, 59);
            this.lblPadi.Name = "lblPadi";
            this.lblPadi.Size = new System.Drawing.Size(51, 13);
            this.lblPadi.TabIndex = 11;
            this.lblPadi.Text = "Oda Adı :";
            // 
            // txtOdaAdi
            // 
            this.txtOdaAdi.Location = new System.Drawing.Point(149, 56);
            this.txtOdaAdi.Name = "txtOdaAdi";
            this.txtOdaAdi.Size = new System.Drawing.Size(120, 20);
            this.txtOdaAdi.TabIndex = 10;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(58, 30);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(87, 13);
            this.lblDep.TabIndex = 15;
            this.lblDep.Text = "Departman Türü:";
            // 
            // comboDep
            // 
            this.comboDep.FormattingEnabled = true;
            this.comboDep.Location = new System.Drawing.Point(149, 22);
            this.comboDep.Name = "comboDep";
            this.comboDep.Size = new System.Drawing.Size(120, 21);
            this.comboDep.TabIndex = 16;
            // 
            // comboSorum
            // 
            this.comboSorum.FormattingEnabled = true;
            this.comboSorum.Location = new System.Drawing.Point(150, 94);
            this.comboSorum.Name = "comboSorum";
            this.comboSorum.Size = new System.Drawing.Size(119, 21);
            this.comboSorum.TabIndex = 17;
            // 
            // Oda_Tanımla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 296);
            this.Controls.Add(this.comboSorum);
            this.Controls.Add(this.comboDep);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.btnOdaKaydet);
            this.Controls.Add(this.lblPsoyad);
            this.Controls.Add(this.lblPadi);
            this.Controls.Add(this.txtOdaAdi);
            this.Name = "Oda_Tanımla";
            this.Text = "Oda_Tanımla";
            this.Load += new System.EventHandler(this.Oda_Tanımla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdaKaydet;
        private System.Windows.Forms.Label lblPsoyad;
        private System.Windows.Forms.Label lblPadi;
        private System.Windows.Forms.TextBox txtOdaAdi;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.ComboBox comboDep;
        private System.Windows.Forms.ComboBox comboSorum;
    }
}