using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Rectangle;
using Programming.Model.Geometry;
using SystemColor = System.Drawing.Color;

namespace Programming.View.Controls
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private Rectangle _currentRectangle;

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private List<Panel> _rectanglePanels = new List<Panel>();

        public int canvasWidth;

        public int canvasHeight;
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void UpdateListBoxes()
        {
            AddingRectanglesListBox.Items.Clear();

            for (int i = 0; i < _rectangles.Count; i++)
            {
                AddingRectanglesListBox.Items.Add(_rectangles[i].GetRectangleInfo());
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
        }
        private void FindCollisions()
        {

            for (int n = 0; n < _rectangles.Count; n++)
            {
                CanvasPanel.Controls[n].BackColor = AppColors.NotCollisionColor;
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

                        CanvasPanel.Controls[i].BackColor = AppColors.CollisionColor;
                        CanvasPanel.Controls[j].BackColor = AppColors.CollisionColor;
                    }
                }
            }
        }
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = AddingRectanglesListBox.FindString(rectangle.Id.ToString());
            AddingRectanglesListBox.Items[index] = rectangle.GetRectangleInfo();
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

       

        private void AddRectanglePictureBox_Click(object sender, EventArgs e)
        {
            var newRectangle = RectangleFactory.Randomize();
            _rectangles.Add(newRectangle);

            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = newRectangle.Width;
            rectanglePanel.Height = newRectangle.Height;
            rectanglePanel.Location = 
                new Point(newRectangle.Center.X, newRectangle.Center.Y);
            rectanglePanel.BackColor = AppColors.NotCollisionColor;

            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);

            UpdateListBoxes();
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
                WidthSelectedRectangleTextBox.BackColor = AppColors.CurrentBackColor;
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Width =
                    _currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                WidthSelectedRectangleTextBox.BackColor = AppColors.ErrorBackColor;
            }
        }

        private void HeightSelectedRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Height = int.Parse(HeightSelectedRectangleTextBox.Text);
                HeightSelectedRectangleTextBox.BackColor = AppColors.CurrentBackColor; 
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Height =
                    _currentRectangle.Height;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                HeightSelectedRectangleTextBox.BackColor = AppColors.ErrorBackColor;
            }
        }

        private void XSelectedRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectanglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Center.X = int.Parse(XSelectedRectangleTextBox.Text);
                XSelectedRectangleTextBox.BackColor = AppColors.CurrentBackColor;
                CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                XSelectedRectangleTextBox.BackColor = AppColors.ErrorBackColor;
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
                    YSelectedRectangleTextBox.BackColor = AppColors.CurrentBackColor;
                    CanvasPanel.Controls[AddingRectanglesListBox.SelectedIndex].Location =
                        new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                    FindCollisions();
                    UpdateRectangleInfo(_currentRectangle);
                }
            }
            catch
            {
                YSelectedRectangleTextBox.BackColor =  AppColors.ErrorBackColor;
            }
        }

        private void CanvasPanel_SizeChanged(object sender, EventArgs e)
        {
            canvasHeight = CanvasPanel.Height;
            canvasWidth = CanvasPanel.Width;
        }
        private void AddRectanglePictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddRectanglePictureBox.BackgroundImage =
                Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectanglePictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddRectanglePictureBox.BackgroundImage =
                Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void AddRectanglePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            AddRectanglePictureBox.BackColor = SystemColor.LightGray;
        }

        private void AddRectanglePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            AddRectanglePictureBox.BackColor = SystemColor.White;
        }
        private void RemoveRectanglePictureBox_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectanglePictureBox.BackgroundImage =
                Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectanglePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectanglePictureBox.BackgroundImage =
                Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RemoveRectanglePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            RemoveRectanglePictureBox.BackColor = SystemColor.LightGray;
        }
        private void RemoveRectanglePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            RemoveRectanglePictureBox.BackColor = SystemColor.White;
        }

        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
