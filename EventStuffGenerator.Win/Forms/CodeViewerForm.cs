using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventStuffGenerator.Win.Forms
{
    public partial class CodeViewerForm : Form
    {
        public CodeViewerForm(string code)
        {
            InitializeComponent();

            txbCode.Text = code;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txbCode.Text);

            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
