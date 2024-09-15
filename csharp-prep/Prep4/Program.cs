using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            numbers.Add(number);
        } while(number != 0);
        /** Remove 0 from the end of the list */
        numbers.RemoveAt(numbers.Count - 1);
        numbers.Sort();

        int smallestPositiveNumber = -1;

        for(int i = 0; i < numbers.Count; i++) {
            if(smallestPositiveNumber == -1 && numbers[i] >= 0) {
                smallestPositiveNumber = numbers[i];
            }
        }

        Console.WriteLine($"The sum is {numbers.Sum()}");
        Console.WriteLine($"The average is {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers[numbers.Count - 1]}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine("The sorted list is:");
        for(int i = 0; i < numbers.Count; i++) {
            Console.WriteLine(numbers[i]);
        }
    }
}