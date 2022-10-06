using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Реализация представления класса <see cref="Customer"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// На значение товара задаются параметры.
        /// </summary>
        /// <param name="Customer"></param>
        /// <returns></returns>
        private string CustomerDescription(Customer сustomer)
        {
            return $"{сustomer.Id}: - {сustomer.Fullname}";
        }
        private void UpdateCustomerInfo(Customer customer)
        {
            int indexSelectedCustomer = CustomersListBox.SelectedIndex;

            if (indexSelectedCustomer == -1) return;

            CustomersListBox.Items[indexSelectedCustomer] 
                = CustomerDescription(customer);
        }

        /// <summary>
        ///Очищает информацию о товаре.
        /// </summary>
        private void ClearCustomerInfo()
        {
            FullNameTextBox.Clear();
            AddressTextBox.Clear();
            IDTextBox.Clear();
            FullNameTextBox.BackColor = AppColor.CorrectColor;
            AddressTextBox.BackColor = AppColor.CorrectColor;
            CustomersListBox.Items.Clear();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int indexSelectedCustomer = CustomersListBox.SelectedIndex;
                _currentCustomer = _customers[indexSelectedCustomer];
                FullNameTextBox.Text = _currentCustomer.Fullname;
                AddressTextBox.Text = _currentCustomer.Address;
                IDTextBox.Text = _currentCustomer.Id.ToString();
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                _currentCustomer.Fullname = FullNameTextBox.Text;
                UpdateCustomerInfo(_currentCustomer);
            }
            catch
            {
                FullNameTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            FullNameTextBox.BackColor = AppColor.CorrectColor;
        }
        
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                _currentCustomer.Address = AddressTextBox.Text;
                UpdateCustomerInfo(_currentCustomer);
            }
            catch
            {
                AddressTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            AddressTextBox.BackColor = AppColor.CorrectColor;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(CustomerDescription(_currentCustomer));
            CustomersListBox.SelectedIndex = _customers.Count - 1;
            UpdateCustomerInfo(_currentCustomer);
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            _customers.RemoveAt(index);
            ClearCustomerInfo();

            foreach (var Customer in _customers)
            {
                CustomersListBox.Items.Add(CustomerDescription(Customer));
                CustomersListBox.SelectedIndex = 0;
            }

            UpdateCustomerInfo(_currentCustomer);
        }
    }
}
