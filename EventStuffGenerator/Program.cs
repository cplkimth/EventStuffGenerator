// https://github.com/CopyText/TextCopy

using System;
using System.IO;
using CommandLine;
using EventStuffGenerator.Core.Components;
using TextCopy;

namespace EventStuffGenerator
{
    class Program
    {
        public class Options
        {
            [Option('t', "template", Required = false, HelpText = "템플릿 이름. 생략하면 default를 사용. ex:default")]
            public string Template { get; set; }

            [Option('e', "event-name", Required = true, HelpText = "이벤트 이름. ex:AgeChanged")]
            public string EventName { get; set; }

            [Option('a', "argument-text", Required = false, HelpText = "이벤트 매개변수의 타입과 이름. \"와 \"로 감싸야 함. ex:\"int oldAge int newAge\"")]
            public string ArgumentText { get; set; }
        }

        static void Main(string[] args)
        {
#if DEBUG
            args = new string[6];
            args[0] = "-e";
            args[1] = "AgeChanged";
            args[2] = "-a";
            args[3] = "int oldAge int newAge";
            args[4] = "-t";
            args[5] = "default";
#endif

            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(o =>
                            {
                                var template = string.IsNullOrEmpty(o.Template) ? Template.DefaultName : o.Template;
                                var templatePath = $"{Template.RootPath}/{template}{Template.FileExtension}";
                                
                                var code = Generator.Generate(templatePath, o.EventName, o.ArgumentText);
                                Console.WriteLine(code);

                                Console.WriteLine("상기 코드를 클립보드로 복사할까요?\n*주의* 기존 클립보드의 내용이 지워집니다. ([y]/n)");
                                string copyToClipboard = Console.ReadLine().ToLower();
                                if (copyToClipboard != "n")
                                {
                                    Clipboard clipboard = new Clipboard();
                                    clipboard.SetText(code);

                                    Console.WriteLine("클립보드로 복사하였습니다.");
                                }
                            });
        }
    }
}
