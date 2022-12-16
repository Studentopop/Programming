using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Создаёт экзампляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;

                if (_items != null) //7
                {
                    ItemsListBox.Items.Clear();

                    for (var i = 0; i < _items.Count; i++)
                    {
                        ItemsListBox.Items.Add(_items[i].Name);
                    }
                }
            }
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

                if (value != null) //8
                {
                    CustomerComboBox.Items.Clear();

                    foreach (var customer in _customers)
                    {
                        CustomerComboBox.Items.Add(customer.Fullname);
                    }

                    CustomerComboBox.SelectedIndex = -1;
                }
            }
        }

        /// <summary>
        /// Обновляет информацию на вкладке <see cref="CartsTab"/>.
        /// </summary>
        public void RefreshData()
        {
            CustomerComboBox.Text = "";
            AmountLabel.Text = "0";
            ItemsListBox.Items.Clear();
            CustomerComboBox.Items.Clear();
            CartListBox.Items.Clear();

            for (var i = 0; i < _items.Count; i++)
            {
                ItemsListBox.Items.Add(_items[i].Name);
            }

            foreach (var customer in _customers)
            {
                CustomerComboBox.Items.Add(customer.Fullname);
            }

            if (CustomerComboBox.SelectedIndex != -1)
            {
                AmountLabel.Text =
                    Customers[CustomerComboBox.SelectedIndex].Cart.Amount.ToString();
            }
        }

        /// <summary>
        /// Обновляет лист бокс с корзиной.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateCartListBox(int index)
        {
            CartListBox.Items.Clear();

            foreach (var item in _currentCustomer.Cart.Items)
            {
                CartListBox.Items.Add(item.Name);
            }

            CartListBox.SelectedIndex = index;
            AmountLabel.Text = _currentCustomer.Cart.AmountToString();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex == -1)
                return;

            _currentCustomer = Customers[CustomerComboBox.SelectedIndex];

            UpdateCartListBox(-1);
        }

        private void AddButton_Click(object sender, EventArgs e) //10
        {
            if (CustomerComboBox.SelectedIndex != -1 &&
                 ItemsListBox.SelectedIndex != -1)
            {
                var item = Items[ItemsListBox.SelectedIndex];
                var items =
                    Customers[CustomerComboBox.SelectedIndex].Cart.Items;
                items.Add(item);
                CartListBox.Items.Add(item.Name);
                CartListBox.SelectedIndex = CartListBox.Items.Count - 1;
                AmountLabel.Text =
                    Customers[CustomerComboBox.SelectedIndex].Cart.Amount.ToString();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e) //10
        {
            if (CustomerComboBox.SelectedIndex != -1 &&
                CartListBox.SelectedIndex != -1)
            {
                int selectedIndex = CartListBox.SelectedIndex;
                var items =
                    Customers[CustomerComboBox.SelectedIndex].Cart.Items;
                items.RemoveAt(selectedIndex);
                CartListBox.Items.RemoveAt(selectedIndex);
                AmountLabel.Text =
                    Customers[CustomerComboBox.SelectedIndex].Cart.Amount.ToString();

                if (items.Count != 0)
                {
                    CartListBox.SelectedIndex = selectedIndex - 1;
                }
            }
        }


        private void CreateOrderButton_Click(object sender, EventArgs e) //12   
        {
            if (CustomerComboBox.SelectedIndex != -1 &&
                CartListBox.Items.Count != 0)
            {
                _currentCustomer = Customers[CustomerComboBox.SelectedIndex];

                var items = new List<Item>(_currentCustomer.Cart.Items);

                var amount = _currentCustomer.Cart.Amount;
                var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                var address = _currentCustomer.Address;
                var fullname = _currentCustomer.Fullname;
                var order = new Order(date, address, items, amount, fullname);
                _currentCustomer.Orders.Add(order);

                CartListBox.Items.Clear();
                AmountLabel.Text = "0";
                _currentCustomer.Cart.Items.Clear();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                CartListBox.Items.Clear();
                _currentCustomer = Customers[CustomerComboBox.SelectedIndex];
                _currentCustomer.Cart.Items.Clear();
                AmountLabel.Text = Customers[CustomerComboBox.SelectedIndex].Cart.Amount.ToString();
            }
        }
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
