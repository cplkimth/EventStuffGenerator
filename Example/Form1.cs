using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uscSearch_Searched(object sender, Controls.SearchControl.SearchedEventArgs e)
        {
            MessageBox.Show($"My name is {e.FirstName} {e.LastName}");
        }

        private void uscSearch_Searching(object sender, Controls.SearchControl.SearchingEventArgs e)
        {
            if (e.LastName == "kim")
                e.Cancel = true;
        }
    }
}
