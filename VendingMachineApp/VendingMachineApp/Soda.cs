using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineApp
{
    public class Soda
    {
        private byte _id;
        private double _size;
        private byte _price;

        public byte Id { get { return _id; } set { _id = value; } }
        public double Size { get { return _size; } set { _size = value; } }
        public byte Price { get { return _price; } set { _price = value; } }

        public Soda(byte id, double size, byte price)
        {
            Id = id;
            Size = size;
            Price = price;
        }
    }
}


