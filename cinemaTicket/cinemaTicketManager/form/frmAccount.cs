using cinemaTicketManager.DataBase;
using cinemaTicketManager.dialog.Alert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaTicketManager.form
{
    public partial class frmAccount : Form
    {
        private cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
        private mainForm parent;
        public frmAccount(mainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private int numImg = 0;
        private void autoLoadImage()
        {
            /*film f = dataContext.films.OrderByDescending(film => film.ariDate).First();*/
            List<film> listFilm = dataContext.films.Where(f => f.calendershows.Where(c => c.showDate >= DateTime.Today).ToList().Count > 0).ToList();
            Bitmap image1 = new Bitmap(("img/" + listFilm[numImg].image));
            numImg = numImg + 1 == listFilm.Count ? 0 : numImg + 1;
            imgLayerLeft.Image = image1;
        }

        private void loadInforAccount()
        {
            accountName.Text = mainForm.userLogin.name;
            accountBirthday.Text = mainForm.userLogin.dob.Month +"/"+mainForm.userLogin.dob.Day+"/"+mainForm.userLogin.dob.Year;
            accountPhone.Text = mainForm.userLogin.phone;
            accountUserName.Text = mainForm.userLogin.userName;
            accountPassword.Text = "• • • • • • • • •";
            accountEmail.Text = mainForm.userLogin.email;
            accountAddress.Text = mainForm.userLogin.address;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            autoLoadImage();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            autoLoadImage();
            timer1.Start();
            loadInforAccount();
        }

        private void accountPassword_Click(object sender, EventArgs e)
        {
            accountPassword.Text = accountPassword.Text == "• • • • • • • • •" ? mainForm.userLogin.password : "• • • • • • • • •";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            alertGoodBye alert =new alertGoodBye("Cinema Ticket Manager Logout","Logout Done, Good Bye!");
            alert.ShowDialog();
            parent.logout();
        }
    }
}