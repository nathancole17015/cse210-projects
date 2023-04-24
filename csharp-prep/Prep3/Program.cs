using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");



        
        int magicNumber;
        Random randomGenerator = new Random();
         magicNumber = randomGenerator.Next(1, 100);;
         

           int guess = -1;
         
         while (guess != magicNumber){
             
             Console.Write("What is your guess? ");
             guess = int.Parse(Console.ReadLine());

            if(guess < magicNumber){
                Console.WriteLine("guess is too low!");
            }

            else if(guess > magicNumber ){

                Console.WriteLine("guess is too high!");

            }

         }
         Console.Write("You guessed it!");
        

        
    }
}