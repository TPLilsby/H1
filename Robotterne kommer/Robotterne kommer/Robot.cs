using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotterne_kommer
{
    //Robot class
    public class Robot
    {
        //Difining varibles
        private string type;
        private byte size;
        private string colour;
        private string microchip;
        private bool wifi;
        private byte batteryCapacity;
        private double soapCapacity;
        private byte wheel;

        //Make so you can get and set them
        public string Type { get; set; }
        public byte Size { get; set; }
        public string Colour { get; set; }
        public string Microchip { get; set; }
        public bool Wifi { get; set; }
        public byte BatteryCapacity { get; set; }
        public double SoapCapacity { get; set; }
        public byte Wheel { get; set; }
        
        //Deafult Cunstroctor
        public Robot()
        {
            Colour = "white";
        }

        //Cunstructor 1 : taking from default constructor
        public Robot(string colour, byte batteryCapacity) : this()
        {
            BatteryCapacity = batteryCapacity;
            Colour = colour;

        }

        //Cunstructor 2 : Cunstructor 1
        public Robot(string type, string colour, byte batteryCapacity) : this(colour, batteryCapacity)
        {
            Type = type;
        }

        //Cunstructor 3 : Cunstructor 2
        public Robot(string type, string colour, byte batteryCapacity, byte size) : this(type, colour, batteryCapacity)
        {
            Size = size;
        }

        //Cunstructor 4 : Cunstructor 3 
        public Robot(string type, string colour, byte size, string microchip) : this(type, colour, size)
        {
            Microchip = microchip;
        }

        //Cunstructor 5 : Cunstructor 4
        public Robot(string type, string colour, byte size, string microchip, bool wifi) : this(type, colour, size, microchip)
        {
            Wifi = wifi;
        }

        //Cunstructor 6 : Cunstructor 5
        public Robot(string type, string colour, byte size, string microchip, bool wifi, double soapCapacity) : this(type, colour, size, microchip, wifi)
        {
            SoapCapacity = soapCapacity;
        }

        //Cunstructor 7 : Cunstructor 6
        public Robot(string type, string colour, byte size, string microchip, bool wifi, double soapCapacity, byte wheel) : this(type, colour, size, microchip, wifi, soapCapacity)
        {
            wheel = Wheel;


        }

    }
}
