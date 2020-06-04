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
    public partial class alertWarning : Form
    {
        public alertWarning()
        {
            InitializeComponent();
        }

        private static alertWarning alert;
        private static DialogResult result;

        public static DialogResult show(string title, string message)
        {
            alert = new alertWarning();
            alert.Text = title;
            alert.txtMessage.Text = message;
            alert.Show();
            return result;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            alert.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            alert.Close();
        }
    }
}
