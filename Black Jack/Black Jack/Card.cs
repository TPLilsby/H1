using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    //Create a struct
    public struct Card
    {
        //Varibles
        string suit = "";
        byte value = 0;
        byte point = 0;

        //Cunstructor
        public Card(string suit, byte value, byte point)
        {
            Suit = suit;
            Value = value;
            Point = point;
        }

        //Get & Get
        public string Suit { get => suit; set => suit = value; }

        public byte Value { get => value; set => this.value = value; }
        public byte Point { get => point; set => point = value; }

        //Return a string
        public override string ToString()
        {
            return this.Suit + " : " + this.value;
        }
    }
}
