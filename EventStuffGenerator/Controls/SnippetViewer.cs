#region
using System;
using System.Windows.Forms;
using EventStuffGenerator.Components;

#endregion

namespace EventStuffGenerator.Controls
{
    public partial class SnippetViewer : UserControl
    {
        public SnippetViewer(Template template)
        {
            InitializeComponent();

            _template = template;
            txtTemplate.Text = template.Text;

            btnTemplateSave.Enabled = template.IsCustomTemplate;
        }

        private readonly Template _template;

        public string GeneratedCode
        {
            get { return txtCode.Text; }
        }

        private void btnTemplateSave_Click(object sender, EventArgs e)
        {
            OnSaveButtonClicked(_template.Name, txtTemplate.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCode.Text);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            _template.Text = txtTemplate.Text;

            GenerateButtonClickedEventArgs arg = new GenerateButtonClickedEventArgs(_template, null, false, null, null);
            OnGenerateButtonClicked(arg);

            if (arg.Successed)
            {
                txtCode.Text = arg.GeneratedCode;

                if (cheAutoCopy.Checked)
                    Clipboard.SetText(txtCode.Text);

                HistoryManager.Instance.Add(arg.EventName, arg.Argument);
            }
        }

        #region GenerateButtonClicked event things for C# 3.0
        public event EventHandler<GenerateButtonClickedEventArgs> GenerateButtonClicked;

        protected virtual void OnGenerateButtonClicked(GenerateButtonClickedEventArgs e)
        {
            if (GenerateButtonClicked != null)
                GenerateButtonClicked(this, e);
        }

        protected virtual void OnGenerateButtonClicked(Template template, string generatedCode, bool successed, string eventName, string argument)
        {
            if (GenerateButtonClicked != null)
                GenerateButtonClicked(this, new GenerateButtonClickedEventArgs(template, generatedCode, successed, eventName, argument));
        }

        public class GenerateButtonClickedEventArgs : EventArgs
        {
            public Template Template { get; set; }
            public string GeneratedCode { get; set; }
            public bool Successed { get; set; }
            public string EventName { get; set; }
            public string Argument { get; set; }

            public GenerateButtonClickedEventArgs()
            {
            }

            public GenerateButtonClickedEventArgs(Template template, string generatedCode, bool successed, string eventName, string argument)
            {
                Template = template;
                GeneratedCode = generatedCode;
                Successed = successed;
                EventName = eventName;
                Argument = argument;
            }
        }
        #endregion

        #region SaveButtonClicked event things for C# 3.0
        public event EventHandler<SaveButtonClickedEventArgs> SaveButtonClicked;

        protected virtual void OnSaveButtonClicked(SaveButtonClickedEventArgs e)
        {
            if (SaveButtonClicked != null)
                SaveButtonClicked(this, e);
        }

        protected virtual void OnSaveButtonClicked(string templateName, string templateText)
        {
            if (SaveButtonClicked != null)
                SaveButtonClicked(this, new SaveButtonClickedEventArgs(templateName, templateText));
        }

        public class SaveButtonClickedEventArgs : EventArgs
        {
            public string TemplateName { get; set; }
            public string TemplateText { get; set; }

            public SaveButtonClickedEventArgs()
            {
            }

            public SaveButtonClickedEventArgs(string templateName, string templateText)
            {
                TemplateName = templateName;
                TemplateText = templateText;
            }
        }
        #endregion
    }
}