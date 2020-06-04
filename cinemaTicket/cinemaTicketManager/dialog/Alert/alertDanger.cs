using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaTicketManager.dialog.Alert
{
    public partial class alertDanger : Form
    {
        public alertDanger(String title, String messeage)
        {
            InitializeComponent();
            this.Text = title;
            txtMessage.Text = messeage;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
