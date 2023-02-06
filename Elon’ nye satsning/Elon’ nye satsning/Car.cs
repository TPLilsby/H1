using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon__nye_satsning
{
    public class Car
    {
        private string _colour;
        private byte _batteryCapacity = 100;
        private int _distance = 0;

        public string Colour
        {
            get { return _colour; }

            set { _colour = value; }
        }

        public byte BatteryCapacity
        {
            get { return _batteryCapacity;}
            
            set { _batteryCapacity = value; }
        }

        public int Distance
        {
            get { return _distance;}

            set { _distance = value; }
        }

        public void Drive()
        {
            Thread.Sleep(200);
            _batteryCapacity--;
            _distance += 20;

        }
    }
}
