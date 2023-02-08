using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public struct Card
    {
        string suit = "";
        byte value = 0;
        byte point = 0;

        public Card(string suit, byte value, byte point)
        {
            Suit = suit;
            Value = value;
            Point = point;
        }

        public string Suit { get => suit; set => suit = value; }

        public byte Value { get => value; set => this.value = value; }
        public byte Point { get => point; set => point = value; }

        public override string ToString()
        {
            return this.Suit + " : " + this.value;
        }
    }
}
