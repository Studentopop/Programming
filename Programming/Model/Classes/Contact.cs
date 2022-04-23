using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private const int _phoneLength = 11;
        private string _number;
        private string _name;
        private string _surname;

        public Contact()
        { }

        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

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