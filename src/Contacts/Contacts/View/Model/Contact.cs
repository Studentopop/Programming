﻿using System;
using System.Collections.Generic;
using System.Text;

namespace View.Model
{
    public class Contact
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="email">Электронная почта.</param>
        /// <param name="phone">Номер телефона.</param>
        public Contact(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возвращает и задаёт электронную почту контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Возвращает копию экземпляра класса <see cref="Contact"/>
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Contact(Name, Email, Phone);
        }
    }
}
