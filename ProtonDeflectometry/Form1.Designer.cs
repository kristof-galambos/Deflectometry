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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.ChartScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartScreen
            // 
            chartArea4.Name = "ChartArea1";
            this.ChartScreen.ChartAreas.Add(chartArea4);
            this.ChartScreen.DataSource = this.ChartScreen.Series;
            legend4.Name = "Legend1";
            this.ChartScreen.Legends.Add(legend4);
            this.ChartScreen.Location = new System.Drawing.Point(29, 130);
            this.ChartScreen.Name = "ChartScreen";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.MarkerSize = 2;
            series4.Name = "Screen";
            this.ChartScreen.Series.Add(series4);
            this.ChartScreen.Size = new System.Drawing.Size(600, 373);
            this.ChartScreen.TabIndex = 0;
            this.ChartScreen.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of particles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Screen distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grid distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Particle energy (keV)";
            // 
            // Ntextbox
            // 
            this.Ntextbox.Location = new System.Drawing.Point(29, 73);
            this.Ntextbox.Name = "Ntextbox";
            this.Ntextbox.Size = new System.Drawing.Size(100, 26);
            this.Ntextbox.TabIndex = 5;
            this.Ntextbox.Text = "3000";
            // 
            // SDtextbox
            // 
            this.SDtextbox.Location = new System.Drawing.Point(529, 73);
            this.SDtextbox.Name = "SDtextbox";
            this.SDtextbox.Size = new System.Drawing.Size(100, 26);
            this.SDtextbox.TabIndex = 6;
            this.SDtextbox.Text = "0.1";
            // 
            // GDtextbox
            // 
            this.GDtextbox.Location = new System.Drawing.Point(394, 73);
            this.GDtextbox.Name = "GDtextbox";
            this.GDtextbox.Size = new System.Drawing.Size(100, 26);
            this.GDtextbox.TabIndex = 7;
            this.GDtextbox.Text = "0.1";
            // 
            // Etextbox
            // 
            this.Etextbox.Location = new System.Drawing.Point(208, 73);
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
            this.button1.Location = new System.Drawing.Point(681, 41);
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
            this.pictureBox1.Location = new System.Drawing.Point(507, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 373);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 562);
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
    }
}

