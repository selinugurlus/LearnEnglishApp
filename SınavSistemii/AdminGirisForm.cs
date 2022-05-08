using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace SınavSistemii
{
    public partial class AdminGirisForm : MaterialForm
    {
        public AdminGirisForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.LightBlue200, MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.LightBlue300, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void AdminGirisButton_Click(object sender, EventArgs e)
        {
            if (AdminGirisMailTextField.Text == "admin@gmail.com" && AdminGirisSifreTextField.Text == "admin123")
            {
                SoruOnayForm SoruOnay = new SoruOnayForm();
                SoruOnay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("GİRDİĞİNİZ MAİL YA DA ŞİFRE YANLIŞ!");
            }
        }
    }
}

