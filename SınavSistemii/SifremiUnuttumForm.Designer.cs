
namespace SınavSistemii
{
    partial class SifremiUnuttumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttumForm));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SifreUnuttumMailTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SifreGonderButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(118, 181);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(582, 27);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mail adresinizi giriniz. Şifreniz mail adresinize gönderilecek.";
            // 
            // SifreUnuttumMailTextField
            // 
            this.SifreUnuttumMailTextField.Depth = 0;
            this.SifreUnuttumMailTextField.Hint = "";
            this.SifreUnuttumMailTextField.Location = new System.Drawing.Point(229, 228);
            this.SifreUnuttumMailTextField.MaxLength = 32767;
            this.SifreUnuttumMailTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.SifreUnuttumMailTextField.Name = "SifreUnuttumMailTextField";
            this.SifreUnuttumMailTextField.PasswordChar = '\0';
            this.SifreUnuttumMailTextField.SelectedText = "";
            this.SifreUnuttumMailTextField.SelectionLength = 0;
            this.SifreUnuttumMailTextField.SelectionStart = 0;
            this.SifreUnuttumMailTextField.Size = new System.Drawing.Size(343, 32);
            this.SifreUnuttumMailTextField.TabIndex = 1;
            this.SifreUnuttumMailTextField.TabStop = false;
            this.SifreUnuttumMailTextField.UseSystemPasswordChar = false;
            // 
            // SifreGonderButton
            // 
            this.SifreGonderButton.AutoSize = true;
            this.SifreGonderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SifreGonderButton.Depth = 0;
            this.SifreGonderButton.Icon = null;
            this.SifreGonderButton.Location = new System.Drawing.Point(344, 325);
            this.SifreGonderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SifreGonderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SifreGonderButton.Name = "SifreGonderButton";
            this.SifreGonderButton.Primary = false;
            this.SifreGonderButton.Size = new System.Drawing.Size(104, 36);
            this.SifreGonderButton.TabIndex = 2;
            this.SifreGonderButton.Text = "GÖNDER";
            this.SifreGonderButton.UseVisualStyleBackColor = true;
            this.SifreGonderButton.Click += new System.EventHandler(this.SifreGonderButton_Click);
            // 
            // button1
            // 
            this.button1.ImageKey = "indir.jpg";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 57);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir.jpg");
            // 
            // SifremiUnuttumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SifreGonderButton);
            this.Controls.Add(this.SifreUnuttumMailTextField);
            this.Controls.Add(this.materialLabel1);
            this.Name = "SifremiUnuttumForm";
            this.Text = "SifremiUnuttumForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField SifreUnuttumMailTextField;
        private MaterialSkin.Controls.MaterialFlatButton SifreGonderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}