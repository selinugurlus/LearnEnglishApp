using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
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
                (MaterialSkin.Primary.Orange200, MaterialSkin.Primary.Orange300, MaterialSkin.Primary.Orange100, MaterialSkin.Accent.DeepOrange100 ,MaterialSkin.TextShade.WHITE); ;
        }

        static string constring = "Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=SinavSistemiDB;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(constring);
        //private readonly object dbHelper;
        public int sınır = 0;

        private void SinaviBaslatButton_Click(object sender, EventArgs e)
        {



            sınır++;
            if (sınır == 11)
            {
                SinaviBaslatButton.Enabled = false;
                //SinavSorutextBox.Enabled = false;
                DogruCevapbutton.Enabled = false;
                YanlisCevap1button.Enabled = false;
                YanlisCevap2button.Enabled = false;
                YanlisCevap3button.Enabled = false;
                MessageBox.Show("sorular bitti");
            }
            else
            {
                SinaviBaslatButton.Enabled = false;
                SinaviBaslatButton.Text = "Sonraki Soru";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from Sorular where sayac<011111 order by newid() ", baglanti);
                // SqlCommand komut = new SqlCommand("select * from Sorular order by NEWID()", baglanti);
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
            // baglanti.Close();

        }
        private void DogruCevapbutton_Click(object sender, EventArgs e)
        {
            if (sınır == 11)
            {
                SinaviBaslatButton.Enabled = false;
                //SinavSorutextBox.Enabled = false;
                DogruCevapbutton.Enabled = false;
                YanlisCevap1button.Enabled = false;
                YanlisCevap2button.Enabled = false;
                YanlisCevap3button.Enabled = false;
                MessageBox.Show("sorular bitti");
            }
            try
            {
                SayactextBox.Text = SayactextBox.Text + 1;
                //int sayi = Convert.ToInt32(SayactextBox.Text);
                //sayi = sayi + 1;
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("insert into DogruSorular(konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,sorma_tarihi,sayac) values( @konu,@soru,@dogru_cevap,@yanlis_cevap1,@yanlis_cevap2,@yanlis_cevap3,@sorma_tarihi,@sayac)", baglanti);
                //  SqlCommand komut3 = new SqlCommand("Update  set sayac = sayac+1", baglanti);
                SqlCommand komut4 = new SqlCommand("insert into BilinenSorular (konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,sorma_tarihi) select konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,sorma_tarihi from DogruSorular where(sayac=011111)", baglanti);
                //  SqlCommand komut5 = new SqlCommand("select konu,soru from DogruSorular,YanlisSorular where sayac>4");
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut2.Parameters.AddWithValue("@konu", KonutextBox.Text);
                komut2.Parameters.AddWithValue("@soru", SinavSorutextBox.Text);
                komut2.Parameters.AddWithValue("@dogru_cevap", DogruCevapbutton.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap1", YanlisCevap1button.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap2", YanlisCevap2button.Text);
                komut2.Parameters.AddWithValue("@yanlis_cevap3", YanlisCevap3button.Text);
                komut2.Parameters.AddWithValue("@sorma_tarihi", dateTimePicker1.Value);
                //komut3.ExecuteNonQuery();
                komut2.Parameters.AddWithValue("@sayac", SayactextBox.Text);
                komut2.ExecuteNonQuery();
                komut4.ExecuteNonQuery();
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
            if (sınır == 11)
            {
                SinaviBaslatButton.Enabled = false;
                //SinavSorutextBox.Enabled = false;
                DogruCevapbutton.Enabled = false;
                YanlisCevap1button.Enabled = false;
                YanlisCevap2button.Enabled = false;
                YanlisCevap3button.Enabled = false;
                MessageBox.Show("sorular bitti");
            }
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
            if (sınır == 11)
            {
                SinaviBaslatButton.Enabled = false;
                DogruCevapbutton.Enabled = false;
                YanlisCevap1button.Enabled = false;
                YanlisCevap2button.Enabled = false;
                YanlisCevap3button.Enabled = false;
                MessageBox.Show("sorular bitti");
            }
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
            if (sınır == 11)
            {
                SinaviBaslatButton.Enabled = false;
                //SinavSorutextBox.Enabled = false;
                DogruCevapbutton.Enabled = false;
                YanlisCevap1button.Enabled = false;
                YanlisCevap2button.Enabled = false;
                YanlisCevap3button.Enabled = false;
                MessageBox.Show("sorular bitti");
            }
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

        int saniye = 60;
        int dakika = 10;
       
        private void surebaslatbutton_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
           
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            dk_label.Text = dakika.ToString();
            sn_label.Text = saniye.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            saniye = saniye - 1;
            sn_label.Text = saniye.ToString();
            dk_label.Text = (dakika - 1).ToString();
            if (saniye == 0)
            {
                dakika = dakika - 1;
                dk_label.Text = dakika.ToString();
                saniye = 60;
          
            }
            if (dk_label.Text == "-1")
            {
                timer1.Stop();
                dk_label.Text = "0";
                sn_label.Text = "0";
                MessageBox.Show("Süreniz Bitti.");

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciMenuForm Ogrmenu = new OgrenciMenuForm();
            Ogrmenu.Show();
            this.Hide();

        }
    }
}



