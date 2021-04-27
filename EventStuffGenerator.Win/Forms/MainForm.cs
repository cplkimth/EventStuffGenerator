#region
using System;
using System.Windows.Forms;
using EventStuffGenerator.Core.Components;
using EventStuffGenerator.Win.Properties;
#endregion

namespace EventStuffGenerator.Win.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            Icon = Resources.Icon_EventStuffGenerator;

#if DEBUG
            txbEventName.Text = "Searched";
            txbArgumentText.Text = "string firstName\r\nstring lastName";
#endif

            txbEventName.Focus();
        }

        private void btnEbnf_Click(object sender, EventArgs e)
        {
            var form = new EbnfForm();
            form.Show();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var templatePath = $"{Template.RootPath}/{uscTemplateSelection.SelectedTemplate}{Template.FileExtension}";

            var code = Generator.Generate(templatePath, txbEventName.Text.Trim(), txbArgumentText.Text.Trim());

            txbGenerated.Text = code;

            if (chbCopyToClipboard.Checked)
                Clipboard.SetText(code);
        }
    }
}