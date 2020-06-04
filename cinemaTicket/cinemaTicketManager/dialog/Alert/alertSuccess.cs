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
    public partial class alertSuccess : Form
    {
        public alertSuccess(String title, String messeage)
        {
            InitializeComponent();
            this.Text = title;
            txtMessage.Text = messeage;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
