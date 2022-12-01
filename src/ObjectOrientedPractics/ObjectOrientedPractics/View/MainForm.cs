using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
