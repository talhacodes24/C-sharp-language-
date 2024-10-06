    using System;

    namespace myfirstproject 
{
    class hello
    {
         static void Main(string[] args)
         {
           Random random = new Random ();

           bool PlayAgain = true;

           int min = 1;

           int max = 100;

           int guess;

           int number;
           
           int guesses;
           string response;
           while (PlayAgain)
           {
                guess = 0;
                number= random.Next(min,max+1);
                guesses =0;
                response = "";
                  
            while (guess != number)
            {
              Console.WriteLine("Guess a number between "+ min +"-" + max +" : ");

              guess =Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("guess: " + guess);

              if (guess > number)
              {
                  Console.WriteLine(guess+" is to high!");
              }
              else if (guess < number)
              {
                  Console.WriteLine(guess + " is to low!");
              }
              guesses++;
            }
            Console.WriteLine("Number:" + number);

            Console.WriteLine("You Win!");

            Console.WriteLine("guesses: "+ guesses);

            Console.WriteLine("Would you like to play again (Y/N):");

            response = Console.ReadLine();
           }
             Console.WriteLine("thanks for playing!... I guess");
             
                
             }
         }
    }
