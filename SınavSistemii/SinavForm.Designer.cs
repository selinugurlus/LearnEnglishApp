
namespace SınavSistemii
{
    partial class SinavForm
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
            this.SinavSorutextBox = new System.Windows.Forms.TextBox();
            this.SinavResimpictureBox = new System.Windows.Forms.PictureBox();
            this.DogruCevapbutton = new System.Windows.Forms.Button();
            this.YanlisCevap1button = new System.Windows.Forms.Button();
            this.YanlisCevap2button = new System.Windows.Forms.Button();
            this.YanlisCevap3button = new System.Windows.Forms.Button();
            this.SinaviBaslatButton = new System.Windows.Forms.Button();
            this.KonutextBox = new System.Windows.Forms.TextBox();
            this.Konulabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lab = new System.Windows.Forms.Label();
            this.SayactextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SinavResimpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SinavSorutextBox
            // 
            this.SinavSorutextBox.Location = new System.Drawing.Point(196, 207);
            this.SinavSorutextBox.Multiline = true;
            this.SinavSorutextBox.Name = "SinavSorutextBox";
            this.SinavSorutextBox.Size = new System.Drawing.Size(444, 144);
            this.SinavSorutextBox.TabIndex = 0;
            // 
            // SinavResimpictureBox
            // 
            this.SinavResimpictureBox.Location = new System.Drawing.Point(854, 146);
            this.SinavResimpictureBox.Name = "SinavResimpictureBox";
            this.SinavResimpictureBox.Size = new System.Drawing.Size(258, 218);
            this.SinavResimpictureBox.TabIndex = 1;
            this.SinavResimpictureBox.TabStop = false;
            // 
            // DogruCevapbutton
            // 
            this.DogruCevapbutton.Location = new System.Drawing.Point(172, 463);
            this.DogruCevapbutton.Name = "DogruCevapbutton";
            this.DogruCevapbutton.Size = new System.Drawing.Size(140, 66);
            this.DogruCevapbutton.TabIndex = 11;
            this.DogruCevapbutton.UseVisualStyleBackColor = true;
            this.DogruCevapbutton.Click += new System.EventHandler(this.DogruCevapbutton_Click);
            // 
            // YanlisCevap1button
            // 
            this.YanlisCevap1button.Location = new System.Drawing.Point(489, 478);
            this.YanlisCevap1button.Name = "YanlisCevap1button";
            this.YanlisCevap1button.Size = new System.Drawing.Size(140, 66);
            this.YanlisCevap1button.TabIndex = 12;
            this.YanlisCevap1button.UseVisualStyleBackColor = true;
            this.YanlisCevap1button.Click += new System.EventHandler(this.YanlisCevap1button_Click);
            // 
            // YanlisCevap2button
            // 
            this.YanlisCevap2button.Location = new System.Drawing.Point(172, 605);
            this.YanlisCevap2button.Name = "YanlisCevap2button";
            this.YanlisCevap2button.Size = new System.Drawing.Size(140, 66);
            this.YanlisCevap2button.TabIndex = 13;
            this.YanlisCevap2button.UseVisualStyleBackColor = true;
            this.YanlisCevap2button.Click += new System.EventHandler(this.YanlisCevap2button_Click);
            // 
            // YanlisCevap3button
            // 
            this.YanlisCevap3button.Location = new System.Drawing.Point(489, 605);
            this.YanlisCevap3button.Name = "YanlisCevap3button";
            this.YanlisCevap3button.Size = new System.Drawing.Size(140, 66);
            this.YanlisCevap3button.TabIndex = 14;
            this.YanlisCevap3button.UseVisualStyleBackColor = true;
            this.YanlisCevap3button.Click += new System.EventHandler(this.YanlisCevap3button_Click);
            // 
            // SinaviBaslatButton
            // 
            this.SinaviBaslatButton.Location = new System.Drawing.Point(898, 490);
            this.SinaviBaslatButton.Name = "SinaviBaslatButton";
            this.SinaviBaslatButton.Size = new System.Drawing.Size(182, 93);
            this.SinaviBaslatButton.TabIndex = 15;
            this.SinaviBaslatButton.Text = "BAŞLAT";
            this.SinaviBaslatButton.UseVisualStyleBackColor = true;
            this.SinaviBaslatButton.Click += new System.EventHandler(this.SinaviBaslatButton_Click);
            // 
            // KonutextBox
            // 
            this.KonutextBox.Location = new System.Drawing.Point(187, 117);
            this.KonutextBox.Name = "KonutextBox";
            this.KonutextBox.Size = new System.Drawing.Size(100, 26);
            this.KonutextBox.TabIndex = 16;
            // 
            // Konulabel
            // 
            this.Konulabel.AutoSize = true;
            this.Konulabel.Location = new System.Drawing.Point(118, 120);
            this.Konulabel.Name = "Konulabel";
            this.Konulabel.Size = new System.Drawing.Size(50, 20);
            this.Konulabel.TabIndex = 17;
            this.Konulabel.Text = "Konu:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(518, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(843, 412);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(94, 20);
            this.lab.TabIndex = 19;
            this.lab.Text = "SoruSayaci:";
            // 
            // SayactextBox
            // 
            this.SayactextBox.Location = new System.Drawing.Point(943, 409);
            this.SayactextBox.Name = "SayactextBox";
            this.SayactextBox.Size = new System.Drawing.Size(100, 26);
            this.SayactextBox.TabIndex = 20;
            // 
            // SinavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 742);
            this.Controls.Add(this.SayactextBox);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Konulabel);
            this.Controls.Add(this.KonutextBox);
            this.Controls.Add(this.SinaviBaslatButton);
            this.Controls.Add(this.YanlisCevap3button);
            this.Controls.Add(this.YanlisCevap2button);
            this.Controls.Add(this.YanlisCevap1button);
            this.Controls.Add(this.DogruCevapbutton);
            this.Controls.Add(this.SinavResimpictureBox);
            this.Controls.Add(this.SinavSorutextBox);
            this.Name = "SinavForm";
            this.Text = "SinavForm";
            ((System.ComponentModel.ISupportInitialize)(this.SinavResimpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SinavSorutextBox;
        private System.Windows.Forms.PictureBox SinavResimpictureBox;
        private System.Windows.Forms.Button DogruCevapbutton;
        private System.Windows.Forms.Button YanlisCevap1button;
        private System.Windows.Forms.Button YanlisCevap2button;
        private System.Windows.Forms.Button YanlisCevap3button;
        private System.Windows.Forms.Button SinaviBaslatButton;
        private System.Windows.Forms.TextBox KonutextBox;
        private System.Windows.Forms.Label Konulabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox SayactextBox;
    }
}