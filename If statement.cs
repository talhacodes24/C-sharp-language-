    using System;

    namespace myfirstproject 
{
    class hello
    {
         static void Main(string[] args)
         { 

        Console.WriteLine("Enter your age : ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 100)
        {
            Console.WriteLine("you are so old so girls don't get married you!");
         
        }
        else if(age >18)
        {
            Console.WriteLine("you can get marriage!");
            
        }
        else if(age < 0)
        {
            Console.WriteLine("you haven't been born yet for get marriage");
        }
        else {
            Console.WriteLine("you must be 21 + get marriage ");
        }
           Console.ReadKey();
             
             }
         }
    }
