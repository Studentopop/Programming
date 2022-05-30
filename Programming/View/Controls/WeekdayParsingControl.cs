using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по парсингу дней недели.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {

        /// <summary>
        /// Создаёт экземпляр класса <see cref="WeekdayParsingControl"/>.
        /// </summary>
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
                ParsingFlag.Text = "Нет такого дня недели";
            }
        }
    }
}
