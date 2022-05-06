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

        private void SinaviBaslatButton_Click(object sender, EventArgs e)
        {
            SinaviBaslatButton.Enabled = false;
            SinaviBaslatButton.Text = "Sonraki Soru";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Sorular order by NEWID()", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            //for (int i=0;i<10;i++)
            //{
            while (oku.Read())
            {
                DogruCevapbutton.Text = oku["dogru_cevap"].ToString();
                YanlisCevap1button.Text = oku["yanlis_cevap1"].ToString();
                YanlisCevap2button.Text = oku["yanlis_cevap2"].ToString();
                YanlisCevap3button.Text = oku["yanlis_cevap3"].ToString();
                SinavSorutextBox.Text = oku["soru"].ToString();
                //SinavResimpictureBox.Image = (Image)oku["resim"];

            }
            baglanti.Close();
            //}
        }
        private void DogruCevapbutton_Click(object sender, EventArgs e)
        {
            SinaviBaslatButton.Enabled = true;
         
            MessageBox.Show("Tebrikler.Doğru cevap");
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into DogruSorular(konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,resim) select konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,resim from Sorular", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();

        }

        private void YanlisCevap1button_Click(object sender, EventArgs e)
        {
            SinaviBaslatButton.Enabled = true;

            MessageBox.Show("Yanlış Doğru cevap");
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into YanlisSorular(konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,resim) select konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,resim from Sorular", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void YanlisCevap2button_Click(object sender, EventArgs e)
        {
            SinaviBaslatButton.Enabled = true;

            MessageBox.Show("Yanlış cevap");
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into YanlisSorular(konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,resim) select konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,resim from Sorular", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void YanlisCevap3button_Click(object sender, EventArgs e)
        {
            SinaviBaslatButton.Enabled = true;

            MessageBox.Show("Yanlış cevap");
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into YanlisSorular(konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,resim) select konu,soru,dogru_cevap,yanlis_cevap1,yanlis_cevap2,yanlis_cevap3,resim from Sorular", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}


