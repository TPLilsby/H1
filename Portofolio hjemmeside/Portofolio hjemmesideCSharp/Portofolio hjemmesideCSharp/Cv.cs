namespace Portofolio_hjemmesideCSharp
{
    //Cv class
    public class Cv
    {
        //Propaties for the Cv class
        public int Id { get; }
        public string Title { get; }
        public string ImagePath { get; }
        public string PdfLink { get; }
        public string Description { get; }

        // Constructor for the Cv class
        public Cv(int id, string title, string imagePath, string pdfLink, string description)
        {
            //Assigning values to the properties
            Id = id;
            Title = title;
            ImagePath = imagePath;
            PdfLink = pdfLink;
            Description = description;
        }
    }
}
