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
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Seasons));
        }

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

        private void SeasonHandleControl_Load(object sender, EventArgs e)
        {

        }
    }
}
