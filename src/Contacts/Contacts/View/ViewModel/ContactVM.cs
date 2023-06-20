using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel, агрегирующий в себе класс <see cref="Model.Contact"/>
    /// </summary>
    public class ContactVM : ObservableValidator, ICloneable
    {
        /// <summary>
        /// Возвращает и получает объект класса <see cref="Model.Contact"/>
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Возвращает и получает имя контакта.
        /// </summary>
        [StringLength(100, ErrorMessage = "Name should not exceed 100 characters.")]
        public string Name
        {
            get => Contact.Name;
            set => SetProperty(Contact.Name, value, Contact, (contact, name) => Contact.Name = name, true);
        }

        /// <summary>
        /// Возвращает и получает телефон контакта.
        /// </summary>
        [StringLength(100, ErrorMessage = "Phone number should not exceed 100 characters.")]
        [RegularExpression(@"^[0-9+\-() ]*$", ErrorMessage = 
            "Phone number can only contain digits, plus, minus, parentheses, and spaces.")]
        public string Phone
        {
            get => Contact.Phone;
            set => SetProperty(Contact.Phone, value, Contact, (contact, phone) =>
            Contact.Phone = phone, true);
        }

        /// <summary>
        /// Возвращает и получает электронную почту контакта.
        /// </summary>
        [StringLength(100, ErrorMessage = "Email should not exceed 100 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email
        {
            get => Contact.Email;
            set => SetProperty(Contact.Email, value, Contact, (contact, email) => Contact.Email = email, true);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact">Объект класса <see cref="Model.Contact"/>.</param>
        public ContactVM(Contact contact)
        {
            Contact = contact;
        }

        /// <summary>
        /// Создает копию объекта.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactVM"/>.</returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }
    }
}