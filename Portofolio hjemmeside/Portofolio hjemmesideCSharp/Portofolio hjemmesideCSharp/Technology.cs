namespace Portofolio_hjemmesideCSharp
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoPath { get; set; }

        public Technology(int id, string name, string logoPath)
        {
            Id = id;
            Name = name;
            LogoPath = logoPath;
        }
    }
}
