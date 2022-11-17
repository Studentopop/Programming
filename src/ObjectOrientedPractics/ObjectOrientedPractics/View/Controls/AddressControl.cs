using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();

        public AddressControl()
        {

            InitializeComponent();
        }

        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                UpdateAddressInfo();
            }
        }
        public void UpdateAddressInfo()
        {
            PostIndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(PostIndexTextBox.Text);
                _address.Index = index;
            }
            catch
            {
                PostIndexTextBox.BackColor = AppColors.ErrorBackColor;
                return;
            }

            PostIndexTextBox.BackColor = AppColors.NormalBackColor;
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = AppColors.ErrorBackColor;
                return;
            }

            CountryTextBox.BackColor = AppColors.NormalBackColor;
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = AppColors.ErrorBackColor;
                return;
            }

            CityTextBox.BackColor = AppColors.NormalBackColor;
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor = AppColors.ErrorBackColor;
                return;
            }

            StreetTextBox.BackColor = AppColors.NormalBackColor;
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor = AppColors.ErrorBackColor;
                return;
            }

            BuildingTextBox.BackColor = AppColors.NormalBackColor;
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = AppColors.ErrorBackColor;
                return;
            }

            ApartmentTextBox.BackColor = AppColors.NormalBackColor;
        }

        public void Clear()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();

            PostIndexTextBox.BackColor = AppColors.NormalBackColor;
        }
    }
}
