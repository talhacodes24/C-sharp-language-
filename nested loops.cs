    using System;

    namespace myfirstproject 
{
    class hello
    {
         static void Main(string[] args)
         {
            Console.Write("How mnay rows?:");
            int row =Convert.ToInt32(Console.ReadLine());
            
            Console.Write("How mnay coloums?:");
            int coloum =Convert.ToInt32(Console.ReadLine());
            
            Console.Write("What the symbol?:");
            string symbol = Console.ReadLine();
            
            for (int i = 0; i < row; i++)
            {
             for (int j = 0;j < coloum;j++)
             {
                  Console.Write(symbol);
             }
                Console.WriteLine();
            }
            
             Console.ReadKey();
             
                
             }
         }
    }
