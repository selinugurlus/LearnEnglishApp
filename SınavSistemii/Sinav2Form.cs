using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SınavSistemii
{
    public partial class Sinav2Form : MaterialForm
    {

        public Sinav2Form()
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
        public int sınır = 0;
        public int dogrusayisi = 0;
        public int yanlissayisi = 0;

        private void Baslabutton_Click(object sender, EventArgs e)
        {

            sınır++;
            if (sınır == 11)
            {
                Baslabutton.Enabled = false;
                //SinavSorutextBox.Enabled = false;
                DogruCevapbutton.Enabled = false;
                YanlisCevap1button.Enabled = false;
                YanlisCevap2button.Enabled = false;
                YanlisCevap3button.Enabled = false;
                MessageBox.Show("sorular bitti");
            }
            else
            {
                Baslabutton.Enabled = false;
                Baslabutton.Text = "Sonraki Soru";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from YanlisSorular,DogruSorular  order by newid() ", baglanti);
                // SqlCommand komut = new SqlCommand("select * from Sorular order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();



                while (oku.Read())
                {
                    DogruCevapbutton.Text = oku["dogru_cevap"].ToString();
                    YanlisCevap1button.Text = oku["yanlis_cevap1"].ToString();
                    YanlisCevap2button.Text = oku["yanlis_cevap2"].ToString();
                    YanlisCevap3button.Text = oku["yanlis_cevap3"].ToString();
                    SorutextBox.Text = oku["soru"].ToString();
                    KonutextBox.Text = oku["konu"].ToString();
                    // SinavResimpictureBox.Image = (Image)oku["resim"];

                }


                baglanti.Close();
            }
        }


        private void DogruCevapbutton_Click_1(object sender, EventArgs e)
        {
            if (sınır == 11)
            {
                Baslabutton.Enabled = false;
                //SinavSorutextBox.Enabled = false;
                DogruCevapbutton.Enabled = false;
                YanlisCevap1button.Enabled = false;
                YanlisCevap2button.Enabled = false;
                YanlisCevap3button.Enabled = false;
                MessageBox.Show("sorular bitti");
            }
            try
            {
                dogrusayisi++;
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                baglanti.Close();
                MessageBox.Show("Tebrikler,doğru cevap.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            Baslabutton.Enabled = true;

        }

        private void YanlisCevap1button_Click_1(object sender, EventArgs e)
        {

            if (sınır == 11)
            {
                Baslabutton.Enabled = false;
                DogruCevapbutton.Enabled = false;
                YanlisCevap1button.Enabled = false;
                YanlisCevap2button.Enabled = false;
                YanlisCevap3button.Enabled = false;
                MessageBox.Show("sorular bitti");
            }
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                baglanti.Close();
                MessageBox.Show("Yanlış cevap.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            Baslabutton.Enabled = true;

        }

        private void YanlisCevap2button_Click_1(object sender, EventArgs e)
        {
            if (sınır == 11)
            {
                Baslabutton.Enabled = false;
                DogruCevapbutton.Enabled = false;
                YanlisCevap1button.Enabled = false;
                YanlisCevap2button.Enabled = false;
                YanlisCevap3button.Enabled = false;
                MessageBox.Show("sorular bitti");
            }
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                baglanti.Close();
                MessageBox.Show("Yanlış cevap.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            Baslabutton.Enabled = true;

        }

        private void YanlisCevap3button_Click(object sender, EventArgs e)
        {

            if (sınır == 11)
            {
                Baslabutton.Enabled = false;
                DogruCevapbutton.Enabled = false;
                YanlisCevap1button.Enabled = false;
                YanlisCevap2button.Enabled = false;
                YanlisCevap3button.Enabled = false;
                MessageBox.Show("sorular bitti");
            }
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                baglanti.Close();
                MessageBox.Show("Yanlış cevap.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            Baslabutton.Enabled = true;
        }
    }
}





