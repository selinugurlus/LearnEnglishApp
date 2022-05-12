
namespace SınavSistemii
{
    partial class Rapor2Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AnimalstextBox1 = new System.Windows.Forms.TextBox();
            this.NumberstextBox1 = new System.Windows.Forms.TextBox();
            this.FurniturestextBox1 = new System.Windows.Forms.TextBox();
            this.ColorstextBox1 = new System.Windows.Forms.TextBox();
            this.PasttextBox1 = new System.Windows.Forms.TextBox();
            this.FoodstextBox1 = new System.Windows.Forms.TextBox();
            this.CLothestextBox1 = new System.Windows.Forms.TextBox();
            this.FuturetextBox1 = new System.Windows.Forms.TextBox();
            this.PresentTextBox = new System.Windows.Forms.TextBox();
            this.JobstextBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(323, 89);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Yanlışlar";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(996, 556);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Animals:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jobs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Furnitures:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Colors:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "S.Present:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Past T:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Clothes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Future T:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Foods:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Numbers:";
            // 
            // AnimalstextBox1
            // 
            this.AnimalstextBox1.Location = new System.Drawing.Point(126, 101);
            this.AnimalstextBox1.Name = "AnimalstextBox1";
            this.AnimalstextBox1.Size = new System.Drawing.Size(100, 26);
            this.AnimalstextBox1.TabIndex = 11;
            // 
            // NumberstextBox1
            // 
            this.NumberstextBox1.Location = new System.Drawing.Point(126, 458);
            this.NumberstextBox1.Name = "NumberstextBox1";
            this.NumberstextBox1.Size = new System.Drawing.Size(100, 26);
            this.NumberstextBox1.TabIndex = 12;
            // 
            // FurniturestextBox1
            // 
            this.FurniturestextBox1.Location = new System.Drawing.Point(126, 419);
            this.FurniturestextBox1.Name = "FurniturestextBox1";
            this.FurniturestextBox1.Size = new System.Drawing.Size(100, 26);
            this.FurniturestextBox1.TabIndex = 13;
            // 
            // ColorstextBox1
            // 
            this.ColorstextBox1.Location = new System.Drawing.Point(126, 380);
            this.ColorstextBox1.Name = "ColorstextBox1";
            this.ColorstextBox1.Size = new System.Drawing.Size(100, 26);
            this.ColorstextBox1.TabIndex = 14;
            // 
            // PasttextBox1
            // 
            this.PasttextBox1.Location = new System.Drawing.Point(126, 341);
            this.PasttextBox1.Name = "PasttextBox1";
            this.PasttextBox1.Size = new System.Drawing.Size(100, 26);
            this.PasttextBox1.TabIndex = 15;
            // 
            // FoodstextBox1
            // 
            this.FoodstextBox1.Location = new System.Drawing.Point(126, 225);
            this.FoodstextBox1.Name = "FoodstextBox1";
            this.FoodstextBox1.Size = new System.Drawing.Size(100, 26);
            this.FoodstextBox1.TabIndex = 16;
            // 
            // CLothestextBox1
            // 
            this.CLothestextBox1.Location = new System.Drawing.Point(126, 302);
            this.CLothestextBox1.Name = "CLothestextBox1";
            this.CLothestextBox1.Size = new System.Drawing.Size(100, 26);
            this.CLothestextBox1.TabIndex = 17;
            // 
            // FuturetextBox1
            // 
            this.FuturetextBox1.Location = new System.Drawing.Point(126, 265);
            this.FuturetextBox1.Name = "FuturetextBox1";
            this.FuturetextBox1.Size = new System.Drawing.Size(100, 26);
            this.FuturetextBox1.TabIndex = 18;
            // 
            // PresentTextBox
            // 
            this.PresentTextBox.Location = new System.Drawing.Point(126, 179);
            this.PresentTextBox.Name = "PresentTextBox";
            this.PresentTextBox.Size = new System.Drawing.Size(100, 26);
            this.PresentTextBox.TabIndex = 19;
            // 
            // JobstextBox1
            // 
            this.JobstextBox1.Location = new System.Drawing.Point(126, 145);
            this.JobstextBox1.Name = "JobstextBox1";
            this.JobstextBox1.Size = new System.Drawing.Size(100, 26);
            this.JobstextBox1.TabIndex = 20;
            // 
            // Rapor2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 722);
            this.Controls.Add(this.JobstextBox1);
            this.Controls.Add(this.PresentTextBox);
            this.Controls.Add(this.FuturetextBox1);
            this.Controls.Add(this.CLothestextBox1);
            this.Controls.Add(this.FoodstextBox1);
            this.Controls.Add(this.PasttextBox1);
            this.Controls.Add(this.ColorstextBox1);
            this.Controls.Add(this.FurniturestextBox1);
            this.Controls.Add(this.NumberstextBox1);
            this.Controls.Add(this.AnimalstextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Name = "Rapor2Form";
            this.Text = "Rapor2Form";
            this.Load += new System.EventHandler(this.Rapor2Form_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AnimalstextBox1;
        private System.Windows.Forms.TextBox NumberstextBox1;
        private System.Windows.Forms.TextBox FurniturestextBox1;
        private System.Windows.Forms.TextBox ColorstextBox1;
        private System.Windows.Forms.TextBox PasttextBox1;
        private System.Windows.Forms.TextBox FoodstextBox1;
        private System.Windows.Forms.TextBox CLothestextBox1;
        private System.Windows.Forms.TextBox FuturetextBox1;
        private System.Windows.Forms.TextBox PresentTextBox;
        private System.Windows.Forms.TextBox JobstextBox1;
    }
}