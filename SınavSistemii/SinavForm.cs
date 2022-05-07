using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavSistemii
{
    public partial class SinavForm : MaterialForm
    {

        public SinavForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.LightBlue200, MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.LightBlue300, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        static string constring = "Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=SinavSistemiDB;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(constring);
        private object dbHelper;

        private void SinaviBaslatButton_Click(object sender, EventArgs e)
        { 
            SinaviBaslatButton.Enabled = false;
            SinaviBaslatButton.Text = "Sonraki Soru";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Sorular order by NEWID()", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

           
            while (oku.Read())
            {
                DogruCevapbutton.Text = oku["dogru_cevap"].ToString();
                YanlisCevap1button.Text = oku["yanlis_cevap1"].ToString();
                YanlisCevap2button.Text = oku["yanlis_cevap2"].ToString();
                YanlisCevap3button.Text = oku["yanlis_cevap3"].ToString();
                SinavSorutextBox.Text = oku["soru"].ToString();
                KonutextBox.Text = oku["konu"].ToString();
                SayactextBox.Text = oku["sayac"].ToString();
               // SinavResimpictureBox.Image = (Image)oku["resim"];

            }
            baglanti.Close();
            
        }
        private void DogruCevapbutton_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("insert into DogruSorular(konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,sorma_tarihi,sayac) values( @konu,@soru,@dogru_cevap,@yanlis_cevap1,@yanlis_cevap2,@yanlis_cevap3,@sorma_tarihi,@sayac)", baglanti);
                SqlCommand komut3 = new SqlCommand("Update Sorular set sayac = sayac+2 ",baglanti);
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut2.Parameters.AddWithValue("@konu", KonutextBox.Text);
                komut2.Parameters.AddWithValue("@soru",SinavSorutextBox.Text);
                komut2.Parameters.AddWithValue("@dogru_cevap", DogruCevapbutton.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap1", YanlisCevap1button.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap2", YanlisCevap2button.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap3", YanlisCevap3button.Text);
                komut2.Parameters.AddWithValue("@sorma_tarihi", dateTimePicker1.Value);
                komut3.ExecuteNonQuery();
                komut2.Parameters.AddWithValue("@sayac", SayactextBox.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
               MessageBox.Show("Tebrikler,doğru cevap.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

             SinaviBaslatButton.Enabled = true;

            
        }

        private void YanlisCevap1button_Click(object sender, EventArgs e)
        {
            try
            {
                
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("insert into YanlisSorular(konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,sorma_tarihi) values( @konu,@soru,@dogru_cevap,@yanlis_cevap1,@yanlis_cevap2,@yanlis_cevap3,@sorma_tarihi)", baglanti);
                 if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand komut3 = new SqlCommand("Update Sorular set sayac =0", baglanti);
                komut2.Parameters.AddWithValue("@konu", KonutextBox.Text);
                komut2.Parameters.AddWithValue("@soru", SinavSorutextBox.Text);
                komut2.Parameters.AddWithValue("@dogru_cevap", DogruCevapbutton.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap1", YanlisCevap1button.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap2", YanlisCevap2button.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap3", YanlisCevap3button.Text);
                komut2.Parameters.AddWithValue("@sorma_tarihi", dateTimePicker1.Value);
                komut3.ExecuteNonQuery();
                komut2.Parameters.AddWithValue("@sayac", SayactextBox.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yanlış cevap.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            SinaviBaslatButton.Enabled = true;

        }

        private void YanlisCevap2button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("insert into YanlisSorular(konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,sorma_tarihi) values( @konu,@soru,@dogru_cevap,@yanlis_cevap1,@yanlis_cevap2,@yanlis_cevap3,@sorma_tarihi)", baglanti);
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand komut3 = new SqlCommand("Update Sorular set sayac =0", baglanti);
                komut2.Parameters.AddWithValue("@konu", KonutextBox.Text);
                komut2.Parameters.AddWithValue("@soru", SinavSorutextBox.Text);
                komut2.Parameters.AddWithValue("@dogru_cevap", DogruCevapbutton.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap1", YanlisCevap1button.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap2", YanlisCevap2button.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap3", YanlisCevap3button.Text);
                komut2.Parameters.AddWithValue("@sorma_tarihi", dateTimePicker1.Value);
                komut3.ExecuteNonQuery();
                komut2.Parameters.AddWithValue("@sayac", SayactextBox.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yanlış cevap.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            SinaviBaslatButton.Enabled = true;

        }

        private void YanlisCevap3button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("insert into YanlisSorular(konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,sorma_tarihi) values( @konu,@soru,@dogru_cevap,@yanlis_cevap1,@yanlis_cevap2,@yanlis_cevap3,@sorma_tarihi)", baglanti);

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand komut3 = new SqlCommand("Update Sorular set sayac =0", baglanti);
                komut2.Parameters.AddWithValue("@konu", KonutextBox.Text);
                komut2.Parameters.AddWithValue("@soru", SinavSorutextBox.Text);
                komut2.Parameters.AddWithValue("@dogru_cevap", DogruCevapbutton.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap1", YanlisCevap1button.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap2", YanlisCevap2button.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap3", YanlisCevap3button.Text);
                komut2.Parameters.AddWithValue("@sorma_tarihi", dateTimePicker1.Value);
                komut3.ExecuteNonQuery();
                komut2.Parameters.AddWithValue("@sayac", SayactextBox.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yanlış cevap.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            SinaviBaslatButton.Enabled = true;

        }

        /*public DataTable OgrenilenSorular()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID,ingilizce,turkce,icumle,tcumle,sozcukturu,kategori,asamaNo FROM DilOgrenmeOtomasyon.dbo.KelimeHavuzu WHERE asamaNo >=5";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }*/
    }
}


