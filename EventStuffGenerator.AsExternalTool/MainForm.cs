using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EventStuffGenerator.Components;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EventStuffGenerator.AsExternalTool
{
    public partial class MainForm : Form
    {
        private readonly string _methodFromVS;

        public MainForm(string methodFromVs)
        {
            _methodFromVS = methodFromVs;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.OnRunTime == false)
                return;

            var template = File.ReadAllText("CSharp 3.0.esg");


            string error = ParseMethod(out string methodName, out List<Argument> arguments);
            if (error != null)
            {
                MessageBox.Show(error);
                Close();
                return;
            }

            var code = Generator.Generate(template, methodName, arguments, string.Empty);
            var result = MessageBox.Show("Generated! Copy to clipboard?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
                Clipboard.SetText(code);

            Close();
        }

        private string ParseMethod(out string methodName, out List<Argument> arguments)
        {
            try
            {
                SyntaxTree tree = CSharpSyntaxTree.ParseText(_methodFromVS);
                CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

                var method = root.Members[0] as MethodDeclarationSyntax;
                methodName = method.Identifier.ToString();

                arguments = method.ParameterList.Parameters
                    .Select(x => new Argument(x.Type.ToString(), x.Identifier.ToString()))
                    .ToList();

                return null;
            }
            catch (Exception ex)
            {
                methodName = null;
                arguments = null;
                return ex.Message;
            }
        }
    }
}