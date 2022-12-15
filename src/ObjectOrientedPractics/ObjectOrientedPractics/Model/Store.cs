using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товарах и покупателях.
    /// </summary>
    class Store
    {
        /// <summary>
        /// Данные о товарах.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Данные о покупателях.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задаёт данные о товарах.
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
            }
        }

        /// <summary>
        /// Возвращает и задаёт данные о покупателях.
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
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        { 
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}
