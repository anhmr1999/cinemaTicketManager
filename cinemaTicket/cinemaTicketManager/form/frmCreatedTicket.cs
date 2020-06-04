using cinemaTicketManager.DataBase;
using cinemaTicketManager.dialog;
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
    public partial class frmCreatedTicket : Form
    {
        private cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
        public frmCreatedTicket()
        {
            InitializeComponent();
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

        private void loadCreatedTicket()
        {
            var tickets = dataContext.showTickets.Where(x => x.createdDate == txtDate.Value && x.createdBy == mainForm.userLogin.id);
            dgvCreatedTicket.DataSource = tickets;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            autoLoadImage();
        }

        private void frmCreatedTicket_Load(object sender, EventArgs e)
        {
            autoLoadImage();
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
