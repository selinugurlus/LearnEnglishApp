using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;


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


     
     private void SifreGonderButton_Click(object sender, EventArgs e)
        {
            sqlbaglanti bgln = new sqlbaglanti();
            SqlCommand komut = new SqlCommand("Select * From OgrenciBilgileri Where ogrenci_mail=" + SifreUnuttumMailTextField.Text.ToString()+ "",bgln.baglanti());

            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                try
                {
                    if (bgln.baglanti().State == ConnectionState.Closed)
                    {
                        bgln.baglanti().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    string tarih = DateTime.Now.ToLongDateString();
                    string mailadresin = ("sifremiuttum@gmail.com");
                    string sifre = ("bilgisayar123");
                    string smtpsrvr = "smtp.gmail.com";
                    string kime = (oku["ogrenci_mail"].ToString());
                    string konu = ("Şifre Hatırlatma Maili");
                    string yaz = (tarih + "tarihindeki talebiniz üzerine şifreniz:" + oku["ogrenci_sifre"].ToString());
                    smtpserver.Credentials = new NetworkCredential(mailadresin, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Şifreniz mailinize gönderildi.");
                    this.Hide();

                }
                catch(Exception Hata)
                {
                    MessageBox.Show("Hata",Hata.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciGirisForm ogrgiris = new OgrenciGirisForm();
            ogrgiris.Show();
            this.Hide();
        }
    }
    }


    
