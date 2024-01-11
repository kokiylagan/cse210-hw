using System;

class Program
{
    static void Main(string[] args)
    {    //list
        List<int> numbers = new List<int>();

        int userNumber=-1;
        while (userNumber !=0)
            {

                Console.WriteLine("Enter a list of numbers, type 0 when finished");
       
                string userResponse = Console.ReadLine();
                userNumber= int.Parse(userResponse);

                if (userNumber != 0)
                    {
                        numbers.Add(userNumber);
                    }
            }
        //sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //average
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");


        


    }
}