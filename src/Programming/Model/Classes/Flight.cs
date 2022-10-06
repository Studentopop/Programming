using System;

namespace Programming.Model.Classes
{

    /// <summary>
    /// Хранит данные о полёте.
    /// </summary>
    public class Flight
    {

        /// <summary>
        /// Время полёта в минутах.
        /// </summary>
        private int _flightTimeMinutes;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>
        /// </summary>
        /// <param name="departure">Пункт отправления.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="flightTimeMinutes">Время полёта в минутах. Положительное число.</param>
        public Flight(string departure, string destination, int flightTimeMinutes)
        {
            Departure = departure;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
        }

        /// <summary>
        /// Возвращает и задаёт пункт отправления.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает и задаёт пункт прибытия.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задаёт время полёта в минутах.
        /// </summary>
        public int FlightTimeMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _flightTimeMinutes = value;
            }
        }
    }
}
