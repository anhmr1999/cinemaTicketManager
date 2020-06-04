using cinemaTicketManager.DataBase;
using cinemaTicketManager.dialog.Alert;
using cinemaTicketManager.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaTicketManager.dialog
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "") {
                if (txtPassword.Text != "")
                {
                    cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
                    account user = dataContext.accounts.FirstOrDefault(x => x.userName == txtUserName.Text && x.password == txtPassword.Text);
                    if(user != null)
                    {
                        mainForm.userLogin = user;
                        if (chkRemenber.Checked)
                        {
                            using (StreamWriter sw = new StreamWriter("textfile.txt"))
                            {

                                sw.Write(txtUserName.Text);
                            }
                        } else
                        {
                            using (StreamWriter sw = new StreamWriter("textfile.txt"))
                            {

                                sw.Write("");
                            }
                        }
                        this.Close();
                    } else
                    {
                        alertDanger alert = new alertDanger("Login Failt", "User account or password is incorrect!");
                        alert.ShowDialog();
                        txtPassword.Text = "";
                    }
                } else
                {
                    alertDanger alert = new alertDanger("Login Failt", "Password is empty!");
                    alert.ShowDialog(); 
                    txtPassword.Text = "";
                }
            } else
            {
                alertDanger alert = new alertDanger("Login Failt", "UserName is empty!");
                alert.ShowDialog();
                txtPassword.Text = "";
            }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("textfile.txt"))
                {
                    txtUserName.Text = sr.ReadToEnd();
                    if(txtUserName.Text != "")
                    {
                        txtPassword.Focus();
                    }
                }
            }
            catch
            {

            }
        }
    }
}
