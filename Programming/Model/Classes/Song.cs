namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Длительность песни.
        /// </summary>
        private int _durationMinutes;


        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название песни.</param>
        /// <param name="durationminutes">Длительность песни в секундах. Положительное число.</param>
        public Song(string name, int durationminutes)
        {
            Name = name;
            DurationMinutes = durationminutes;
        }


        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт автора песни.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задаёт длительность песни . Положительное число.
        /// </summary>
        public int DurationMinutes
        {
            get
            {
                return _durationMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationMinutes),value);
                _durationMinutes = value;
            }
        }
    }
}