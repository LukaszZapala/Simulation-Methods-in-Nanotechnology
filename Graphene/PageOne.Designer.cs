namespace Graphene
{
    partial class PageOne
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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chartButton = new System.Windows.Forms.Button();
            this.openBrowseDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(56, 19);
            this.pathTextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(179, 20);
            this.pathTextBox.TabIndex = 8;
            this.pathTextBox.TextChanged += new System.EventHandler(this.pathTextBox_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.AutoSize = true;
            this.browseButton.Location = new System.Drawing.Point(243, 19);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(26, 23);
            this.browseButton.TabIndex = 7;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Plik:";
            // 
            // chartButton
            // 
            this.chartButton.Enabled = false;
            this.chartButton.Location = new System.Drawing.Point(282, 19);
            this.chartButton.Margin = new System.Windows.Forms.Padding(10);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(103, 23);
            this.chartButton.TabIndex = 9;
            this.chartButton.Text = "Wykres";
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // openBrowseDialog
            // 
            this.openBrowseDialog.FileName = "openBrowseDialog";
            // 
            // PageOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(406, 58);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label1);
            this.Name = "PageOne";
            this.Text = "PageOne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.OpenFileDialog openBrowseDialog;
    }
}