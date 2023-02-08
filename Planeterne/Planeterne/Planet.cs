using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    //Planet class
    public class Planet
    {
        //Varibles to the planet
        public string name;
        public double mass;
        public double diameter;
        public int density;
        public double gravity;
        public double rotationPeriod;
        public double lengthOfDay;
        public double distanceFromSun;
        public double orbitalPeriod;
        public double orbitalVelocity;
        public int meanTemperature;
        public byte numberOfMoons;
        public bool ringSystem;

        //make get & set to varibles
        public string Name { get; set; }
        public double Mass { get; set; }
        public double Diameter { get; set; }
        public int Density { get; set; }
        public double Gravity { get; set; }
        public double RotationPeriod { get; set; }
        public double LengthOfDay { get; set; }
        public double DistanceFromSun { get; set; }
        public double OrbitalPeriod { get; set; }
        public double OrbitalVelocity { get; set; }
        public int MeanTemperature { get; set; }
        public byte NúmberOfMoons { get; set; }
        public bool RingSystem { get; set; }

        //Cunstructor
        public Planet(string Name, double Mass, double Diameter, int Density, double Gravity,
        double RotationPeriod, double LengthOfDay, double DistanceFromSun, double OrbitalPeriod,
        double OrbitalVelocity, int MeanTemperature, byte NumberOfMoons, bool RingSystem)
        {
            name = Name;
            mass = Mass;
            diameter = Diameter;
            density = Density;
            gravity = Gravity;
            rotationPeriod = RotationPeriod;
            lengthOfDay = LengthOfDay;
            distanceFromSun = DistanceFromSun;
            orbitalPeriod = OrbitalPeriod;
            orbitalVelocity = OrbitalVelocity;
            meanTemperature = MeanTemperature;
            numberOfMoons = NumberOfMoons;
            ringSystem = RingSystem;
        }
    }
}
