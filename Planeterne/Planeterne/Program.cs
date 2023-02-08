using Planeterne;
using System.Numerics;

//Program class
public class Program
{
    //Main method
    public static void Main(string[] args)
    {
        //Insert data to the planet
        Planet mercury = new Planet("Mercury", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false);
        Planet venus = new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false);
        Planet earth = new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false);
        Planet mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
        Planet jupiter = new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
        Planet saturn = new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, true);
        Planet uranus = new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, true);
        Planet neptune = new Planet("Neptune", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true);
        Planet pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false);

        //2. makes list with the planets
        List<Planet> planets = new List<Planet>();

        //Add the planets
        planets.Add(mercury);
        planets.Add(earth);
        planets.Add(mars);
        planets.Add(jupiter);
        planets.Add(saturn);
        planets.Add(uranus);
        planets.Add(neptune);
        planets.Add(pluto);

        //4. Insert Venus
        planets.Insert(1, venus);

        //6. Remove pluto
        planets.Remove(pluto);

        //7. Insert pluto again
        planets.Add(pluto);

        //8. Print planet count
        Console.WriteLine("Number of planets: " + planets.Count());

        //9. Find planets with a mean temperature under 0
        List<Planet> planetTemperature = new List<Planet>();

        //Loops through all planets to find the planets
        foreach (Planet planet in planets)
        {
            if (planet.meanTemperature < 0)
            {
                planetTemperature.Add(planet);
            }
        }

        //Prnt the planets with a mean temperature under 0
        Console.WriteLine("\nPlanets with a mean temperature under 0");
        foreach (Planet planet in planetTemperature)
        {
            Console.WriteLine("Name: " + planet.name + " - Temp: " + planet.meanTemperature);
        }

        //10. Find planets with a diameter over 10000 and under 50000
        List<Planet> planetDiameter = new List<Planet>();

        //Loops through all planets to find the planets with the diameter
        foreach (Planet planet in planets)
        {
            if (planet.diameter > 10000 && planet.diameter < 50000)
            {
                planetDiameter.Add(planet);
            }
        }

        //Print planets with a diameter over 10000 and under 50000
        Console.WriteLine("\nPlanets with a diameter over 10000 and under 50000");
        foreach (Planet planet in planetDiameter)
        {
            Console.WriteLine("Planet Name: " + planet.name + " - Diameter: " + planet.diameter);
        }

        //11. Remove all planets
        planets.Clear();

        //2. Print list with planets
        Console.WriteLine("\nPlanet names:");
        foreach (Planet planet in planets)
        {
            Console.WriteLine(planet.name);
        }
    }
}