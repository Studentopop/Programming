using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public object SelectedContact
        {
            get { return GetValue(SelectedContactProperty); }
            set { SetValue(SelectedContactProperty, value); }
        }

        public static readonly DependencyProperty SelectedContactProperty =
            DependencyProperty.Register("SelectedContact", typeof(object),
                typeof(ContactControl), new PropertyMetadata(null));
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c) && c != '+' && c != '-' && !char.IsWhiteSpace(c))
                {
                    e.Handled = true;
                    break;
                }
            }
        }

        private void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            string clipboardText = e.DataObject.GetData(DataFormats.Text) as string;
            if (!string.IsNullOrEmpty(clipboardText))
            {
                if (clipboardText.Any(c => !char.IsDigit(c) && c != '+' && c != '-' && !char.IsWhiteSpace(c)))
                {
                    e.CancelCommand();
                }
            }
        }
        public ContactControl()
        {
            InitializeComponent();
        }
    }
}
