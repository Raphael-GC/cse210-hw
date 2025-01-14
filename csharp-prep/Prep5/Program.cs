using System;

class Program
{
    static void Main(string[] args)
    {
        Message();
        string name = GetName();
        double fNumber = GetNumber();
        double squaredNumber = GetSquaredNumber(fNumber);
        Message2(name, squaredNumber);

    }

    static void Message()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    
    static double GetNumber()
    {
        Console.Write("Please enter your favorite number: ");
        double favoriteNumber = Convert.ToDouble(Console.ReadLine());
        return favoriteNumber;
    }

    static double GetSquaredNumber(double favoriteNumber)
    {
        double squaredNumber =  Math.Pow(favoriteNumber, 2);
        return squaredNumber;
    }

    static void Message2(string name, double squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }
}