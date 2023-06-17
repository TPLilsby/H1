namespace Portofolio_hjemmesideCSharp
{
    public class Contact
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }

        public Contact(int id, string email, string text, string first_name, string last_name) {
            Id = id;
            Email = email;
            Text = text;
            First_name = first_name;
            Last_name = last_name;
        }

    }
}
