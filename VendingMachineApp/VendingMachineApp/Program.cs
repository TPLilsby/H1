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

        bool run = true;

        while (run)
        {

            //Add's all the soda's in the vending machine to a queue
            Console.WriteLine("The soda's:");

            foreach (Soda soda in vendingMachine.SodaQueue)
            {
                Console.WriteLine(soda.Id + ": " + soda.Size + "l | " + soda.Price + " kr.");
            }

            //Add's all the candy in the vending machine to a queue
            Console.WriteLine("\nThe candy:");

            foreach (Candy candy in vendingMachine.CandyQueue)
            {
                Console.WriteLine(candy.Id + ": " + candy.Weight + " g - " + candy.Price + " kr.");
            }

            //Shows option 1
            Soda sodaItems = vendingMachine.SodaQueue.Peek();
            Console.WriteLine(string.Format("\nOption 1: {0}l | {1}", sodaItems.Size, sodaItems.Price));

            //Shows option 2
            Candy candyItems = vendingMachine.CandyQueue.Peek();
            Console.WriteLine(string.Format("Option 2: {0}g | {1}", candyItems.Weight, candyItems.Price));

            Console.Write("What would you like to by? (option 1/1 & option 2/2): ");
            byte option = byte.Parse(Console.ReadLine());

            if (option == 1)
            {
                vendingMachine.PaymentSoda(vendingMachine.Soda.Price, vendingMachine.SodaQueue);
            }
            else if (option == 2)
            {
                vendingMachine.PaymentCandy(vendingMachine.Candy.Price, vendingMachine.CandyQueue);
            }
        }
    }
}