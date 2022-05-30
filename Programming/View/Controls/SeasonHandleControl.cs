using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class SeasonHandleControl : UserControl
    {
        /// <summary>
        /// Предоставляет реализацию по выбору времени года.
        /// </summary>
        public SeasonHandleControl()
        {
            InitializeComponent();
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Seasons));
        }

        /// <summary>
        /// Предоставляет реализацию по изменение фона с выбором времени года.
        /// </summary>
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            var item = SeasonComboBox.SelectedItem;

            switch (item)
            {
                case Seasons.Winter:
                    SeasonButton.BackColor = AppColors.WinterColor;
                    MessageBox.Show("Бррр! Холодно!", "Погода", MessageBoxButtons.OK);
                    break;
                case Seasons.Spring:
                    SeasonButton.BackColor = AppColors.SpringColor;
                    break;
                case Seasons.Summer:
                    SeasonButton.BackColor = AppColors.SummerColor;
                    MessageBox.Show("Ура! Солнце!", "Погода", MessageBoxButtons.OK);
                    break;
                case Seasons.Autumn:
                    SeasonButton.BackColor = AppColors.AutumnColor;
                    break;
            }
        }
    }
}
