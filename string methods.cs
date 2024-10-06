    using System;

    namespace myfirstproject 
{
    class hello
    {
         static void Main(string[] args)
         {
             string fullName = "Abu Talha";
             string phoneNumber = "013-456-789";
             //fullName = fullname.Toupper();
             //fullName = fullName.TpLower();
            //Console.WriteLine(fullname);
            // phoneNumber = phoneNumber.Replace("-"," ");
            // Console.WriteLine(phoneNumber);
             //string userName = fullName.Insert(0,"Mr.");
             //Console.WriteLine(userName);
             //Console.WriteLine(fullName.Length);
             string firstName = fullName.Substring(0,3);
             string lastName = fullName.Substring(4,7);
             
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

             Console.ReadKey();
             
                
             }
         }
    }
