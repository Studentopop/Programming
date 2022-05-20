using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Classes;

namespace Programming.View.Controls
{
    public partial class MoviesControl : UserControl
    {
        private const int _moviesCount = 6;

        private const string _wrongColor = "LightPink";

        private const string _correctColor = "Window";

        private Movie[] _movies;

        private Movie _currentMovie;
        public MoviesControl()
        {
            InitializeComponent();

            _movies = new Movie[6]
            {
                new Movie("The Batman",176,2022,"Fantasy",8.4),
                new Movie("Free Guy",115,2021,"Fantasy",7.4),
                new Movie("Klaus",96,2019,"Сartoon",8.7),
                new Movie("It",135,2017,"Horror", 7.3),
                new Movie("Home Alone",103,1990,"Comedy",8.3),
                new Movie("The Green Mile",189,1999 ,"Drama",9.1),
            };

            foreach (var movie in _movies)
            {
                MoviesListBox.Items.Add(movie.Name);
            }
            MoviesListBox.SelectedIndex = 0;
        }
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int indexOfMaxRating = 0;
            double max = 0;
            for (int i = 0; i < _moviesCount; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    indexOfMaxRating = i;
                }
            }
            return indexOfMaxRating;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedMovie];
            MovieNameTextBox.Text = _currentMovie.Name;
            MovieGenreTextBox.Text = _currentMovie.Genre;
            MovieDurationTextBox.Text = _currentMovie.DurationMinutes.ToString();
            MovieReleaseTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }
        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = MovieNameTextBox.Text;
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = MovieGenreTextBox.Text;
        }

        private void MovieDuretionTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieDurationTextBox.BackColor = ColorTranslator.FromHtml(_correctColor);
            try
            {
                _currentMovie.DurationMinutes = Convert.ToInt32(MovieDurationTextBox.Text);
            }
            catch
            {
                MovieDurationTextBox.BackColor = ColorTranslator.FromHtml(_wrongColor);
            }
        }

        private void MovieReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieReleaseTextBox.BackColor = ColorTranslator.FromHtml(_correctColor);
            try
            {
                _currentMovie.ReleaseYear = Convert.ToInt32(MovieReleaseTextBox.Text);
            }
            catch
            {
                MovieReleaseTextBox.BackColor = ColorTranslator.FromHtml(_wrongColor);
            }
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieRatingTextBox.BackColor = ColorTranslator.FromHtml(_correctColor);
            try
            {
                _currentMovie.Rating = Convert.ToDouble(MovieRatingTextBox.Text);
            }
            catch
            {
                MovieRatingTextBox.BackColor = ColorTranslator.FromHtml(_wrongColor);
            }
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int indexFindMovie = FindMovieWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = indexFindMovie;
        }
        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}
