using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Уникальный индетификатор.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес.
        /// </summary>
        private string _address;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя. Длина строки должна быть 
        ///                        не больше 200 символов.</param>
        /// <param name="adress">Адрес. Длина строки должна быть не больше 500 символов.</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/> по-умолчанию.
        /// </summary>
        public Customer()
        {
            Fullname = "";
            Address = "";
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
