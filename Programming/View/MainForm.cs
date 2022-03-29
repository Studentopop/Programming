using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private string[] _colors = { "Red", "Black", "Green", "Yellow", "Orange" };
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private Movie[] _movies;
        private Movie _currentMovie;
        private int _rectanglesAmount = 5;
        private int _moviesAmount = 5;
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexOfMaxWidth = 0;
            double max = 0;
            for (int i = 0; i < _rectanglesAmount; i++)
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
            for (int i = 0; i < _moviesAmount; i++)
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

            foreach (Enums enumsValues in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(enumsValues);
            }

            EnumsListBox.SelectedIndex = 0;
            var values = Enum.GetValues(typeof(Seasons));

            foreach (var value in values)
            {
                ChooseSeasonBox.Items.Add(value);
            }
            //second page
            _rectangles = new Rectangle[_rectanglesAmount];
            var rand = new Random();
            double length, width;
            for (int i = 0; i < 5; i++)
            {
                length = Math.Round(rand.NextDouble() * 100, 1);
                width = Math.Round(rand.NextDouble() * 100, 1);
                _rectangles[i] = new Rectangle(length, width, _colors[rand.Next(_colors.Length)]);
                RectanglesListBox.Items.Add("Rectangle " + (i + 1));
            }
            RectanglesListBox.SelectedIndex = 0;

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
            IntBox.Text = ((int)item).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
          
            var text = ParseTextBox.Text;
            Weekday day;

            if (Enum.TryParse(text, out day))
            {
                OutLabel.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                OutLabel.Text = "Нет такого дня недели!";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var item = ChooseSeasonBox.SelectedItem;

            switch (item)
            {
                case Seasons.Winter:
                    SeasonHandleGroupBox.BackColor = Color.White;
                    MessageBox.Show("Бррр! Холодно!", "Погода", MessageBoxButtons.OK);
                    break;
                case Seasons.Spring:
                    SeasonHandleGroupBox.BackColor = Color.LightGreen;
                    break;
                case Seasons.Summer:
                    SeasonHandleGroupBox.BackColor = Color.White;
                    MessageBox.Show("Ура! Солнце!", "Погода", MessageBoxButtons.OK);
                    break;
                case Seasons.Autumn:
                    SeasonHandleGroupBox.BackColor = Color.Orange;
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
