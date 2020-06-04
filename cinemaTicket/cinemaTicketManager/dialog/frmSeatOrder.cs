using cinemaTicketManager.DataBase;
using cinemaTicketManager.form;
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
    public partial class frmSeatOrder : Form
    {
        private int idCalendar;
        private cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
        public frmSeatOrder(string idCalendar)
        {
            InitializeComponent();
            this.idCalendar = Int32.Parse(idCalendar);
        }

        public void reloadSeatAfterCreatedTicketSuccess()
        {
            layerSeats.Controls.Clear();
            loadSeat();
        }

        private void loadCalendarShow()
        {
            var calendarShow = dataContext.showCalenders.FirstOrDefault(x=> x.id == idCalendar);
            if(calendarShow != null)
            {
                filmName.Text = calendarShow.film;
                showTime.Text = calendarShow.showDate.Month + "/" + calendarShow.showDate.Day + "/" + calendarShow.showDate.Year + " - "+ calendarShow.timeName + " - " + (calendarShow.timeBegin / 60 + "h" + calendarShow.timeBegin % 60);
                showRoom.Text = calendarShow.room;
                txtPrice.Text = calendarShow.extraPrice + " $";
            }
        }

        private void loadSeat()
        {
            foreach (var item in dataContext.seats)
            {
                int widthButton = (Boolean)item.type ? 165 : 80 ;
                Button seat = new Button() { Width = widthButton, Height = 50 };
                seat.Text = item.seatName;
                if (dataContext.tickets.Where(x => x.seat == item.id && x.calenderShow == idCalendar).Count() >0)
                {
                    seat.BackColor = Color.Red;
                } else
                {
                    if (item.price == 0)
                    {
                        seat.BackColor = Color.Aquamarine;
                    }
                    else if (item.price == 1)
                    {
                        seat.BackColor = Color.SpringGreen;
                    }
                    else if ( item.price == 3)
                    {
                        seat.BackColor = Color.LawnGreen;
                    } else{}
                    seat.Tag = item;
                    seat.Click += Seat_Click;
                }
                layerSeats.Controls.Add(seat);
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            int seatId = ((sender as Button).Tag as seat).id;
            frmEndOrder endOrder = new frmEndOrder(idCalendar,seatId,this);
            endOrder.ShowDialog();
        }

        private void frmSeatOrder_Load(object sender, EventArgs e)
        {
            loadCalendarShow();
            loadSeat();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
