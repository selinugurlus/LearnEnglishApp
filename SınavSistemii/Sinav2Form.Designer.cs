
namespace SınavSistemii
{
    partial class Sinav2Form
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
            this.SorutextBox = new System.Windows.Forms.TextBox();
            this.DogruCevapbutton = new System.Windows.Forms.Button();
            this.YanlisCevap1button = new System.Windows.Forms.Button();
            this.YanlisCevap2button = new System.Windows.Forms.Button();
            this.YanlisCevap3button = new System.Windows.Forms.Button();
            this.KonutextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Baslabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SorutextBox
            // 
            this.SorutextBox.Location = new System.Drawing.Point(98, 148);
            this.SorutextBox.Multiline = true;
            this.SorutextBox.Name = "SorutextBox";
            this.SorutextBox.Size = new System.Drawing.Size(398, 125);
            this.SorutextBox.TabIndex = 0;
            // 
            // DogruCevapbutton
            // 
            this.DogruCevapbutton.Location = new System.Drawing.Point(98, 308);
            this.DogruCevapbutton.Name = "DogruCevapbutton";
            this.DogruCevapbutton.Size = new System.Drawing.Size(110, 75);
            this.DogruCevapbutton.TabIndex = 1;
            this.DogruCevapbutton.UseVisualStyleBackColor = true;
            // 
            // YanlisCevap1button
            // 
            this.YanlisCevap1button.Location = new System.Drawing.Point(398, 308);
            this.YanlisCevap1button.Name = "YanlisCevap1button";
            this.YanlisCevap1button.Size = new System.Drawing.Size(110, 75);
            this.YanlisCevap1button.TabIndex = 2;
            this.YanlisCevap1button.UseVisualStyleBackColor = true;
            // 
            // YanlisCevap2button
            // 
            this.YanlisCevap2button.Location = new System.Drawing.Point(98, 467);
            this.YanlisCevap2button.Name = "YanlisCevap2button";
            this.YanlisCevap2button.Size = new System.Drawing.Size(110, 75);
            this.YanlisCevap2button.TabIndex = 3;
            this.YanlisCevap2button.UseVisualStyleBackColor = true;
            // 
            // YanlisCevap3button
            // 
            this.YanlisCevap3button.Location = new System.Drawing.Point(398, 467);
            this.YanlisCevap3button.Name = "YanlisCevap3button";
            this.YanlisCevap3button.Size = new System.Drawing.Size(110, 75);
            this.YanlisCevap3button.TabIndex = 4;
            this.YanlisCevap3button.UseVisualStyleBackColor = true;
            this.YanlisCevap3button.Click += new System.EventHandler(this.YanlisCevap3button_Click);
            // 
            // KonutextBox
            // 
            this.KonutextBox.Location = new System.Drawing.Point(209, 92);
            this.KonutextBox.Name = "KonutextBox";
            this.KonutextBox.Size = new System.Drawing.Size(100, 26);
            this.KonutextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Konu:";
            // 
            // Baslabutton
            // 
            this.Baslabutton.Location = new System.Drawing.Point(754, 381);
            this.Baslabutton.Name = "Baslabutton";
            this.Baslabutton.Size = new System.Drawing.Size(164, 86);
            this.Baslabutton.TabIndex = 7;
            this.Baslabutton.Text = "SINAVA BAŞLA";
            this.Baslabutton.UseVisualStyleBackColor = true;
            this.Baslabutton.Click += new System.EventHandler(this.Baslabutton_Click);
            // 
            // Sinav2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 611);
            this.Controls.Add(this.Baslabutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KonutextBox);
            this.Controls.Add(this.YanlisCevap3button);
            this.Controls.Add(this.YanlisCevap2button);
            this.Controls.Add(this.YanlisCevap1button);
            this.Controls.Add(this.DogruCevapbutton);
            this.Controls.Add(this.SorutextBox);
            this.Name = "Sinav2Form";
            this.Text = "Sinav2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SorutextBox;
        private System.Windows.Forms.Button DogruCevapbutton;
        private System.Windows.Forms.Button YanlisCevap1button;
        private System.Windows.Forms.Button YanlisCevap2button;
        private System.Windows.Forms.Button YanlisCevap3button;
        private System.Windows.Forms.TextBox KonutextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Baslabutton;
    }
}