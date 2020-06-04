namespace cinemaTicketManager.form
{
    partial class frmAddTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTicket));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgLayer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFilm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxShowtime = new System.Windows.Forms.ComboBox();
            this.dgvCalenderShow = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalenderShow)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLayer
            // 
            this.imgLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgLayer.Image = ((System.Drawing.Image)(resources.GetObject("imgLayer.Image")));
            this.imgLayer.Location = new System.Drawing.Point(0, 0);
            this.imgLayer.Name = "imgLayer";
            this.imgLayer.Size = new System.Drawing.Size(350, 611);
            this.imgLayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLayer.TabIndex = 1;
            this.imgLayer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film:";
            // 
            // cbxFilm
            // 
            this.cbxFilm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilm.FormattingEnabled = true;
            this.cbxFilm.Items.AddRange(new object[] {
            "How to Train Your Dragon 3: The Hidden World",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxFilm.Location = new System.Drawing.Point(407, 3);
            this.cbxFilm.Name = "cbxFilm";
            this.cbxFilm.Size = new System.Drawing.Size(578, 33);
            this.cbxFilm.TabIndex = 3;
            this.cbxFilm.SelectedIndexChanged += new System.EventHandler(this.cbxFilm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(991, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = " Date:";
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(1055, 1);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(137, 30);
            this.txtDate.TabIndex = 5;
            this.txtDate.ValueChanged += new System.EventHandler(this.txtDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1198, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time:";
            // 
            // cbxShowtime
            // 
            this.cbxShowtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxShowtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxShowtime.FormattingEnabled = true;
            this.cbxShowtime.Items.AddRange(new object[] {
            "How to Train Your Dragon 3: The Hidden World",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxShowtime.Location = new System.Drawing.Point(1256, 3);
            this.cbxShowtime.Name = "cbxShowtime";
            this.cbxShowtime.Size = new System.Drawing.Size(216, 33);
            this.cbxShowtime.TabIndex = 7;
            this.cbxShowtime.SelectedIndexChanged += new System.EventHandler(this.cbxShowtime_SelectedIndexChanged);
            // 
            // dgvCalenderShow
            // 
            this.dgvCalenderShow.AllowUserToAddRows = false;
            this.dgvCalenderShow.AllowUserToDeleteRows = false;
            this.dgvCalenderShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalenderShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalenderShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCalenderShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalenderShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.filmName,
            this.showTime,
            this.room,
            this.showdate,
            this.extraPrice});
            this.dgvCalenderShow.Cursor = System.Windows.Forms.Cursors.Help;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalenderShow.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCalenderShow.Location = new System.Drawing.Point(356, 42);
            this.dgvCalenderShow.Name = "dgvCalenderShow";
            this.dgvCalenderShow.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalenderShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCalenderShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalenderShow.Size = new System.Drawing.Size(1116, 566);
            this.dgvCalenderShow.TabIndex = 8;
            this.dgvCalenderShow.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCalenderShow_MouseDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // filmName
            // 
            this.filmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filmName.DataPropertyName = "film";
            this.filmName.FillWeight = 300F;
            this.filmName.HeaderText = "Film Name";
            this.filmName.Name = "filmName";
            this.filmName.ReadOnly = true;
            this.filmName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // showTime
            // 
            this.showTime.DataPropertyName = "timeName";
            this.showTime.FillWeight = 120F;
            this.showTime.HeaderText = "Time";
            this.showTime.Name = "showTime";
            this.showTime.ReadOnly = true;
            this.showTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // room
            // 
            this.room.DataPropertyName = "room";
            this.room.HeaderText = "Room";
            this.room.Name = "room";
            this.room.ReadOnly = true;
            this.room.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // showdate
            // 
            this.showdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.showdate.DataPropertyName = "showDate";
            this.showdate.HeaderText = "Date";
            this.showdate.Name = "showdate";
            this.showdate.ReadOnly = true;
            this.showdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // extraPrice
            // 
            this.extraPrice.DataPropertyName = "extraPrice";
            this.extraPrice.HeaderText = "Price";
            this.extraPrice.Name = "extraPrice";
            this.extraPrice.ReadOnly = true;
            this.extraPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 611);
            this.Controls.Add(this.dgvCalenderShow);
            this.Controls.Add(this.cbxShowtime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFilm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgLayer);
            this.Name = "frmAddTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddTicket";
            this.Load += new System.EventHandler(this.frmAddTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalenderShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxShowtime;
        private System.Windows.Forms.DataGridView dgvCalenderShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn showTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn showdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraPrice;
    }
}