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
    public partial class frmHome : Form
    {
        private cinemaTicketManagerDataContext dataContext = new cinemaTicketManagerDataContext();
        public frmHome()
        {
            InitializeComponent();
        }

        private int numImg = 0;
        private void autoLoadImage()
        {
            /*film f = dataContext.films.OrderByDescending(film => film.ariDate).First();*/
            List<film> listFilm = dataContext.films.Where(f => f.calendershows.Where(c => c.showDate >= DateTime.Today).ToList().Count > 0).ToList();
             Bitmap image2 = new Bitmap(("img/" + listFilm[numImg].image));
            numImg = numImg + 1 == listFilm.Count? 0 : numImg + 1;
            imgLayerRight.Image = image2;
        }

        private void getListFilmisShowing()
        {
            var list = dataContext.films.Where(f => f.calendershows.Where(c => c.showDate == DateTime.Today).Count() > 0 && f.ariDate <= DateTime.Today);
            listFilmisShow.DataSource = list;
            listFilmisShow.ValueMember = "id";
            listFilmisShow.DisplayMember = "filmName";
        }

        private void getListFilmisComming()
        {
            var list = dataContext.films.Where(f => f.calendershows.Where(c => c.showDate > DateTime.Today).Count() > 0 && f.ariDate > DateTime.Today);
            listMovieComming.DataSource = list;
            listMovieComming.ValueMember = "id";
            listMovieComming.DisplayMember = "filmName";
        }

        private void showFilmDetailt(string id)
        {
            film filmDetailt = dataContext.films.FirstOrDefault(x => x.id == Int32.Parse(id));
            if (filmDetailt != null)
            {
                frmFilmDetailt frmFilmDetailt = new frmFilmDetailt(filmDetailt);
                frmFilmDetailt.ShowDialog();
            } else
            {
                alertDanger alert = new alertDanger("Cinema Ticket Alert Danger", "Film not found!");
                alert.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            autoLoadImage();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            autoLoadImage();
            timer1.Start();
            getListFilmisShowing();
            getListFilmisComming();
        }

        private void listFilmisShow_DoubleClick(object sender, EventArgs e)
        {
            if(listFilmisShow.SelectedValue != null)
            {
                showFilmDetailt(listFilmisShow.SelectedValue.ToString());
            }
        }

        private void listMovieComming_DoubleClick(object sender, EventArgs e)
        {
            if (listMovieComming.SelectedValue != null)
            {
                showFilmDetailt(listMovieComming.SelectedValue.ToString());
            }
        }
    }
}
