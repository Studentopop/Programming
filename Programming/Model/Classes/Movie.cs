using System;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _durationMinutes;

        private int _releaseYear;

        private double _rating;

        public Movie()
        { }
      
        public string Name { get; set; }
        public int DurationMinutes
        {
            get
            {
                return _durationMinutes;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _durationMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException();
                }

                _releaseYear = value;
            }  
        }

        public string Genre { get; set; }
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value <= 0 || value > 10)
                {
                    throw new ArgumentException();
                }
                _rating = value;
            }
        }
        public Movie(string name, int durationminutes, int releaseyear, string genre, double rating)
        {
            Name = name;
            DurationMinutes = durationminutes;
            ReleaseYear = releaseyear;
            Genre = genre;
            Rating = rating;
        }
    }
}