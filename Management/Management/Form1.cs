using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class MainForm : Form
    {
        public int var = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Func<ChartPoint, string> label = ChartPoint >= string.Format("{0} ({1:P)", ChartPoint.Y, ChartPoint.participation);


        private void button1_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in data.DataTable1)
                series.Add(new PieSeries() { Title = obj.Project.ToString(), Values = new ChartValues<int> { obj.Uren },DataLabels = true });
            pieChart1.Series = series;
        }
    }
}
