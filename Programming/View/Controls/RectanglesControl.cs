using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Programming.Model.Classes;
using SystemColor = System.Drawing.Color;
using Rectangle = Programming.Model.Classes.Rectangle;
using Programming.Model.Geometry;

namespace Programming.View.Controls
{
    public partial class RectanglesControl : UserControl
    {
        private string[] _colors = { "Red", "Black", "Green", "Yellow", "Orange" };

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        private int _rectanglesAmount = 5;

        public RectanglesControl()
        {

            InitializeComponent();
            _rectangles = new Rectangle[_rectanglesAmount];
            var rand = new Random();
            double height, width;
            int centerX, centerY;
            for (int i = 0; i < 5; i++)
            {
                height = Math.Round(rand.NextDouble() * 100, 1);
                width = Math.Round(rand.NextDouble() * 100, 1);
                centerX = rand.Next(10);
                centerY = rand.Next(10);
                Random r = new Random();
                _rectangles[i] = new Rectangle(height, width, _colors[r.Next(0, _colors.Length)], new Point2D(centerX, centerY));
                RectanglesListBox.Items.Add("Rectangle " + (i + 1));
            }

            RectanglesListBox.SelectedIndex = 0;
        }
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
            RectangleHeightTextBox.BackColor = AppColors.currentBackColor;
            try
            {
                _currentRectangle.Height = int.Parse(RectangleHeightTextBox.Text);
            }
            catch
            {
                RectangleHeightTextBox.BackColor = AppColors.errorBackColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleWidthTextBox.BackColor = AppColors.currentBackColor;
            try
            {
                _currentRectangle.Width = int.Parse(RectangleWidthTextBox.Text);
            }
            catch
            {
                RectangleWidthTextBox.BackColor = AppColors.errorBackColor;
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
                RectangleHeightTextBox.BackColor = AppColors.currentBackColor; 
            }
            catch
            {
                RectangleHeightTextBox.BackColor = AppColors.errorBackColor; 
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(RectangleWidthTextBox.Text);
                RectangleWidthTextBox.BackColor = AppColors.currentBackColor;
            }
            catch
            {
                RectangleWidthTextBox.BackColor = AppColors.errorBackColor; 
            }
        }
       
        private void XRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.X = int.Parse(XRectangleTextBox.Text);
                XRectangleTextBox.BackColor = AppColors.currentBackColor;
            }
            catch
            {
                XRectangleTextBox.BackColor = AppColors.errorBackColor; 
            }
        }

        private void YRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.Y = int.Parse(YRectangleTextBox.Text);
                YRectangleTextBox.BackColor = AppColors.currentBackColor;
            }
            catch
            {
                YRectangleTextBox.BackColor = AppColors.errorBackColor; 
            }
        }
        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
