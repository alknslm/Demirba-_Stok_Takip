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
    public partial class P_Arama : Form
    {
        public P_Arama()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=SELIM;Initial Catalog=Stok_Takip;Integrated Security=True");

        void listeleme()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "select * from Personeller where PersonelAdi=@padi";
                cmd.Parameters.AddWithValue("@padi", txtPadi.Text);
                cmd.ExecuteReader();
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Personeller");
                dataGridView1.DataSource = ds.Tables["Personeller"];
                baglan.Close();
            }
        }
        public void btnGiris_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string srg = txtPadi.Text;
            string srg2 = txtSoyad.Text;

            string sorgu = "Select * from Personeller where PersonelAdi Like '" + srg + "' OR PersonelSoyadi Like '" + srg2 + "' ";

            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglan);

            DataSet ds = new DataSet();

            adap.Fill(ds, "personelarama");

            this.dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();

        }

        private void P_Arama_Load(object sender, EventArgs e)
        {

        }
    }
}
