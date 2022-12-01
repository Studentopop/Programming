using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
    
namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Реализация представления товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

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
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            var category = Enum.GetValues(typeof(Category));

            foreach (var value in category)
                CategoryComboBox.Items.Add(value);
        }

        /// <summary>
        /// На значение товара задаются параметры.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private string ItemDescription(Item item)
        {
            return $"{item.Name}: - {item.Cost}";
        }
        private void UpdateItemInfo(Item item)
        {
            int indexSelectedItem = ItemsListBox.SelectedIndex;

            if (indexSelectedItem == -1) return;

            ItemsListBox.Items[indexSelectedItem] = ItemDescription(item);
        }

        /// <summary>
        ///Очищает информацию о товаре.
        /// </summary>
        private void ClearItemInfo()
        {
            ItemsListBox.Items.Clear();
            IDTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.BackColor = AppColors.NormalBackColor;
            CostTextBox.BackColor = AppColors.NormalBackColor;
            ItemsListBox.Items.Clear();
            CategoryComboBox.SelectedIndex = -1;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int indexSelectedItem = ItemsListBox.SelectedIndex;
                _currentItem = _items[indexSelectedItem];
                NameTextBox.Text = _currentItem.Name;
                DescriptionTextBox.Text = _currentItem.Info;
                CostTextBox.Text = _currentItem.Cost.ToString();
                IDTextBox.Text = _currentItem.Id.ToString();
                CategoryComboBox.SelectedIndex = (int)_currentItem.Category;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Name = NameTextBox.Text;
                UpdateItemInfo(_currentItem);
            }
            catch
            {
                NameTextBox.BackColor = AppColors.ErrorBackColor;
                return;
            }

            NameTextBox.BackColor = AppColors.NormalBackColor;
        }
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                double cost = Convert.ToDouble(CostTextBox.Text);
                _currentItem.Cost = cost;
                UpdateItemInfo(_currentItem);
            }
            catch
            {
                CostTextBox.BackColor = AppColors.ErrorBackColor;
                return;
            }
            CostTextBox.BackColor = AppColors.NormalBackColor;
        }
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Info = DescriptionTextBox.Text;
                UpdateItemInfo(_currentItem);
            }
            catch
            {
                DescriptionTextBox.BackColor = AppColors.ErrorBackColor;
                return;
            }

            DescriptionTextBox.BackColor = AppColors.NormalBackColor;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();
            _items.Add(_currentItem);
            ItemsListBox.Items.Add(ItemDescription(_currentItem));
            ItemsListBox.SelectedIndex = _items.Count - 1;
            UpdateItemInfo(_currentItem);
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _items.RemoveAt(index);
            ClearItemInfo();

            foreach (var item in _items)
            {
                ItemsListBox.Items.Add(ItemDescription(item));
                ItemsListBox.SelectedIndex = 0;
            }

            UpdateItemInfo(_currentItem);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexCategory = CategoryComboBox.SelectedIndex;
            int indexListBox = ItemsListBox.SelectedIndex;

            if ((indexCategory == -1) || (indexListBox == -1)) return;

            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}