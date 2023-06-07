using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //Interface for all the GUI things
    internal interface IGuiService
    {
        //Method to insert money in the GUI
        double InsertMoney();

        //Method to show current money in the GUI
        void ShowMoney(double amount);


        //Method to show all items in the GUI
        void ShowAllItems(List<Item> items);

        //Method to select an item in the GUI
        int SelectItem();

        //Method to show selected item in the GUI
        void ShowSelectedItem(int id);

        //Kan ikke få den til at vis avaivable items udfra pris så jeg ShowAllItems/GetAllItems

        //void ShowAvaivableItems(List<Item> items);
    }
}
