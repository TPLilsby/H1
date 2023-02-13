using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineApp
{
    public class Candy
    {
        private byte _id;
        private byte _weight;
        private byte _price;

        public byte Id { get { return _id; } set { _id = value; } }
        public byte Weight { get { return _weight; } set { _weight = value; } }
        public byte Price { get { return _price; } set { _price = value; } }

        public Candy(byte id, byte weight, byte price)
        {
            Id = id;
            Weight = weight;
            Price = price;
        }
    }
}


