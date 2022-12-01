using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Реализация представления покупателей.
    /// </summary>
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
        /// Создает экземпляр класса <see cref="CustomersTab"/>
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            _customers = Customers;
        }

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>  
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                UpdateListBox();
            }
        }


        /// <summary>
        /// Обновляет ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();
            for (int i = 0; i < _customers.Count; i++)
            {
                CustomersListBox.Items.Add(_customers[i].Fullname);
            }
        }

        /// <summary>
        /// На значение покупателя задаются параметры.
        /// </summary>
        /// <param name="сustomer"></param>
        /// <returns></returns>
        private string CustomerDescription(Customer сustomer)
        {
            return $"{сustomer.Fullname}";
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="customer"></param>
        private void UpdateCustomerInfo(Customer customer)
        {
            IDTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.Fullname.ToString();
            addressControl.Address = customer.Address;
            addressControl.UpdateAddressInfo();
        }

        /// <summary>
        ///Очищает информацию о покупателе.
        /// </summary>
        private void ClearCustomerInfo()
        {
            FullNameTextBox.Clear();
            IDTextBox.Clear();
            FullNameTextBox.BackColor = AppColors.NormalBackColor;
            CustomersListBox.Items.Clear();
            addressControl.Clear();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                if (_customers.Count > 0)
                {
                    CustomersListBox.SelectedIndex = 0;
                }
                else
                {
                    ClearCustomerInfo();
                }
                return;
            }
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            UpdateCustomerInfo(_currentCustomer);
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                FullNameTextBox.SelectionStart = FullNameTextBox.Text.Length;
                _currentCustomer.Fullname = FullNameTextBox.Text;
                FullNameTextBox.BackColor = AppColors.NormalBackColor;
                CustomersListBox.Items[CustomersListBox.SelectedIndex] =
                    FullNameTextBox.Text;
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorBackColor;
                return;
            }

            FullNameTextBox.BackColor = AppColors.NormalBackColor;
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
            if (CustomersListBox.Items.Count == 0)
            {
                return;
            }
            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
        }

        private void addressControl_Load(object sender, EventArgs e)
        {

        }
    }
}
