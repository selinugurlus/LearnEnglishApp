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

namespace SınavSistemii
{
    public partial class SinavSorumlusuForm : MaterialForm
    {
        public SinavSorumlusuForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.LightBlue200, MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.LightBlue300, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void SSorumlusuGirisButton_Click(object sender, EventArgs e)
        {
            if(SSorumlusuGirisMailTextField.Text=="sinavsorumlusu@gmail.com"&&SSorumlusuSifreTextField.Text=="sinavsorumlusu123")
            {
                SınavSoruHazırlamaForm SoruHazırlama = new SınavSoruHazırlamaForm();
                SoruHazırlama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("GİRDİĞİNİZ MAİL YA DA ŞİFRE YANLIŞ!");
            }
        }
    }
}
