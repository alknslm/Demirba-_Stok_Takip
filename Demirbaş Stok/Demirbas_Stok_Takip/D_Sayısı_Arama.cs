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
    public partial class D_Sayısı_Arama : Form
    {
        public D_Sayısı_Arama()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=SELIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void btnAra_Click(object sender, EventArgs e)
        {
            //SqlCommand kmt = new SqlCommand();
            //DataTable dt = new DataTable();
            //baglan.Open();
            //kmt.Connection = baglan;
            //SqlDataReader idoku;
            //kmt.CommandText = "Select DemirbasTuruID From DemirbasTurleri";
            //idoku = kmt.ExecuteReader();
            //dt.Load(idoku);
            //comboDBasTür.DataSource = dt.DefaultView;
            //comboDBasTür.DisplayMember = "DemirbasTuruAdi";
            //comboDBasTür.ValueMember = "DemirbasTuruID";
            //int turıd = Convert.ToInt32(comboDBasTür.SelectedValue);


            string srg = txtDadi.Text;
            string srg2 = comboDBasTür.Text;
            string srg3 = txtDadet.Text;

            string sorgu = "Select * from Demirbaslar d INNER JOIN DemirbasTurleri dt ON dt.DemirbasTuruID= d.DemirbasTuruID where DemirbasAdi Like '" + srg + "' OR dt.DemirbasTuruAdi Like '" + srg2 + "' OR Adeti Like '" + srg3 + "' ";

            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglan);

            DataSet ds = new DataSet();

            adap.Fill(ds, "demirbasarama");

            this.dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
        }

        private void comboDBasTür_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void D_Sayısı_Arama_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Select DemirbasTuruAdi from DemirbasTurleri", baglan);
            
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            { comboDBasTür.Items.Add(dr2[0]); }

            baglan.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
