namespace EventStuffGenerator.Components
{
    public class Template
    {
        public const string CustomPrefix = "Custom";

        public Template(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string Name { get; set; }
        public string Text { get; set; }

        public bool IsCustomTemplate
        {
            get { return Name.StartsWith(CustomPrefix); }
        }
    }
}
