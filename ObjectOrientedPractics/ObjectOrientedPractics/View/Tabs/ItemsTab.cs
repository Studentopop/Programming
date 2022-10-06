﻿using System;
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
        private List<Item> _items;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            _items = new List<Item>();

            InitializeComponent();
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
            NameTextBox.BackColor = AppColor.CorrectColor;
            CostTextBox.BackColor = AppColor.CorrectColor;
            ItemsListBox.Items.Clear();
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
                NameTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            NameTextBox.BackColor = AppColor.CorrectColor;
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
                CostTextBox.BackColor = AppColor.ErrorColor;
                return;
            }
            CostTextBox.BackColor = AppColor.CorrectColor;
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
                DescriptionTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            DescriptionTextBox.BackColor = AppColor.CorrectColor; 
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
    }
}
