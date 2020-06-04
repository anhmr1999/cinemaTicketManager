using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemaTicketManager.crystalReport
{
    class totalTicketReport
    {
        public DateTime dateFrom { get; set; }
        public DateTime dateTo { get; set; }
        public DateTime date { get; set; }
        public String filmName { get; set; }
        public int totalTicket { get; set; }
        public double totalRevenue { get; set; }
        public override string ToString()
        {
            return filmName + " - " +totalTicket + " - " + totalRevenue;
        }
    }
}
