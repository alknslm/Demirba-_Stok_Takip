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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ytk;
        SqlConnection baglan = new SqlConnection("Data Source=SELIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            try
            {
                baglan.Open();
                string sql = "Select * From Kullanicilar where KullaniciAdi=@kadi AND Sifre=@sifre AND Yetki=@yetki";
                if(comboYetki.SelectedItem.ToString()=="Admin")
                {
                    ytk = 0;
                }
                else
                {
                    ytk = 1;
                }
                SqlParameter prm = new SqlParameter("kadi", txtKadi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", txtSifre.Text.Trim());
                SqlParameter prm3 = new SqlParameter("yetki", ytk);

                SqlCommand komut = new SqlCommand(sql, baglan);
                
                komut.Parameters.Add(prm);
                komut.Parameters.Add(prm2);
                komut.Parameters.Add(prm3);
                DataTable dt = new DataTable();
               
                SqlDataAdapter da = new SqlDataAdapter(komut);
                
                da.Fill(dt);
                
                if(dt.Rows.Count>0)
                {

                    if (ytk == 0)
                    {
                        Ana_Sayfa anasayfa = new Ana_Sayfa();
                        anasayfa.Show();
                        this.Hide();
                        baglan.Close();
                    }
                    else if (ytk == 1)
                    {
                        
                        Ana_Sayfa anasayfa = new Ana_Sayfa();
                        anasayfa.Show();
                        anasayfa.stokKayıtToolStripMenuItem.Visible = false;
                        anasayfa.odaTanımlamaToolStripMenuItem.Visible = false;
                        this.Hide();
                        baglan.Close();
                    }

                }
                
            }
            catch (Exception)
            {
                baglan.Close();
                MessageBox.Show("Hatalı giris yaptınız!");
                
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}
