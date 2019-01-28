using System;


namespace Console_Input_Output
{
    class Sum_of_3
    {
        static void Main()
        {
            Decimal a;
            Decimal b;
            Decimal c;

            a = Decimal.Parse(Console.ReadLine());
            b = Decimal.Parse(Console.ReadLine());
            c = Decimal.Parse(Console.ReadLine());

            Console.WriteLine(a+b+c);
        }

    }
}
