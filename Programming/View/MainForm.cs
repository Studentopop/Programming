using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.View;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (Enums enumsValues in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(enumsValues);
            }

            EnumsListBox.SelectedIndex = 0;
            var values = Enum.GetValues(typeof(Seasons));

            foreach (var value in values)
            {
                ChooseSeasonBox.Items.Add(value);
            }
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
            IntBox.Text = ((int)item).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse(ParseTextBox.Text, out Weekday day))
            {
                OutLabel.Text = $"Это день недели { day } - {(int)day}";
            }
            else
            {
                OutLabel.Text = "Нет такого дня недели";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var item = ChooseSeasonBox.SelectedItem;

            switch (item)
            {
                case Seasons.Winter:
                    SeasonHandleGroupBox.BackColor = Color.White;
                    MessageBox.Show("Бррр! Холодно!", "Погода", MessageBoxButtons.OK);
                    break;
                case Seasons.Spring:
                    SeasonHandleGroupBox.BackColor = Color.LightGreen;
                    break;
                case Seasons.Summer:
                    SeasonHandleGroupBox.BackColor = Color.White;
                    MessageBox.Show("Ура! Солнце!", "Погода", MessageBoxButtons.OK);
                    break;
                case Seasons.Autumn:
                    SeasonHandleGroupBox.BackColor = Color.Orange;
                    break;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EnumerationsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void IntBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeasonHandleGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
