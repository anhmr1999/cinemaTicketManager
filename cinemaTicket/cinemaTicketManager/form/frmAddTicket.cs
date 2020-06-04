using cinemaTicketManager.DataBase;
using cinemaTicketManager.dialog;
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
    public partial class frmAddTicket : Form
    {
        public frmAddTicket()
        {
            InitializeComponent();
            dgvCalenderShow.AutoGenerateColumns = false;
        }

        private cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();

        private int numImg = 0;
        private void autoLoadImage()
        {
            /*film f = dataContext.films.OrderByDescending(film => film.ariDate).First();*/
            List<film> listFilm = dataContext.films.Where(f => f.calendershows.Where(c => c.showDate >= DateTime.Today).ToList().Count > 0).ToList();
            Bitmap image = new Bitmap(("img/" + listFilm[numImg].image));
            imgLayer.Image = image;
            numImg = numImg + 1 == listFilm.Count ? 0 : numImg + 1;
        }

        private void loadCbxFilm()
        {
            List<film> films = new List<film>() { 
                new film(){id = 0, filmName = "All"}
            };
            foreach (var item in dataContext.films.Where(f => f.calendershows.Where(c => c.showDate == txtDate.Value).Count() > 0)) 
            {
                films.Add(item);
            }
            cbxFilm.DataSource = films;
            cbxFilm.DisplayMember = "filmName";
            cbxFilm.ValueMember = "id";
        }

        private void loadCbxShowTimes()
        {
            List<showtime> showtimes = new List<showtime>()
            {
                new showtime(){id = 0, timeName = "All"}
            };
            foreach (var item in dataContext.showtimes)
            {
                showtimes.Add(item);
            }
            cbxShowtime.DataSource = showtimes;
            cbxShowtime.DisplayMember = "timeName";
            cbxShowtime.ValueMember = "id";
        }

        private void loadCalendarShow()
        {
            string filmName = "";
            string showtimes = "";
            try
            {
                filmName = cbxFilm.Text;
            } catch
            {
                filmName = "All";
            }
            try
            {
                showtimes = cbxShowtime.Text;
            }
            catch
            {
                showtimes = "All";
            }
            List<showCalender> calendars;
            if (filmName != "All" && showtimes == "All")
            {
                calendars = dataContext.showCalenders.Where(x => x.showDate == txtDate.Value && x.film == filmName).ToList();
            } else if (filmName == "All" && showtimes != "All")
            {
                calendars = dataContext.showCalenders.Where(x => x.showDate == txtDate.Value && x.timeName == showtimes).ToList();
            } else if(filmName != "All" && showtimes != "All")
            {
                calendars = dataContext.showCalenders.Where(x => x.showDate == txtDate.Value && x.timeName == showtimes && x.film == filmName).ToList();
            }
            else
            {
                calendars = dataContext.showCalenders.Where(x => x.showDate == txtDate.Value).ToList();
            }
            dgvCalenderShow.DataSource = calendars;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            autoLoadImage();
        }

        private void frmAddTicket_Load(object sender, EventArgs e)
        {
            timer1.Start();
            loadCbxFilm();
            loadCbxShowTimes();
            loadCalendarShow();
        }

        private void cbxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCalendarShow();
        }

        private void cbxShowtime_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCalendarShow();
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {
            loadCbxFilm();
            loadCalendarShow();
        }

        private void dgvCalenderShow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvCalenderShow.CurrentRow != null && mainForm.checkLogin())
            {
                if (dataContext.calendershows.FirstOrDefault(x => x.id == Int32.Parse(dgvCalenderShow.CurrentRow.Cells[0].Value.ToString())).showDate >= DateTime.Today)
                {
                    frmSeatOrder seatOrder = new frmSeatOrder(dgvCalenderShow.CurrentRow.Cells[0].Value.ToString());
                    seatOrder.ShowDialog();
                } else
                {
                    alertDanger alert = new alertDanger("Create Ticket Message", "Tickets for this show have been stopped!");
                    alert.ShowDialog();
                }
            }
        }
    }
}
