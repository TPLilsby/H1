using Køen;
using System.Diagnostics;

//Program class
public class Program
{
    //Main method
    public static void Main(string[] args)
    {
        //Make queue named songs
        Queue<Song> songs = new Queue<Song>();

        //List with the menu
        List<string> menu = new List<string>();
        menu.Add("1. Add songs");
        menu.Add("2. Play song");
        menu.Add("3. Show the number of songs");
        menu.Add("4. Show the next song in queue");
        menu.Add("5. Print all songs");
        menu.Add("6. Exit");

        //Set run to true
        bool run = true;

        //varible to count number of songs in queue
        byte numberOfSongs = 0;

        //While loop for runing program
        while (run)
        {
            //Print the menu llist
            foreach (string item in menu)
            {
                Console.WriteLine("\n" + item);
            }

            //Choose a number from the list
            Console.Write("\nEnter your choice: ");
            byte choice = byte.Parse(Console.ReadLine());

            //Switch with options from list
            switch (choice)
            {
                //1. Add songs
                case 1:
                    Console.Clear();

                    //Enter artist name
                    Console.Write("\nArtist: ");
                    string artistName = Console.ReadLine();
                    
                    //Enter song name
                    Console.Write("Name: ");
                    string songName = Console.ReadLine();

                    //Add the song to the queue
                    songs.Enqueue(new Song() { Artist = artistName, Name = songName });
                    break;

                //2. Play song
                case 2:
                    Console.Clear();

                    //Play the first song in the queue
                    Song playSong = songs.Dequeue();

                    //Print out what song is playing
                    Console.WriteLine(string.Format("Song playing: {0} | {1}", playSong.Artist, playSong.Name));
                    break;

                //3. Show the number of songs
                case 3:
                    Console.Clear();

                    //Count number of songs in queue
                    foreach (Song song in songs)
                    {
                        numberOfSongs++;
                    }

                    //Print number of songs in queue
                    Console.WriteLine("Number of guests: " + numberOfSongs);
                    break;

                //4. Show the next song in queue
                case 4:
                    Console.Clear();

                    //Looks what the next song is
                    Song nextSong = songs.Peek();

                    //Print what the song to play is
                    Console.WriteLine(string.Format("Next song to play: {0} | {1}", nextSong.Artist, nextSong.Name));
                    break;

                //5. Print all songs
                case 5:
                    Console.Clear();

                    //Print all the songs left in the queue
                    Console.WriteLine("Songs:");
                    foreach (Song song in songs)
                    {
                        Console.WriteLine("{0} | {1}", song.Artist, song.Name);
                    }
                    break;

                //6. Exit program
                case 6:

                    //Confirmation that want to exit
                    Console.WriteLine("Are you sure you want to exit? (Yes/y | No/n");
                    char runAgain = char.Parse(Console.ReadLine());

                    //If y is entered the program closes
                    if (runAgain == 'y')
                    {
                        run = false;
                        Console.WriteLine("Program closed...");
                    }
                    break;
            }
        }
    }
}