namespace Demirbas_Stok_Takip
{
    partial class Ana_Sayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aramalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personeleGöreDemirbaşAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demirbaşSayısınıAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaDemirbaşİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaDemirbaşListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aramalarToolStripMenuItem,
            this.stokKayıtToolStripMenuItem,
            this.odaTanımlamaToolStripMenuItem,
            this.odaDemirbaşİşlemleriToolStripMenuItem,
            this.odaDemirbaşListesiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aramalarToolStripMenuItem
            // 
            this.aramalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personeleGöreDemirbaşAramaToolStripMenuItem,
            this.demirbaşSayısınıAramaToolStripMenuItem});
            this.aramalarToolStripMenuItem.Name = "aramalarToolStripMenuItem";
            this.aramalarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aramalarToolStripMenuItem.Text = "Aramalar";
            this.aramalarToolStripMenuItem.Click += new System.EventHandler(this.aramalarToolStripMenuItem_Click);
            // 
            // personeleGöreDemirbaşAramaToolStripMenuItem
            // 
            this.personeleGöreDemirbaşAramaToolStripMenuItem.Name = "personeleGöreDemirbaşAramaToolStripMenuItem";
            this.personeleGöreDemirbaşAramaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.personeleGöreDemirbaşAramaToolStripMenuItem.Text = "Personele göre demirbaş arama";
            this.personeleGöreDemirbaşAramaToolStripMenuItem.Click += new System.EventHandler(this.personeleGöreDemirbaşAramaToolStripMenuItem_Click);
            // 
            // demirbaşSayısınıAramaToolStripMenuItem
            // 
            this.demirbaşSayısınıAramaToolStripMenuItem.Name = "demirbaşSayısınıAramaToolStripMenuItem";
            this.demirbaşSayısınıAramaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.demirbaşSayısınıAramaToolStripMenuItem.Text = "Demirbaş sayısını arama";
            this.demirbaşSayısınıAramaToolStripMenuItem.Click += new System.EventHandler(this.demirbaşSayısınıAramaToolStripMenuItem_Click);
            // 
            // stokKayıtToolStripMenuItem
            // 
            this.stokKayıtToolStripMenuItem.Name = "stokKayıtToolStripMenuItem";
            this.stokKayıtToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.stokKayıtToolStripMenuItem.Text = "Stok Kayıt";
            this.stokKayıtToolStripMenuItem.Click += new System.EventHandler(this.stokKayıtToolStripMenuItem_Click);
            // 
            // odaTanımlamaToolStripMenuItem
            // 
            this.odaTanımlamaToolStripMenuItem.Name = "odaTanımlamaToolStripMenuItem";
            this.odaTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.odaTanımlamaToolStripMenuItem.Text = "Oda Tanımlama";
            this.odaTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.odaTanımlamaToolStripMenuItem_Click);
            // 
            // odaDemirbaşİşlemleriToolStripMenuItem
            // 
            this.odaDemirbaşİşlemleriToolStripMenuItem.Name = "odaDemirbaşİşlemleriToolStripMenuItem";
            this.odaDemirbaşİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.odaDemirbaşİşlemleriToolStripMenuItem.Text = "Oda Demirbaş İşlemleri";
            this.odaDemirbaşİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.odaDemirbaşİşlemleriToolStripMenuItem_Click);
            // 
            // odaDemirbaşListesiToolStripMenuItem
            // 
            this.odaDemirbaşListesiToolStripMenuItem.Name = "odaDemirbaşListesiToolStripMenuItem";
            this.odaDemirbaşListesiToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.odaDemirbaşListesiToolStripMenuItem.Text = "Oda Demirbaş Listesi";
            this.odaDemirbaşListesiToolStripMenuItem.Click += new System.EventHandler(this.odaDemirbaşListesiToolStripMenuItem_Click);
            // 
            // Ana_Sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 456);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ana_Sayfa";
            this.Text = "Ana_Sayfa";
            this.Load += new System.EventHandler(this.Ana_Sayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aramalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personeleGöreDemirbaşAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demirbaşSayısınıAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaDemirbaşİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaDemirbaşListesiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem stokKayıtToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem odaTanımlamaToolStripMenuItem;
    }
}