using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        private Store _store ;
        public MainForm()
        {
            InitializeComponent();
            _store = new Store();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            OrdersTab.Customers = _store.Customers;

        }

        private void ItemsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ItemsTabControl.SelectedIndex)
            {
                case 2:
                    {
                        CartsTab.Customers = _store.Customers;
                        CartsTab.Items = _store.Items;
                        CartsTab.RefreshData();
                        break;
                    }
                case 3:
                    {
                        OrdersTab.Customers = _store.Customers;
                        OrdersTab.RefreshData();
                        break;
                    }
            }
        }
    }
}
