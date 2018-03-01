namespace Demirbas_Stok_Takip
{
    partial class Oda_Demirbas_Liste
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnOdaListeAra = new System.Windows.Forms.Button();
            this.lblPadi = new System.Windows.Forms.Label();
            this.txtOdaListeAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ODA DEMİRBAŞ LİSTESİ";
            // 
            // btnOdaListeAra
            // 
            this.btnOdaListeAra.Location = new System.Drawing.Point(163, 128);
            this.btnOdaListeAra.Name = "btnOdaListeAra";
            this.btnOdaListeAra.Size = new System.Drawing.Size(89, 38);
            this.btnOdaListeAra.TabIndex = 28;
            this.btnOdaListeAra.Text = "Liste Görüntüle";
            this.btnOdaListeAra.UseVisualStyleBackColor = true;
            this.btnOdaListeAra.Click += new System.EventHandler(this.btnOdaListeAra_Click);
            // 
            // lblPadi
            // 
            this.lblPadi.AutoSize = true;
            this.lblPadi.Location = new System.Drawing.Point(72, 105);
            this.lblPadi.Name = "lblPadi";
            this.lblPadi.Size = new System.Drawing.Size(51, 13);
            this.lblPadi.TabIndex = 27;
            this.lblPadi.Text = "Oda Adı :";
            // 
            // txtOdaListeAdi
            // 
            this.txtOdaListeAdi.Location = new System.Drawing.Point(163, 102);
            this.txtOdaListeAdi.Name = "txtOdaListeAdi";
            this.txtOdaListeAdi.Size = new System.Drawing.Size(100, 20);
            this.txtOdaListeAdi.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // Oda_Demirbas_Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 364);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdaListeAra);
            this.Controls.Add(this.lblPadi);
            this.Controls.Add(this.txtOdaListeAdi);
            this.Name = "Oda_Demirbas_Liste";
            this.Text = "Oda_Demirbas_Liste";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOdaListeAra;
        private System.Windows.Forms.Label lblPadi;
        private System.Windows.Forms.TextBox txtOdaListeAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}