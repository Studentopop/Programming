using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private string[] _colors = { "Black", "Red", "Green", "Pink", "Yellow" };
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private Movie[] _movies;
        private Movie _currentMovie;
        private int _rectanglesCount = 5;
        private int _moviesCount = 6;
        private string _wrongColor = "LightPink";
        private string _correctColor = "Window";

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexOfMaxWidth = 0;
            double max = 0;
            for (int i = 0; i < _rectanglesCount; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    indexOfMaxWidth = i;
                }
            }
            return indexOfMaxWidth;
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
        public MainForm()
        {
            InitializeComponent();
            
            // Первая страница
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Seasons));
            EnumsListBox.SelectedIndex = 0;

            // вторая страница
            _rectangles = new Rectangle[_rectanglesCount];
            var rand = new Random();
            double length, width;
            int centerX, centerY;
            for (int i = 0; i < 5; i++)
            {
                length = Math.Round(rand.NextDouble() * 100, 1);
                width = Math.Round(rand.NextDouble() * 100, 1);
                centerX = rand.Next(10);
                centerY = rand.Next(10);
                _rectangles[i] = new Rectangle(length, width, _colors[1], new Point2D(centerX, centerY));
                RectanglesListBox.Items.Add("Rectangle " + (i + 1));
            }

            RectanglesListBox.SelectedIndex = 0;

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

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var item = EnumsListBox.SelectedItem;
            var itemType = (Enums)item;
            Array values;

            switch (itemType)
            {
                case Enums.Colour:
                    values = Enum.GetValues(typeof(Colour));
                    break;
                case Enums.Genre:
                    values = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    values = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Manufactures:
                    values = Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Seasons:
                    values = Enum.GetValues(typeof(Seasons));
                    break;
                case Enums.Weekday:
                    values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in values)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntTextBox.Text = ((int)item).ToString();
        }
        private void ParseButton_Click(object sender, EventArgs e)
        {

            var text = ValueParsing.Text;
            Weekday day;

            if (Enum.TryParse(text, out day))
            {
                ParsingFlag.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                ParsingFlag.Text = "Нет такого дня недели!!!";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            var item = SeasonComboBox.SelectedItem;

            switch (item)
            {
                case Seasons.Winter:
                    SeasonGroupBox.BackColor = Color.White;
                    MessageBox.Show("Бррр! Холодно!", "Погода", MessageBoxButtons.OK);
                    break;
                case Seasons.Spring:
                    SeasonGroupBox.BackColor = Color.LightGreen;
                    break;
                case Seasons.Summer:
                    SeasonGroupBox.BackColor = Color.White;
                    MessageBox.Show("Ура! Солнце!", "Погода", MessageBoxButtons.OK);
                    break;
                case Seasons.Autumn:
                    SeasonGroupBox.BackColor = Color.Orange;
                    break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedRectangle];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            Xcoordinate.Text = _currentRectangle.Center.X.ToString();
            Ycoordinate.Text = _currentRectangle.Center.Y.ToString();
            IdRectangle.Text = "Id:" + _currentRectangle.Id.ToString();
            if (CollisionManager.IsCollision(_rectangles[0], _rectangles[1]))
            {
                CollisionLable.Text = "Collision: True";
            }
            else
            {
                CollisionLable.Text = "Collision: False";
            }
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            LenghtTextBox.BackColor = ColorTranslator.FromHtml(_correctColor);
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LenghtTextBox.Text);
            }
            catch
            {
                LenghtTextBox.BackColor = ColorTranslator.FromHtml(_wrongColor);
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            WidthTextBox.BackColor = ColorTranslator.FromHtml(_correctColor);
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = ColorTranslator.FromHtml(_wrongColor);
            }
        }
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int indexFindRectangle = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = indexFindRectangle;
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}