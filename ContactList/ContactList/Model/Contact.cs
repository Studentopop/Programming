using System;
using ContactsApp.Model;

namespace ContactList.Model
{
    public class Contact
    {
        private string _fullname;

        private string _vkcom;

        private string _phone;

        private DateTime _dateOfBirth;

        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
            }
        }

        public string VKcom
        {
            get
            {
                return _vkcom;
            }
            set
            {
               // Validator.AssertValueInRange(value.Length, 1, 100, nameof(VKcom));
                _vkcom = value;
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
                _phone = value;
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
                _dateOfBirth = value;
            }
        }

        public Contact()
        {
        }
        public Contact(string fullName, DateTime dateOfBirth, string phone, string vkcom)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            VKcom = vkcom;
        }
    }
}
