using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //Interface for them itemsd
    internal interface IItemService
    {
        //Method named GetAllItems to Get all the items
        List<Item> GetAllItems();

        //Kan ikke få den til at vis avaivable items udfra pris så jeg ShowAllItems/GetAllItems
        //List<Item> GetAvaivableItems();
    }
}
