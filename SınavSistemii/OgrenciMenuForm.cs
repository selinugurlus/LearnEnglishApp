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
    public partial class OgrenciMenuForm : MaterialForm
    {

        public OgrenciMenuForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.LightBlue200, MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.LightBlue300, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void NormalSinavButton_Click(object sender, EventArgs e)
        {
            SinavForm Sinav = new SinavForm();
            Sinav.Show();
            this.Hide();
        }

        private void KarisikSinavButton_Click(object sender, EventArgs e)
        {
            Sinav2Form Sinav2 = new Sinav2Form();
            Sinav2.Show();
            this.Hide();
        }
    }
}
