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

    public partial class AnaMenuForm : MaterialForm
    {
        public AnaMenuForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.LightBlue200, MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.LightBlue300, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void OgrenciKayıtButton_Click(object sender, EventArgs e)
        {
            OgrenciKayitForm OgrenciKayıt = new OgrenciKayitForm();
            OgrenciKayıt.Show();
            this.Hide();

        }

        private void OgrenciGirisiButton_Click(object sender, EventArgs e)
        {

            OgrenciGirisForm OgrenciGiris = new OgrenciGirisForm();
            OgrenciGiris.Show();
            this.Hide();
        }

        private void AdminGirisiButton_Click(object sender, EventArgs e)
        {
            AdminGirisForm AdminGiris = new AdminGirisForm();
            AdminGiris.Show();
            this.Hide();
        }

        private void SinavSorumlusuGirisiButton_Click(object sender, EventArgs e)
        {
            SinavSorumlusuForm SinavSorumlusuGiris = new SinavSorumlusuForm();
            SinavSorumlusuGiris.Show();
            this.Hide();
        }

    }
}
