using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //Class for all the items
    //implment the Item inteface
    internal class ItemService : IItemService
    {
        //List named ItemList for all the items
        List<Item>ItemList = new List<Item>();


        //Item constructor
        public ItemService() {

            //Add all the diffrent items to tthe list ItemList
            ItemList.Add(new Item(1, "Faxe Kondi med sukker", 5, 11, TypeEnum.Drink, BrandEnum.FaxeKondi));
            ItemList.Add(new Item(2, "Coca Cola med sukker", 5, 13, TypeEnum.Drink, BrandEnum.CocaCola));
            ItemList.Add(new Item(3, "Kims Sour Cream & Onion", 7, 9, TypeEnum.Snack, BrandEnum.Kims));
            ItemList.Add(new Item(4, "Kims Peanuts", 7, 10, TypeEnum.Snack, BrandEnum.Kims));
            ItemList.Add(new Item(5, "Lays Classic", 7, 6, TypeEnum.Snack, BrandEnum.Lays));
            ItemList.Add(new Item(6, "Haribo Matador mix", 5, 12, TypeEnum.Candy, BrandEnum.Haribo));
            ItemList.Add(new Item(7, "Malaco Lakridsbidder", 5, 14, TypeEnum.Candy, BrandEnum.Malaco));
        }

        //Get items
        public List<Item> GetAllItems()
        { 
            //Return the list ItemList
            return ItemList;
        }

        //Kan ikke få den til at vis avaivable items udfra pris så jeg ShowAllItems/GetAllItems

        /* public List<Item> GetAvaivableItems(double t)
         {
             List<Item> Avaivableitems = new List<Item>();

              foreach (Item item in GetAllItems())
              {
                  if (item.Price < t)
                  {
                      Avaivableitems.Add(item);
                  }
              }

              return Avaivableitems;

             return Avaivableitems;
         }*/
    }
}
