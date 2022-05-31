namespace Programming.Model.Classes
{

    /// <summary>
    /// Хранит информацию о дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Возвращает и задаёт имя преподавателя.
        /// </summary>
        private string _firstname;

        /// <summary>
        /// Возвращает и задаёт имя преподавателя.
        /// </summary>
        private string _lastname;

        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        private string _name;

        public Subject()
        { }


        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="firstname">Имя преподавателя.</param>
        /// <param name="lastname">Фамилия преподавателя.</param>
        public Subject(string name, string firstname, string lastname)
        {
            Name = name;
            Lastname = lastname;
            Firstname = firstname;
        }

        /// <summary>
        /// Возвращает и задаёт название дисциплины.
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
        /// Возвращает и задаёт имя преподавателя.
        /// </summary>
        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Firstname));
                _firstname = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт фамилию преподавателя.
        /// </summary>
        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Lastname));
                _lastname = value;
            }
        }

    }
}
