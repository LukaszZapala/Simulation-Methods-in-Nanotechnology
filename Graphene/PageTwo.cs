using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graphene
{
    public partial class PageTwo : Form
    {
        private string path;
        private Graphene graphene;

        public PageTwo(string path)
        {
            this.path = path;
            InitializeComponent();
            ExecuteGraphene();

        }
        private void ExecuteGraphene()
        {
            graphene = new Graphene(path);
            graphene.Logic();

            int i, k;

            for (i = 1; i < graphene.row; i++)
            {
                chart1.Series.Add("Series" + i);
            }

            for (i = 1; i < graphene.row; i++)
            {
                for (k = 0; k < graphene.columns; k++)
                {
                    chart1.Series["Series" + i].ChartType = SeriesChartType.Spline;
                    chart1.Series["Series" + i].Points.AddXY(graphene.resultingMatrix[0, k], graphene.resultingMatrix[i, k]);
                }
            }

            chart1.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var path = graphene.pathInputFile.TrimEnd(new char[] { '.', 't', 'x', 't' }) + "_wyniki";

            using (var outfile = new StreamWriter(path + ".csv"))
            {
                for (int i = 0; i < graphene.row; i++)
                {
                    string content = "";
                    for (int j = 0; j < graphene.columns; j++)
                    {
                        content += graphene.resultingMatrix[i, j].ToString() + ";";
                    }
                    outfile.WriteLine(content);
                }
            }

            this.chart1.SaveImage(path + ".png", ChartImageFormat.Png);
        }
    }
}
