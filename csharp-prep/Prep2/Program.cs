using System;

class Program
{  
    static void Main(string[] args)
    {
        Console.Write("Please insert your grade (%): ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);

        string letter;
        string sign = "";

        if (grade >= 90)
            letter = "A";
        else if (grade >= 80)
            letter = "B";
        else if (grade >= 70)
            letter = "C";
        else if (grade >= 60)
            letter = "D";
        else
            letter = "F";

        int remainder = grade % 10;
        if (remainder >= 7 && letter != "A" && letter != "F")
            sign = "+";
        else if (remainder <= 3 && letter != "F")
            sign = "-";

        Console.WriteLine($"Your letter is {letter}{sign}");
        if (grade >= 70)
            Console.WriteLine("Congratulations!! You pass the class!");
        else
            Console.WriteLine("Sorry, but you have to try hard next year!");
    }
}
