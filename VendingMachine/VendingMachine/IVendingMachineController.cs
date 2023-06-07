using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface IVendingMachineController
    {
        //Method to insert money
        double InsertMoney();

        //Method to show current money
        void ShowMoney(double amount);

        //Method to show all items
        void ShowAllItems();
        
        //Method to select items
        int SelectItem();

        //Method to show selected items
        void ShowSelctedItems(int id);

        //Kan ikke få den til at vis avaivable items udfra pris så jeg ShowAllItems/GetAllItems
        //void ShowAvaivableItems();
    }
}
