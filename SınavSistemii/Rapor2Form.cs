using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SınavSistemii
{
    public partial class Rapor2Form : MaterialForm
    {

        public Rapor2Form()
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
        int yanlissayisi = 0;

        private void Rapor2Form_Load_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count(*) from YanlisSorular where [konu]='Animals'", baglanti);
            yanlissayisi = Convert.ToInt32(komut.ExecuteScalar());
            AnimalstextBox1.Text = yanlissayisi.ToString();
            SqlCommand komut1 = new SqlCommand("select count(*) from YanlisSorular where [konu]='Jobs'", baglanti);
            yanlissayisi = Convert.ToInt32(komut1.ExecuteScalar());
            JobstextBox1.Text = yanlissayisi.ToString();
            SqlCommand komut2 = new SqlCommand("select count(*) from YanlisSorular where [konu]='SimplePresentTense'", baglanti);
            yanlissayisi = Convert.ToInt32(komut2.ExecuteScalar());
            PresentTextBox.Text = yanlissayisi.ToString();
            SqlCommand komut3 = new SqlCommand("select count(*) from YanlisSorular where [konu]='Foods'", baglanti);
            yanlissayisi = Convert.ToInt32(komut3.ExecuteScalar());
            FoodstextBox1.Text = yanlissayisi.ToString();
            SqlCommand komut4 = new SqlCommand("select count(*) from YanlisSorular where [konu]='FutureTense'", baglanti);
            yanlissayisi = Convert.ToInt32(komut4.ExecuteScalar());
            FuturetextBox1.Text = yanlissayisi.ToString();
            SqlCommand komut5 = new SqlCommand("select count(*) from YanlisSorular where [konu]='Clothes'", baglanti);
            yanlissayisi = Convert.ToInt32(komut5.ExecuteScalar());
            CLothestextBox1.Text = yanlissayisi.ToString();
            SqlCommand komut6 = new SqlCommand("select count(*) from YanlisSorular where [konu]='PastTense'", baglanti);
            yanlissayisi = Convert.ToInt32(komut6.ExecuteScalar());
            PasttextBox1.Text = yanlissayisi.ToString();
            SqlCommand komut7 = new SqlCommand("select count(*) from YanlisSorular where [konu]='Colors'", baglanti);
            yanlissayisi = Convert.ToInt32(komut7.ExecuteScalar());
            ColorstextBox1.Text = yanlissayisi.ToString();
            SqlCommand komut8 = new SqlCommand("select count(*) from YanlisSorular where [konu]='Furnitures'", baglanti);
            yanlissayisi = Convert.ToInt32(komut8.ExecuteScalar());
            FurniturestextBox1.Text = yanlissayisi.ToString();
            SqlCommand komut9 = new SqlCommand("select count(*) from YanlisSorular where [konu]='Numbers'", baglanti);
            yanlissayisi = Convert.ToInt32(komut9.ExecuteScalar());
            NumberstextBox1.Text = yanlissayisi.ToString();


            int AnimalsUnit = Convert.ToInt32(AnimalstextBox1.Text);
            int JobsUnit = Convert.ToInt32(JobstextBox1.Text);
            int SimplePresentTense = Convert.ToInt32(PresentTextBox.Text);
            int FoodsUnit = Convert.ToInt32(FoodstextBox1.Text);
            int FutureTense = Convert.ToInt32(FuturetextBox1.Text);
            int ClothesUnit = Convert.ToInt32(CLothestextBox1.Text);
            int PastTense = Convert.ToInt32(PasttextBox1.Text);
            int ColorsUnit = Convert.ToInt32(ColorstextBox1.Text);
            int FurnituresUnit = Convert.ToInt32(FurniturestextBox1.Text);
            int NumbersUnit = Convert.ToInt32(NumberstextBox1.Text);

            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            chart2.Series["Yanlışlar"].Points.AddXY("animals", AnimalsUnit);
            chart2.Series["Yanlışlar"].Points.AddXY("jobs", JobsUnit);
            chart2.Series["Yanlışlar"].Points.AddXY("simple present tense", SimplePresentTense);
            chart2.Series["Yanlışlar"].Points.AddXY("foods", FoodsUnit);
            chart2.Series["Yanlışlar"].Points.AddXY("future tense", FutureTense);
            chart2.Series["Yanlışlar"].Points.AddXY("clothes", ClothesUnit);
            chart2.Series["Yanlışlar"].Points.AddXY("past tense", PastTense);
            chart2.Series["Yanlışlar"].Points.AddXY("colors", ColorsUnit);
            chart2.Series["Yanlışlar"].Points.AddXY("furnitures", FurnituresUnit);
            chart2.Series["Yanlışlar"].Points.AddXY("numbers", NumbersUnit);

        }
    }
}
