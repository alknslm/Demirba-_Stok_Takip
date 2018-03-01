namespace Demirbas_Stok_Takip
{
    partial class Stok_Kayıt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok_Kayıt));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fakultelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_TakipDataSet1 = new Demirbas_Stok_Takip.Stok_TakipDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.stok_TakipDataSet = new Demirbas_Stok_Takip.Stok_TakipDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstokDadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstokDadet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstokDfiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.departmanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmanlarTableAdapter = new Demirbas_Stok_Takip.Stok_TakipDataSetTableAdapters.DepartmanlarTableAdapter();
            this.fakultelerTableAdapter = new Demirbas_Stok_Takip.Stok_TakipDataSet1TableAdapters.FakultelerTableAdapter();
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.demirbasIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasTuruIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakulteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbaslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_TakipDataSet2 = new Demirbas_Stok_Takip.Stok_TakipDataSet2();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PdYazici = new System.Drawing.Printing.PrintDocument();
            this.PpdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.demirbaslarTableAdapter = new Demirbas_Stok_Takip.Stok_TakipDataSet2TableAdapters.DemirbaslarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fakultelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbaslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fakultelerBindingSource, "FakulteAdi", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(226, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fakultelerBindingSource
            // 
            this.fakultelerBindingSource.DataMember = "Fakulteler";
            this.fakultelerBindingSource.DataSource = this.stok_TakipDataSet1;
            // 
            // stok_TakipDataSet1
            // 
            this.stok_TakipDataSet1.DataSetName = "Stok_TakipDataSet1";
            this.stok_TakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fakülte Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departman Adı :";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stok_TakipDataSet, "Departmanlar.DepartmantAdi", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(226, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(119, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // stok_TakipDataSet
            // 
            this.stok_TakipDataSet.DataSetName = "Stok_TakipDataSet";
            this.stok_TakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Demirbaş Türü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Demirbaş Adı :";
            // 
            // txtstokDadi
            // 
            this.txtstokDadi.Location = new System.Drawing.Point(226, 112);
            this.txtstokDadi.Name = "txtstokDadi";
            this.txtstokDadi.Size = new System.Drawing.Size(119, 20);
            this.txtstokDadi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Demirbaş Adeti :";
            // 
            // txtstokDadet
            // 
            this.txtstokDadet.Location = new System.Drawing.Point(226, 216);
            this.txtstokDadet.MaxLength = 9;
            this.txtstokDadet.Name = "txtstokDadet";
            this.txtstokDadet.Size = new System.Drawing.Size(119, 20);
            this.txtstokDadet.TabIndex = 15;
            this.txtstokDadet.TextChanged += new System.EventHandler(this.txtstokDadet_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Demirbaş Fiyatı :";
            // 
            // txtstokDfiyat
            // 
            this.txtstokDfiyat.Location = new System.Drawing.Point(226, 164);
            this.txtstokDfiyat.MaxLength = 9;
            this.txtstokDfiyat.Name = "txtstokDfiyat";
            this.txtstokDfiyat.Size = new System.Drawing.Size(119, 20);
            this.txtstokDfiyat.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Demirbaş Alım Tarihi :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(382, 88);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 30);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // departmanlarBindingSource
            // 
            this.departmanlarBindingSource.DataMember = "Departmanlar";
            this.departmanlarBindingSource.DataSource = this.stok_TakipDataSet;
            // 
            // departmanlarTableAdapter
            // 
            this.departmanlarTableAdapter.ClearBeforeFill = true;
            // 
            // fakultelerTableAdapter
            // 
            this.fakultelerTableAdapter.ClearBeforeFill = true;
            // 
            // comboTur
            // 
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Location = new System.Drawing.Point(226, 137);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(119, 21);
            this.comboTur.TabIndex = 19;
            this.comboTur.SelectedIndexChanged += new System.EventHandler(this.comboTur_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demirbasIDDataGridViewTextBoxColumn,
            this.demirbasAdiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.alimTarihiDataGridViewTextBoxColumn,
            this.demirbasTuruIDDataGridViewTextBoxColumn,
            this.fakulteIDDataGridViewTextBoxColumn,
            this.departmantIDDataGridViewTextBoxColumn,
            this.adetiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.demirbaslarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // demirbasIDDataGridViewTextBoxColumn
            // 
            this.demirbasIDDataGridViewTextBoxColumn.DataPropertyName = "DemirbasID";
            this.demirbasIDDataGridViewTextBoxColumn.HeaderText = "DemirbasID";
            this.demirbasIDDataGridViewTextBoxColumn.Name = "demirbasIDDataGridViewTextBoxColumn";
            this.demirbasIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // demirbasAdiDataGridViewTextBoxColumn
            // 
            this.demirbasAdiDataGridViewTextBoxColumn.DataPropertyName = "DemirbasAdi";
            this.demirbasAdiDataGridViewTextBoxColumn.HeaderText = "DemirbasAdi";
            this.demirbasAdiDataGridViewTextBoxColumn.Name = "demirbasAdiDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // alimTarihiDataGridViewTextBoxColumn
            // 
            this.alimTarihiDataGridViewTextBoxColumn.DataPropertyName = "AlimTarihi";
            this.alimTarihiDataGridViewTextBoxColumn.HeaderText = "AlimTarihi";
            this.alimTarihiDataGridViewTextBoxColumn.Name = "alimTarihiDataGridViewTextBoxColumn";
            // 
            // demirbasTuruIDDataGridViewTextBoxColumn
            // 
            this.demirbasTuruIDDataGridViewTextBoxColumn.DataPropertyName = "DemirbasTuruID";
            this.demirbasTuruIDDataGridViewTextBoxColumn.HeaderText = "DemirbasTuruID";
            this.demirbasTuruIDDataGridViewTextBoxColumn.Name = "demirbasTuruIDDataGridViewTextBoxColumn";
            // 
            // fakulteIDDataGridViewTextBoxColumn
            // 
            this.fakulteIDDataGridViewTextBoxColumn.DataPropertyName = "FakulteID";
            this.fakulteIDDataGridViewTextBoxColumn.HeaderText = "FakulteID";
            this.fakulteIDDataGridViewTextBoxColumn.Name = "fakulteIDDataGridViewTextBoxColumn";
            // 
            // departmantIDDataGridViewTextBoxColumn
            // 
            this.departmantIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmantID";
            this.departmantIDDataGridViewTextBoxColumn.HeaderText = "DepartmantID";
            this.departmantIDDataGridViewTextBoxColumn.Name = "departmantIDDataGridViewTextBoxColumn";
            // 
            // adetiDataGridViewTextBoxColumn
            // 
            this.adetiDataGridViewTextBoxColumn.DataPropertyName = "Adeti";
            this.adetiDataGridViewTextBoxColumn.HeaderText = "Adeti";
            this.adetiDataGridViewTextBoxColumn.Name = "adetiDataGridViewTextBoxColumn";
            // 
            // demirbaslarBindingSource
            // 
            this.demirbaslarBindingSource.DataMember = "Demirbaslar";
            this.demirbaslarBindingSource.DataSource = this.stok_TakipDataSet2;
            // 
            // stok_TakipDataSet2
            // 
            this.stok_TakipDataSet2.DataSetName = "Stok_TakipDataSet2";
            this.stok_TakipDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // PdYazici
            // 
            this.PdYazici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PdYazici_PrintPage);
            // 
            // PpdDialog
            // 
            this.PpdDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PpdDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PpdDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PpdDialog.Document = this.PdYazici;
            this.PpdDialog.Enabled = true;
            this.PpdDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PpdDialog.Icon")));
            this.PpdDialog.Name = "PpdDialog";
            this.PpdDialog.Visible = false;
            // 
            // btnYazdır
            // 
            this.btnYazdır.Location = new System.Drawing.Point(382, 150);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(80, 30);
            this.btnYazdır.TabIndex = 23;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // demirbaslarTableAdapter
            // 
            this.demirbaslarTableAdapter.ClearBeforeFill = true;
            // 
            // Stok_Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 454);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboTur);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstokDadet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtstokDfiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstokDadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Stok_Kayıt";
            this.Text = "Stok_Kayıt";
            this.Load += new System.EventHandler(this.Stok_Kayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fakultelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbaslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstokDadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstokDadet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstokDfiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
        private Stok_TakipDataSet stok_TakipDataSet;
        private System.Windows.Forms.BindingSource departmanlarBindingSource;
        private Stok_TakipDataSetTableAdapters.DepartmanlarTableAdapter departmanlarTableAdapter;
        private Stok_TakipDataSet1 stok_TakipDataSet1;
        private System.Windows.Forms.BindingSource fakultelerBindingSource;
        private Stok_TakipDataSet1TableAdapters.FakultelerTableAdapter fakultelerTableAdapter;
        private System.Windows.Forms.ComboBox comboTur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Drawing.Printing.PrintDocument PdYazici;
        private System.Windows.Forms.PrintPreviewDialog PpdDialog;
        private System.Windows.Forms.Button btnYazdır;
        private Stok_TakipDataSet2 stok_TakipDataSet2;
        private System.Windows.Forms.BindingSource demirbaslarBindingSource;
        private Stok_TakipDataSet2TableAdapters.DemirbaslarTableAdapter demirbaslarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasTuruIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakulteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetiDataGridViewTextBoxColumn;
    }
}