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
    public partial class frmFilmDetailt : Form
    {
        public frmFilmDetailt(film film)
        {
            InitializeComponent();
            loadFilmDetailt(film);
        }

        private void loadFilmDetailt(film film)
        {
            filmName.Text = film.filmName;
            txtDirector.Text = film.director;
            txtDate.Text = film.ariDate.Month + "/" + film.ariDate.Day + "/" + film.ariDate.Year;
            txtTime.Text = film.time + " minutes";
            txtCast.Text = film.casts;
            txtCategory.Text = film.category.catName;
            txtContent.Text = film.content;
            Bitmap image = new Bitmap(("img/" + film.image));
            imgLayer.Image = image;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
