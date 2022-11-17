using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о адресе.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Фиксированная длина почтового индекса.
        /// </summary>
        private readonly int _indexLength = 6;

        /// <summary>
        /// Максимальное количество символов в стране/регионе.
        /// </summary>
        private readonly int _maxSymbolsInCountry = 50;

        /// <summary>
        /// Максимальное количество символов в городе (населенном пункте).
        /// </summary>
        private readonly int _maxSymbolsInCity = 50;

        /// <summary>
        /// Максимальное количество символов в улице.
        /// </summary>
        private readonly int _maxSymbolsInStreet = 100;

        /// <summary>
        /// Максимальное количество символов в номере дома.
        /// </summary>
        private readonly int _maxSymbolsInBuilding = 10;

        /// <summary>
        /// Максимальное количество символов в номере квартиры/помещения.
        /// </summary>
        private readonly int _maxSymbolsInApartment = 10;

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населенный пункт).
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "None";
            City = "None";
            Street = "None";
            Building = "None";
            Apartment = "None";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index"> Почтовый индекс.
        /// Длина должна быть целым шестизначным числом.</param>
        /// <param name="country">Страна/регион. Длина не более 50 символов.</param>
        /// <param name="city">Город (населенный пункт). Длина не более 50 символов.</param>
        /// <param name="street">Улица. Длина не более 100 символов.</param>
        /// <param name="building">Номер дома. Длина не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещенияю. Длина не более 10 символов.</param>
        public Address(int index, string country, string city,
                       string street, string apartment, string building)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Возвращает и задает почтовый индекс.
        /// Длина должна быть целым шестизначным числом.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                Validator.AssertStringLength(value, _indexLength, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну/регион.
        /// Длина не более 50 символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                Validator.AssertLengthString(value, _maxSymbolsInCountry, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город (населенный пункт).
        /// Длина не более 50 символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                Validator.AssertLengthString(value, _maxSymbolsInCity, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер улицы.
        /// Длина не более 100 символов.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                Validator.AssertLengthString(value, _maxSymbolsInStreet, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома.
        /// Длина не более 10 символов.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                Validator.AssertLengthString(value, _maxSymbolsInBuilding, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры/помещения.
        /// Длина не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                Validator.AssertLengthString(value, _maxSymbolsInApartment, nameof(Apartment));
                _apartment = value;
            }
        }
    }
}
