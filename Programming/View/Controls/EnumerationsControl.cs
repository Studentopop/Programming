﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var item = EnumsListBox.SelectedItem;
            var itemType = (Enums)item;
            Array values;

            switch (itemType)
            {
                case Enums.Colour:
                    values = Enum.GetValues(typeof(Colour));
                    break;
                case Enums.Genre:
                    values = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    values = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Manufactures:
                    values = Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Seasons:
                    values = Enum.GetValues(typeof(Seasons));
                    break;
                case Enums.Weekday:
                    values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in values)
            {
                ValuesListBox.Items.Add(value);
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntTextBox.Text = ((int)item).ToString();
        }

        private void EnumGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
