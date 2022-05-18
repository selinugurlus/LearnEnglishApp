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
    public partial class AyarlarForm : MaterialForm
    {
        public AyarlarForm()
        {

            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.Orange200, MaterialSkin.Primary.Orange300, MaterialSkin.Primary.Orange100, MaterialSkin.Accent.DeepOrange100, MaterialSkin.TextShade.WHITE);
        }



        public static int n;
            
            

        private void btnSoruSıklıkDegis_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txtboxSoruSıklık.Text);
            SinavForm sinav = new SinavForm();
            sinav.Show();
            this.Hide();
        }

        private void AyarlarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnvarsayilan_Click(object sender, EventArgs e)
        {
            n = 0;
            SinavForm sinav = new SinavForm();
            sinav.Show();
            this.Hide();
        }
    }
    }

