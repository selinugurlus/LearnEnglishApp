using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SınavSistemii
{
    public partial class SınavSoruHazırlamaForm : MaterialForm
    {
        public SınavSoruHazırlamaForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.Orange200, MaterialSkin.Primary.Orange300, MaterialSkin.Primary.Orange100, MaterialSkin.Accent.DeepOrange100, MaterialSkin.TextShade.WHITE);



        }
        string resimPath;
        private void ResimYukleButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";

            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                SoruGorselipictureBox.Image = Image.FromFile(openFileDialog1.FileName);

                resimPath = openFileDialog1.FileName.ToString();

            }

        }
        private void SoruEkleButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();


            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=SinavSistemiDB;Integrated Security=True");
            SqlCommand komut = new SqlCommand(" insert into Sorular (konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,resim)values(@konu,@soru,@dogrucevap,@yanliscevap1,@yanliscevap2,@yanliscevap3,@image)", baglanti);
            komut.Parameters.AddWithValue("@konu", KonuTextBox.Text);
            komut.Parameters.AddWithValue("@soru", SoruTextBox.Text);
            komut.Parameters.AddWithValue("@dogrucevap", DogruCevapTextBox.Text);
            komut.Parameters.AddWithValue("@yanliscevap1", YanlisCevapTextBox1.Text);
            komut.Parameters.AddWithValue("@yanliscevap2", YanlisCevapTextBox2.Text);
            komut.Parameters.AddWithValue("@yanliscevap3", YanlisCevapTextBox3.Text);
            komut.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;

            try

            {
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Soru kaydedildi.");
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally

            {
                baglanti.Close();
            }

        }

        private void SınavSoruHazırlamaForm_Load(object sender, EventArgs e)
        {

        }

        private void ResimsizSoruEkleButton_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=SinavSistemiDB;Integrated Security=True");
            SqlCommand komut = new SqlCommand(" insert into Sorular (konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3)values(@konu,@soru,@dogrucevap,@yanliscevap1,@yanliscevap2,@yanliscevap3)", baglanti);
            komut.Parameters.AddWithValue("@konu", KonuTextBox.Text);
            komut.Parameters.AddWithValue("@soru", SoruTextBox.Text);
            komut.Parameters.AddWithValue("@dogrucevap", DogruCevapTextBox.Text);
            komut.Parameters.AddWithValue("@yanliscevap1", YanlisCevapTextBox1.Text);
            komut.Parameters.AddWithValue("@yanliscevap2", YanlisCevapTextBox2.Text);
            komut.Parameters.AddWithValue("@yanliscevap3", YanlisCevapTextBox3.Text);
            try

            {
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Soru kaydedildi.");
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally

            {
                baglanti.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinavSorumlusuForm Ssorumlu = new SinavSorumlusuForm();
            Ssorumlu.Show();
            this.Hide();
        }
    }

}



