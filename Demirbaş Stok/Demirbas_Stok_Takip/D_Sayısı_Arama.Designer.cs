namespace Demirbas_Stok_Takip
{
    partial class D_Sayısı_Arama
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
            this.txtDadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDadet = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.comboDBasTür = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDadi
            // 
            this.txtDadi.Location = new System.Drawing.Point(198, 52);
            this.txtDadi.Name = "txtDadi";
            this.txtDadi.Size = new System.Drawing.Size(100, 20);
            this.txtDadi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Demirbaş Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Demirbaş Türü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Demirbaş Adeti :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDadet
            // 
            this.txtDadet.Location = new System.Drawing.Point(199, 118);
            this.txtDadet.MaxLength = 9;
            this.txtDadet.Name = "txtDadet";
            this.txtDadet.Size = new System.Drawing.Size(100, 20);
            this.txtDadet.TabIndex = 8;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(155, 154);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(83, 33);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // comboDBasTür
            // 
            this.comboDBasTür.FormattingEnabled = true;
            this.comboDBasTür.Location = new System.Drawing.Point(199, 86);
            this.comboDBasTür.Name = "comboDBasTür";
            this.comboDBasTür.Size = new System.Drawing.Size(100, 21);
            this.comboDBasTür.TabIndex = 12;
            this.comboDBasTür.SelectedIndexChanged += new System.EventHandler(this.comboDBasTür_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // D_Sayısı_Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboDBasTür);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDadet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDadi);
            this.Name = "D_Sayısı_Arama";
            this.Text = "da";
            this.Load += new System.EventHandler(this.D_Sayısı_Arama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDadet;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox comboDBasTür;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}