
namespace SınavSistemii
{
    partial class OgrenciMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciMenuForm));
            this.NormalSinavButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.KarisikSinavButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.RaporButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // NormalSinavButton
            // 
            this.NormalSinavButton.AutoSize = true;
            this.NormalSinavButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NormalSinavButton.Depth = 0;
            this.NormalSinavButton.Icon = null;
            this.NormalSinavButton.Location = new System.Drawing.Point(88, 293);
            this.NormalSinavButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NormalSinavButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NormalSinavButton.Name = "NormalSinavButton";
            this.NormalSinavButton.Primary = false;
            this.NormalSinavButton.Size = new System.Drawing.Size(194, 36);
            this.NormalSinavButton.TabIndex = 0;
            this.NormalSinavButton.Text = "STANDART SINAV";
            this.NormalSinavButton.UseVisualStyleBackColor = true;
            this.NormalSinavButton.Click += new System.EventHandler(this.NormalSinavButton_Click);
            // 
            // KarisikSinavButton
            // 
            this.KarisikSinavButton.AutoSize = true;
            this.KarisikSinavButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KarisikSinavButton.Depth = 0;
            this.KarisikSinavButton.Icon = null;
            this.KarisikSinavButton.Location = new System.Drawing.Point(401, 336);
            this.KarisikSinavButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.KarisikSinavButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.KarisikSinavButton.Name = "KarisikSinavButton";
            this.KarisikSinavButton.Primary = false;
            this.KarisikSinavButton.Size = new System.Drawing.Size(422, 36);
            this.KarisikSinavButton.TabIndex = 1;
            this.KarisikSinavButton.Text = "EKSİK OLDUĞUN KONULARDAN SORU ÇÖZ";
            this.KarisikSinavButton.UseVisualStyleBackColor = true;
            this.KarisikSinavButton.Click += new System.EventHandler(this.KarisikSinavButton_Click);
            // 
            // RaporButton
            // 
            this.RaporButton.AutoSize = true;
            this.RaporButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RaporButton.Depth = 0;
            this.RaporButton.Icon = null;
            this.RaporButton.Location = new System.Drawing.Point(947, 311);
            this.RaporButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RaporButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RaporButton.Name = "RaporButton";
            this.RaporButton.Primary = false;
            this.RaporButton.Size = new System.Drawing.Size(210, 36);
            this.RaporButton.TabIndex = 2;
            this.RaporButton.Text = "ANALİZ RAPORU AL";
            this.RaporButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(971, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(508, 395);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(173, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // OgrenciMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 641);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RaporButton);
            this.Controls.Add(this.KarisikSinavButton);
            this.Controls.Add(this.NormalSinavButton);
            this.Name = "OgrenciMenuForm";
            this.Text = "OgrenciMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton NormalSinavButton;
        private MaterialSkin.Controls.MaterialFlatButton KarisikSinavButton;
        private MaterialSkin.Controls.MaterialFlatButton RaporButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}