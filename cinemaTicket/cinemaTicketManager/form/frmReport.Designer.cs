namespace cinemaTicketManager.form
{
    partial class frmReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.imgLayerLeft = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnPrintReportTicket = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chartTotalTicket = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartFilmReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dateShowFilmTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateShowFilmFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFilm = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartRevenueReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dateRevenueTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateRevenueFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLayerLeft)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalTicket)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFilmReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueReport)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLayerLeft
            // 
            this.imgLayerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgLayerLeft.Image = ((System.Drawing.Image)(resources.GetObject("imgLayerLeft.Image")));
            this.imgLayerLeft.Location = new System.Drawing.Point(0, 0);
            this.imgLayerLeft.Name = "imgLayerLeft";
            this.imgLayerLeft.Size = new System.Drawing.Size(350, 611);
            this.imgLayerLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLayerLeft.TabIndex = 4;
            this.imgLayerLeft.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(350, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 611);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.chartTotalTicket);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1126, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ticket Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateFrom);
            this.panel1.Controls.Add(this.btnPrintReportTicket);
            this.panel1.Controls.Add(this.dateTo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 42);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(59, 6);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(144, 26);
            this.dateFrom.TabIndex = 0;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // btnPrintReportTicket
            // 
            this.btnPrintReportTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReportTicket.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReportTicket.Location = new System.Drawing.Point(964, 1);
            this.btnPrintReportTicket.Name = "btnPrintReportTicket";
            this.btnPrintReportTicket.Size = new System.Drawing.Size(151, 36);
            this.btnPrintReportTicket.TabIndex = 4;
            this.btnPrintReportTicket.Text = "Print Report";
            this.btnPrintReportTicket.UseVisualStyleBackColor = true;
            this.btnPrintReportTicket.Click += new System.EventHandler(this.btnPrintReportTicket_Click);
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(246, 6);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(136, 26);
            this.dateTo.TabIndex = 2;
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // chartTotalTicket
            // 
            this.chartTotalTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea14.Name = "ChartArea1";
            this.chartTotalTicket.ChartAreas.Add(chartArea14);
            legend14.Alignment = System.Drawing.StringAlignment.Center;
            legend14.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend14.Name = "Legend1";
            this.chartTotalTicket.Legends.Add(legend14);
            this.chartTotalTicket.Location = new System.Drawing.Point(6, 51);
            this.chartTotalTicket.Name = "chartTotalTicket";
            series22.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series22.ChartArea = "ChartArea1";
            series22.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series22.IsValueShownAsLabel = true;
            series22.IsXValueIndexed = true;
            series22.LabelBackColor = System.Drawing.Color.White;
            series22.LabelBorderColor = System.Drawing.Color.White;
            series22.Legend = "Legend1";
            series22.Name = "Total Ticket Sale";
            series23.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series23.ChartArea = "ChartArea1";
            series23.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series23.IsValueShownAsLabel = true;
            series23.IsXValueIndexed = true;
            series23.LabelBackColor = System.Drawing.Color.White;
            series23.LabelBorderColor = System.Drawing.Color.White;
            series23.Legend = "Legend1";
            series23.Name = "Total Ticket Not Sale";
            series24.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series24.ChartArea = "ChartArea1";
            series24.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series24.IsValueShownAsLabel = true;
            series24.IsXValueIndexed = true;
            series24.LabelBackColor = System.Drawing.Color.White;
            series24.LabelBorderColor = System.Drawing.Color.White;
            series24.Legend = "Legend1";
            series24.Name = "Total Ticket";
            this.chartTotalTicket.Series.Add(series22);
            this.chartTotalTicket.Series.Add(series23);
            this.chartTotalTicket.Series.Add(series24);
            this.chartTotalTicket.Size = new System.Drawing.Size(1106, 522);
            this.chartTotalTicket.TabIndex = 5;
            this.chartTotalTicket.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartFilmReport);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1126, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Film Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartFilmReport
            // 
            this.chartFilmReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea13.Name = "ChartArea1";
            this.chartFilmReport.ChartAreas.Add(chartArea13);
            legend13.Alignment = System.Drawing.StringAlignment.Center;
            legend13.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend13.Name = "Legend1";
            this.chartFilmReport.Legends.Add(legend13);
            this.chartFilmReport.Location = new System.Drawing.Point(6, 55);
            this.chartFilmReport.Name = "chartFilmReport";
            this.chartFilmReport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series21.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series21.ChartArea = "ChartArea1";
            series21.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series21.IsValueShownAsLabel = true;
            series21.Legend = "Legend1";
            series21.Name = "Total Ticket";
            this.chartFilmReport.Series.Add(series21);
            this.chartFilmReport.Size = new System.Drawing.Size(1111, 513);
            this.chartFilmReport.TabIndex = 1;
            this.chartFilmReport.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.dateShowFilmTo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateShowFilmFrom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbxFilm);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 43);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1001, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Print Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateShowFilmTo
            // 
            this.dateShowFilmTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateShowFilmTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateShowFilmTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateShowFilmTo.Location = new System.Drawing.Point(847, 7);
            this.dateShowFilmTo.Name = "dateShowFilmTo";
            this.dateShowFilmTo.Size = new System.Drawing.Size(146, 26);
            this.dateShowFilmTo.TabIndex = 6;
            this.dateShowFilmTo.ValueChanged += new System.EventHandler(this.dateShowFilmTo_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(815, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "To";
            // 
            // dateShowFilmFrom
            // 
            this.dateShowFilmFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateShowFilmFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateShowFilmFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateShowFilmFrom.Location = new System.Drawing.Point(662, 7);
            this.dateShowFilmFrom.Name = "dateShowFilmFrom";
            this.dateShowFilmFrom.Size = new System.Drawing.Size(146, 26);
            this.dateShowFilmFrom.TabIndex = 4;
            this.dateShowFilmFrom.ValueChanged += new System.EventHandler(this.dateShowFilmFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film";
            // 
            // cbxFilm
            // 
            this.cbxFilm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilm.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilm.FormattingEnabled = true;
            this.cbxFilm.Location = new System.Drawing.Point(45, 7);
            this.cbxFilm.Name = "cbxFilm";
            this.cbxFilm.Size = new System.Drawing.Size(561, 27);
            this.cbxFilm.TabIndex = 1;
            this.cbxFilm.SelectedValueChanged += new System.EventHandler(this.cbxFilm_SelectedValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartRevenueReport);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1126, 576);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Revenue Report";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartRevenueReport
            // 
            this.chartRevenueReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea15.Name = "ChartArea1";
            this.chartRevenueReport.ChartAreas.Add(chartArea15);
            legend15.Alignment = System.Drawing.StringAlignment.Center;
            legend15.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend15.Name = "Legend1";
            legend15.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartRevenueReport.Legends.Add(legend15);
            this.chartRevenueReport.Location = new System.Drawing.Point(6, 56);
            this.chartRevenueReport.Name = "chartRevenueReport";
            this.chartRevenueReport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chartRevenueReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series25.BorderWidth = 4;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series25.IsValueShownAsLabel = true;
            series25.Legend = "Legend1";
            series25.Name = "Revenue";
            series25.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartRevenueReport.Series.Add(series25);
            this.chartRevenueReport.Size = new System.Drawing.Size(1114, 514);
            this.chartRevenueReport.TabIndex = 1;
            this.chartRevenueReport.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.dateRevenueTo);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dateRevenueFrom);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1120, 47);
            this.panel3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(976, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Print Report";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateRevenueTo
            // 
            this.dateRevenueTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRevenueTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRevenueTo.Location = new System.Drawing.Point(218, 10);
            this.dateRevenueTo.Name = "dateRevenueTo";
            this.dateRevenueTo.Size = new System.Drawing.Size(124, 26);
            this.dateRevenueTo.TabIndex = 4;
            this.dateRevenueTo.ValueChanged += new System.EventHandler(this.dateRevenueTo_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "To";
            // 
            // dateRevenueFrom
            // 
            this.dateRevenueFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRevenueFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRevenueFrom.Location = new System.Drawing.Point(55, 10);
            this.dateRevenueFrom.Name = "dateRevenueFrom";
            this.dateRevenueFrom.Size = new System.Drawing.Size(124, 26);
            this.dateRevenueFrom.TabIndex = 3;
            this.dateRevenueFrom.ValueChanged += new System.EventHandler(this.dateRevenueFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "From";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.imgLayerLeft);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLayerLeft)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalTicket)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFilmReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueReport)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLayerLeft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button btnPrintReportTicket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFilm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateShowFilmFrom;
        private System.Windows.Forms.DateTimePicker dateShowFilmTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFilmReport;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateRevenueFrom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker dateRevenueTo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenueReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalTicket;
    }
}