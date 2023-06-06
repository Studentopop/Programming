using System;
using System.Collections.Generic;
using System.Text;
using View.Model;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel, агрегирующий в себе класс <see cref="Model.Contact"/>.
    /// </summary>
    public class ContactVM : ObservableObject, ICloneable, IDataErrorInfo
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact"></param>
        public ContactVM(Contact contact)
        {
            Contact = contact;
        }

        /// <summary>
        /// Возвращает и задает объект класса <see cref="Model.Contact"/>.
        /// </summary>
        public Contact Contact { get; set; }

        private bool _isNameValid;

        private bool _isPhoneValid;

        private bool _isApplyEnabled;
        /// <summary>
        /// Возвращает или задает значение, указывающее, является ли поле "Phone" валидным.
        /// </summary>
        public bool IsNameValid
        {
            get { return _isNameValid; }
            set { SetProperty(ref _isNameValid, value); }
        }

        /// <summary>
        /// Возвращает или задает значение, указывающее, является ли поле "Phone" валидным.
        /// </summary>
        public bool IsPhoneValid
        {
            get { return _isPhoneValid; }
            set { SetProperty(ref _isPhoneValid, value); }
        }

        private bool _isEmailValid;

        /// <summary>
        /// Возвращает или задает значение, указывающее, является ли поле "Email" валидным.
        /// </summary>
        public bool IsEmailValid
        {
            get { return _isEmailValid; }
            set { SetProperty(ref _isEmailValid, value); }
        }

        /// <summary>
        /// Возвращает или задает значение, указывающее, доступна ли кнопка "Apply".
        /// </summary>
        public bool IsApplyEnabled
        {
            get { return _isApplyEnabled; }
            set { SetProperty(ref _isApplyEnabled, value); }
        }

        /// <summary>
        /// Возвращает и получает имя контакта.
        /// </summary>
        [StringLength(100, ErrorMessage = "Name should not exceed 100 characters.")]

        public string Name
        {
            get
            {
                return Contact.Name;
            }
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof(Name));

            }
        }

        /// <summary>
        /// Возвращает и получает телефон контакта.
        /// </summary>
        [StringLength(100, ErrorMessage = "Phone number should not exceed 100 characters.")]
        [RegularExpression(@"^[0-9+\-() ]*$", ErrorMessage = "Phone number can only contain digits, plus, minus, parentheses, and spaces.")]
        public string Phone
        {
            get
            {
                return Contact.Phone;
            }
            set
            {
                Contact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        /// <summary>
        /// Возвращает и получает электронную почту контакта.
        /// </summary>
        [StringLength(100, ErrorMessage = "Email should not exceed 100 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Создает клон объекта.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactVM"/>.</returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }
        public string this[string columnName]
        {
            get
            {
                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(this, null, null) { MemberName = columnName };
                Validator.TryValidateProperty(GetType().GetProperty(columnName)?.GetValue(this), validationContext, validationResults);

                if (validationResults.Any())
                {
                    return validationResults.First().ErrorMessage;
                }

                return null;
            }
        }

        public string Error
        {
            get
            {
                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(this, null, null);
                Validator.TryValidateObject(this, validationContext, validationResults, true);

                if (validationResults.Any())
                {
                    return string.Join(Environment.NewLine, validationResults.Select(r => r.ErrorMessage));
                }

                return null;
            }
        }

    }
}
