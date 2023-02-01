
class Program
{
    public static void Main(string[] args)
    { 

        Console.WriteLine("Indtast et ord:");
        string word = Console.ReadLine();

        Console.WriteLine(CalculatePoints(word));
     }

    public static int CalculatePoints(string word)
    {
        int points = 0;

        char[] charArr = word.ToCharArray();

        foreach (char ch in charArr)
        {
           switch (ch)
            {
                case 'a':
                    points += 1;
                    break;

                case 'b':
                    points += 3;
                    break;

                case 'c':
                    points += 8;
                    break;

                case 'd':
                    points += 2;
                    break;

                case 'e':
                    points += 1;
                    break;

                case'f':
                    points += 3;
                    break;

                case 'g':
                    points += 3;
                    break;

                case 'h':
                    points += 4;
                    break;

                case 'i':
                    points += 3;
                    break;

                case 'j':
                    points += 4;
                    break;

                case 'k':
                    points += 3;
                    break;

                case 'l':
                    points += 2;
                    break;

                case 'm':
                    points += 3;
                    break;

                case 'n':
                    points += 1;
                    break;

                case 'o':
                    points += 2;
                    break;

                case 'p':
                    points += 4;
                    break;

                case 'q':
                    points += 8;
                    break;

                case 'r':
                    points += 1;
                    break;

                case 's':
                    points += 2;
                    break;

                case 't':
                    points += 2;
                    break;

                case 'u':
                    points += 3;
                    break;

                case 'v':
                    points += 3;
                    break;

                case 'w':
                    points += 8;
                    break;

                case 'x':
                    points += 8;
                    break;

                case 'y':
                    points += 4;
                    break;

                case 'z':
                    points += 8;
                    break;

                case 'æ':
                    points += 4;
                    break;

                case 'ø':
                    points += 4;
                    break;

                case 'å':
                    points += 4;
                    break;
            }
        }

        return points;

    }
}
