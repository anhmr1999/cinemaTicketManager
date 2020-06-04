namespace cinemaTicketManager.dialog
{
    partial class frmEndOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEndOrder));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.saleNum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuyer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilmName = new System.Windows.Forms.RichTextBox();
            this.txtShowRoom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShowTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShowDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saleNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(103, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 35);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(228, 328);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(134, 35);
            this.btnCreate.TabIndex = 34;
            this.btnCreate.Text = "Create Ticket";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(189, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 18);
            this.label11.TabIndex = 33;
            this.label11.Text = "%";
            // 
            // saleNum
            // 
            this.saleNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleNum.Location = new System.Drawing.Point(103, 287);
            this.saleNum.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.saleNum.Name = "saleNum";
            this.saleNum.Size = new System.Drawing.Size(80, 24);
            this.saleNum.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Sale:";
            // 
            // txtBuyer
            // 
            this.txtBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyer.Location = new System.Drawing.Point(103, 242);
            this.txtBuyer.Name = "txtBuyer";
            this.txtBuyer.Size = new System.Drawing.Size(259, 24);
            this.txtBuyer.TabIndex = 30;
            this.txtBuyer.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Buyer:";
            // 
            // txtFilmName
            // 
            this.txtFilmName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilmName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilmName.Enabled = false;
            this.txtFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilmName.Location = new System.Drawing.Point(12, 12);
            this.txtFilmName.Name = "txtFilmName";
            this.txtFilmName.Size = new System.Drawing.Size(350, 71);
            this.txtFilmName.TabIndex = 28;
            this.txtFilmName.Text = "How to Train Your Dragon 3: The Hidden World";
            // 
            // txtShowRoom
            // 
            this.txtShowRoom.AutoSize = true;
            this.txtShowRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowRoom.Location = new System.Drawing.Point(103, 169);
            this.txtShowRoom.Name = "txtShowRoom";
            this.txtShowRoom.Size = new System.Drawing.Size(62, 18);
            this.txtShowRoom.TabIndex = 27;
            this.txtShowRoom.Text = "Room 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Room:";
            // 
            // txtSeat
            // 
            this.txtSeat.AutoSize = true;
            this.txtSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeat.Location = new System.Drawing.Point(103, 206);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(25, 18);
            this.txtSeat.TabIndex = 25;
            this.txtSeat.Text = "A1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Seat:";
            // 
            // txtShowTime
            // 
            this.txtShowTime.AutoSize = true;
            this.txtShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowTime.Location = new System.Drawing.Point(103, 132);
            this.txtShowTime.Name = "txtShowTime";
            this.txtShowTime.Size = new System.Drawing.Size(100, 18);
            this.txtShowTime.TabIndex = 23;
            this.txtShowTime.Text = "Case 1 - 8h00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Time:";
            // 
            // txtShowDate
            // 
            this.txtShowDate.AutoSize = true;
            this.txtShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowDate.Location = new System.Drawing.Point(103, 95);
            this.txtShowDate.Name = "txtShowDate";
            this.txtShowDate.Size = new System.Drawing.Size(80, 18);
            this.txtShowDate.TabIndex = 21;
            this.txtShowDate.Text = "29/04/2020";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Show Date:";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(316, 206);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(25, 18);
            this.txtPrice.TabIndex = 37;
            this.txtPrice.Text = "A1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Price:";
            // 
            // frmEndOrder
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(379, 379);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.saleNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuyer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilmName);
            this.Controls.Add(this.txtShowRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtShowTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShowDate);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEndOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Ticket";
            this.Load += new System.EventHandler(this.frmEndOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown saleNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuyer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtFilmName;
        private System.Windows.Forms.Label txtShowRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtSeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtShowTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtShowDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label label6;
    }
}