using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SınavSistemii
{
    public partial class OgrenciGirisForm : MaterialForm
    {
        public OgrenciGirisForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.LightBlue200, MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.LightBlue300, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void OgrSifreUnutButton_Click(object sender, EventArgs e)
        {
            SifremiUnuttumForm AdminGiris = new SifremiUnuttumForm();
            AdminGiris.Show();
            this.Hide();

        }
        static string constring = "Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=SinavSistemiDB;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);


        private void OgrGirisButton_Click(object sender, EventArgs e)
        {
            string mail = OgrGirisMailTextField.Text;
            string sifre = OgrGirisSifreTextField.Text;
            SqlCommand komut = new SqlCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "Select*from OgrenciBilgileri where ogrenci_mail='" + OgrGirisMailTextField.Text + "'And ogrenci_sifre='" + OgrGirisSifreTextField.Text + "'";
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş başarılı.");

            }
            else
            {
                MessageBox.Show("Hatalı mail veya sifre");
            }
            baglan.Close();


        }
    }
}
