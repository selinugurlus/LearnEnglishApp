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
using System.Drawing.Imaging;
using System.IO;

namespace SınavSistemii
{
    public partial class RaporForm : MaterialForm
    {

        public RaporForm()
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
        int dogrusayisi = 0;
        private void RaporForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count(*) from DogruSorular where [konu]='Animals'", baglanti);
            dogrusayisi = Convert.ToInt32(komut.ExecuteScalar());
            AnimalstextBox.Text = dogrusayisi.ToString();
            SqlCommand komut1 = new SqlCommand("select count(*) from DogruSorular where [konu]='Jobs'", baglanti);
            dogrusayisi = Convert.ToInt32(komut1.ExecuteScalar());
            JobstextBox.Text = dogrusayisi.ToString();
            SqlCommand komut2 = new SqlCommand("select count(*) from DogruSorular where [konu]='SimplePresentTense'", baglanti);
            dogrusayisi = Convert.ToInt32(komut2.ExecuteScalar());
            PresenttextBox.Text = dogrusayisi.ToString();
            SqlCommand komut3 = new SqlCommand("select count(*) from DogruSorular where [konu]='Foods'", baglanti);
            dogrusayisi = Convert.ToInt32(komut3.ExecuteScalar());
            FoodstextBox.Text = dogrusayisi.ToString();
            SqlCommand komut4 = new SqlCommand("select count(*) from DogruSorular where [konu]='FutureTense'", baglanti);
            dogrusayisi = Convert.ToInt32(komut4.ExecuteScalar());
            FuturetextBox.Text = dogrusayisi.ToString();
            SqlCommand komut5 = new SqlCommand("select count(*) from DogruSorular where [konu]='Clothes'", baglanti);
            dogrusayisi = Convert.ToInt32(komut5.ExecuteScalar());
            ClothestextBox.Text = dogrusayisi.ToString();
            SqlCommand komut6 = new SqlCommand("select count(*) from DogruSorular where [konu]='PastTense'", baglanti);
            dogrusayisi = Convert.ToInt32(komut6.ExecuteScalar());
            PasttextBox.Text = dogrusayisi.ToString();
            SqlCommand komut7 = new SqlCommand("select count(*) from DogruSorular where [konu]='Colors'", baglanti);
            dogrusayisi = Convert.ToInt32(komut7.ExecuteScalar());
            ColorstextBox.Text = dogrusayisi.ToString();
            SqlCommand komut8 = new SqlCommand("select count(*) from DogruSorular where [konu]='Furnitures'", baglanti);
            dogrusayisi = Convert.ToInt32(komut8.ExecuteScalar());
            FurniturestextBox.Text = dogrusayisi.ToString();
            SqlCommand komut9 = new SqlCommand("select count(*) from DogruSorular where [konu]='Numbers'", baglanti);
            dogrusayisi = Convert.ToInt32(komut9.ExecuteScalar());
            NumberstextBox.Text = dogrusayisi.ToString();

            int AnimalsUnit = Convert.ToInt32(AnimalstextBox.Text);
            int JobsUnit = Convert.ToInt32(JobstextBox.Text);
            int SimplePresentTense = Convert.ToInt32(PresenttextBox.Text);
            int FoodsUnit = Convert.ToInt32(FoodstextBox.Text);
            int FutureTense = Convert.ToInt32(FuturetextBox.Text);
            int ClothesUnit = Convert.ToInt32(ClothestextBox.Text);
            int PastTense = Convert.ToInt32(PasttextBox.Text);
            int ColorsUnit = Convert.ToInt32(ColorstextBox.Text);
            int FurnituresUnit = Convert.ToInt32(FurniturestextBox.Text);
            int NumbersUnit = Convert.ToInt32(NumberstextBox.Text);

            foreach(var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Series["Doğrular"].Points.AddXY("animals", AnimalsUnit);
            chart1.Series["Doğrular"].Points.AddXY("jobs", JobsUnit);
            chart1.Series["Doğrular"].Points.AddXY("simple present tense", SimplePresentTense);
            chart1.Series["Doğrular"].Points.AddXY("foods", FoodsUnit);
            chart1.Series["Doğrular"].Points.AddXY("future tense",FutureTense);
            chart1.Series["Doğrular"].Points.AddXY("clothes", ClothesUnit);
            chart1.Series["Doğrular"].Points.AddXY("past tense", PastTense);
            chart1.Series["Doğrular"].Points.AddXY("colors", ColorsUnit);
            chart1.Series["Doğrular"].Points.AddXY("furnitures", FurnituresUnit);
            chart1.Series["Doğrular"].Points.AddXY("numbers", NumbersUnit);





            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciMenuForm ogrmenu = new OgrenciMenuForm();
            ogrmenu.Show();
            this.Hide();
        }

     




        private void button2_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Ekran_Resimleri");
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"C:\Ekran_Resimleri\ekrangoruntusu.png");
            }
            MessageBox.Show("Rapor Ekran_Resimleri klasöründe kaydedildi.");
        }
    }
}
