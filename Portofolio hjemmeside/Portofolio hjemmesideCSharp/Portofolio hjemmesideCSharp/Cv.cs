namespace Portofolio_hjemmesideCSharp
{
    public class Cv
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image_path { get; set; }
        public string Pdf_link { get; set; }
        public string Description { get; set; }

        public Cv(int id, string title, string image_path, string pdf_link, string description)
        {
            Id = id;
            Title = title;
            Image_path = image_path;
            Pdf_link = pdf_link;
            Description = description;
        }
    }
}
