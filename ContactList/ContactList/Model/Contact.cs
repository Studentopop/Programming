using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Полное имя контакта.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Ссылка на страницу VK контакта.
        /// </summary>
        private string _vk;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// Возвращает и задает полное имя контакта.
        /// Должно состоять только из букв. Длина не более 150 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                Validator.AssertLengthString(value, 150, nameof(FullName));
                Validator.AssertEmptyValue(value, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// Должен начинаться с "+" и содержать 11 цифр.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                Validator.IsPhoneNumber(value, nameof(Phone));
                Validator.AssertEmptyValue(value, nameof(Phone));
                _phone = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ссылку на VK контакта.
        /// Должна быть ссылкой на страницу ползователя VK.
        /// </summary>
        public string VK
        {
            get
            {
                return _vk;
            }
            set
            {
                Validator.AssertLengthString(value, 150, nameof(VK));
                Validator.IsUrlLink(value, nameof(VK));
                Validator.AssertEmptyValue(value, nameof(VK));
                _vk = value;
            }
        }

        /// <summary>
        /// Возвращает и задает дату рождения контакта.
        /// Не должна быть больше текущего дня.
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                Validator.AssertValueInRange(value, DateTime.Now, nameof(DateOfBirth));
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
            FullName = "FullName";
            Phone = "+79000000000";
            VK = "https://vk.com/";
            DateOfBirth = DateTime.Today;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="fullname">Полное имя контакта.</param>
        /// <param name="dateofbirth">Дата рождения контакта.</param>
        /// <param name="phone">Номер телефона контакта.</param>
        /// <param name="vk">Ссылка на страницу VK контакта.</param>
        public Contact(string fullname, DateTime dateofbirth, string phone, string vk)
        {
            FullName = fullname;
            DateOfBirth = dateofbirth;
            Phone = phone;
            VK = vk;
        }

    }
}
