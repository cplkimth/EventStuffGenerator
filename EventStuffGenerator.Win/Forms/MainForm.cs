using System;
using System.Diagnostics;
using System.Windows.Forms;
using EventStuffGenerator.Core.Components;
using EventStuffGenerator.Win.Properties;

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

            Text += " - " + Application.ProductVersion;

            #if DEBUG
            txbEventName.Text = "AgeChanged";
            txbArgumentText.Text = "int oldAge\r\nint newAge";
            #endif
        }

        private void tsbHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/cplkimth/EventStuffGenerator");
        }

        private void tsbEbnf_Click(object sender, EventArgs e)
        {
            var form = new EbnfForm();
            form.Show();
        }

        private void tsbGenerate_Click(object sender, EventArgs e)
        {
            var templatePath = $"{Template.RootPath}/{uscTemplateSelection.SelectedTemplate}{Template.FileExtension}";

            var code = Generator.Generate(templatePath, txbEventName.Text.Trim(), txbArgumentText.Text.Trim());

            CodeViewerForm form = new CodeViewerForm(code);
            form.ShowDialog();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            tsbGenerate.PerformClick();
        }
    }
}
