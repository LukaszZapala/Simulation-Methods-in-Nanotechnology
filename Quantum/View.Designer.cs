namespace Quantum
{
    partial class View
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.main_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.a_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.accept_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.n_tb = new System.Windows.Forms.TextBox();
            this.k_tb = new System.Windows.Forms.TextBox();
            this.lambda_tb = new System.Windows.Forms.TextBox();
            this.h_tb = new System.Windows.Forms.TextBox();
            this.min_beta_tb = new System.Windows.Forms.TextBox();
            this.max_beta_tb = new System.Windows.Forms.TextBox();
            this.count_beta_tb = new System.Windows.Forms.TextBox();
            this.min_alpha_tb = new System.Windows.Forms.TextBox();
            this.max_alpha_tb = new System.Windows.Forms.TextBox();
            this.count_alpha_tb = new System.Windows.Forms.TextBox();
            this.min_x_tb = new System.Windows.Forms.TextBox();
            this.max_x_tb = new System.Windows.Forms.TextBox();
            this.count_x_tb = new System.Windows.Forms.TextBox();
            this.max_axi_x_tb = new System.Windows.Forms.TextBox();
            this.min_axi_x_tb = new System.Windows.Forms.TextBox();
            this.max_axi_y_tb = new System.Windows.Forms.TextBox();
            this.min_axi_y_tb = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.update_button = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.min_e_tb = new System.Windows.Forms.TextBox();
            this.max_e_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.main_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // main_chart
            // 
            this.main_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.main_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.main_chart.Legends.Add(legend2);
            this.main_chart.Location = new System.Drawing.Point(12, 19);
            this.main_chart.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.main_chart.Name = "main_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.main_chart.Series.Add(series2);
            this.main_chart.Size = new System.Drawing.Size(1082, 603);
            this.main_chart.TabIndex = 0;
            this.main_chart.Text = "chart1";
            this.main_chart.Click += new System.EventHandler(this.main_chart_Click);
            // 
            // a_tb
            // 
            this.a_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.a_tb.Location = new System.Drawing.Point(1186, 87);
            this.a_tb.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.a_tb.Name = "a_tb";
            this.a_tb.Size = new System.Drawing.Size(59, 20);
            this.a_tb.TabIndex = 30;
            this.a_tb.Text = "0,000003";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1148, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1148, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "n = ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1148, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "k = ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1153, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "N = ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1127, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Min( β ) = ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1123, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Max( β ) = ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1128, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Min( x ) = ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1125, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Max( x ) = ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1157, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "h = ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1156, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "λ = ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1123, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Max( α ) = ";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1126, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Min( α ) = ";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1116, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Count( α ) = ";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1116, 482);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Count( x ) = ";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(219, 645);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Max( AxiX ) = ";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(372, 645);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 59;
            this.label16.Text = "Min( AxiX ) = ";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(699, 645);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "Min( AxiY ) = ";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(546, 645);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "Max( AxiY ) = ";
            // 
            // accept_button
            // 
            this.accept_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.accept_button.Location = new System.Drawing.Point(1119, 646);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(42, 23);
            this.accept_button.TabIndex = 84;
            this.accept_button.Text = "Ok";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // next_button
            // 
            this.next_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.next_button.Enabled = false;
            this.next_button.Location = new System.Drawing.Point(1177, 646);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(75, 23);
            this.next_button.TabIndex = 85;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // n_tb
            // 
            this.n_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.n_tb.Location = new System.Drawing.Point(1186, 119);
            this.n_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.n_tb.Name = "n_tb";
            this.n_tb.Size = new System.Drawing.Size(59, 20);
            this.n_tb.TabIndex = 67;
            this.n_tb.Text = "8";
            // 
            // k_tb
            // 
            this.k_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.k_tb.Location = new System.Drawing.Point(1186, 149);
            this.k_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.k_tb.Name = "k_tb";
            this.k_tb.Size = new System.Drawing.Size(59, 20);
            this.k_tb.TabIndex = 68;
            this.k_tb.Text = "23";
            // 
            // lambda_tb
            // 
            this.lambda_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lambda_tb.Location = new System.Drawing.Point(1186, 179);
            this.lambda_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lambda_tb.Name = "lambda_tb";
            this.lambda_tb.Size = new System.Drawing.Size(59, 20);
            this.lambda_tb.TabIndex = 69;
            this.lambda_tb.Text = "0,5";
            // 
            // h_tb
            // 
            this.h_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.h_tb.Location = new System.Drawing.Point(1186, 209);
            this.h_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.h_tb.Name = "h_tb";
            this.h_tb.Size = new System.Drawing.Size(59, 20);
            this.h_tb.TabIndex = 70;
            this.h_tb.Text = "1";
            // 
            // min_beta_tb
            // 
            this.min_beta_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min_beta_tb.Location = new System.Drawing.Point(1186, 239);
            this.min_beta_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.min_beta_tb.Name = "min_beta_tb";
            this.min_beta_tb.Size = new System.Drawing.Size(59, 20);
            this.min_beta_tb.TabIndex = 71;
            this.min_beta_tb.Text = "1000";
            // 
            // max_beta_tb
            // 
            this.max_beta_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max_beta_tb.Location = new System.Drawing.Point(1186, 269);
            this.max_beta_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.max_beta_tb.Name = "max_beta_tb";
            this.max_beta_tb.Size = new System.Drawing.Size(59, 20);
            this.max_beta_tb.TabIndex = 72;
            this.max_beta_tb.Text = "0,1";
            // 
            // count_beta_tb
            // 
            this.count_beta_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.count_beta_tb.Location = new System.Drawing.Point(1186, 299);
            this.count_beta_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.count_beta_tb.Name = "count_beta_tb";
            this.count_beta_tb.Size = new System.Drawing.Size(59, 20);
            this.count_beta_tb.TabIndex = 73;
            this.count_beta_tb.Text = "70";
            // 
            // min_alpha_tb
            // 
            this.min_alpha_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min_alpha_tb.Location = new System.Drawing.Point(1186, 329);
            this.min_alpha_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.min_alpha_tb.Name = "min_alpha_tb";
            this.min_alpha_tb.Size = new System.Drawing.Size(59, 20);
            this.min_alpha_tb.TabIndex = 74;
            this.min_alpha_tb.Text = "0,1";
            // 
            // max_alpha_tb
            // 
            this.max_alpha_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max_alpha_tb.Location = new System.Drawing.Point(1186, 359);
            this.max_alpha_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.max_alpha_tb.Name = "max_alpha_tb";
            this.max_alpha_tb.Size = new System.Drawing.Size(59, 20);
            this.max_alpha_tb.TabIndex = 75;
            this.max_alpha_tb.Text = "1";
            // 
            // count_alpha_tb
            // 
            this.count_alpha_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.count_alpha_tb.Location = new System.Drawing.Point(1186, 389);
            this.count_alpha_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.count_alpha_tb.Name = "count_alpha_tb";
            this.count_alpha_tb.Size = new System.Drawing.Size(59, 20);
            this.count_alpha_tb.TabIndex = 76;
            this.count_alpha_tb.Text = "100";
            // 
            // min_x_tb
            // 
            this.min_x_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min_x_tb.Location = new System.Drawing.Point(1186, 419);
            this.min_x_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.min_x_tb.Name = "min_x_tb";
            this.min_x_tb.Size = new System.Drawing.Size(59, 20);
            this.min_x_tb.TabIndex = 77;
            this.min_x_tb.Text = "-100";
            // 
            // max_x_tb
            // 
            this.max_x_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max_x_tb.Location = new System.Drawing.Point(1186, 449);
            this.max_x_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.max_x_tb.Name = "max_x_tb";
            this.max_x_tb.Size = new System.Drawing.Size(59, 20);
            this.max_x_tb.TabIndex = 78;
            this.max_x_tb.Text = "100";
            // 
            // count_x_tb
            // 
            this.count_x_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.count_x_tb.Location = new System.Drawing.Point(1186, 479);
            this.count_x_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.count_x_tb.Name = "count_x_tb";
            this.count_x_tb.Size = new System.Drawing.Size(59, 20);
            this.count_x_tb.TabIndex = 79;
            this.count_x_tb.Text = "100";
            // 
            // max_axi_x_tb
            // 
            this.max_axi_x_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.max_axi_x_tb.Location = new System.Drawing.Point(290, 642);
            this.max_axi_x_tb.Margin = new System.Windows.Forms.Padding(10);
            this.max_axi_x_tb.Name = "max_axi_x_tb";
            this.max_axi_x_tb.Size = new System.Drawing.Size(59, 20);
            this.max_axi_x_tb.TabIndex = 80;
            // 
            // min_axi_x_tb
            // 
            this.min_axi_x_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.min_axi_x_tb.Location = new System.Drawing.Point(443, 642);
            this.min_axi_x_tb.Margin = new System.Windows.Forms.Padding(10);
            this.min_axi_x_tb.Name = "min_axi_x_tb";
            this.min_axi_x_tb.Size = new System.Drawing.Size(59, 20);
            this.min_axi_x_tb.TabIndex = 81;
            // 
            // max_axi_y_tb
            // 
            this.max_axi_y_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.max_axi_y_tb.Location = new System.Drawing.Point(618, 642);
            this.max_axi_y_tb.Margin = new System.Windows.Forms.Padding(10);
            this.max_axi_y_tb.Name = "max_axi_y_tb";
            this.max_axi_y_tb.Size = new System.Drawing.Size(59, 20);
            this.max_axi_y_tb.TabIndex = 82;
            // 
            // min_axi_y_tb
            // 
            this.min_axi_y_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.min_axi_y_tb.Location = new System.Drawing.Point(769, 642);
            this.min_axi_y_tb.Margin = new System.Windows.Forms.Padding(10);
            this.min_axi_y_tb.Name = "min_axi_y_tb";
            this.min_axi_y_tb.Size = new System.Drawing.Size(59, 20);
            this.min_axi_y_tb.TabIndex = 83;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Images|*.png; *.bmp; *.jpg";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // update_button
            // 
            this.update_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.update_button.Enabled = false;
            this.update_button.Location = new System.Drawing.Point(1028, 646);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 86;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1128, 542);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 88;
            this.label19.Text = "Max( E ) = ";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1128, 512);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 87;
            this.label20.Text = "Min( E ) = ";
            // 
            // min_e_tb
            // 
            this.min_e_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min_e_tb.Enabled = false;
            this.min_e_tb.Location = new System.Drawing.Point(1186, 509);
            this.min_e_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.min_e_tb.Name = "min_e_tb";
            this.min_e_tb.Size = new System.Drawing.Size(59, 20);
            this.min_e_tb.TabIndex = 89;
            this.min_e_tb.Text = "0,9";
            // 
            // max_e_tb
            // 
            this.max_e_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max_e_tb.Enabled = false;
            this.max_e_tb.Location = new System.Drawing.Point(1186, 539);
            this.max_e_tb.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.max_e_tb.Name = "max_e_tb";
            this.max_e_tb.Size = new System.Drawing.Size(59, 20);
            this.max_e_tb.TabIndex = 90;
            this.max_e_tb.Text = "1,5";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.max_e_tb);
            this.Controls.Add(this.min_e_tb);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.min_axi_y_tb);
            this.Controls.Add(this.max_axi_y_tb);
            this.Controls.Add(this.min_axi_x_tb);
            this.Controls.Add(this.max_axi_x_tb);
            this.Controls.Add(this.count_x_tb);
            this.Controls.Add(this.max_x_tb);
            this.Controls.Add(this.min_x_tb);
            this.Controls.Add(this.count_alpha_tb);
            this.Controls.Add(this.max_alpha_tb);
            this.Controls.Add(this.min_alpha_tb);
            this.Controls.Add(this.count_beta_tb);
            this.Controls.Add(this.max_beta_tb);
            this.Controls.Add(this.min_beta_tb);
            this.Controls.Add(this.h_tb);
            this.Controls.Add(this.lambda_tb);
            this.Controls.Add(this.k_tb);
            this.Controls.Add(this.n_tb);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.a_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_chart);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "View";
            this.Text = "Quantum by Łukasz Zapała (c) 2015";
            ((System.ComponentModel.ISupportInitialize)(this.main_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart main_chart;
        private System.Windows.Forms.TextBox a_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.TextBox n_tb;
        private System.Windows.Forms.TextBox k_tb;
        private System.Windows.Forms.TextBox lambda_tb;
        private System.Windows.Forms.TextBox h_tb;
        private System.Windows.Forms.TextBox min_beta_tb;
        private System.Windows.Forms.TextBox max_beta_tb;
        private System.Windows.Forms.TextBox count_beta_tb;
        private System.Windows.Forms.TextBox min_alpha_tb;
        private System.Windows.Forms.TextBox max_alpha_tb;
        private System.Windows.Forms.TextBox count_alpha_tb;
        private System.Windows.Forms.TextBox min_x_tb;
        private System.Windows.Forms.TextBox max_x_tb;
        private System.Windows.Forms.TextBox count_x_tb;
        private System.Windows.Forms.TextBox max_axi_x_tb;
        private System.Windows.Forms.TextBox min_axi_x_tb;
        private System.Windows.Forms.TextBox max_axi_y_tb;
        private System.Windows.Forms.TextBox min_axi_y_tb;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox min_e_tb;
        private System.Windows.Forms.TextBox max_e_tb;
    }
}

