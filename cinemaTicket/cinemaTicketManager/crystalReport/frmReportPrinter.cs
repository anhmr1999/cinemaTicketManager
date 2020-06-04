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

namespace cinemaTicketManager.crystalReport
{
    public partial class frmReportPrinter : Form
    {
        public frmReportPrinter(int ticketID)
        {
            InitializeComponent();
            autoLoadReport(ticketID);
        }

        public frmReportPrinter(DateTime from, DateTime To)
        {
            InitializeComponent();
            autoLoadReport(from, To);
        }

        public frmReportPrinter(DateTime from, DateTime To,Boolean pro)
        {
            InitializeComponent();
            autoLoadReport(from, To, pro);
        }

        private void autoLoadReport(int ticketID)
        {
            cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
            var tickets = from t in dataContext.showTickets where t.id == ticketID select new ticketViewDetailtReport {
                id = t.id,
                buyer = t.buyer,
                createdBy = t.createdBy + t.createdName,
                createdDate = t.createdDate,
                film = t.film,
                room = t.room,
                seatName = t.seatName,
                showDate = t.showDate,
                showTime = t.timeName + " - "+t.timeBegin / 60 + "h" + t.timeBegin % 60,
                totalPrice = t.totalPrice
            };
            rptTicketPrinter prints = new rptTicketPrinter();
            prints.SetDataSource(tickets);
            crystalReport.ReportSource = prints;
            crystalReport.Show();
        }

        private void autoLoadReport(DateTime from, DateTime To)
        {
            List<totalTicketReport> totalTickets = new List<totalTicketReport>();
            cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
            var listFilms = dataContext.calendershows.Where(x => x.showDate >= from && x.showDate <= To).GroupBy(x=> x.film, x=>x.id, (key,g) => new { film = key, calendar = g.ToList() });
            foreach (var item in listFilms)
            {
                var tickets = dataContext.tickets.Where(x => item.calendar.Contains(x.calenderShow) && x.createdDate >= from && x.createdDate <= To).GroupBy(x => x.createdDate, x=> x.totalPrice, (key,g) => new { createdDate = key, total = g.ToList() });
                foreach (var item1 in tickets)
                {
                    totalTicketReport totalTicket = new totalTicketReport() { 
                        dateFrom = from,
                        date = item1.createdDate,
                        filmName = dataContext.films.FirstOrDefault(x => x.id == item.film).filmName,
                        totalTicket = item1.total.Count,
                        totalRevenue = item1.total.Sum(),
                    };
                    totalTickets.Add(totalTicket);
                }
            }
            if ( DateTime.Compare(from,To) == 0)
            {
                rptTicketAllFilmReport report = new rptTicketAllFilmReport();
                report.SetDataSource(totalTickets);
                crystalReport.ReportSource = report;
                crystalReport.Show();
            } else
            {
                rptTicketAllFilmReport_SingleDay report = new rptTicketAllFilmReport_SingleDay();
                report.SetDataSource(totalTickets);
                crystalReport.ReportSource = report;
                crystalReport.Show();
            }
        }

        private void autoLoadReport(DateTime from, DateTime To, Boolean pro)
        {
            List<filmReport> totalTickets = new List<filmReport>();
            cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
            List<filmReport> reports = new List<filmReport>();
            var listFilms = dataContext.calendershows.Where(x => x.showDate >= from && x.showDate <= To).GroupBy(x => x.film, x => x.id, (key, g) => new { film = key, calendar = g.ToList() });
            foreach (var item in listFilms)
            {
                var tickets = dataContext.tickets.Where(x => item.calendar.Contains(x.calenderShow) && x.createdDate >= from && x.createdDate <= To).GroupBy(x => x.calendershow1.film, x => x.totalPrice, (key, g) => new { film = key, total = g.ToList() });
                foreach (var item1 in tickets)
                {
                    filmReport film = new filmReport() {
                        filmName = dataContext.films.FirstOrDefault(x => x.id == item.film).filmName,
                        totalView =item1.total.Count,
                        totalRevenue = item1.total.Sum()
                    };
                    totalTickets.Add(film);
                }
            }
            rptTotalFilmReport report = new rptTotalFilmReport();
            report.SetDataSource(totalTickets);
            crystalReport.ReportSource = report;
            crystalReport.Show();
        }
    }
}
