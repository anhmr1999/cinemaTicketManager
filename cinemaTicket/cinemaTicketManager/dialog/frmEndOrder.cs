using cinemaTicketManager.crystalReport;
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

namespace cinemaTicketManager.dialog
{
    public partial class frmEndOrder : Form
    {
        private cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
        private int idCalendar, idSeat;
        private frmSeatOrder seatOrder;
        public frmEndOrder(int idCalendar, int idSeat, frmSeatOrder seatOrder)
        {
            InitializeComponent();
            this.seatOrder = seatOrder;
            this.idCalendar = idCalendar;
            this.idSeat = idSeat;
        }

        private void loadDataTicket()
        {
            var calendar = dataContext.showCalenders.FirstOrDefault(x => x.id == idCalendar);
            var seat = dataContext.seats.FirstOrDefault(x => x.id == idSeat);
            if(calendar != null && seat != null)
            {
                txtFilmName.Text = calendar.film;
                txtShowDate.Text = calendar.showDate.ToString();
                txtShowTime.Text = calendar.timeName + " - " + (calendar.timeBegin / 60 + "h" + calendar.timeBegin % 60);
                txtShowRoom.Text = calendar.room;
                txtSeat.Text = seat.seatName;
                txtPrice.Text = (seat.price + calendar.extraPrice) + "$";
            }
            else
            {
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int result = dataContext.insertTicket(mainForm.userLogin.id, txtBuyer.Text, DateTime.Today, double.Parse(saleNum.Value.ToString()), idSeat, idCalendar);
            if (result != 0)
            {
                seatOrder.reloadSeatAfterCreatedTicketSuccess();
                alertSuccess success = new alertSuccess("Cinema Ticket Manager Alert", "Created New Ticket Success!");
                success.ShowDialog();
                frmReportPrinter reportPrinter = new frmReportPrinter(result);
                reportPrinter.ShowDialog();
                this.Dispose();
            }
            else
            {
                alertDanger alert = new alertDanger("Cinema Ticket Manager Alert", "Created New Ticket Failt!");
                alert.ShowDialog();
            }
        }

        private void frmEndOrder_Load(object sender, EventArgs e)
        {
            loadDataTicket();
        }
    }
}
