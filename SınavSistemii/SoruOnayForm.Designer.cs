
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoruKaldırButton = new System.Windows.Forms.Button();
            this.sinavSistemiDBDataSet2 = new SınavSistemii.SinavSistemiDBDataSet2();
            this.sorularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sorularTableAdapter = new SınavSistemii.SinavSistemiDBDataSet2TableAdapters.SorularTableAdapter();
            this.soruidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogrucevapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanliscevap1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanliscevap2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanliscevap3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSistemiDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // SoruKaldırButton
            // 
            this.SoruKaldırButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SoruKaldırButton.Location = new System.Drawing.Point(1123, 524);
            this.SoruKaldırButton.Name = "SoruKaldırButton";
            this.SoruKaldırButton.Size = new System.Drawing.Size(200, 93);
            this.SoruKaldırButton.TabIndex = 1;
            this.SoruKaldırButton.Text = "SEÇİLİ SORULARI KALDIR";
            this.SoruKaldırButton.UseVisualStyleBackColor = false;
            this.SoruKaldırButton.Click += new System.EventHandler(this.SoruKaldırButton_Click);
            // 
            // sinavSistemiDBDataSet2
            // 
            this.sinavSistemiDBDataSet2.DataSetName = "SinavSistemiDBDataSet2";
            this.sinavSistemiDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sorularBindingSource
            // 
            this.sorularBindingSource.DataMember = "Sorular";
            this.sorularBindingSource.DataSource = this.sinavSistemiDBDataSet2;
            // 
            // sorularTableAdapter
            // 
            this.sorularTableAdapter.ClearBeforeFill = true;
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
            // SoruOnayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 676);
            this.Controls.Add(this.SoruKaldırButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SoruOnayForm";
            this.Text = "SoruOnayForm";
            this.Load += new System.EventHandler(this.SoruOnayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSistemiDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularBindingSource)).EndInit();
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
    }
}