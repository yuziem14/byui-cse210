using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string name = PromptUserName();
        int squaredNumber = SquareNumber(PromptUserNumber());
        DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcomeMessage() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    
    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number) {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber) {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}