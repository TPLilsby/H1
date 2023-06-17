namespace Portofolio_hjemmesideCSharp
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Github_link { get; set; }
        public string Image_path { get; set; }

        public Project(int id, string title, string description, string github_link, string image_path)
        {
            Id = id;
            Title = title;
            Description = description;
            Github_link = github_link;
            Image_path = image_path;
        }
    }
}
