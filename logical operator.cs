    using System;

    namespace myfirstproject 
{
    class hello
    {
         static void Main(string[] args)
         {
            Console.WriteLine("What's the temperaturs outside:(c)");
             double temp = Convert.ToDouble(Console.ReadLine());
             if (temp >= 10 && temp <= 25)
             {
                 Console.WriteLine("it's warm outsides!");
             }
             else if (temp <= -50 || temp >= 50)
             {
                 Console.WriteLine("do not go outisde!");
             }
             
             Console.Readkey();
                
             }
         }
    }
