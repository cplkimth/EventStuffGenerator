using System;
using System.Collections.Generic;
using EventStuffGenerator.Core.Exceptions;

namespace EventStuffGenerator.Core.Components
{
    public struct Argument
    {
        private readonly string _type;

        public string Type
        {
            get { return _type; }
        }

        private readonly string _name;

        public string CamelName
        {
            get { return char.ToLower(_name[0]) + _name.Substring(1); }
        }

        public string PascalName
        {
            get { return char.ToUpper(_name[0]) + _name.Substring(1); }
        }

        public string FieldName
        {
            get { return "_" + CamelName; }
        }

        public string[] IdentifierNames => new[] { PascalName, CamelName };

        public Argument(string type, string name)
        {
            _type = type;
            _name = name;
        }

        public static List<Argument> ParseAsList(string text)
        {
            List<Argument> arguments = new List<Argument>();

            string[] tokens = text.Split(new[] { ",", " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tokens.Length; i = i + 2)
            {
                Argument pair = new Argument(tokens[i], tokens[i + 1]);
                arguments.Add(pair);

                foreach (var identifierName in pair.IdentifierNames)
                {
                    if (identifierName.IsValidIdentifier() == false)
                        throw new InvalidIdentifierException(identifierName);

                    if (identifierName.IsCSharpKeyword())
                        throw new InvalidIdentifierException(identifierName);
                    
                }
            }

            return arguments;
        }
    }
}