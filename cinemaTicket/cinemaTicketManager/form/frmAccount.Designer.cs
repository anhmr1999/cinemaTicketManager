namespace cinemaTicketManager.form
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.imgLayerLeft = new System.Windows.Forms.PictureBox();
            this.accountPassword = new System.Windows.Forms.Label();
            this.accountAddress = new System.Windows.Forms.Label();
            this.accountEmail = new System.Windows.Forms.Label();
            this.accountPhone = new System.Windows.Forms.Label();
            this.accountBirthday = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.accountAvatar = new System.Windows.Forms.PictureBox();
            this.accountUserName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLayerLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountAvatar)).BeginInit();
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
            this.imgLayerLeft.TabIndex = 3;
            this.imgLayerLeft.TabStop = false;
            // 
            // accountPassword
            // 
            this.accountPassword.AutoSize = true;
            this.accountPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountPassword.Location = new System.Drawing.Point(485, 293);
            this.accountPassword.Name = "accountPassword";
            this.accountPassword.Size = new System.Drawing.Size(61, 25);
            this.accountPassword.TabIndex = 24;
            this.accountPassword.Text = "name";
            this.accountPassword.Click += new System.EventHandler(this.accountPassword_Click);
            // 
            // accountAddress
            // 
            this.accountAddress.AutoSize = true;
            this.accountAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountAddress.Location = new System.Drawing.Point(485, 405);
            this.accountAddress.Name = "accountAddress";
            this.accountAddress.Size = new System.Drawing.Size(61, 25);
            this.accountAddress.TabIndex = 23;
            this.accountAddress.Text = "name";
            // 
            // accountEmail
            // 
            this.accountEmail.AutoSize = true;
            this.accountEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountEmail.Location = new System.Drawing.Point(482, 349);
            this.accountEmail.Name = "accountEmail";
            this.accountEmail.Size = new System.Drawing.Size(61, 25);
            this.accountEmail.TabIndex = 22;
            this.accountEmail.Text = "name";
            // 
            // accountPhone
            // 
            this.accountPhone.AutoSize = true;
            this.accountPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountPhone.Location = new System.Drawing.Point(485, 181);
            this.accountPhone.Name = "accountPhone";
            this.accountPhone.Size = new System.Drawing.Size(61, 25);
            this.accountPhone.TabIndex = 21;
            this.accountPhone.Text = "name";
            // 
            // accountBirthday
            // 
            this.accountBirthday.AutoSize = true;
            this.accountBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBirthday.Location = new System.Drawing.Point(485, 125);
            this.accountBirthday.Name = "accountBirthday";
            this.accountBirthday.Size = new System.Drawing.Size(61, 25);
            this.accountBirthday.TabIndex = 20;
            this.accountBirthday.Text = "name";
            // 
            // accountName
            // 
            this.accountName.AutoSize = true;
            this.accountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountName.Location = new System.Drawing.Point(485, 69);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(61, 25);
            this.accountName.TabIndex = 19;
            this.accountName.Text = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Birthday:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Full Name:";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1180, 361);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 45);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1116, 44);
            this.label7.TabIndex = 26;
            this.label7.Text = "Account Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountAvatar
            // 
            this.accountAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountAvatar.Image = global::cinemaTicketManager.Properties.Resources.user_theinformation_788;
            this.accountAvatar.Location = new System.Drawing.Point(1180, 69);
            this.accountAvatar.Name = "accountAvatar";
            this.accountAvatar.Size = new System.Drawing.Size(292, 286);
            this.accountAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.accountAvatar.TabIndex = 27;
            this.accountAvatar.TabStop = false;
            // 
            // accountUserName
            // 
            this.accountUserName.AutoSize = true;
            this.accountUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountUserName.Location = new System.Drawing.Point(485, 237);
            this.accountUserName.Name = "accountUserName";
            this.accountUserName.Size = new System.Drawing.Size(61, 25);
            this.accountUserName.TabIndex = 29;
            this.accountUserName.Text = "name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(359, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "UserName:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1330, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 45);
            this.button1.TabIndex = 30;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accountUserName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.accountAvatar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.accountPassword);
            this.Controls.Add(this.accountAddress);
            this.Controls.Add(this.accountEmail);
            this.Controls.Add(this.accountPhone);
            this.Controls.Add(this.accountBirthday);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgLayerLeft);
            this.Name = "frmAccount";
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLayerLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLayerLeft;
        private System.Windows.Forms.Label accountPassword;
        private System.Windows.Forms.Label accountAddress;
        private System.Windows.Forms.Label accountEmail;
        private System.Windows.Forms.Label accountPhone;
        private System.Windows.Forms.Label accountBirthday;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox accountAvatar;
        private System.Windows.Forms.Label accountUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}