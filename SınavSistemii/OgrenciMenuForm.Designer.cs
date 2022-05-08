
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
            this.NormalSinavButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.KarisikSinavButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.RaporButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // NormalSinavButton
            // 
            this.NormalSinavButton.AutoSize = true;
            this.NormalSinavButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NormalSinavButton.Depth = 0;
            this.NormalSinavButton.Icon = null;
            this.NormalSinavButton.Location = new System.Drawing.Point(100, 176);
            this.NormalSinavButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NormalSinavButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NormalSinavButton.Name = "NormalSinavButton";
            this.NormalSinavButton.Primary = false;
            this.NormalSinavButton.Size = new System.Drawing.Size(194, 36);
            this.NormalSinavButton.TabIndex = 0;
            this.NormalSinavButton.Text = "STANDART SINAV";
            this.NormalSinavButton.UseVisualStyleBackColor = true;
            // 
            // KarisikSinavButton
            // 
            this.KarisikSinavButton.AutoSize = true;
            this.KarisikSinavButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KarisikSinavButton.Depth = 0;
            this.KarisikSinavButton.Icon = null;
            this.KarisikSinavButton.Location = new System.Drawing.Point(100, 333);
            this.KarisikSinavButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.KarisikSinavButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.KarisikSinavButton.Name = "KarisikSinavButton";
            this.KarisikSinavButton.Primary = false;
            this.KarisikSinavButton.Size = new System.Drawing.Size(422, 36);
            this.KarisikSinavButton.TabIndex = 1;
            this.KarisikSinavButton.Text = "EKSİK OLDUĞUN KONULARDAN SORU ÇÖZ";
            this.KarisikSinavButton.UseVisualStyleBackColor = true;
            // 
            // RaporButton
            // 
            this.RaporButton.AutoSize = true;
            this.RaporButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RaporButton.Depth = 0;
            this.RaporButton.Icon = null;
            this.RaporButton.Location = new System.Drawing.Point(100, 460);
            this.RaporButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RaporButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RaporButton.Name = "RaporButton";
            this.RaporButton.Primary = false;
            this.RaporButton.Size = new System.Drawing.Size(210, 36);
            this.RaporButton.TabIndex = 2;
            this.RaporButton.Text = "ANALİZ RAPORU AL";
            this.RaporButton.UseVisualStyleBackColor = true;
            // 
            // OgrenciMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 666);
            this.Controls.Add(this.RaporButton);
            this.Controls.Add(this.KarisikSinavButton);
            this.Controls.Add(this.NormalSinavButton);
            this.Name = "OgrenciMenuForm";
            this.Text = "OgrenciMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton NormalSinavButton;
        private MaterialSkin.Controls.MaterialFlatButton KarisikSinavButton;
        private MaterialSkin.Controls.MaterialFlatButton RaporButton;
    }
}