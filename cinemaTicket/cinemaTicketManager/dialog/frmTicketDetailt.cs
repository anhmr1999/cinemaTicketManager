using cinemaTicketManager.crystalReport;
using cinemaTicketManager.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaTicketManager.dialog
{
    public partial class frmTicketDetailt : Form
    {
        private int ticketId;
        public frmTicketDetailt(string ticketId)
        {
            InitializeComponent();
            this.ticketId = Int32.Parse(ticketId);
            loadTicket();
        }

        private void loadTicket()
        {
            cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
            var ticketDetailt = dataContext.showTickets.FirstOrDefault(x=> x.id == ticketId);
            if(ticketDetailt != null)
            {
                txtFilmName.Text = ticketDetailt.film;
                txtID.Text = ticketId.ToString();
                txtBuyer.Text = ticketDetailt.buyer;
                txtCreatedBy.Text = ticketDetailt.createdName;
                txtCreatedDate.Text = ticketDetailt.createdDate.Month + "/" + ticketDetailt.createdDate.Day + "/" + ticketDetailt.createdDate.Year;
                txtPrice.Text = ticketDetailt.totalPrice + "$";
                txtRoom.Text = ticketDetailt.room;
                txtSeat.Text = ticketDetailt.seatName;
                txtDate.Text = ticketDetailt.showDate.Month + "/" + ticketDetailt.showDate.Day + "/" + ticketDetailt.showDate.Year;
                txtShowTime.Text = ticketDetailt.timeName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportPrinter frmReport = new frmReportPrinter(ticketId);
            frmReport.ShowDialog();
        }
    }
}
