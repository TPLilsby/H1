namespace Portofolio_hjemmesideCSharp
{
    //Project class
    public class Project
    {
        //Propaties for the Project class
        public int Id { get; }
        public string Title { get; }
        public string Description { get; }

        public string GithubLink { get; }
        public string ImagePath { get; }

        // Constructor for the Project class
        public Project(int id, string title, string description, string githubLink, string imagePath)
        {
            ////Assigning values to the properties
            Id = id;
            Title = title;
            Description = description;
            GithubLink = githubLink;
            ImagePath = imagePath;
        }
    }
}
