using cinemaTicketManager.crystalReport;
using cinemaTicketManager.DataBase;
using CrystalDecisions.Shared;
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
    public partial class frmReport : Form
    {
        private cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
        private int numImg = 0;
        public frmReport()
        {
            InitializeComponent();
            autoLoadFilm();
            autoLoadImage();
            timer1.Start();
        }

        private void autoLoadImage()
        {
            /*film f = dataContext.films.OrderByDescending(film => film.ariDate).First();*/
            List<film> listFilm = dataContext.films.Where(f => f.calendershows.Where(c => c.showDate >= DateTime.Today).ToList().Count > 0).ToList();
            Bitmap image = new Bitmap(("img/" + listFilm[numImg].image));
            numImg = numImg + 1 == listFilm.Count ? 0 : numImg + 1;
            imgLayerLeft.Image = image;
        }

        private void autoLoadFilm()
        {
            var calender = dataContext.calendershows.Where(x => x.showDate >= dateShowFilmFrom.Value && x.showDate <= dateShowFilmTo.Value).GroupBy(x=> x.film, x=> x.id, (key, g) => new { filmId = key, idCalendar = g.ToList() });
            List<film> films = new List<film>();
            foreach (var item in calender)
            {
                films.Add(dataContext.films.FirstOrDefault(x=> x.id == item.filmId));
            }
            cbxFilm.DataSource = films;
            cbxFilm.DisplayMember = "filmName";
            cbxFilm.ValueMember = "id";
        }

        private void loadTicketReport()
        {
            List<dataChartTicket> dataCharts = new List<dataChartTicket>();
            var ticketTo = dataContext.tickets.Where(x => x.createdDate >= dateFrom.Value && x.createdDate <= dateTo.Value).GroupBy(x => x.createdDate, x=> x.id, (key, g) => new { createdDate = key, total = g.ToList() });
            foreach (var item in ticketTo)
            {
                dataCharts.Add( new dataChartTicket() { 
                    createdDate = item.createdDate.Month + " - " + item.createdDate.Day + " - "+ item.createdDate.Year,
                    totalTicket = item.total.Count(),
                    totalSale = dataContext.tickets.Where(x => x.createdDate == item.createdDate && x.sale >0).Count(),
                    totalNotSale = dataContext.tickets.Where(x => x.createdDate == item.createdDate && x.sale == 0).Count()
                });
            }
            chartTotalTicket.Series["Total Ticket Sale"].XValueMember = "createdDate";
            chartTotalTicket.Series["Total Ticket Sale"].YValueMembers = "totalSale";
            chartTotalTicket.Series["Total Ticket Not Sale"].YValueMembers = "totalNotSale";
            chartTotalTicket.Series["Total Ticket"].YValueMembers = "totalTicket";
            chartTotalTicket.DataSource = dataCharts;
            chartTotalTicket.DataBind();
        }

        private void loadFilmReport()
        {
            try
            {
                int filmId = Int32.Parse(cbxFilm.SelectedValue.ToString());
                List<dataChartFilm> dataCharts = new List<dataChartFilm>();
                var ticketTo = dataContext.tickets.Where(x => x.calendershow1.film == filmId && x.createdDate >= dateShowFilmFrom.Value && x.createdDate <= dateShowFilmTo.Value).GroupBy(x => x.createdDate, x => x.id, (key, g) => new { createdDate = key, total = g.ToList() });
                foreach (var item in ticketTo)
                {
                    dataCharts.Add(new dataChartFilm()
                    {
                        createdDate = item.createdDate.Month + " - " + item.createdDate.Day + " - " + item.createdDate.Year,
                        totalTicket = item.total.Count()
                    });
                }
                chartFilmReport.Series["Total Ticket"].XValueMember = "createdDate";
                chartFilmReport.Series["Total Ticket"].YValueMembers = "totalTicket";
                chartFilmReport.DataSource = dataCharts;
                chartFilmReport.DataBind();
            } catch
            {

            }
        }

        private void loadTotalRevenueReport()
        {
            /*double test = (new List<double>() { 3.3, 3.2 }).Sum();
            MessageBox.Show(test.ToString());*/
            var dataRevenue = dataContext.tickets.Where(x => x.createdDate >= dateRevenueFrom.Value && x.createdDate <= dateRevenueTo.Value).GroupBy(x => x.createdDate, x=> x.totalPrice, (key, g) => new { createdDate = key, price = g.ToList() });
            List<object> list = new List<object>();
            foreach (var item in dataRevenue)
            {
               list.Add(new { 
                   createdDate = item.createdDate.Month + " - "+item.createdDate.Day +" - "+item.createdDate.Year, 
                   revenue = item.price.Sum()
               });
            }
            chartRevenueReport.Series["Revenue"].XValueMember = "createdDate";
            chartRevenueReport.Series["Revenue"].YValueMembers = "revenue";
            chartRevenueReport.DataSource = list;
            chartRevenueReport.DataBind();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            loadTotalRevenueReport();
            loadTicketReport();
            dateFrom.Value = DateTime.Today.Subtract(new TimeSpan(7,0,0,0));
            dateShowFilmFrom.Value = DateTime.Today.Subtract(new TimeSpan(7, 0, 0, 0));
            dateRevenueFrom.Value = DateTime.Today.Subtract(new TimeSpan(7, 0, 0, 0));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            autoLoadImage();
        }

        private void cbxFilm_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbxFilm.SelectedValue != null)
            {
                loadFilmReport();
            }
        }

        private void dateShowFilmFrom_ValueChanged(object sender, EventArgs e)
        {
            autoLoadFilm();
            loadFilmReport();
        }

        private void dateShowFilmTo_ValueChanged(object sender, EventArgs e)
        {
            autoLoadFilm();
            loadFilmReport();
        }

        private void btnPrintReportTicket_Click(object sender, EventArgs e)
        {
            frmReportPrinter frmReport = new frmReportPrinter(dateFrom.Value, dateTo.Value);
            frmReport.ShowDialog();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            loadTicketReport();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            loadTicketReport();
        }

        private void dateRevenueFrom_ValueChanged(object sender, EventArgs e)
        {
            loadTotalRevenueReport();
        }

        private void dateRevenueTo_ValueChanged(object sender, EventArgs e)
        {
            loadTotalRevenueReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReportPrinter frmReport = new frmReportPrinter(dateFrom.Value, dateTo.Value,true);
            frmReport.ShowDialog();
        }
    }

    public class dataChartTicket
    {
        public string createdDate { get; set; }
        public int totalTicket { get; set; }
        public int totalSale { get; set; }
        public int totalNotSale { get; set; }

        public override string ToString()
        {
            return createdDate + " - " + totalTicket + " - " + totalSale + " - " + totalNotSale;
        }
    }

    public class dataChartFilm
    {
        public string createdDate { get; set; }
        public int totalTicket { get; set; }
    }
}