using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов этого класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Общее количество покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
            Fullname = "Full Name";
            Address = "Address";
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя. Длина строки должна быть 
        ///                        не больше 200 символов.</param>
        /// <param name="address">Адрес. Длина строки должна быть не больше 500 символов.</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаёт полное имя. 
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                Validator.AssertLengthString(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес. 
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validator.AssertLengthString(value, 500, nameof(Address));
                _address = value;
            }
        }
    }
}
