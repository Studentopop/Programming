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
        private Contact _currentContact = new Contact();

        private List<Contact> _contacts = new List<Contact>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateContactInfo(Contact contact)
        {
            FullNameTextBox.Text = contact.FullName;
            dateTimePicker.Value = contact.DateOfBirth;
            PhoneTextBox.Text = contact.Phone;
            VKTextBox.Text = contact.VKcom;
        }

        private void ClearContactInfo()
        {
            FullNameTextBox.Clear();
            PhoneTextBox.Clear();
            VKTextBox.Clear();
            dateTimePicker.Value = DateTime.Today;
            FullNameTextBox.BackColor = AppColors.CorrectColor;
            PhoneTextBox.BackColor = AppColors.CorrectColor;
            VKTextBox.BackColor = AppColors.CorrectColor;
            dateTimePicker.BackColor = AppColors.CorrectColor;
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            var contact = new Contact("Full Name",
                DateTime.Today, "+70000000000", "https://vk.com/alisherbat");
            _contacts.Add(contact);
            ContactsListBox.Items.Add(contact.FullName);
            ContactsListBox.SelectedIndex = ContactsListBox.Items.Count - 1;
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentContact = _contacts[ContactsListBox.SelectedIndex];
                UpdateContactInfo(_currentContact);
            }
            catch
            {
                ClearContactInfo();
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentContact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _currentContact.DateOfBirth = dateTimePicker.Value;
                dateTimePicker.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                dateTimePicker.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentContact.Phone = PhoneTextBox.Text;
                PhoneTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                PhoneTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentContact.VKcom = VKTextBox.Text;
                VKTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                VKTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                int selectedIndex = ContactsListBox.SelectedIndex;
                _contacts.RemoveAt(selectedIndex);
                ContactsListBox.Items.RemoveAt(selectedIndex);
                if (_contacts.Count != 0)
                {
                    ContactsListBox.SelectedIndex = selectedIndex - 1;
                }
            }
        }
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            ContactsListBox.Items.Clear();
            _contacts = _contacts.OrderBy(contact => contact.FullName).ToList();
            foreach (var contact in _contacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
            ContactsListBox.SelectedIndex = ContactsListBox.Items.Count - 1;
        }
        private void DeleteContactButton_MouseEnter(object sender, EventArgs e)
        {

            DeleteContactButton.Image = ContactList.Properties.Resources.rectangle_remove_24x24;
        }

        private void DeleteContactButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteContactButton.Image = ContactList.Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = ContactList.Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = ContactList.Properties.Resources.rectangle_add_24x24;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializer.SaveToFile(_contacts);
        }
    }
}
