using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("--------------------------\n");

            while (!endApp)
            {
                string numInputOne = "";
                string numInputTwo = "";
                double result = 0;

                Console.WriteLine("Type a number and press enter!");
                numInputOne = Console.ReadLine();

                double cleanNumOne = 0;

                while (!double.TryParse(numInputOne, out cleanNumOne))
                {
                    Console.WriteLine("This is not a valid input. Please enter an integer value.");
                    numInputOne = Console.ReadLine();
                }

                Console.WriteLine("Type another number and press enter!");
                numInputTwo = Console.ReadLine();

                double cleanNumTwo = 0;

                while (!double.TryParse(numInputTwo, out cleanNumTwo))
                {
                    Console.WriteLine("This is not a valid input. Please enter an integer value.");
                    numInputTwo = Console.ReadLine();
                }

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("Your option?");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNumOne, cleanNumTwo, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error!\n");
                    }
                    else
                    {
                        Console.WriteLine("Your result: {0:0.##}\n", result);
                    }
                }

                catch(Exception e)
                {
                    Console.WriteLine("Oh no, an exception occurred trying to do the math!\n-Details: " + e.Message);
                }

                Console.WriteLine("--------------------------\n");
                Console.WriteLine("Press 'n' and Enter to close the app or press any other key to continue");

                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                }

                Console.WriteLine("\n");
            }
            return;
        }
    }
}
