namespace QLTV
{
    partial class Stast
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateMonth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnYear = new Guna.UI2.WinForms.Guna2Button();
            this.lbDT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbDT);
            this.panel1.Controls.Add(this.btnYear);
            this.panel1.Controls.Add(this.dateMonth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2087, 200);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartDT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2087, 921);
            this.panel2.TabIndex = 1;
            // 
            // chartDT
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDT.ChartAreas.Add(chartArea3);
            this.chartDT.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartDT.Legends.Add(legend3);
            this.chartDT.Location = new System.Drawing.Point(0, 0);
            this.chartDT.Name = "chartDT";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDT.Series.Add(series3);
            this.chartDT.Size = new System.Drawing.Size(2087, 921);
            this.chartDT.TabIndex = 0;
            this.chartDT.Text = "chart1";
            this.chartDT.Click += new System.EventHandler(this.chart1_Click);
            this.chartDT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartDT_MouseClick);
            // 
            // dateMonth
            // 
            this.dateMonth.Checked = true;
            this.dateMonth.CustomFormat = "MM/yyyy";
            this.dateMonth.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMonth.Location = new System.Drawing.Point(354, 77);
            this.dateMonth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateMonth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateMonth.Name = "dateMonth";
            this.dateMonth.ShowUpDown = true;
            this.dateMonth.Size = new System.Drawing.Size(468, 65);
            this.dateMonth.TabIndex = 0;
            this.dateMonth.Value = new System.DateTime(2024, 12, 2, 23, 7, 46, 904);
            this.dateMonth.ValueChanged += new System.EventHandler(this.dateMonth_ValueChanged);
            // 
            // btnYear
            // 
            this.btnYear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.Location = new System.Drawing.Point(915, 77);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(232, 64);
            this.btnYear.TabIndex = 1;
            this.btnYear.Text = "THEO NĂM";
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // lbDT
            // 
            this.lbDT.AutoSize = true;
            this.lbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDT.Location = new System.Drawing.Point(1551, 115);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(0, 42);
            this.lbDT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1312, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doanh thu : ";
            // 
            // Stast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2087, 1121);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stast";
            this.Text = "Stast";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stast_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateMonth;
        private Guna.UI2.WinForms.Guna2Button btnYear;
        private System.Windows.Forms.Label lbDT;
        private System.Windows.Forms.Label label1;
    }
}