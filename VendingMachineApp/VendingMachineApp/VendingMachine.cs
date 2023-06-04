using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineApp
{
    public class VendingMachine
    {
        //Incasulate Soda
        public Soda Soda { get; set; }

        //Incasulate Candy
        public Candy Candy { get; set; }

        //Make the list to the soda's
        public List<Soda> SodaList = new List<Soda>();

        //Make the soda queue
        public Queue<Soda> SodaQueue = new Queue<Soda>();

        //Make the list to the candy
        public List<Candy> CandyList = new List<Candy>();

        //Make the candy queue
        public Queue<Candy> CandyQueue = new Queue<Candy>();

        //Vending machine cunstructor
        public VendingMachine()
        {
            #region SODA
            //Id count for soda
            byte countSodaId = 1;

            //Add ten soda's to the vending machine
            for (int i = 0; i < 10; i++)
            {
                SodaList.Add(Soda = new Soda(countSodaId, 0.5, 22));
                countSodaId++;
            }

            foreach (Soda soda in SodaList)
            {
                SodaQueue.Enqueue(soda);
            }
            #endregion

            #region CANDY
            //Id count for candy
            byte countCandyId = 1;

            for (var i = 0; i < 15; i++)
            {
                CandyList.Add(Candy = new Candy(countCandyId, 75, 17));
                countCandyId++;
            }

            foreach (Candy candy in CandyList)
            {
                CandyQueue.Enqueue(candy);
            }
            #endregion
        }

        //Method to Soda payment
        public Queue<Soda> PaymentSoda(byte price, Queue<Soda> soda)
        {
            //Copy the queue from the ohter soda queue
            Queue<Soda> sodaQueue = soda;

            //Enter money
            Console.WriteLine("enter money: ");
            byte money = byte.Parse(Console.ReadLine());

            //If the right numder of money is entered
            if (money == price)
            {
                //Removes 1 from the queue
                sodaQueue.Dequeue();

                //Print sucessful
                Console.WriteLine("\nItem is payed");

                //Returns the queue
                return sodaQueue;
            }

            //Print unsucessful
            Console.WriteLine("\nWrong paymenmt");
            return sodaQueue;
        }

        //Method to Candy payment
        public Queue<Candy> PaymentCandy(byte price, Queue<Candy> candy)
        {
            //Copy the queue from the ohter candy queue
            Queue<Candy> candyQueue = candy;

            //Enter money
            Console.WriteLine("enter money: ");
            byte money = byte.Parse(Console.ReadLine());

            //If the right numder of money is entered
            if (money == price)
            {
                //Removes 1 from the queue
              candyQueue.Dequeue();

                //Print sucessful
                Console.WriteLine("\nItem is payed");

                //Returns the queue
                return candyQueue;
            }

            //Print unsucessful
            Console.WriteLine("\nWrong paymenmt");
            return candyQueue;
        }

    }
}


