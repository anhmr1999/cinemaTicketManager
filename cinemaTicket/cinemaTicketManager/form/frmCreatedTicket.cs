using cinemaTicketManager.DataBase;
using cinemaTicketManager.dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaTicketManager.form
{
    public partial class frmCreatedTicket : Form
    {
        private cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
        int page = 1;
        public frmCreatedTicket()
        {
            InitializeComponent();
            button1.Enabled = button2.Enabled = false;
            dgvCreatedTicket.AutoGenerateColumns = false;
        }

        private int numImg = 0;
        private void autoLoadImage()
        {
            /*film f = dataContext.films.OrderByDescending(film => film.ariDate).First();*/
            List<film> listFilm = dataContext.films.Where(f => f.calendershows.Where(c => c.showDate >= DateTime.Today).ToList().Count > 0).ToList();
            Bitmap image1 = new Bitmap(("img/" + listFilm[numImg].image));
            numImg = numImg + 1 == listFilm.Count? 0 : numImg + 1;
            imgLayerLeft.Image = image1;
        }

        private void loadFilm()
        {
            var calendars = dataContext.tickets.Where(x => x.createdDate == txtDate.Value).GroupBy(x => x.calendershow1, x => id, (key, g) => new { calendar = key, list = g.ToList() });
            var films = calendars.GroupBy(x => x.calendar.film1).Select(x=> new { film = x.Key.filmName});
            cbxFilm.DataSource = films;
            cbxFilm.DisplayMember = "film";
        }

        private void loadCreatedTicket()
        {
            var tickets = dataContext.showTickets.Where(x => x.createdDate == txtDate.Value && x.createdBy == mainForm.userLogin.id && x.film == cbxFilm.Text);
            dgvCreatedTicket.DataSource = tickets.Skip((page -1) *21).Take(21);
            totalPage.Text = " / " + (tickets.Count() % 21 != 0 ? (tickets.Count() / 21) + 1 : (tickets.Count() / 21)).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            autoLoadImage();
        }

        private void frmCreatedTicket_Load(object sender, EventArgs e)
        {
            autoLoadImage();
            loadFilm();
            loadCreatedTicket();
            timer1.Start();
        }

        private void dgvCreatedTicket_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dgvCreatedTicket.CurrentRow != null)
            {
                frmTicketDetailt ticketDetailt = new frmTicketDetailt(dgvCreatedTicket.CurrentRow.Cells[0].Value.ToString());
                ticketDetailt.ShowDialog();
            }
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {
            loadFilm();
            dgvCreatedTicket.Focus();
            loadCreatedTicket();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            page = 1;
            button3.Enabled = button4.Enabled = true;
            button1.Enabled = button2.Enabled = false;
            txtPage.Text = page.ToString();
            loadCreatedTicket();
            dgvCreatedTicket.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page = page - 1;
            txtPage.Text = page.ToString();
            loadCreatedTicket();
            if (page == 1)
            {
                button1.Enabled = button2.Enabled = false;
                button3.Enabled = button4.Enabled = true;
            } else
            {
                button1.Enabled = button2.Enabled = true;
                button3.Enabled = button4.Enabled = true;
            }
            dgvCreatedTicket.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            page = page + 1;
            txtPage.Text = page.ToString();
            var tickets = dataContext.showTickets.Where(x => x.createdDate == txtDate.Value && x.createdBy == mainForm.userLogin.id && x.film == cbxFilm.Text);
            loadCreatedTicket();
            if (page == (tickets.Count() % 21 != 0 ? (tickets.Count() / 21) + 1 : (tickets.Count() / 21)))
            {
                button1.Enabled = button2.Enabled = true;
                button3.Enabled = button4.Enabled = false;
            }
            else
            {
                button1.Enabled = button2.Enabled = true;
                button3.Enabled = button4.Enabled = true;
            }
            dgvCreatedTicket.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var tickets = dataContext.showTickets.Where(x => x.createdDate == txtDate.Value && x.createdBy == mainForm.userLogin.id && x.film == cbxFilm.Text);
            page = (tickets.Count() % 21 != 0 ? (tickets.Count() / 21) + 1 : (tickets.Count() / 21));
            loadCreatedTicket();
            button1.Enabled = button2.Enabled = true;
            button3.Enabled = button4.Enabled = false;
            txtPage.Text = page.ToString();
            dgvCreatedTicket.Focus();
        }

        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgvCreatedTicket.Focus();
                var tickets = dataContext.showTickets.Where(x => x.createdDate == txtDate.Value && x.createdBy == mainForm.userLogin.id && x.film == cbxFilm.Text);
                page = txtPage.Text.Count() > 0 && Int32.Parse(txtPage.Text) > 0 ? Int32.Parse(txtPage.Text) : 1;
                page = page > (tickets.Count() % 21 != 0 ? (tickets.Count() / 21) + 1 : (tickets.Count() / 21)) ? (tickets.Count() % 21 != 0 ? (tickets.Count() / 21) + 1 : (tickets.Count() / 21)) : page;
                loadCreatedTicket();
                if (page == 1)
                {
                    button1.Enabled = button2.Enabled = false;
                    button3.Enabled = button4.Enabled = true;
                } else if (page == (tickets.Count() % 21 != 0 ? (tickets.Count() / 21) + 1 : (tickets.Count() / 21)))
                {
                    button1.Enabled = button2.Enabled = true;
                    button3.Enabled = button4.Enabled = false;
                } else
                {
                    button1.Enabled = button2.Enabled = true;
                    button3.Enabled = button4.Enabled = true;
                }
                txtPage.Text = page.ToString();
            }
        }

        private void cbxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            page = 1;
            loadCreatedTicket();
        }


        /* Tự động thêm vé, bỏ ra khi chạy lại database
         * private void autoGenerateTicket()
        {
            Random r = new Random();
            foreach (var item in dataContext.calendershows.Where(x=> x.showDate == DateTime.Today.AddDays(1)))
            {
                int seatId = r.Next(1, dataContext.seats.Count());
                if (dataContext.tickets.FirstOrDefault(x=> x.calenderShow == item.id && x.seat == seatId) == null)
                {
                    dataContext.insertTicket(mainForm.userLogin.id, "Customer", item.showDate, 0, seatId, item.id);
                }
            }
        }*/
    }
}
