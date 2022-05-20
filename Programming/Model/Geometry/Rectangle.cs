﻿using System;
namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _allRectanglesCount;

        private int _height;

        private int _width;

        private int _id;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Height), value);
                _height = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public int Id
        {
            get
            {
                return _id;
            }
        }
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        public Rectangle(double height, double width, string color, Point2D center)
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
            Height = (int)height;
            Width = (int)width;
            Color = color;
            Center = center;
        }

        public Rectangle(double length, double width)
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public override string ToString()
        {
            return $"Rectangle {_allRectanglesCount}";
        }

        public string GetRectangleInfo()
        {
            return $"{_id}: (X={Center.X}; Y={Center.Y}; W={_width}; L={_height})";
        }
    }
}