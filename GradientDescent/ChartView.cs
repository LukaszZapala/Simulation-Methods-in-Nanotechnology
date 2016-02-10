using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GradientDescent
{
    public partial class ChartView : Form
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChartView());
        }

        private const int maxIteration = 100000;
        private const double epsilon = 10e-6;

        public ChartView()
        {
            InitializeComponent();
            this.Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            Gradient gradient = new Gradient(9, 0.01, 2.0, 10, 1.5);

            chart1.Series["Series1"].ChartType = SeriesChartType.Spline;

            gradient.SetStartPoint();

            double length = 0.0;
            int i = 0;
            do 
            {
                length = gradient.GetNext();
                chart1.Series["Series1"].Points.AddXY(i, length);
                i++;
            } while (length > epsilon && i < maxIteration);

            Console.WriteLine("\nIteration = " + (i - 1));
            Console.WriteLine("Distance between atoms = " + gradient.GetPoint() + "\n");

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.Update();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.SaveImage("outputChar.png", ChartImageFormat.Png);
        }
    }
}