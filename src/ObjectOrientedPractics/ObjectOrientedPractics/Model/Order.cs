
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _ordersId;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly string _dateOfCreate;

        /// <summary>
        /// Уникальный ID товара.
        /// </summary>
        private int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private string _creationDate;

        /// <summary>
        /// Общее количество заказов.
        /// </summary>
        private static int _allOrdersCount;

        /// <summary>
        /// Адресс доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Общая стоимость товаров.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public string DateOfCreate
        {
            get
            {
                return _dateOfCreate;
            }
        }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int OrdersId
        {
            get
            {
                return _ordersId;
            }
        }

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;
        private OrderStatus status;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _deliveryAddress;

        /// <summary>
        /// Возвращает ID товара.
        /// </summary>
        public int Id
        {
            get
            {
                return _id + 1;
            }
        }

        /// <summary>
        /// Возвращает дату создания товара.
        /// </summary>
        public string CreationDate
        {
            get
            {
                return _creationDate;
            }
            set
            {
                _creationDate = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адресс доставки.
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
            }
        }

        /// <summary>
        /// Возвращает и задает список товаров.
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
        /// Возвращает и задает общую стоимость товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки заказа.
        /// </summary>
        public Address DeliveryAddress
        {
            get
            {
                return _deliveryAddress;
            }
            set
            {
                _deliveryAddress = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт состояние заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _id = _allOrdersCount++;
        }
          
        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="creationDate">Дата создания заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="amount">Общая стоимость заказа.</param> ka
        public Order(string creationDate, Address address,
            List<Item> items, double amount, string fullname)
        {
            CreationDate = creationDate;
            OrderStatus = OrderStatus.New;
            Address = address;
            Items = items;
            Amount = amount;
            Fullname = fullname;
            _id = _allOrdersCount++;
        }

        public Order(OrderStatus status, Address address, List<Item> items)
        {
            this.status = status;
            Address = address;
            Items = items;
        }
    }
}
