using Robotterne_kommer;

//Program class
public class Program
{
    //Main method
    static void Main(string[] args)
    {   
        //Creating a robot object
        Robot r = new Robot();

        //Set's the type of robot
        Console.WriteLine("Set type");
        string setType = Console.ReadLine();
        r.Type = setType;

        //Depending on the type, the soap is set
        if (setType == "cleaningrobot")
        {
            r.SoapCapacity = 2.3;
        }
        else
        {
            r.SoapCapacity = 0;
        }

        //Set's the colour on the robot
        Console.WriteLine("\nSet colour (Make a space and press enter for no colour)");
        string setColour = Console.ReadLine();

        //Depending on the colour, the battery capacity is set
        if (setColour == " " || setColour == "white")
        {
            r.BatteryCapacity = 255;
        }
        else
        {
            r.Colour = setColour;
            r.BatteryCapacity = 0;
        }

        //Set's the size of the robot
        Console.WriteLine("\nSet size");
        byte setSize = byte.Parse(Console.ReadLine());
        r.Size = setSize;

        //Depending on the size, the number of wheels is set
        if (r.Size == 1)
        {
            r.Wheel = 0;
        } else if (r.Size == 2)
        {
            r.Wheel = 4;
        } else if (r.Size == 3)
        {
            r.Wheel = 6;
        }

        //Set's the microchip
        Console.WriteLine("\nSet microchip");
        string setMicrochip = Console.ReadLine();
        r.Microchip = setMicrochip;

        //Set's the wifi
        Console.WriteLine("\nShall it have wifi or not? (Yes/Y | No/N)");
        char setWifi = char.Parse(Console.ReadLine());

        //Define if it have or not have wifio
        if (setWifi == 'y')
        {
            r.Wifi = true;
        } else if (setWifi == 'n')
        {
            r.Wifi = false;
        }

        //Writing out the robot specifications
        Console.WriteLine("\nRobot is made:");

        Console.WriteLine("Type: " + r.Type);

        Console.WriteLine("Colour: " + r.Colour);

        Console.WriteLine("Microchip:" + r.Microchip);

        Console.WriteLine("Wifi status: " + r.Wifi);

        Console.WriteLine("Wheels: " + r.Wheel);

        Console.WriteLine("Battery: " + r.BatteryCapacity);
         
        Console.WriteLine("Soap: " + r.SoapCapacity);
    }
}
