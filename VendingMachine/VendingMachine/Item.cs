using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //Class named Item for incasulate the item things needed
    internal class Item
    {
        
        //Clarify varibales to make an item (set to get)
        public int Id { get; }
        public string Name { get; }
        public int Amount { get; }
        public int Price { get; }
        public TypeEnum Type { get; }
        public BrandEnum Brand { get; }

        // Item constructor
        public Item(int id, string name, int amount, int price, TypeEnum type, BrandEnum brand) 
        { 
            Id = id;
            Name = name;
            Amount = amount;
            Price = price;
            Type = type;
            Brand = brand;
        }

    }
}
