using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {

            var text = ValueParsing.Text;
            Weekday day;

            if (Enum.TryParse(text, out day))
            {
                ParsingFlag.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                ParsingFlag.Text = "Нет такого дня недели!!!";
            }
        }
    }
}
