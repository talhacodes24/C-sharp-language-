using System;

    namespace myfirstproject 
{
    class hello
    {
         static void Main(string[] args)
         {

        // type casting: type casting converting a value to a different data type useful when we accept 
        // user input(string)different data types can do different things
          
        double a = 3.14;
        int b = Convert.ToInt32(a);
        int c = 123;
        double d = Convert.ToDouble(c);
        int e = 321;
        string f = Convert.ToString(e);
        string g = "$";
        char h = Convert.ToChar(g);
        string i = "true";
        bool j = Convert.ToBoolean(i);

            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(h);
             Console.WriteLine(j);
             Console.ReadKey();
            
                
             }
         }
    }