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
    public partial class Oda_Demirbas_Islem : Form
    {
        public Oda_Demirbas_Islem()
        {
            InitializeComponent();
        }
        string komut;
        SqlConnection baglan = new SqlConnection("Data Source=SELIM;Initial Catalog=Stok_Takip;Integrated Security=True");

        private void btnDKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = SELIM; Initial Catalog = Stok_Takip; Integrated Security = True");
            try
            {
                baglanti.Open();
            }
            catch (Exception)
            {

                throw;
            }


            SqlCommand kmt3 = new SqlCommand();
            DataTable dt3 = new DataTable();

            kmt3.Connection = baglanti;
            SqlDataReader odaidoku;
            kmt3.CommandText = "Select OdaID From Odalar";
            odaidoku = kmt3.ExecuteReader();
            dt3.Load(odaidoku);
            comboDmrbasAd.DataSource = dt3.DefaultView;
            comboDmrbasAd.DisplayMember = "OdaAdi";
            comboDmrbasAd.ValueMember = "OdaID";
            int odaıd = Convert.ToInt32(comboOdaID.SelectedValue);

            SqlCommand kmt = new SqlCommand();
            DataTable dt = new DataTable();
            
            kmt.Connection = baglanti;
            SqlDataReader idoku;
            kmt.CommandText = "Select DemirbasID From Demirbaslar";
            idoku = kmt.ExecuteReader();
            dt.Load(idoku);
            comboDmrbasAd.DataSource = dt.DefaultView;
            comboDmrbasAd.DisplayMember = "DemirbasAdi";
            comboDmrbasAd.ValueMember = "DemirbasID";
            int turıd = Convert.ToInt32(comboDmrbasAd.SelectedValue);

            SqlCommand kmt2 = new SqlCommand();
            DataTable dt2 = new DataTable();
           
            kmt2.Connection = baglanti;
            SqlDataReader adoku;
            kmt2.CommandText = "Select PersonelID From Personeller";
            adoku = kmt2.ExecuteReader();
            dt2.Load(adoku);
            comboPersonelAd.DataSource = dt2.DefaultView;
            comboPersonelAd.DisplayMember = "PersonelAdi";
            comboPersonelAd.ValueMember = "PersonelID";
            int adıd = Convert.ToInt32(comboPersonelAd.SelectedValue);



           
            komut = "Insert into OdaDemirBasAtamalari(OdaID,DemirbasID,Adeti,PersonelID) values ('" + (comboOdaID.SelectedIndex + 1).ToString() + "','" + turıd + "','" + txtDemirbaşİslemAdet.Text + "','" + (comboPersonelAd.SelectedIndex + 1).ToString() +"')";
           
            SqlCommand komutsatiri = new SqlCommand(komut, baglanti);
            komutsatiri.ExecuteNonQuery();
            baglanti.Close();

            

            try
            {
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOdaAra_Click(object sender, EventArgs e)
        {

        }

        private void Oda_Demirbas_Islem_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut7 = new SqlCommand("Select OdaAdi from Odalar", baglan);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            { comboOdaID.Items.Add(dr7[0]); }
            baglan.Close();

            baglan.Open();
            SqlCommand komut5 = new SqlCommand("Select DemirbasAdi from Demirbaslar", baglan);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            { comboDmrbasAd.Items.Add(dr5[0]); }
            baglan.Close();


            baglan.Open();
            SqlCommand komut6 = new SqlCommand("Select PersonelAdi from Personeller", baglan);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            { comboPersonelAd.Items.Add(dr6[0]); }
            baglan.Close();
        }
    }
}
