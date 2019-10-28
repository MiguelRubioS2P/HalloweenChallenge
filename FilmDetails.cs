using HalloweenChallenge.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloweenChallenge
{
    public partial class FilmDetails : Form
    {
        Film _selectedFilm;
        public FilmDetails(Film selected)
        {
            InitializeComponent();
            _selectedFilm = selected;
        }

        private void FilmDetails_Load(object sender, EventArgs e)
        {
            labelTitleDetails.Text = _selectedFilm.title;
            labelDescriptionL.Text = _selectedFilm.description;
            labelTime.Text = _selectedFilm.length;
            labelAge.Text = _selectedFilm.rating;
        }

    }
}
