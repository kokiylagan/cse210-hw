using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicnumber)
        {
            Console.WriteLine("  What is your guess?");
            guess  = int.Parse(Console.ReadLine());

            if (magicnumber > guess)
            {
                Console.WriteLine("Higher!");
            }
            
            else if (magicnumber < guess)
            {
                Console.WriteLine("Lower!");
            }
            
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}