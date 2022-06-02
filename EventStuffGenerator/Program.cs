// https://github.com/CopyText/TextCopy

using System;
using CommandLine;
using EventStuffGenerator.Core.Components;
using TextCopy;

namespace EventStuffGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string eventName = null;
            string argumentText = null;
            string templateName = null;

            if (args.Length > 0)
            {
                Parser.Default.ParseArguments<Options>(args)
                    .WithParsed(o =>
                                {
                                    eventName = o.EventName;
                                    argumentText = o.ArgumentText;
                                    templateName = o.TemplateName;
                                });
            }
            else
            {
                Console.WriteLine("Because you did not send arguments, you can enter argument values for now.");
                Console.WriteLine();

                Console.WriteLine("Enter [eventName]. ex) AgeChanged");
                eventName = Console.ReadLine();

                Console.WriteLine("Enter [argumentText]. ex) int oldAge, int newAge");
                argumentText = Console.ReadLine();

                Console.WriteLine("Enter [templateName] or just enter if you want to use [clr]. ex) routed");
                templateName = Console.ReadLine();
            }

            if (eventName == null || argumentText == null)
                return;


            templateName = string.IsNullOrEmpty(templateName) ? Template.DefaultName : templateName;
            var templatePath = $"{Template.RootPath}/{templateName}{Template.FileExtension}";

            var code = Generator.Generate(templatePath, eventName, argumentText);
            Console.WriteLine(code);

            Console.WriteLine("Do you want to copy above generated code to clipboard?([y]/n)");
            var copyToClipboard = Console.ReadLine().ToLower();

            if (copyToClipboard == "n")
                return;

            try
            {
                ClipboardService.SetText(code);
                Console.WriteLine("Copied");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception]");
                Console.WriteLine(ex.Message);
                Console.WriteLine("If you run this under debian, try install xclip by following command");
                Console.WriteLine("sudo apt install xclip");
            }
        }

        public class Options
        {
            [Option('t', "template-name", Required = false, HelpText = "template name. [clr] and [routed]. default value is [clr].", Default = "clr")]
            public string TemplateName { get; set; }

            [Value(0, Required = true, HelpText = "name of event. ex:AgeChanged")]
            public string EventName { get; set; }

            [Value(1, Required = true, HelpText = "pairs of type and name of event agruments. must by quoted in \" and \". ex:\"int oldAge int newAge\"")]
            public string ArgumentText { get; set; }
        }
    }
}