using System;

namespace DayOfTheProgrammerChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = int.TryParse(Console.ReadLine(), out int year);
            Console.WriteLine(GetDayOfProgrammer(year));
        }

        private static string GetDayOfProgrammer(int year)
        {

            if (year == 1918)
                return "26.09." + year;
            else if (year <= 1917)
            {
                if (year % 4 == 0)
                    return "12.09." + year;
                else 
                    return "13.09." + year;
            }
            else
            {
                if ( (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0) )
                    return "12.09." + year;
                else 
                    return "13.09." + year;
            }
        }
    }
}

