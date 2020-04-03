using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float numOne = 0;
            float numTwo = 0;
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("Type a number and press Enter!");
            numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a number and press Enter!");
            numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("Your option?");

            switch(Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your Result: {numOne} + {numTwo} = " + (numOne + numTwo));
                    break;
                case "s":
                    Console.WriteLine($"Your Result: {numOne} - {numTwo} = " + (numOne - numTwo));
                    break;
                case "m":
                    Console.WriteLine($"Your Result: {numOne} * {numTwo} = " + (numOne * numTwo));
                    break;
                case "d":
                    while (numTwo == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor");
                        numTwo = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your Result: {numOne} / {numTwo} = " + (numOne / numTwo));
                    break;
            }

            Console.WriteLine("Press any key to close the Calculator app!");
            Console.ReadKey();
        }
    }
}
