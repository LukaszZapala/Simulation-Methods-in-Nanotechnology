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

namespace Graphene
{
    public partial class PageOne : Form
    {
        public PageOne()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openBrowseDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.pathTextBox.Text = this.openBrowseDialog.FileName;
                
                if (!this.pathTextBox.Text.Equals(""))
                {
                    this.chartButton.Enabled = true;
                }
            }
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            var pageTwo = new PageTwo(pathTextBox.Text);
            pageTwo.ShowDialog();

            this.Close();
        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(pathTextBox.Text))
            {
                this.chartButton.Enabled = true;
            }
        }
    }
}
