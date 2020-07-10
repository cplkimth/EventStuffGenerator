#region
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using EventStuffGenerator.Components;
using EventStuffGenerator.Controls;
using EventStuffGenerator.Exceptions;
using EventStuffGenerator.Properties;

#endregion

namespace EventStuffGenerator.Forms
{
    public partial class EventStuffGeneratorForm : Form
    {
        public EventStuffGeneratorForm()
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

            uscInput.Initiate();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (DesignMode)
                return;

            LoadTemplates();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            HistoryManager.Instance.Save();

            base.OnClosing(e);
        }

        private void LoadTemplates()
        {
            var templates = new List<Template>();
            templates.AddRange(LoadSystemTemplates());
            templates.AddRange(LoadCustomTemplates());
            AddTabPage(templates);

            tbcTab.SelectedIndex = 1;
        }

        private List<Template> LoadSystemTemplates()
        {
            var templates = new List<Template>();

            var files = Directory.GetFiles("Templates", "*.esg");
            foreach (var file in files)
            {
                Template template = new Template(Path.GetFileNameWithoutExtension(file), File.ReadAllText(file));
                templates.Add(template);
            }

            return templates;
        }

        private string GetCustomTemplateName(int index)
        {
            return Template.CustomPrefix + index;
        }

        private List<Template> LoadCustomTemplates()
        {
            var templates = new List<Template>();

            for (int i = 0; i < 10; i++)
            {
                Template template = new Template(GetCustomTemplateName(i), (string)Settings.Default[GetCustomTemplateName(i)]);
                templates.Add(template);
            }

            return templates;
        }

        private void AddTabPage(List<Template> templates)
        {
            foreach (var template in templates)
            {
                SnippetViewer viewer = new SnippetViewer(template);
                viewer.Dock = DockStyle.Fill;
                viewer.SaveButtonClicked += SnippetViewer_SaveButtonClicked;
                viewer.GenerateButtonClicked += SnippetViewer_GenerateButtonClicked;

                TabPage page = new TabPage();
                page.Text = template.Name;
                page.Controls.Add(viewer);

                tbcTab.TabPages.Add(page);
            }
        }

        private void SnippetViewer_SaveButtonClicked(object sender, SnippetViewer.SaveButtonClickedEventArgs e)
        {
            Settings.Default[e.TemplateName] = e.TemplateText;
            Settings.Default.Save();

            MessageBox.Show("저장되었습니다.");
        }

        private void SnippetViewer_GenerateButtonClicked(object sender, SnippetViewer.GenerateButtonClickedEventArgs e)
        {
            List<Argument> arguments = null;
            try
            {
                arguments = Argument.ParseAsList(uscInput.Argument);
            }
            catch (InvalidIdentifierException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (KeywordException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("매개변수의 형식이 잘못되었습니다.");
            }

            try
            {
                e.GeneratedCode = Generator.Generate(e.Template.Text, uscInput.EventName, arguments);
                e.Successed = true;
                e.EventName = uscInput.EventName;
                e.Argument = uscInput.Argument;
            }
            catch
            {
                e.Successed = false;
            }
        }
    }
}