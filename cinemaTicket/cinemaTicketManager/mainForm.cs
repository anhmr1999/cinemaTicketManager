using cinemaTicketManager.DataBase;
using cinemaTicketManager.dialog;
using cinemaTicketManager.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaTicketManager
{
    public partial class mainForm : Form
    {
        public static account userLogin;

        public mainForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void changeLayer(Form frm)
        {
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            if (this.ActiveMdiChild != null)
            {
                Form frmNow = this.ActiveMdiChild;
                if (frmNow.Name != frm.Name)
                {
                    frmNow.Close();
                    frm.Show();
                }
            }
            else
            {
                frm.Show();
            }
        }
        public static Boolean checkLogin()
        {
            if (userLogin == null)
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                return false;
            }
            return true;
        }

        public void logout()
        {
            userLogin = null;
            frmHome home = new frmHome();
            changeLayer(home);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            changeLayer(home);
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            frmAddTicket addTicket = new frmAddTicket();
            changeLayer(addTicket);
        }

        private void btnCreatedTicket_Click(object sender, EventArgs e)
        {
            if (checkLogin())
            {
                frmCreatedTicket frmCreatedTicket = new frmCreatedTicket();
                changeLayer(frmCreatedTicket);
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (checkLogin())
            {
                frmAccount frmAccount = new frmAccount(this);
                changeLayer(frmAccount);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            changeLayer(home);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtNow.Text = "Now: "+ DateTime.Now.ToString();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            changeLayer(report);
        }
    }
}
