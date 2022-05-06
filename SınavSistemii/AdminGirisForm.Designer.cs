
namespace SınavSistemii
{
    partial class AdminGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGirisForm));
            this.AdminGirisButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.AdminGirisSifreTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AdminGirisMailTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminGirisButton
            // 
            this.AdminGirisButton.AutoSize = true;
            this.AdminGirisButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdminGirisButton.Depth = 0;
            this.AdminGirisButton.Icon = null;
            this.AdminGirisButton.Location = new System.Drawing.Point(403, 487);
            this.AdminGirisButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AdminGirisButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminGirisButton.Name = "AdminGirisButton";
            this.AdminGirisButton.Primary = false;
            this.AdminGirisButton.Size = new System.Drawing.Size(119, 36);
            this.AdminGirisButton.TabIndex = 9;
            this.AdminGirisButton.Text = "GİRİŞ YAP";
            this.AdminGirisButton.UseVisualStyleBackColor = true;
            // 
            // AdminGirisSifreTextField
            // 
            this.AdminGirisSifreTextField.Depth = 0;
            this.AdminGirisSifreTextField.Hint = "";
            this.AdminGirisSifreTextField.Location = new System.Drawing.Point(311, 387);
            this.AdminGirisSifreTextField.MaxLength = 32767;
            this.AdminGirisSifreTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminGirisSifreTextField.Name = "AdminGirisSifreTextField";
            this.AdminGirisSifreTextField.PasswordChar = '\0';
            this.AdminGirisSifreTextField.SelectedText = "";
            this.AdminGirisSifreTextField.SelectionLength = 0;
            this.AdminGirisSifreTextField.SelectionStart = 0;
            this.AdminGirisSifreTextField.Size = new System.Drawing.Size(321, 32);
            this.AdminGirisSifreTextField.TabIndex = 8;
            this.AdminGirisSifreTextField.TabStop = false;
            this.AdminGirisSifreTextField.UseSystemPasswordChar = false;
            // 
            // AdminGirisMailTextField
            // 
            this.AdminGirisMailTextField.Depth = 0;
            this.AdminGirisMailTextField.Hint = "";
            this.AdminGirisMailTextField.Location = new System.Drawing.Point(311, 270);
            this.AdminGirisMailTextField.MaxLength = 32767;
            this.AdminGirisMailTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminGirisMailTextField.Name = "AdminGirisMailTextField";
            this.AdminGirisMailTextField.PasswordChar = '\0';
            this.AdminGirisMailTextField.SelectedText = "";
            this.AdminGirisMailTextField.SelectionLength = 0;
            this.AdminGirisMailTextField.SelectionStart = 0;
            this.AdminGirisMailTextField.Size = new System.Drawing.Size(321, 32);
            this.AdminGirisMailTextField.TabIndex = 7;
            this.AdminGirisMailTextField.TabStop = false;
            this.AdminGirisMailTextField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(137, 392);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 27);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "ŞİFRE:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(137, 270);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 27);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "MAİL:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(730, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AdminGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 732);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdminGirisButton);
            this.Controls.Add(this.AdminGirisSifreTextField);
            this.Controls.Add(this.AdminGirisMailTextField);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AdminGirisForm";
            this.Text = "AdminGirisForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton AdminGirisButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField AdminGirisSifreTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField AdminGirisMailTextField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}