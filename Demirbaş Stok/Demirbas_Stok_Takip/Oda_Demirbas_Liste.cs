using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demirbas_Stok_Takip
{
    public partial class Oda_Demirbas_Liste : Form
    {
        public Oda_Demirbas_Liste()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=SELIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void btnOdaListeAra_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string srg = txtOdaListeAdi.Text;


            string sorgu = "Select d.* from OdaDemirbasAtamalari OdDeAt INNER JOIN Demirbaslar d ON OdDeAt.DemirbasID = d.DemirbasID INNER JOIN Odalar o ON OdDeAt.OdaID = o.OdaID where o.OdaAdi Like '" + srg + "' ";

            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglan);

            DataSet ds = new DataSet();

            adap.Fill(ds, "personelarama");

            this.dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
        }
    }
}
