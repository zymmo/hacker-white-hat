using System;


namespace Conditional_statements
{
    class Exchange_If_greater
    {
        static void Main()
        {
            Decimal number1;
            Decimal number2;

            number1 = Decimal.Parse(Console.ReadLine());
            number2 = Decimal.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("{0} {1}", number2, number1);
            }
            else {
                Console.WriteLine("{0} {1}", number1, number2);
            }


        }
    }
}
