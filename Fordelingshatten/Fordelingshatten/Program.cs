public class SortingHat
{
    public enum Colleges { Gryffindor, Hufflepuff, Ravenclaw, Slytherin }

    public static void Main(string[] args)
    {
        SortingHat hat = new SortingHat();

        Console.WriteLine(hat.Sort());
    }

    public Colleges Sort()
    {
            Random random = new Random();
            int number = random.Next(1, 5);

            if (number == 1)
            {
                return Colleges.Gryffindor;
            }
            else if (number == 2)
            {
                return Colleges.Hufflepuff;
            }
            else if (number == 3)
            {
                return Colleges.Ravenclaw;
            }
            else
            {
                return Colleges.Slytherin;
            }
    }
}