using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList.Model
{
    public class Contact
    {
        private string _fullName;

        private string _phone;

        private string _vk;

        private DateTime _dateOfBirth;

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

        public string VK
        {
            get
            {
                return _vk;
            }
            set
            {
                Validator.IsUrlLink(value, nameof(VK));
                Validator.AssertEmptyValue(value, nameof(VK));
                _vk = value;
            }
        }

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

        public Contact()
        {
            FullName = "FullName";
            Phone = "+79000000000";
            VK = "https://vk.com/user/";
            DateOfBirth = DateTime.Today;
        }

        public Contact(string fullname, DateTime dateofbirth, string phone, string vk)
        {
            FullName = fullname;
            DateOfBirth = dateofbirth;
            Phone = phone;
            VK = vk;
        }
    }
}
