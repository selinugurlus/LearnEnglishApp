
namespace SınavSistemii
{
    partial class SoruOnayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoruOnayForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soruidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogrucevapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanliscevap1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanliscevap2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanliscevap3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.sorularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinavSistemiDBDataSet2 = new SınavSistemii.SinavSistemiDBDataSet2();
            this.SoruKaldırButton = new System.Windows.Forms.Button();
            this.sorularTableAdapter = new SınavSistemii.SinavSistemiDBDataSet2TableAdapters.SorularTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSistemiDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soruidDataGridViewTextBoxColumn,
            this.konuDataGridViewTextBoxColumn,
            this.soruDataGridViewTextBoxColumn,
            this.dogrucevapDataGridViewTextBoxColumn,
            this.yanliscevap1DataGridViewTextBoxColumn,
            this.yanliscevap2DataGridViewTextBoxColumn,
            this.yanliscevap3DataGridViewTextBoxColumn,
            this.resimDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.sorularBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // soruidDataGridViewTextBoxColumn
            // 
            this.soruidDataGridViewTextBoxColumn.DataPropertyName = "soru_id";
            this.soruidDataGridViewTextBoxColumn.HeaderText = "soru_id";
            this.soruidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soruidDataGridViewTextBoxColumn.Name = "soruidDataGridViewTextBoxColumn";
            this.soruidDataGridViewTextBoxColumn.ReadOnly = true;
            this.soruidDataGridViewTextBoxColumn.Width = 150;
            // 
            // konuDataGridViewTextBoxColumn
            // 
            this.konuDataGridViewTextBoxColumn.DataPropertyName = "konu";
            this.konuDataGridViewTextBoxColumn.HeaderText = "konu";
            this.konuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.konuDataGridViewTextBoxColumn.Name = "konuDataGridViewTextBoxColumn";
            this.konuDataGridViewTextBoxColumn.Width = 150;
            // 
            // soruDataGridViewTextBoxColumn
            // 
            this.soruDataGridViewTextBoxColumn.DataPropertyName = "soru";
            this.soruDataGridViewTextBoxColumn.HeaderText = "soru";
            this.soruDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soruDataGridViewTextBoxColumn.Name = "soruDataGridViewTextBoxColumn";
            this.soruDataGridViewTextBoxColumn.Width = 150;
            // 
            // dogrucevapDataGridViewTextBoxColumn
            // 
            this.dogrucevapDataGridViewTextBoxColumn.DataPropertyName = "dogru_cevap";
            this.dogrucevapDataGridViewTextBoxColumn.HeaderText = "dogru_cevap";
            this.dogrucevapDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dogrucevapDataGridViewTextBoxColumn.Name = "dogrucevapDataGridViewTextBoxColumn";
            this.dogrucevapDataGridViewTextBoxColumn.Width = 150;
            // 
            // yanliscevap1DataGridViewTextBoxColumn
            // 
            this.yanliscevap1DataGridViewTextBoxColumn.DataPropertyName = "yanlis_cevap1";
            this.yanliscevap1DataGridViewTextBoxColumn.HeaderText = "yanlis_cevap1";
            this.yanliscevap1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yanliscevap1DataGridViewTextBoxColumn.Name = "yanliscevap1DataGridViewTextBoxColumn";
            this.yanliscevap1DataGridViewTextBoxColumn.Width = 150;
            // 
            // yanliscevap2DataGridViewTextBoxColumn
            // 
            this.yanliscevap2DataGridViewTextBoxColumn.DataPropertyName = "yanlis_cevap2";
            this.yanliscevap2DataGridViewTextBoxColumn.HeaderText = "yanlis_cevap2";
            this.yanliscevap2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yanliscevap2DataGridViewTextBoxColumn.Name = "yanliscevap2DataGridViewTextBoxColumn";
            this.yanliscevap2DataGridViewTextBoxColumn.Width = 150;
            // 
            // yanliscevap3DataGridViewTextBoxColumn
            // 
            this.yanliscevap3DataGridViewTextBoxColumn.DataPropertyName = "yanlis_cevap3";
            this.yanliscevap3DataGridViewTextBoxColumn.HeaderText = "yanlis_cevap3";
            this.yanliscevap3DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yanliscevap3DataGridViewTextBoxColumn.Name = "yanliscevap3DataGridViewTextBoxColumn";
            this.yanliscevap3DataGridViewTextBoxColumn.Width = 150;
            // 
            // resimDataGridViewImageColumn
            // 
            this.resimDataGridViewImageColumn.DataPropertyName = "resim";
            this.resimDataGridViewImageColumn.HeaderText = "resim";
            this.resimDataGridViewImageColumn.MinimumWidth = 8;
            this.resimDataGridViewImageColumn.Name = "resimDataGridViewImageColumn";
            this.resimDataGridViewImageColumn.Width = 150;
            // 
            // sorularBindingSource
            // 
            this.sorularBindingSource.DataMember = "Sorular";
            this.sorularBindingSource.DataSource = this.sinavSistemiDBDataSet2;
            // 
            // sinavSistemiDBDataSet2
            // 
            this.sinavSistemiDBDataSet2.DataSetName = "SinavSistemiDBDataSet2";
            this.sinavSistemiDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SoruKaldırButton
            // 
            this.SoruKaldırButton.BackColor = System.Drawing.Color.Coral;
            this.SoruKaldırButton.Location = new System.Drawing.Point(1123, 524);
            this.SoruKaldırButton.Name = "SoruKaldırButton";
            this.SoruKaldırButton.Size = new System.Drawing.Size(200, 93);
            this.SoruKaldırButton.TabIndex = 1;
            this.SoruKaldırButton.Text = "SEÇİLİ SORULARI KALDIR";
            this.SoruKaldırButton.UseVisualStyleBackColor = false;
            this.SoruKaldırButton.Click += new System.EventHandler(this.SoruKaldırButton_Click);
            // 
            // sorularTableAdapter
            // 
            this.sorularTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.ImageKey = "indir.jpg";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(36, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 73);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir.jpg");
            // 
            // SoruOnayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 676);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SoruKaldırButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SoruOnayForm";
            this.Text = "SoruOnayForm";
            this.Load += new System.EventHandler(this.SoruOnayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSistemiDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SoruKaldırButton;
        private SinavSistemiDBDataSet2 sinavSistemiDBDataSet2;
        private System.Windows.Forms.BindingSource sorularBindingSource;
        private SinavSistemiDBDataSet2TableAdapters.SorularTableAdapter sorularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogrucevapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yanliscevap1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yanliscevap2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yanliscevap3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn resimDataGridViewImageColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}