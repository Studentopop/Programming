using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Предоставляет методы для обработки адресов.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Только для чтения.
        /// </summary>
        private bool _readOnly;

        /// <summary>
        /// Возращает и задает адрес.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт значение, указывающее, может ли 
        /// пользователь изменять данные в элементе управления.
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return _readOnly;
            }
            set
            {
                _readOnly = value;

                if (value)
                {
                    PostIndexTextBox.ReadOnly = true;
                    CountryTextBox.ReadOnly = true;
                    CityTextBox.ReadOnly = true;
                    StreetTextBox.ReadOnly = true;
                    BuildingTextBox.ReadOnly = true;
                    ApartmentTextBox.ReadOnly = true;
                }
            }
        }


        /// <summary>
        /// Создает экземпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о адресе в текстовых полях.
        /// </summary>
        public void UpdateAddressInfo()
        {
            PostIndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }

        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
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

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = Convert.ToInt32(PostIndexTextBox.Text);
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

        private void AddressControl_Load(object sender, EventArgs e)
        {

        }
    }
}