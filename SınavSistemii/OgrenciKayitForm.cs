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
using System.Data.SqlClient;

namespace SınavSistemii
{
    public partial class OgrenciKayitForm : MaterialForm
    {
        public OgrenciKayitForm()
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void OgrKayıtOlButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into OgrenciBİlgileri (ogrenci_adi,ogrenci_soyadi,ogrenci_mail,ogrenci_sifre)values(@ad,@soyad,@mail,@sifre)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@ad", OgrKayıtAdTextField.Text);
                komut.Parameters.AddWithValue("@soyad", OgrKayıtSoyadTextField.Text);
                komut.Parameters.AddWithValue("@mail", OgrKayıtMailTextField.Text);
                komut.Parameters.AddWithValue("@sifre", OgrKayıtSifreTextField.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("KAYDINIZ TAMAMLANMIŞIR");
            }
            catch(Exception hata)
            {
                MessageBox.Show("HATA" + hata);
            }
        }
    }
}
