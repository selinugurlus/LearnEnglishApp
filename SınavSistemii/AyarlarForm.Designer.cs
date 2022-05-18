namespace SınavSistemii
{
    partial class AyarlarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnvarsayilan = new System.Windows.Forms.Button();
            this.btnSoruSıklıkDegis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoruSıklık = new System.Windows.Forms.Label();
            this.txtboxSoruSıklık = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // btnvarsayilan
            // 
            this.btnvarsayilan.Location = new System.Drawing.Point(67, 201);
            this.btnvarsayilan.Name = "btnvarsayilan";
            this.btnvarsayilan.Size = new System.Drawing.Size(147, 38);
            this.btnvarsayilan.TabIndex = 1;
            this.btnvarsayilan.Text = "Varsayılan Olarak Ayarla";
            this.btnvarsayilan.UseVisualStyleBackColor = true;
            this.btnvarsayilan.Click += new System.EventHandler(this.btnvarsayilan_Click);
            // 
            // btnSoruSıklıkDegis
            // 
            this.btnSoruSıklıkDegis.Location = new System.Drawing.Point(527, 250);
            this.btnSoruSıklıkDegis.Name = "btnSoruSıklıkDegis";
            this.btnSoruSıklıkDegis.Size = new System.Drawing.Size(146, 36);
            this.btnSoruSıklıkDegis.TabIndex = 2;
            this.btnSoruSıklıkDegis.Text = "Soru Sıklığını Belirle";
            this.btnSoruSıklıkDegis.UseVisualStyleBackColor = true;
            this.btnSoruSıklıkDegis.Click += new System.EventHandler(this.btnSoruSıklıkDegis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soruların Sorulma Sıklığını Ayarla";
            // 
            // lblSoruSıklık
            // 
            this.lblSoruSıklık.AutoSize = true;
            this.lblSoruSıklık.Location = new System.Drawing.Point(361, 201);
            this.lblSoruSıklık.Name = "lblSoruSıklık";
            this.lblSoruSıklık.Size = new System.Drawing.Size(233, 13);
            this.lblSoruSıklık.TabIndex = 4;
            this.lblSoruSıklık.Text = "Soru Çıkma Sıklığı Değiştirmek İstediğiniz Miktar:";
            // 
            // txtboxSoruSıklık
            // 
            this.txtboxSoruSıklık.Location = new System.Drawing.Point(607, 198);
            this.txtboxSoruSıklık.Name = "txtboxSoruSıklık";
            this.txtboxSoruSıklık.Size = new System.Drawing.Size(66, 20);
            this.txtboxSoruSıklık.TabIndex = 5;
            // 
            // AyarlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxSoruSıklık);
            this.Controls.Add(this.lblSoruSıklık);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSoruSıklıkDegis);
            this.Controls.Add(this.btnvarsayilan);
            this.Controls.Add(this.label1);
            this.Name = "AyarlarForm";
            this.Text = "AyarlarForm";
            this.Load += new System.EventHandler(this.AyarlarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvarsayilan;
        private System.Windows.Forms.Button btnSoruSıklıkDegis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoruSıklık;
        private System.Windows.Forms.TextBox txtboxSoruSıklık;
    }
}