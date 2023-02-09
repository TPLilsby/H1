using En_tur_på_biblioteket;
using System.Collections.Generic;

/// <summary>
/// Libary program where you can rent books
/// </summary>

//Program class
public class Program
{
    //Main method
    public static void Main(string[] args)
    {
        //Entered data for books
        Book harryPotter1 = new Book(1, "Harry Potter and the Philosopher's Stone", "Fantasy", "J.K. Rowling", 223, 1997);
        Book theHobbit = new Book(2, "The Hobbit", "Fantasy", "J.R.R. Tolkien", 310, 1937);
        Book lordOfTheRings1 = new Book(3, "The Fellowship of the Ring", "Fantasy", "J.R.R. Tolkien", 423, 1957);

        //List with all the books in
        List<Book> lendingList = new List<Book>();

        //Add the books
        lendingList.Add(harryPotter1);
        lendingList.Add(theHobbit);
        lendingList.Add(lordOfTheRings1);
        
        //A stack to the user loans
        Stack<Book> userLoan = new Stack<Book>();

        //Bool to the first while loop
        bool pickBooks = true;

        //First while loop | pick books from the libary
        while (pickBooks)
        {
            //Print all the books
            foreach (Book book in lendingList)
            {
                Console.WriteLine(book.Id + " | " + book.Name + " | " + book.Genre + " | " + book.Author + " | " + book.Pages + " | " + book.ReleaseYear);
            }

            //User input's ID to pick the book they want to rent
            Console.Write("\nEnter the ID on the book you want to rent or (quit/q: ");
            char bookId = char.Parse(Console.ReadLine());

            //Switch to the diffrent options
            switch (bookId)
            {
                //The book with ID 1
                case '1':

                    //Removes the book from the list
                    lendingList.Remove(harryPotter1);

                    //Add the book to the stack
                    userLoan.Push(harryPotter1);
                    break;

                //The book with ID 2
                case '2':

                    //Removes the book from the list
                    lendingList.Remove(theHobbit);

                    //Add the book to the stack
                    userLoan.Push(theHobbit);
                    break;

                //The book with ID 3
                case '3':

                    //Removes the book from the list
                    lendingList.Remove(lordOfTheRings1);

                    //Add the book to the stack
                    userLoan.Push(lordOfTheRings1);
                    break;

                //Quits the while loop when user don't want to rent more books
                case 'q':
                    pickBooks = false;
                    break;
            }
        }

        //Clear the console
        Console.Clear();

        //count the books in the stack to see how many is back
        byte countBooks = 0;
        foreach (Book book in userLoan)
        {
            countBooks++;
        }
        
        //Bool to the second while loop
        bool rentBooks = true;

        //Second while loop | rent books from the user stack
        while (rentBooks)
        {
            //If there is no books back in the stack, print the writeline & set rentbooks to false
            if (countBooks == 0)
            {
                Console.WriteLine("\nNo more books to rent:");
                rentBooks = false;
            }
            //Rent books
            else
            {
                //Clear console
                Console.Clear();

                //looks what the next book in the stack is and print it
                Book book = userLoan.Peek();
                Console.WriteLine(book.Name + " | " + book.Genre + " | " + book.Author + " | " + book.Pages + " | " + book.ReleaseYear);

                //Asks user to press (r) to rent
                Console.Write("Rent book: press (r): ");
                char choice = char.Parse(Console.ReadLine());

                //If choice is (r) it removes the book from the stack and minus countBooks with 1
                if (choice == 'r')
                {
                    //Remove from stack
                    userLoan.Pop();

                    //Minus countBooks with 1
                    countBooks--;
                }
            }
        }
        
    }
}