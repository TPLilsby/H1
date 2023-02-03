/*
    for (int j = 1; j <= 13; j++)
    {
    DateTime date = new DateTime(DateTime.Today.Year + 1, j, 13);

        if (date.DayOfWeek == DayOfWeek.Friday)
        {
            Console.WriteLine(date.ToString("dd\\t\\h MMMM yyyy") + " Is a friday");
        }
    }
*/

int year = 2023;
for (int y = 0; y <= 10; y++)
{
    for (int m = 1; m <= 12; m++)
    {
        DateTime date = new DateTime(year, m, 13);

        if (date.DayOfWeek == DayOfWeek.Friday)
        {
            Console.WriteLine(date.ToString("dd\\t\\h MMMM yyyy") + " Is a friday");
        }
    }
    year++;
}