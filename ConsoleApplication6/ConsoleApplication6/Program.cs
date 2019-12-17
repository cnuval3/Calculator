using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int result = 0;
            char op;

            do
            {
                Console.Write("Please enter your number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("What do you want to do? (+, -, *, /, %): ");
                op = char.Parse(Console.ReadLine());
                Console.Write("Please enter another number: ");
                num2 = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '%':
                        result = num1 * num2;
                        break;
                }
                Console.WriteLine("The result is " + result);
                Console.WriteLine("Do you want to compute again? [y/n]");
                char response = char.Parse(Console.ReadLine());
                if (response == 'n')
                {
                    break;
                }
                Console.ReadKey();
            } while (true);
        }
    }
}

