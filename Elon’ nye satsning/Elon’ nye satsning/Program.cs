using Elon__nye_satsning;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Car car1 = new Car();


        car.Colour = "Blå";
        string carColour = car.Colour;

        car1.Colour = "Rød";
        string car1Volour = car1.Colour;

        Console.WriteLine(CarDriving(car));
        Console.WriteLine(CarDriving(car1));

    }

    public static string CarDriving(Car c)
    {
        bool notStop = true;
        string message = "";

        while (notStop)
        {
            if (c.BatteryCapacity == 0)
            {
                notStop = false;
                message = "Kan ikke kører mere";
                
            }
            Console.WriteLine("Pres a key: ");
            Console.ReadKey();

            c.Drive();
            Console.WriteLine("Den " + c.Colour + " bil har kørt: " + c.Distance + " meter og har: " + c.BatteryCapacity + "% tilbage");
        }
        return message;
    }
}
