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
                (MaterialSkin.Primary.Orange200, MaterialSkin.Primary.Orange300, MaterialSkin.Primary.Orange100, MaterialSkin.Accent.DeepOrange100, MaterialSkin.TextShade.WHITE);
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

       
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            RaporForm rapor = new RaporForm();
            rapor.Show();
            this.Hide();
        }

        private void RaporButton_Click(object sender, EventArgs e)
        {
            Rapor2Form rapor2 = new Rapor2Form();
            rapor2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciGirisForm ogrgiris = new OgrenciGirisForm();
            ogrgiris.Show();
            this.Hide();
        }
    }
}
