using System;
using System.IO;
using System.Windows.Forms;
using EventStuffGenerator.Core.Components;

namespace EventStuffGenerator.Win.Controls
{
    public partial class TemplateSelectionControl : UserControl
    {
        public TemplateSelectionControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            var files = Directory.GetFiles(Template.RootPath, "*" + Template.FileExtension);

            foreach (var file in files)
                cbbTemplate.Items.Add(Path.GetFileNameWithoutExtension(file));

            cbbTemplate.SelectedItem = Template.DefaultName;
        }

        public string SelectedTemplate => (string) cbbTemplate.SelectedItem;
    }
}