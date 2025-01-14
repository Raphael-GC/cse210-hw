using System.Collections.Generic;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (true)
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();
            int input = int.Parse(response);

            if (input == 0)
            {
                break;
            }
            else
            {
                numbers.Add(input);
            }
        } 

        int sum = numbers.Sum();
        double avg = numbers.Average();
        int largest = numbers.Max();
        int small_positive = numbers.Where(num => num > 0).Min();

        Console.WriteLine($"Total typed numbers: {numbers.Count}"); // This is a bonus by my own account ;p
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The small positive number is: {small_positive}");
        Console.WriteLine($"The sorted list is:");

        // Here's tha magic ;p
        numbers.Sort();

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

