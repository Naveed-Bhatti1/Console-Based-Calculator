using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");

            Console.Write("Choose an operation: +, -, *, /, %, ^, sqrt");
            string operation = Console.ReadLine();

            double num1 = 0, num2 = 0, result = 0;

            if (operation == "sqrt")
            {
                Console.Write("Enter the number for square root:");
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            else if ( operation == "^")
            {
                Console.Write("Enter the Exponent:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Base:");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.Write("Enter the first number:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number:");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    break;

                case "%":
                    if (num2 != 0)
                        result = num1 % num2;
                    else
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    break;
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                case "sqrt":
                    if (num1 >= 0)
                        result = Math.Sqrt(num1);
                    else
                        Console.WriteLine("Error: Cannot take the square root of a negative number.");
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            if (operation != "sqrt")
            {
                Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
            }
            else
                {
                Console.WriteLine($"The square root of {num1} is: {result}");
            }
        }
    }
}
