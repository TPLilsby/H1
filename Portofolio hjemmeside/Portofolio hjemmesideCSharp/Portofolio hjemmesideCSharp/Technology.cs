namespace Portofolio_hjemmesideCSharp
{
    //Technology class
    public class Technology
    {
        //Propaties for the Technology class
        public int Id { get; }
        public string Name { get; }
        public string LogoPath { get; }

        // Constructor for the Technology class
        public Technology(int id, string name, string logoPath)
        {
            //Assigning values to the properties
            Id = id;
            Name = name;
            LogoPath = logoPath;
        }
    }
}
