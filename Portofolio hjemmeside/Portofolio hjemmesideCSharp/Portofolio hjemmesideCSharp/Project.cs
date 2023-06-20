namespace Portofolio_hjemmesideCSharp
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string GithubLink { get; set; }
        public string ImagePath { get; set; }

        public Project(int id, string title, string description, string githubLink, string imagePath)
        {
            Id = id;
            Title = title;
            Description = description;
            GithubLink = githubLink;
            ImagePath = imagePath;
        }
    }
}
