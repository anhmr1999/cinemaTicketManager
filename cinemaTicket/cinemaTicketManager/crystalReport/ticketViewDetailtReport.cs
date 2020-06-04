using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemaTicketManager.crystalReport
{
    class ticketViewDetailtReport
    {
		public ticketViewDetailtReport()
		{
		}

		public int id { set; get; }
		public string buyer { set; get; }
		public System.DateTime createdDate { set; get; }
		public double totalPrice { set; get; }
		public System.DateTime showDate { set; get; }
		public string showTime { set; get; }
		public string film { set; get; }
		public string room { set; get; }
		public string seatName { set; get; }
		public string createdBy { set; get; }
	}
}
