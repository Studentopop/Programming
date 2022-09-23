using System;
using ObjectOrientedPractics.Services;
using static ObjectOrientedPractics.Services.IdGenerator;

namespace ObjectOrientedPractics.Model
{
	/// <summary>
	/// Хранит данные о товаре.
	/// </summary>
	public class Item
	{
		/// <summary>
		/// Уникальный индетификатор.
		/// </summary>
		private readonly int _id;

		/// <summary>
		/// Название товара.
		/// </summary>
		private string _name;

		/// <summary>
		/// Информация о товаре.
		/// </summary>
		private string _info;

		/// <summary>
		/// Стоимость товара.
		/// </summary>
		private int _cost;

		/// <summary>
		/// Создаёт экземпляр класса <see cref="Item"/>
		/// </summary>
		/// <param name="name">Название товара. Длина строки должна быть
		///					   не больше 200 символов.</param>
		/// <param name="info">Информация о товаре. Длина строки должна 
		///					   быть не больше 1000 символов.</param>
		/// <param name="cost">Стоимость товара. Длина строки должна быть от 0 до 100 000.</param>
		public Item(string name, string info, int cost)
		{
			_id = GetNextId();
			Name = name;
			Info = info;
			Cost = cost;
		}

		/// <summary>
		/// Создаёт экземпляр класса <see cref="Item"/>
		/// </summary>
		public Item()
		{
			_id = GetNextId();
			Name = "";
			Info = "";
			Cost = 0;
		}

		/// <summary>
		/// Возвращает и задаёт название товара.
		/// </summary>
		public string Name
        {
            get
            {
				return _name;
            }
			set
            {
				Validator.AssertLengthString(value, 200, nameof(Name));
				_name = value;
			}
        }

		/// <summary>
		/// Возвращает и задаёт информацию о товаре.
		/// </summary>
		public string Info
        {
            get
            {
				return _info;
            }
			set
            {
				Validator.AssertLengthString(value, 1000, nameof(Info));
				_info = value;
            }
        }

		/// <summary>
		/// Возвращает и задаёт стоимость товара.
		/// </summary>
		public int Cost
        {
			get
            {
				return _cost;
            }
			set
            {
				Validator.AssertValueInRange(value, 0, 100000, nameof(Cost));
				_cost = value;
            }
        }
	}
}
