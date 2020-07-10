using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace EventStuffGenerator.Components
{
    public class Generator
    {
        public static string Generate(string templateText, string eventName, List<Argument> arguments)
        {
            templateText = templateText.Replace("[EN]", eventName);
            templateText = templateText.Replace("[CN]", eventName);

            string[] splitedTexts = Regex.Split(templateText, @"<\*(.*?)\*>", RegexOptions.Singleline);

            StringBuilder builder = new StringBuilder();
            foreach (var splitedText in splitedTexts)
            {
                if (splitedText.Contains("::"))
                    builder.Append(ReplaceArguments(splitedText, arguments));
                else
                    builder.Append(splitedText);
            }

            builder.Replace("[N]", Environment.NewLine);
            builder.Replace("[T]", "\t");

            builder.Replace("[BC]", arguments.Count == 0 ? "/*" : string.Empty);
            builder.Replace("[EC]", arguments.Count == 0 ? "*/" : string.Empty);

            return builder.ToString();
        }

        private static string ReplaceArguments(string line, List<Argument> arguments)
        {
            var tokens = line.Split(new[] { "::" }, StringSplitOptions.None);

            if (tokens.Length != 2)
                throw new Exception();

            string macro = tokens[0];
            string seperator = tokens[1];

            StringBuilder text = new StringBuilder();

            for (int i = 0; i < arguments.Count; i++)
            {
                var replacedMacro = macro.Replace("[AT]", arguments[i].Type).Replace("[AC]", arguments[i].CamelName).Replace("[AP]", arguments[i].PascalName);

                text.Append(replacedMacro);

                if (i != arguments.Count - 1)
                    text.Append(seperator);
            }

            return text.ToString();
        }
    }
}