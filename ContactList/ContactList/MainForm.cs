using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ContactList.Model;

namespace ContactList
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список контактов.
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// Текст поиска.
        /// </summary>
        private string _searchText;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _contacts = Serializer.LoadFromFile();
            UpdateListBox(-1);
        }

        /// <summary>
        /// Организует поиск полей у объектов, удовлетворяющих введенному в строку значению.
        /// </summary>
        /// <param name="searchText">Строка по которой нужно искать.</param>
        /// <returns>Список объектов подходящих под введенную строку.</returns>
        private List<Contact> SearchContacts()
        {
            var result = from contact in _contacts
                         where contact.FullName.Contains(_searchText)
                         select contact;

            return result.ToList();
        }

        /// <summary>
        /// Сортировка _contacts.
        /// </summary>
        private void SortFullName()
        {
            _contacts = (from Contact in _contacts
                         orderby Contact.FullName
                         select Contact).ToList();
        }

        /// <summary>
        /// Очищает поля для вывода информации.
        /// </summary>
        private void ClearContactInfo()
        {
            ContactsListBox.SelectedIndex = -1;
            FullNameTextBox.Clear();
            PhoneTextBox.Clear();
            VKTextBox.Clear();
            DateofBirthTimePicker.Value = DateTime.Today;
        }

        /// <summary>
        /// Обновляет данные в списке ContactsListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            List<Contact> contacts;

            ContactsListBox.Items.Clear();

            if (_searchText != "" && _searchText != null) contacts = SearchContacts();
            else contacts = _contacts;

            foreach (var contact in contacts)
            {
                if (contact.FullName != null)
                {
                    ContactsListBox.Items.Add(contact.FullName);
                }
            }

            if (-1 <= index && index < ContactsListBox.Items.Count)
                ContactsListBox.SelectedIndex = index;
        }

        private void AddContactPictureBox_Click(object sender, EventArgs e)
        {
            var contact = new Contact();
            _contacts.Add(contact);
            SortFullName();
            UpdateListBox(_contacts.IndexOf(contact));
        }

        private void DeleteContactPictureBox_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1) return;

            _contacts.RemoveAt(ContactsListBox.SelectedIndex);

            if (_contacts.Count == 0)
            {
                UpdateListBox(-1);
                ClearContactInfo();
            }
            else
            {
                UpdateListBox(0);

            }
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1) return;

            if (_searchText == "" || _searchText == null)
                _currentContact = _contacts[ContactsListBox.SelectedIndex];
            else
                _currentContact = SearchContacts()[ContactsListBox.SelectedIndex];

            FullNameTextBox.Text = _currentContact.FullName;
            PhoneTextBox.Text = _currentContact.Phone;
            VKTextBox.Text = _currentContact.VK;
            DateofBirthTimePicker.Value = _currentContact.DateOfBirth;
        }
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1) return;

            try
            {
                _currentContact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = AppColors.NormalBackColor;
                SortFullName();
                UpdateListBox(_contacts.IndexOf(_currentContact));
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorBackColor;
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1) return;

            try
            {
                _currentContact.Phone = (PhoneTextBox.Text);
                PhoneTextBox.BackColor = AppColors.NormalBackColor;
                SortFullName();
                UpdateListBox(_contacts.IndexOf(_currentContact));
            }
            catch
            {
                PhoneTextBox.BackColor = AppColors.ErrorBackColor;
            }
        }
        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1) return;

            try
            {
                _currentContact.VK = VKTextBox.Text;
                VKTextBox.BackColor = AppColors.NormalBackColor;
                SortFullName();
                UpdateListBox(_contacts.IndexOf(_currentContact));
            }
            catch
            {
                VKTextBox.BackColor = AppColors.ErrorBackColor;
            }
        }

        private void DateofBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1) return;

            try
            {
                _currentContact.DateOfBirth = DateofBirthTimePicker.Value;
                DateofBirthTimePicker.BackColor = AppColors.NormalBackColor;
                SortFullName();
                UpdateListBox(_contacts.IndexOf(_currentContact));
            }
            catch
            {
                DateofBirthTimePicker.BackColor = AppColors.ErrorBackColor;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            _searchText = SearchTextBox.Text;
            ClearContactInfo();
            UpdateListBox(-1);
        }
        private void AddContactPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddContactPictureBox.Image = 
                Properties.Resources.plus_active;
        }

        private void AddContactPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddContactPictureBox.Image =
                Properties.Resources.plus;
        }

        private void DeleteContactPictureBox_MouseLeave(object sender, EventArgs e)
        {
            DeleteContactPictureBox.Image = 
                Properties.Resources.cancel;
        }

        private void DeleteContactPictureBox_MouseEnter(object sender, EventArgs e)
        {
            DeleteContactPictureBox.Image = 
                Properties.Resources.cancel_active;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.SaveToFile(_contacts);
        }
    }
}
