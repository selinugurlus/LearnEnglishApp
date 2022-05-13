using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;


namespace SınavSistemii
{
    public partial class SifremiUnuttumForm : MaterialForm
    {
        public SifremiUnuttumForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.Orange200, MaterialSkin.Primary.Orange300, MaterialSkin.Primary.Orange100, MaterialSkin.Accent.DeepOrange100, MaterialSkin.TextShade.WHITE);
        }
        static string constring = "Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=SinavSistemiDB;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(constring);

        public bool MailGonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("sifremiuttum@gmail.com");
            ePosta.To.Add(SifreUnuttumMailTextField.Text);

            ePosta.Subject = konu;
            ePosta.Body = icerik;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("sifremiuttum@gmail.com", "bilgisayar123");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Send(ePosta);
            object userState = true;
            bool kontrol = true;
            try
            {
                client.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message);
            }
            return kontrol;
          
        }
        string sifre;
        private void SifreGonderButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("select * from OgrenciBilgileri where ogrenci_mail='" + SifreUnuttumMailTextField.Text + "'");
                komut.Connection = baglanti;
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    sifre = oku["ogrenci_sifre"].ToString();


                    MailGonder("ŞİFRE HATIRLATMA", "Şifreniz: " + sifre);
                    MessageBox.Show("Mail Gönderildi.");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("bilgiler uymuyor");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata:" + hata);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciGirisForm ogr = new OgrenciGirisForm();
            ogr.Show();
            this.Hide();
        }
    }
}



