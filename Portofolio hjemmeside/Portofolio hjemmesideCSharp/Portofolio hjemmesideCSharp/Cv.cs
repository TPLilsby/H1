namespace Portofolio_hjemmesideCSharp
{
    public class Cv
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string PdfLink { get; set; }
        public string Description { get; set; }

        public Cv(int id, string title, string imagePath, string pdfLink, string description)
        {
            Id = id;
            Title = title;
            ImagePath = imagePath;
            PdfLink = pdfLink;
            Description = description;
        }
    }
}
