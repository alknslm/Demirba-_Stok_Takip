using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demirbas_Stok_Takip
{
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
        }
        
        void AltForm(Form altform)
        {
            bool durum = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item.Text == altform.Text)
                {
                    durum = true;
                    item.Activate();
                }
            }

            if (durum == false)
            {
                altform.MdiParent = this;
                altform.Show();
            }
        }

        private void personeleGöreDemirbaşAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_Arama p = new P_Arama();
            AltForm(p);
        }

       

        private void demirbaşSayısınıAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            D_Sayısı_Arama d = new D_Sayısı_Arama();
            AltForm(d);

        }

        private void stokKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_Kayıt s = new Stok_Kayıt();
            AltForm(s);
        }

        private void odaTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oda_Tanımla o = new Oda_Tanımla();
            AltForm(o);
        }

        private void odaDemirbaşİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oda_Demirbas_Islem odi = new Oda_Demirbas_Islem();
            AltForm(odi);
        }

        private void odaDemirbaşListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oda_Demirbas_Liste odl = new Oda_Demirbas_Liste();
            AltForm(odl);
        }

        private void stoktaBulunanDemirbaşToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void aramalarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Ana_Sayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
