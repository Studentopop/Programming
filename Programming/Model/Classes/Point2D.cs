﻿namespace Programming.Model.Classes
{
    public class Point2D
    {
        private int _x;

        private int _y;

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get
            {
                return _x;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }
    }
}