using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        Scripture scripture = library.GetRandomScripture();

        string input = "";
        bool quited = false;

        Console.WriteLine(scripture.GetDisplayText());
        do {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            quited = input.ToLower().Equals("quit");

            if(!quited) {
                scripture.HideRandomWords(3);
            }
            Console.Clear();
            Console.WriteLine(quited);
            Console.WriteLine(scripture.GetDisplayText());
        } while(!quited && !scripture.IsCompletelyHidden());
    }
}