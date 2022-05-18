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

    public partial class SoruOnayForm : MaterialForm
    {

        public SoruOnayForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.Orange200, MaterialSkin.Primary.Orange300, MaterialSkin.Primary.Orange100, MaterialSkin.Accent.DeepOrange100, MaterialSkin.TextShade.WHITE);
        }

        private void SoruOnayForm_Load(object sender, EventArgs e)
        {
            
            this.sorularTableAdapter.Fill(this.sinavSistemiDBDataSet2.Sorular);
        }


        static string constring = "Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=SinavSistemiDB;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(constring);




        private void SoruKaldırButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                MessageBox.Show("Seçilen sorular kaldırıldı. Kalan sorular onaylandı.");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGirisForm adgiris = new AdminGirisForm();
            adgiris.Show();
            this.Hide();
        }
    }
}
