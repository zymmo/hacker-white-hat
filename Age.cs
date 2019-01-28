using System;
using System.Globalization;

class AgeAfter10Years
{
    static void Main()
    {
        DateTime dateOfBirth = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", CultureInfo.InvariantCulture);

        DateTime presentYear = DateTime.Now;
        TimeSpan ts = presentYear - dateOfBirth;


        DateTime Age = DateTime.MinValue.AddDays(ts.Days);

        Console.WriteLine(Age.Year - 1);

        int ageAFterTen = Age.Year + 9;
        Console.WriteLine(ageAFterTen);
    }
}
