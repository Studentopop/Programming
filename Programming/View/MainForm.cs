using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;
using Rectangle = Programming.Model.Classes.Rectangle;
using Programming.Model.Geometry;
using SystemColor = System.Drawing.Color;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly SystemColor _errorBackColor = SystemColor.LightPink;

        private readonly SystemColor _currentBackColor = SystemColor.White;

        private readonly SystemColor _intersect = SystemColor.FromArgb(127, 255, 127, 127);

        private readonly SystemColor _unIntersect = SystemColor.FromArgb(127, 127, 255, 127);

        private const int _moviesCount = 6;
        
        private const string _wrongColor = "LightPink";

        private const string _correctColor = "Window";

        private Movie[] _movies;

        private Movie _currentMovie;
        
        private Rectangle _currentRectangle;

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private List<Panel> _rectanglePanels = new List<Panel>();

        public int canvasWidth;

        public int canvasHeight;

        public MainForm()
        {
            InitializeComponent();

            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Seasons));
            EnumsListBox.SelectedIndex = 0;
            

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

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            int indexMaxWidth = 0;
            double maxWidth = 0;
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexMaxWidth = i;
                }
            }
            return indexMaxWidth;
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
        private void UpdateListBoxes()
        {
            AddingRectanglesListBox.Items.Clear();
            RectanglesListBox.Items.Clear();

            for (int i = 0; i < _rectangles.Count; i++)
            {
                AddingRectanglesListBox.Items.Add(_rectangles[i].GetRectangleInfo());
                RectanglesListBox.Items.Add("Rectangle " + (i + 1));
            }

            AddingRectanglesListBox.SelectedIndex = _rectangles.Count - 1;
        }
        private void ClearRectangleInfo()
        {
            IdSelectedRectangleTextBox.Clear();
            XSelectedRectangleTextBox.Clear();
            YSelectedRectangleTextBox.Clear();
            WidthSelectedRectangleTextBox.Clear();
            HeightSelectedRectangleTextBox.Clear();

            IdRectangleTextBox.Clear();
            XRectangleTextBox.Clear();
            YRectangleTextBox.Clear();
            RectangleWidthTextBox.Clear();
            RectangleHeightTextBox.Clear();
        }
        private void FindCollisions()
        {

            for (int n = 0; n < _rectangles.Count; n++)
            {
                CanvasPanel.Controls[n].BackColor = _unIntersect;
                _rectangles[n].Color = "Green";
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectangles[i].Color = "Red";
                        _rectangles[j].Color = "Red";

                        CanvasPanel.Controls[i].BackColor = _intersect;
                        CanvasPanel.Controls[j].BackColor = _intersect;
                    }
                }
            }
        }
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = AddingRectanglesListBox.FindString(rectangle.Id.ToString());
            AddingRectanglesListBox.Items[index] = rectangle.GetRectangleInfo();
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
            RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
            YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
            if (CollisionManager.IsCollision(_rectangles[0], _rectangles[1]))
            {
                CollisionTextBox.Text = "True";
            }
            else
            {
                CollisionTextBox.Text = "False";
            }
        }
        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleHeightTextBox.BackColor = ColorTranslator.FromHtml(_correctColor);
            try
            {
                _currentRectangle.Height = int.Parse(RectangleHeightTextBox.Text);
            }
            catch
            {
                RectangleHeightTextBox.BackColor = ColorTranslator.FromHtml(_wrongColor);
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleWidthTextBox.BackColor = ColorTranslator.FromHtml(_correctColor);
            try
            {
                _currentRectangle.Width = int.Parse(RectangleWidthTextBox.Text);
            }
            catch
            {
                RectangleWidthTextBox.BackColor = ColorTranslator.FromHtml(_wrongColor);
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

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Height = int.Parse(RectangleHeightTextBox.Text);
                RectangleHeightTextBox.BackColor = _currentBackColor;
            }
            catch
            {
                RectangleHeightTextBox.BackColor = _errorBackColor;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(RectangleWidthTextBox.Text);
                RectangleWidthTextBox.BackColor = _currentBackColor;
            }
            catch
            {
                RectangleWidthTextBox.BackColor = _errorBackColor;
            }
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

        private void AddRectanglePictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddRectanglePictureBox.BackgroundImage = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectanglePictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddRectanglePictureBox.BackgroundImage = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void AddRectanglePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            AddRectanglePictureBox.BackColor = SystemColor.LightGray;
        }

        private void AddRectanglePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            AddRectanglePictureBox.BackColor = RectanglesTabPage.BackColor;
        }

        private void RemoveRectanglePictureBox_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectanglePictureBox.BackgroundImage = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectanglePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectanglePictureBox.BackgroundImage = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RemoveRectanglePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            RemoveRectanglePictureBox.BackColor = SystemColor.LightGray;
        }

        private void RemoveRectanglePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            RemoveRectanglePictureBox.BackColor = RectanglesTabPage.BackColor;
        }

        private void AddRectanglePictureBox_Click(object sender, EventArgs e)
        {
            var newRectangle = RectangleFactory.Randomize();
            _rectangles.Add(newRectangle);

            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = newRectangle.Width;
            rectanglePanel.Height = newRectangle.Height;
            rectanglePanel.Location = new Point(newRectangle.Center.X, newRectangle.Center.Y);
            rectanglePanel.BackColor = _unIntersect;

            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);

            UpdateListBoxes();
        }
        private void RemoveRectanglePictureBox_Click(object sender, EventArgs e)
        {
            if (_rectangles.Count > 0)
            {
                int rectangleIndex = AddingRectanglesListBox.SelectedIndex;
                _rectangles.RemoveAt(rectangleIndex);
                _rectanglePanels.RemoveAt(rectangleIndex);
                CanvasPanel.Controls.RemoveAt(rectangleIndex);
                UpdateListBoxes();
                FindCollisions();
            }
            if (_rectangles.Count == 0)
            {
                ClearRectangleInfo();
            }
        }
        
        private void AddingRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex != -1)
            {
                int rectangleIndex = AddingRectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[rectangleIndex];
                HeightSelectedRectangleTextBox.Text = _currentRectangle.Height.ToString();
                WidthSelectedRectangleTextBox.Text = _currentRectangle.Width.ToString();
                XSelectedRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
                YSelectedRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdSelectedRectangleTextBox.Text = _currentRectangle.Id.ToString();
            }
        }
        private void WidthSelectedRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Width = int.Parse(WidthSelectedRectangleTextBox.Text);
                WidthSelectedRectangleTextBox.BackColor = _currentBackColor;
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Width = _currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                WidthSelectedRectangleTextBox.BackColor = _errorBackColor;
            }
        }

        private void HeightSelectedRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Height = int.Parse(HeightSelectedRectangleTextBox.Text);
                HeightSelectedRectangleTextBox.BackColor = _currentBackColor;
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Height = _currentRectangle.Height;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                HeightSelectedRectangleTextBox.BackColor = _errorBackColor;
            }
        }

        private void XSelectedRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Center.X = int.Parse(XSelectedRectangleTextBox.Text);
                XSelectedRectangleTextBox.BackColor = _currentBackColor;
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                XSelectedRectangleTextBox.BackColor = _errorBackColor;
            }
        }

        private void YSelectedRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

            try
            {
                if (AddingRectanglesListBox.SelectedIndex >= 0)
                {
                    _currentRectangle.Center.Y = int.Parse(YSelectedRectangleTextBox.Text);
                    YSelectedRectangleTextBox.BackColor = _currentBackColor;
                    CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                    FindCollisions();
                    UpdateRectangleInfo(_currentRectangle);
                }
            }
            catch
            {
                YSelectedRectangleTextBox.BackColor = _errorBackColor;
            }
        }

        private void CanvasPanel_SizeChanged(object sender, EventArgs e)
        {
            canvasHeight = CanvasPanel.Height;
            canvasWidth = CanvasPanel.Width;
        }

        private void XRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.X = int.Parse(XRectangleTextBox.Text);
                XRectangleTextBox.BackColor = _currentBackColor;
            }
            catch
            {
                XRectangleTextBox.BackColor = _errorBackColor;
            }
        }

        private void YRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.Y = int.Parse(YRectangleTextBox.Text);
                YRectangleTextBox.BackColor = _currentBackColor;
            }
            catch
            {
                YRectangleTextBox.BackColor = _errorBackColor;
            }
        }
    }
}