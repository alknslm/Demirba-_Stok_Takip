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
    public partial class Oda_Tanımla : Form
    {
        public Oda_Tanımla()
        {
            InitializeComponent();
        }
        string komut;
        private void btnOdaKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand();
            DataTable dt = new DataTable();
            baglan.Open();
            kmt.Connection = baglan;
            SqlDataReader idoku;
            kmt.CommandText = "Select DepartmantID From Departmanlar";
            idoku = kmt.ExecuteReader();
            dt.Load(idoku);
            comboDep.DataSource = dt.DefaultView;
            comboDep.DisplayMember = "DepartmantAdi";
            comboDep.ValueMember = "DepartmantID";
            int Depıd = Convert.ToInt32(comboDep.SelectedValue);
            
            string Odaadi;
            string odasorumlu;
            baglan.Close();
            Odaadi = txtOdaAdi.Text;
            odasorumlu = comboSorum.SelectedItem.ToString();
            SqlConnection con = new SqlConnection();

            
            con.ConnectionString = "Data Source=SELIM;Initial Catalog=Stok_Takip;Integrated Security=True";// buralar bi 10 kere yazmışsınız
            komut = "insert into Odalar(OdaAdi,DepartmantID,OdaSorumlu) values ('" + Odaadi + "','" + Depıd + "','" + odasorumlu +"')";
            con.Open();
            SqlCommand komutsatiri = new SqlCommand(komut, con);
            komutsatiri.ExecuteNonQuery();
            con.Close();
        }
        SqlConnection baglan = new SqlConnection("Data Source=SELIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void Oda_Tanımla_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut3 = new SqlCommand("Select DepartmantAdi from Departmanlar", baglan);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            { comboDep.Items.Add(dr3[0]); }
            baglan.Close();

            baglan.Open();
            SqlCommand komut4 = new SqlCommand("Select PersonelAdi,PersonelSoyadi from Personeller", baglan);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            { comboSorum.Items.Add(dr4[0]); }
            baglan.Close();
        }
    }
}
