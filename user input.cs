 using System;

    namespace myfirstproject 
{
    class hello
    {
         static void Main(string[] args)
         {
        Console.WriteLine("what's your name ?");
        string name = Console.ReadLine();
        Console.WriteLine("what's your age ?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" hello " + name);
        Console.WriteLine("your are "+ age + " years old");




             Console.ReadKey();

                
             }
         }
    }
