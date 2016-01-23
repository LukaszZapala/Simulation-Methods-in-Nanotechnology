using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quantum
{
    public partial class View : Form
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View());
        }

        private Quantum quantum = null;
        private int count = 0;
        Thread threadOne, threadTwo;

        public View()
        {
            InitializeComponent();
            CheckFile();            
        }

        private void CheckFile()
        {
            string[] paths = { "matrixS.csv", "matrixT.csv", "matrixValpha.csv", "matrixH.csv", "matrixEnergy.csv", "matrixOutput.csv" };

            foreach (var file in paths)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
            }
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            CheckFile();

            quantum = new Quantum
            {
                n = Convert.ToInt32(n_tb.Text),
                lambda = Convert.ToDouble(lambda_tb.Text),
                h = Convert.ToInt32(h_tb.Text),
                k = Convert.ToInt32(k_tb.Text),
                N = Convert.ToInt32(count_beta_tb.Text),
                countAlpha = Convert.ToInt32(count_alpha_tb.Text),
                countX = Convert.ToInt32(count_x_tb.Text),
                a = Convert.ToDouble(a_tb.Text),
                minBeta = Convert.ToDouble(min_beta_tb.Text),
                maxBeta = Convert.ToDouble(max_beta_tb.Text),
                minAlpha = Convert.ToDouble(min_alpha_tb.Text),
                maxAlpha = Convert.ToDouble(max_alpha_tb.Text),
                minX = Convert.ToDouble(min_x_tb.Text),
                maxX = Convert.ToDouble(max_x_tb.Text),
            };
            quantum.InitializeMatrixAndVectors();

            threadOne = new Thread(quantum.GetPotential);
            threadOne.Start();

            threadTwo = new Thread(quantum.GetEnergy);
            threadTwo.Start();

            PotentialChart();

            accept_button.Enabled = false;
            next_button.Enabled = true;
            update_button.Enabled = true;
        }

        private void PotentialChart()
        {
            main_chart.Series.Clear();

            threadOne.Join();

            count++;

            main_chart.ChartAreas[0].AxisX.Title = "X";
            main_chart.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(min_x_tb.Text);
            main_chart.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(max_x_tb.Text);

            main_chart.ChartAreas[0].AxisY.Title = "Y";
            main_chart.ChartAreas[0].AxisY.Minimum = 0;
            main_chart.ChartAreas[0].AxisY.Maximum = quantum.FindMaximumPotential();

            main_chart.Series.Add("V(x)");
            main_chart.Series["V(x)"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            for (int i = 0; i < quantum.countX; i++)
            {
                main_chart.Series["V(x)"].Points.AddXY(quantum.potentialMatrix[i, 0], quantum.potentialMatrix[i, 1]);
                main_chart.Update();
            }            
        }

        private void EnergyChart()
        {
            main_chart.Series.Clear();

            threadTwo.Join();
            count++;

            main_chart.ChartAreas[0].AxisX.Title = "energy";
            main_chart.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(min_alpha_tb.Text);
            main_chart.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(max_alpha_tb.Text);

            main_chart.ChartAreas[0].AxisY.Title = "alpha";
            main_chart.ChartAreas[0].AxisY.Minimum = 0.0;
            main_chart.ChartAreas[0].AxisY.Maximum = quantum.FindMaximumPotential();

            for (int i = 1; i < quantum.N + 1; i++)
            {
                main_chart.Series.Add(i.ToString());
                main_chart.Series[i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            }

            for (int i = 0; i < quantum.countAlpha; i++)
            {
                var x = quantum.outputMatrix[i, 0];

                for (int j = 1; j < quantum.N + 1; j++)
                {
                    var y = quantum.outputMatrix[i, j];

                    main_chart.Series[j.ToString()].Points.AddXY(x, y);
                }
                main_chart.Update();
            }
        }
        
        private void HistogramChart()
        {
            main_chart.Series.Clear();

            main_chart.Series.Add("Frequency");
            main_chart.Series["Frequency"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            main_chart.Series["Frequency"].Color = Color.Red;

            main_chart.Series.Add("Lorenz curve");
            main_chart.Series["Lorenz curve"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            main_chart.Series["Lorenz curve"].Color = Color.RoyalBlue;

            Histogram histogram = new Histogram(quantum, Convert.ToDouble(min_e_tb.Text), Convert.ToDouble(max_e_tb.Text));

            main_chart.ChartAreas[0].AxisX.Title = "section";
            main_chart.ChartAreas[0].AxisX.Minimum = histogram.vector.Min();
            main_chart.ChartAreas[0].AxisX.Maximum = histogram.vector.Max();

            main_chart.ChartAreas[0].AxisY.Title = "frequency";
            main_chart.ChartAreas[0].AxisY.Minimum = 0;
            main_chart.ChartAreas[0].AxisY.Maximum = (int)(histogram.frequency.Max() * 11 / 10.0);

            for (int i = 0; i < histogram.numbOfSection; i++)
            {
                // Histogram
                var x = histogram.section[i, 2];
                var y = histogram.frequency[i];

                main_chart.Series["Frequency"].Points.AddXY(histogram.section[i, 2], histogram.frequency[i]);

                main_chart.Series["Lorenz curve"].Points.AddXY(histogram.section[i, 2], histogram.sectionSum[i]);
                
                main_chart.Update();
            }
            count = 0;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            next_button.Enabled = false;
            switch (count)
            {
                case 0:
                    PotentialChart();
                    break;
                case 1:
                    EnergyChart();
                    min_e_tb.Enabled = true;
                    max_e_tb.Enabled = true;
                    accept_button.Enabled = true;
                    break;
                case 2:
                    HistogramChart();                                
                    break;
            }
            next_button.Enabled = true;
        }
        
        private void update_button_Click(object sender, EventArgs e)
        {
            main_chart.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(min_axi_x_tb.Text);
            main_chart.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(max_axi_x_tb.Text);

            main_chart.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(min_axi_y_tb.Text);
            main_chart.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(max_axi_y_tb.Text);

            main_chart.Update();
        }

        private void main_chart_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
            switch (ext)
            {
                case ".jpg":
                    main_chart.SaveImage(saveFileDialog1.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);
                    break;
                case ".bmp":
                    main_chart.SaveImage(saveFileDialog1.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp);
                    break;
                default:
                    main_chart.SaveImage(saveFileDialog1.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                    break;
            }
        }

    }
}
