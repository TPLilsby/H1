using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_tur_på_biblioteket
{
    public class Book
    {
        //Defining varibles
        private byte _id;
        private string _name;
        private string _genre;
        private string _author;
        private int _pages;
        private int _releaseYear;

        //Incapsulating
        public byte Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Genre { get { return _genre; } set { _genre = value; } }
        public string Author { get { return _author; } set { _author = value; } }
        public int Pages { get { return _pages; } set { _pages = value; } }
        public int ReleaseYear { get { return _releaseYear; } set { _releaseYear = value; } }

        //Book Constructor
        public Book(byte id, string name, string genre, string author, int pages, int releaseYear)
        {
            Id = id;
            Name = name;
            Genre = genre;
            Author = author;
            Pages = pages;
            ReleaseYear = releaseYear;
        }
    }
}
