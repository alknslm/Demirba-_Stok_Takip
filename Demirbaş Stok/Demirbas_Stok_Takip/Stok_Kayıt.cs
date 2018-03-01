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
    public partial class Stok_Kayıt : Form
    {
        public Stok_Kayıt()
        {
            InitializeComponent();
        }
        string dbasad,komut;
        long adet;
        long fiyat; Bitmap bmp;
        SqlConnection baglan = new SqlConnection("Data Source=SELIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        void listeleme()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "select * from Demirbaslar";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Demirbaslar");
                dataGridView1.DataSource = ds.Tables["Demirbaslar"];
                baglan.Close();
            }
        }
        void liste()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "select * from Demirbaslar";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Demirbaslar");
                dataGridView1.DataSource = ds.Tables["Demirbaslar"];
                baglan.Close();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {   SqlCommand kmt = new SqlCommand();
            DataTable dt = new DataTable();
            baglan.Open();
            kmt.Connection = baglan;
            SqlDataReader idoku;
            kmt.CommandText = "Select DepartmantID From Departmanlar";
            idoku = kmt.ExecuteReader();
            dt.Load(idoku);
            comboBox2.DataSource = dt.DefaultView;
            comboBox2.DisplayMember = "DepartmantAdi";
            comboBox2.ValueMember = "DepartmantID";
            int  turıd= Convert.ToInt32(comboBox2.SelectedValue);
            
            baglan.Close();
            dbasad = txtstokDadi.Text;
            fiyat = Convert.ToInt64(txtstokDfiyat.Text);
            var tarih = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            
            adet = Convert.ToInt64(txtstokDadet.Text);

            SqlConnection con = new SqlConnection();


            con.ConnectionString = "Data Source=SELIM;Initial Catalog=Stok_Takip;Integrated Security=True";// buralar bi 10 kere yazmışsınız
            komut = "insert into Demirbaslar(DemirbasAdi,Fiyat,AlimTarihi,Adeti,DemirbasTuruID,FakulteID,DepartmantID) values ('" + dbasad + "','" + fiyat + "','" + tarih + "','" + adet + "','" + (comboTur.SelectedIndex + 1).ToString() + "','" + (comboBox1.SelectedIndex + 1).ToString() + "','" + turıd + "')";
            con.Open();
            SqlCommand komutsatiri = new SqlCommand(komut, con);
            komutsatiri.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Eklendi");
            liste();
            con.Close();
            
        }

        private void Stok_Kayıt_Load(object sender, EventArgs e)
        {
            
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select FakulteAdi from Fakulteler", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]); }
            baglan.Close();

            baglan.Open();
            SqlCommand komut3 = new SqlCommand("Select DemirbasTuruAdi from DemirbasTurleri", baglan);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            { comboTur.Items.Add(dr3[0]); }
            baglan.Close();



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Select DepartmantAdi from Departmanlar where FakulteID=@fklt", baglan);
            komut2.Parameters.AddWithValue("@fklt", comboBox1.SelectedIndex+1);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            { comboBox2.Items.Add(dr2[0]); }
            
            baglan.Close();
            
        }

        private void PdYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }
       

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width,dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp,new Rectangle(0,0,dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height=height;
            PpdDialog.ShowDialog();
        }

        private void txtstokDadet_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
