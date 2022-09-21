using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{	
	public class Item
	{
		private static int _allItemsCount;

		private readonly int _id;

		private string _name;

		private string _info;

		private int _cost;
		public int Id
		{
			get
			{
				return _id;
			}
		}

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
		public Item()
		{
			_allItemsCount++;
			_id = _allItemsCount;
		}
		public Item(string name, string info, int cost)
		{
			Name = name;
			Info = info;
			Cost = cost;
			_allItemsCount++;
			_id = _allItemsCount;
		}
	}
}
