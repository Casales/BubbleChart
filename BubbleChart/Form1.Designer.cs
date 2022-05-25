namespace BubbleChart
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
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel5 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel6 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel7 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel8 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_Before = new System.Windows.Forms.TextBox();
            this.textBox_After = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Load = new System.Windows.Forms.Button();
            this.checkBox_Web = new System.Windows.Forms.CheckBox();
            this.textBox_XAxis = new System.Windows.Forms.TextBox();
            this.textBox_YAxis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            customLabel1.FromPosition = 1D;
            customLabel1.Text = "1.5";
            customLabel1.ToPosition = 2D;
            customLabel2.FromPosition = 1.5D;
            customLabel2.Text = "2.0";
            customLabel2.ToPosition = 2.5D;
            customLabel3.FromPosition = 2D;
            customLabel3.Text = "2.5";
            customLabel3.ToPosition = 3D;
            customLabel4.FromPosition = 2.5D;
            customLabel4.Text = "3.0";
            customLabel4.ToPosition = 3.5D;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.CustomLabels.Add(customLabel2);
            chartArea1.AxisX.CustomLabels.Add(customLabel3);
            chartArea1.AxisX.CustomLabels.Add(customLabel4);
            chartArea1.AxisX.Interval = 0.25D;
            chartArea1.AxisX.IntervalOffset = 0.125D;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.MajorGrid.Interval = 0.25D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = -0.125D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorTickMark.Interval = 0.25D;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = -0.125D;
            chartArea1.AxisX.Maximum = 3.125D;
            chartArea1.AxisX.Minimum = 1.625D;
            chartArea1.AxisX.MinorGrid.Interval = 0.25D;
            chartArea1.AxisX.MinorGrid.IntervalOffset = -0.5D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.Title = "Before";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customLabel5.FromPosition = 1D;
            customLabel5.Text = "1.5";
            customLabel5.ToPosition = 2D;
            customLabel6.FromPosition = 1.5D;
            customLabel6.Text = "2.0";
            customLabel6.ToPosition = 2.5D;
            customLabel7.FromPosition = 2D;
            customLabel7.Text = "2.5";
            customLabel7.ToPosition = 3D;
            customLabel8.FromPosition = 2.5D;
            customLabel8.Text = "3.0";
            customLabel8.ToPosition = 3.5D;
            chartArea1.AxisY.CustomLabels.Add(customLabel5);
            chartArea1.AxisY.CustomLabels.Add(customLabel6);
            chartArea1.AxisY.CustomLabels.Add(customLabel7);
            chartArea1.AxisY.CustomLabels.Add(customLabel8);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.Interval = 0.25D;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.Interval = 0.25D;
            chartArea1.AxisY.MajorTickMark.IntervalOffset = 0D;
            chartArea1.AxisY.Maximum = 3D;
            chartArea1.AxisY.Minimum = 1.25D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.Title = "After";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 88F;
            chartArea1.Position.Width = 88F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 10F;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-2, 50);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1986, 1212);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            title1.Text = "Title";
            this.chart1.Titles.Add(title1);
            // 
            // textBox_Before
            // 
            this.textBox_Before.Location = new System.Drawing.Point(12, 23);
            this.textBox_Before.Name = "textBox_Before";
            this.textBox_Before.Size = new System.Drawing.Size(140, 20);
            this.textBox_Before.TabIndex = 1;
            // 
            // textBox_After
            // 
            this.textBox_After.Location = new System.Drawing.Point(158, 23);
            this.textBox_After.Name = "textBox_After";
            this.textBox_After.Size = new System.Drawing.Size(140, 20);
            this.textBox_After.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Before";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "After";
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(767, 21);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 23);
            this.button_Load.TabIndex = 7;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // checkBox_Web
            // 
            this.checkBox_Web.AutoSize = true;
            this.checkBox_Web.Location = new System.Drawing.Point(304, 25);
            this.checkBox_Web.Name = "checkBox_Web";
            this.checkBox_Web.Size = new System.Drawing.Size(49, 17);
            this.checkBox_Web.TabIndex = 3;
            this.checkBox_Web.Text = "Web";
            this.checkBox_Web.UseVisualStyleBackColor = true;
            // 
            // textBox_XAxis
            // 
            this.textBox_XAxis.Location = new System.Drawing.Point(359, 23);
            this.textBox_XAxis.Name = "textBox_XAxis";
            this.textBox_XAxis.Size = new System.Drawing.Size(130, 20);
            this.textBox_XAxis.TabIndex = 4;
            this.textBox_XAxis.Text = "Pre";
            // 
            // textBox_YAxis
            // 
            this.textBox_YAxis.Location = new System.Drawing.Point(495, 23);
            this.textBox_YAxis.Name = "textBox_YAxis";
            this.textBox_YAxis.Size = new System.Drawing.Size(130, 20);
            this.textBox_YAxis.TabIndex = 5;
            this.textBox_YAxis.Text = "Post";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "X-Axis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y-Axis";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(631, 23);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(130, 20);
            this.textBox_Title.TabIndex = 6;
            this.textBox_Title.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Title";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(848, 21);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 7;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1984, 1261);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.textBox_YAxis);
            this.Controls.Add(this.textBox_XAxis);
            this.Controls.Add(this.checkBox_Web);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_After);
            this.Controls.Add(this.textBox_Before);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Happy Bubbler";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox_Before;
        private System.Windows.Forms.TextBox textBox_After;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.CheckBox checkBox_Web;
        private System.Windows.Forms.TextBox textBox_XAxis;
        private System.Windows.Forms.TextBox textBox_YAxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Save;
    }
}

