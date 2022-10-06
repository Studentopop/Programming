using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контактных данных человека.
    /// </summary>
    public class Contact
    {

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _number;

        /// <summary>
        /// Имя человека.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        private string _surname;

        /// <summary>
        ///  Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="number">Номер телефона . Должен состоять из цифр.
        /// Длина 11 символов.</param>
        /// <param name="name">Имя. Должно состоять из букв.</param>
        /// <param name="surname">Фамилия. Должна состоять из букв.</param>
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона человека. Должен состоять из цифр. 
        /// Длина номера телефона  11 символов.
        /// </summary>
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException();
                }
                if (!int.TryParse(value, out _))
                {
                    throw new ArgumentException();
                }
                _number = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя человека. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию человека. Должно состоять только из букв.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }
    }
}