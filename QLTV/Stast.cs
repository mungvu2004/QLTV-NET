using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLTV
{
    public partial class Stast : Form
    {
        public Stast()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void LoadChart()
        {
            int month = dateMonth.Value.Month;
            int year = dateMonth.Value.Year;
            DataTable chart = modify.GetDate(year, month);
            Series series = new Series()
            {
                Name = "Số lượng sách",
                XValueMember = "NgayMuon",
                YValueMembers = "TongSoLuong",
                ChartType = SeriesChartType.Column
            };
            
            
            series["PixelPointWidth"] = "30";
            chartDT.Series.Add(series);
            chartDT.DataSource = chart;
            chartDT.DataBind();
        }
        private void Stast_Load(object sender, EventArgs e)
        {
            LoadChart();
            //AskChart();
        }

        private void AskChart()
        {
            DataTable chart = modify.GetMounth();
            Series series = new Series()
            {
                Name = "Số lượng sách",
                XValueMember = "Thang",
                YValueMembers = "TongSoLuong",
                ChartType = SeriesChartType.Column
            };
            series["PixelPointWidth"] = "30";
            chartDT.Series.Clear();
            chartDT.Series.Add(series);
            chartDT.DataSource = chart;
            chartDT.DataBind();
        }
        

        private void dateMonth_ValueChanged(object sender, EventArgs e)
        {
            chartDT.Series.Clear();
            
            LoadChart();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            chartDT.Series.Clear();
            AskChart();
        }

        private void chartDT_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult result = chartDT.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                
                Series series = result.Series;

                
                DataPoint point = series.Points[result.PointIndex];

                double value = point.YValues[0]; // Đây là giá trị trên trục Y của cột
                int dt = int.Parse(value.ToString()) * 10000;
                lbDT.Text =$"{dt}" + "VND";
            }
        }
    }
}
