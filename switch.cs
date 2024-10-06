    using System;

    namespace myfirstproject 
{
    class hello
    {
         static void Main(string[] args)
         {
            Console.WriteLine("What day is it today?");
            string day = Console.ReadLine();
            switch (day)
             {
                case "Monday":
                Console.WriteLine("today is monday!");
                break;
                case "tuesday":
                Console.WriteLine("today is tuesday!");
                break;
                case "wednesday":
                Console.WriteLine("today is wednesday!");
                break;
                case "thusday":
                Console.WriteLine("today is thusday!");
                break;
                case "sunday":
                Console.WriteLine("today is sunday!");
                break;
                default:
                Console.WriteLine( day + " is not a day!");
                break;
             }
             
             
                
             }
         }
    }
