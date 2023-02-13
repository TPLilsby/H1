using VendingMachineApp;
using System.Net.Http.Headers;

//Program class
public class Program
{
    //Main method
    public static void Main(string[] args)
    {
        //Make the vending machine
        VendingMachine vendingMachine = new VendingMachine();

        #region SODA QUEUE

        //Queue for soda's
        Queue<Soda> sodaQueue = new Queue<Soda>();

        foreach (Soda soda in vendingMachine.SodaList)
        {
            sodaQueue.Enqueue(soda);
        }
        #endregion

        #region CANDY QUEUE

        //Queue for candy
        Queue<Candy> candyQueue = new Queue<Candy>();

        foreach (Candy candy in vendingMachine.CandyList)
        {
            candyQueue.Enqueue(candy);
        }
        #endregion

        bool run = true;

        while (run)
        {

            //Add's all the soda's in the vending machine to a queue
            Console.WriteLine("The soda's:");

            foreach (Soda soda in sodaQueue)
            {
                Console.WriteLine(soda.Id + ": " + soda.Size + "l | " + soda.Price + " kr.");
            }

            //Add's all the candy in the vending machine to a queue
            Console.WriteLine("\nThe candy:");

            foreach (Candy candy in candyQueue)
            {
                Console.WriteLine(candy.Id + ": " + candy.Weight + " g - " + candy.Price + " kr.");
            }

            //Shows option 1
            Soda sodaItems = sodaQueue.Peek();
            Console.WriteLine(string.Format("\nOption 1: {0}l | {1}", sodaItems.Size, sodaItems.Price));

            //Shows option 2
            Candy candyItems = candyQueue.Peek();
            Console.WriteLine(string.Format("Option 2: {0}g | {1}", candyItems.Weight, candyItems.Price));

            Console.Write("What would you like to by? (option 1/1 & option 2/2): ");
            byte option = byte.Parse(Console.ReadLine());

            if (option == 1)
            {

                Console.WriteLine(Payment(vendingMachine.Soda.Price, sodaQueue));
            }
            else if (option == 2)
            {

            }
        }
    }

    public static string Payment(byte price, Queue<Soda> soda)
    {
        foreach (Soda soda1 in soda)
        {
            soda.Enqueue(soda1);
        }

        bool paying = true;

        while (paying)
        {
            Console.WriteLine("enter money: ");
            byte money = byte.Parse(Console.ReadLine());

            if (money == price)
            {
                return "Item is payed";
                soda.Dequeue();

                paying = false;
            }
            else if (money < price)
            {
                return "Paid yo little";
            }
        }
        return null;
    }
}

