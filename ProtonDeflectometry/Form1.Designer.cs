namespace ProtonDeflectometry
{
    partial class Form1
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
            this.ChartScreen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ntextbox = new System.Windows.Forms.TextBox();
            this.SDtextbox = new System.Windows.Forms.TextBox();
            this.GDtextbox = new System.Windows.Forms.TextBox();
            this.Etextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lBfield = new System.Windows.Forms.Label();
            this.rbUniform = new System.Windows.Forms.RadioButton();
            this.rbZpinch = new System.Windows.Forms.RadioButton();
            this.rbNofield = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ChartScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartScreen
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartScreen.ChartAreas.Add(chartArea1);
            this.ChartScreen.DataSource = this.ChartScreen.Series;
            legend1.Name = "Legend1";
            this.ChartScreen.Legends.Add(legend1);
            this.ChartScreen.Location = new System.Drawing.Point(29, 193);
            this.ChartScreen.Name = "ChartScreen";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerSize = 2;
            series1.Name = "Screen";
            this.ChartScreen.Series.Add(series1);
            this.ChartScreen.Size = new System.Drawing.Size(600, 373);
            this.ChartScreen.TabIndex = 0;
            this.ChartScreen.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of particles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Screen distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grid distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Particle energy (keV)";
            // 
            // Ntextbox
            // 
            this.Ntextbox.Location = new System.Drawing.Point(181, 30);
            this.Ntextbox.Name = "Ntextbox";
            this.Ntextbox.Size = new System.Drawing.Size(100, 26);
            this.Ntextbox.TabIndex = 5;
            this.Ntextbox.Text = "3000";
            // 
            // SDtextbox
            // 
            this.SDtextbox.Location = new System.Drawing.Point(181, 144);
            this.SDtextbox.Name = "SDtextbox";
            this.SDtextbox.Size = new System.Drawing.Size(100, 26);
            this.SDtextbox.TabIndex = 6;
            this.SDtextbox.Text = "0.1";
            // 
            // GDtextbox
            // 
            this.GDtextbox.Location = new System.Drawing.Point(181, 105);
            this.GDtextbox.Name = "GDtextbox";
            this.GDtextbox.Size = new System.Drawing.Size(100, 26);
            this.GDtextbox.TabIndex = 7;
            this.GDtextbox.Text = "0.1";
            // 
            // Etextbox
            // 
            this.Etextbox.Location = new System.Drawing.Point(181, 67);
            this.Etextbox.Name = "Etextbox";
            this.Etextbox.Size = new System.Drawing.Size(100, 26);
            this.Etextbox.TabIndex = 8;
            this.Etextbox.Text = "100";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(622, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Run!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(233, 861);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(304, 160);
            this.picture.TabIndex = 10;
            this.picture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(492, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 373);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lBfield
            // 
            this.lBfield.AutoSize = true;
            this.lBfield.Location = new System.Drawing.Point(324, 33);
            this.lBfield.Name = "lBfield";
            this.lBfield.Size = new System.Drawing.Size(54, 20);
            this.lBfield.TabIndex = 12;
            this.lBfield.Text = "B-field";
            // 
            // rbUniform
            // 
            this.rbUniform.AutoSize = true;
            this.rbUniform.Checked = true;
            this.rbUniform.Location = new System.Drawing.Point(402, 67);
            this.rbUniform.Name = "rbUniform";
            this.rbUniform.Size = new System.Drawing.Size(174, 24);
            this.rbUniform.TabIndex = 13;
            this.rbUniform.Text = "Uniform in positive y";
            this.rbUniform.UseVisualStyleBackColor = true;
            // 
            // rbZpinch
            // 
            this.rbZpinch.AutoSize = true;
            this.rbZpinch.Location = new System.Drawing.Point(402, 104);
            this.rbZpinch.Name = "rbZpinch";
            this.rbZpinch.Size = new System.Drawing.Size(87, 24);
            this.rbZpinch.TabIndex = 14;
            this.rbZpinch.Text = "Z-pinch";
            this.rbZpinch.UseVisualStyleBackColor = true;
            // 
            // rbNofield
            // 
            this.rbNofield.AutoSize = true;
            this.rbNofield.Location = new System.Drawing.Point(402, 31);
            this.rbNofield.Name = "rbNofield";
            this.rbNofield.Size = new System.Drawing.Size(103, 24);
            this.rbNofield.TabIndex = 15;
            this.rbNofield.Text = "No B-field";
            this.rbNofield.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 632);
            this.Controls.Add(this.rbNofield);
            this.Controls.Add(this.rbZpinch);
            this.Controls.Add(this.rbUniform);
            this.Controls.Add(this.lBfield);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Etextbox);
            this.Controls.Add(this.GDtextbox);
            this.Controls.Add(this.SDtextbox);
            this.Controls.Add(this.Ntextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ChartScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Ntextbox;
        private System.Windows.Forms.TextBox SDtextbox;
        private System.Windows.Forms.TextBox GDtextbox;
        private System.Windows.Forms.TextBox Etextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lBfield;
        private System.Windows.Forms.RadioButton rbUniform;
        private System.Windows.Forms.RadioButton rbZpinch;
        private System.Windows.Forms.RadioButton rbNofield;
    }
}

