namespace cinemaTicketManager.form
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listFilmisShow = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listMovieComming = new System.Windows.Forms.ListBox();
            this.imgLayerRight = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLayerRight)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 606);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listFilmisShow);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "The Film is Showing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listFilmisShow
            // 
            this.listFilmisShow.Cursor = System.Windows.Forms.Cursors.Help;
            this.listFilmisShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFilmisShow.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFilmisShow.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listFilmisShow.FormattingEnabled = true;
            this.listFilmisShow.ItemHeight = 28;
            this.listFilmisShow.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "6",
            "66",
            "66",
            "6",
            "5"});
            this.listFilmisShow.Location = new System.Drawing.Point(3, 3);
            this.listFilmisShow.Name = "listFilmisShow";
            this.listFilmisShow.Size = new System.Drawing.Size(739, 557);
            this.listFilmisShow.TabIndex = 0;
            this.listFilmisShow.DoubleClick += new System.EventHandler(this.listFilmisShow_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listMovieComming);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movie or Comming Soon";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listMovieComming
            // 
            this.listMovieComming.Cursor = System.Windows.Forms.Cursors.Help;
            this.listMovieComming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMovieComming.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMovieComming.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listMovieComming.FormattingEnabled = true;
            this.listMovieComming.ItemHeight = 28;
            this.listMovieComming.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "6",
            "66",
            "66",
            "6",
            "How to Train Your Dragon 3: The Hidden World"});
            this.listMovieComming.Location = new System.Drawing.Point(3, 3);
            this.listMovieComming.Name = "listMovieComming";
            this.listMovieComming.Size = new System.Drawing.Size(758, 557);
            this.listMovieComming.TabIndex = 1;
            this.listMovieComming.DoubleClick += new System.EventHandler(this.listMovieComming_DoubleClick);
            // 
            // imgLayerRight
            // 
            this.imgLayerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgLayerRight.Image = ((System.Drawing.Image)(resources.GetObject("imgLayerRight.Image")));
            this.imgLayerRight.Location = new System.Drawing.Point(758, 0);
            this.imgLayerRight.Name = "imgLayerRight";
            this.imgLayerRight.Size = new System.Drawing.Size(398, 611);
            this.imgLayerRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLayerRight.TabIndex = 2;
            this.imgLayerRight.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 611);
            this.Controls.Add(this.imgLayerRight);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLayerRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listFilmisShow;
        private System.Windows.Forms.ListBox listMovieComming;
        private System.Windows.Forms.PictureBox imgLayerRight;
        private System.Windows.Forms.Timer timer1;
    }
}