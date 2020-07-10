namespace EventStuffGenerator.Core.Components
{
    public class Template
    {
        public const string RootPath = "Templates";
        public const string FileExtension = ".esg";
        public const string DefaultName = "default";
        
        public const string CustomPrefix = "Custom";

        public Template(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string Name { get; set; }
        public string Text { get; set; }

        public bool IsCustomTemplate => Name.StartsWith(CustomPrefix);
    }
}
