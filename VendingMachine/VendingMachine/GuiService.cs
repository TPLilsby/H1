using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //Class for all the things showed in the console
    //implment the GUI inteface
    internal class GuiService : IGuiService
    {
        //GUI constructor
        public GuiService() { }
        
        //Insert money
        public double InsertMoney()
        {
            //Money input from user
            double inputMoney = 0;

            //Total inserted money
            double totalMoney = 0;

            //While loop for inserting money
            while (true)
            {
                //Takes input from user
                Console.WriteLine("\nHvor mange penge vil du indsætte?");
                string? input = Console.ReadLine();

                //Checks if input isn't empty and parses string to double
                if (input != null && double.TryParse(input, out _))
                {
                    //Set input money
                    inputMoney = double.Parse(input);

                    //Ask user insert more money or not (read key)
                    Console.WriteLine("Vil du indtaste flere penge n/j?");
                    ConsoleKeyInfo key = Console.ReadKey();

                    //Calculate total money
                    totalMoney = inputMoney + totalMoney;

                    //If input isn't "n" start over
                    if (key.KeyChar != 'n')
                    {
                        continue;
                    }
                    
                }
                // If input is wrong call Insert method again
                else
                {
                    return InsertMoney();
                }

                //If input is "n" return totalMoney
                return totalMoney;
            }
        }
        
        //Shows money in GUI
        public void ShowMoney(double amount)
        {
            //Print the amount to the console
            Console.WriteLine($"\nCurrent money { amount }");
        }

        // show all items in the machine
        public void ShowAllItems(List<Item> items)
        {
            //runs through every item
            foreach (Item item in items)
            {
                //Print the item to the console
                Console.WriteLine($"{item.Id} | {item.Name} | {item.Amount} back | {item.Price} kr. | Brand: {item.Brand}");
            }
        }

        //Select Item
        public List<Item> SelectItem(List<Item> selecteditems)
        {
            //Varibale for user input id
            double inputId;

            //Takes input id from user
            Console.WriteLine("Vælg ID på varen du vil købe");
            inputId = double.Parse(Console.ReadLine());

            //Runs through each item in the list
            foreach (Item item in selecteditems)
            {
                //If the id of item == to the user input id
                if (item.Id == inputId)
                {
                    // addd the item to selecteditems
                    selecteditems.Add(item);
                }
            }

            //return selectedItems
            return selecteditems;
        }

        //Show the selected items
        public void ShowSelectedItem(List<Item> selecteditems)
        {
            //Runs through the selected items
            foreach (Item item in selecteditems)
            {
                //Print the name of the item
                Console.WriteLine($"Du har valgt: {item.Name}");
            }
        }

        //Kan ikke få den til at vis avaivable items udfra pris så jeg ShowAllItems/GetAllItems

        /* 
         //shows avaivable items
         public void ShowAvaivableItems(List<Item> items)
         { 
            //runs through items
             foreach (Item item in items)
             {
                 77if price is less or equal the curren money
                 if (item.Price <= this.InsertMoney())
                 {
                     //Print the item out
                     Console.WriteLine($"{item.Id} | {item.Name} | {item.Amount} back | {item.Price} kr. | Brand: {item.Brand}");
                 }
             }
         }
        */
    }
}
