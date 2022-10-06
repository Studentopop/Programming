using System;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Geometry;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению прямоугольников.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Количество элементов.
        /// </summary>
        private int _rectanglesAmount = 5;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectanglesControl"/>.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = CreateRectangles();
            RectanglesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Инициализирует коллекцию прямоугольников.
        /// </summary>
        /// <returns>Возвращает коллекцию прямоугольников.</returns>
        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[_rectanglesAmount];
            for (int i = 0; i < _rectanglesAmount; i++)
            {
                _currentRectangle = RectangleFactory.Randomize();
                rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            return rectangles;
        }

        /// <summary>
        /// Находит прямоугольник у которой ширина больше остальных.
        /// </summary>
        /// <param name="rectangles">Прямоугольник.</param>
        /// <returns>Индекс элемента коллекции, чья ширина больше остальных.</returns>
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedRectangle];
            RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
            YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
            if (CollisionManager.IsCollision(_rectangles[0], _rectangles[1]))
            {
                CollisionTextBox.Text = " True";
            }
            else
            {
                CollisionTextBox.Text = " False";
            }
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleHeightTextBox.BackColor = AppColors.CurrentBackColor;
            try
            {
                _currentRectangle.Height = int.Parse(RectangleHeightTextBox.Text);
            }
            catch
            {
                RectangleHeightTextBox.BackColor = AppColors.ErrorBackColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleWidthTextBox.BackColor = AppColors.CurrentBackColor;
            try
            {
                _currentRectangle.Width = int.Parse(RectangleWidthTextBox.Text);
            }
            catch
            {
                RectangleWidthTextBox.BackColor = AppColors.ErrorBackColor;
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
        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Height = int.Parse(RectangleHeightTextBox.Text);
                RectangleHeightTextBox.BackColor = AppColors.CurrentBackColor; 
            }
            catch
            {
                RectangleHeightTextBox.BackColor = AppColors.ErrorBackColor; 
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(RectangleWidthTextBox.Text);
                RectangleWidthTextBox.BackColor = AppColors.CurrentBackColor;
            }
            catch
            {
                RectangleWidthTextBox.BackColor = AppColors.ErrorBackColor; 
            }
        }
       
        private void XRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.X = int.Parse(XRectangleTextBox.Text);
                XRectangleTextBox.BackColor = AppColors.CurrentBackColor;
            }
            catch
            {
                XRectangleTextBox.BackColor = AppColors.ErrorBackColor; 
            }
        }

        private void YRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.Y = int.Parse(YRectangleTextBox.Text);
                YRectangleTextBox.BackColor = AppColors.CurrentBackColor;
            }
            catch
            {
                YRectangleTextBox.BackColor = AppColors.ErrorBackColor; 
            }
        }
        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void IdRectangleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CollisionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RectangleFindButton_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
