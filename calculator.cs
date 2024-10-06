using System;

namespace myfirstproject
{
    class hello
    { 
    
        static int sum(int a, int b)
        {
            return a + b;
        }
        static int subtraction(int a, int b)
        {
            return a - b;
        }
        static int multiplication(int a, int b)
        {
            return a * b;
        }
        static int division(int a, int b)
        {
            return a / b;
        }



        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operator(+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine(sum(a, b));
            
            }
            else if (op == '-')
            {
                Console.WriteLine(subtraction(a, b));
            }
            else if (op == '*')
            {
                Console.WriteLine(multiplication(a, b));
            }
            else if (op == '/')
            {
                Console.WriteLine(division(a, b));
            }
            else
            {
                Console.WriteLine("Invalid output");
            }
        }
    }
}