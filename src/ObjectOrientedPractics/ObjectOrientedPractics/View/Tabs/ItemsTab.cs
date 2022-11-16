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
        private Item _currentItem = new Item();

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
            return $"{item.Name}";
        }
        private void UpdateItemInfo(Item item)
        {
            IDTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;
            CategoryComboBox.Text = item.Category.ToString();
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
            NameTextBox.BackColor = AppColors.NormalBackColor;
            CostTextBox.BackColor = AppColors.NormalBackColor;
            ItemsListBox.Items.Clear();
        }

        /// <summary>
        /// Меняет доступ к редактированию элементов.
        /// </summary>
        private void ChangeAccessToChangeElements()
        {
            bool value = ItemsListBox.SelectedIndex == -1;
            NameTextBox.ReadOnly = value;
            CostTextBox.ReadOnly = value;
            DescriptionTextBox.ReadOnly = value;
            CategoryComboBox.DropDownStyle =ComboBoxStyle.DropDownList;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = ItemsListBox.SelectedIndex;

                if (selectedIndex >= 0)
                {
                    _currentItem = _items[selectedIndex];
                    UpdateItemInfo(_currentItem);
                }

                ChangeAccessToChangeElements();
            }
            catch
            {
                ClearItemInfo();
                ChangeAccessToChangeElements();
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
            var item = new Item("Name", "Info", 0, Category.Xbox);
            _items.Add(item);
            ItemsListBox.Items.Add(item.Name);
            ItemsListBox.SelectedIndex = ItemsListBox.Items.Count - 1;
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

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            ChangeAccessToChangeElements();

            foreach (var value in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(value.ToString());
            }

            CategoryComboBox.SelectedIndex = -1;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexCategory = CategoryComboBox.SelectedIndex;
            int indexListBox = ItemsListBox.SelectedIndex;

            if ((indexCategory == -1) || (indexListBox == -1)) return;

            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
        }

        private void SelectedItemPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
