    using System;

    namespace myfirstproject 
{
    class hello
    {
         static void Main(string[] args)
         {
            
        Console.Write("Enter your name :");
        string name = Console.ReadLine();
        while ( name == "")
        {
            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();
        }
            Console.WriteLine(" Hello " + name );
            
             Console.ReadKey();
             
                
             }
         }
    }
