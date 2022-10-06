using System;

namespace Programming.Model.Classes
{

    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {

        /// <summary>
        /// Длительность фильма в минутах.
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Год релиза фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задаёт название.
        /// </summary>
        public string Name { get; set; }
        public int DurationMinutes
        {
            get
            {
                return _durationMinutes;
            }
            set
            {
                Validator.AssertValueInRange(value, 10, 500, nameof(DurationMinutes));
                _durationMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год выпуска. Число в диапазоне от 1900 до 2022.
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, 2022, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Число в диапазоне от 0 до 10.
        /// </summary>
        public double Rating 
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }


        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="durationminutes">Длительность фильма в минутах.</param>
        /// <param name="releaseyear">Год релиза фильма. Число в диапазоне от 1900 до 2022.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма. Число в диапазоне от 0 до 10.</param>
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