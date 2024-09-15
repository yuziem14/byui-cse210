using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());
        int lastDigit = gradePercentage % 10;

        string letter = "A";
        string signal = "";
        string message = "You passed!";

        if(gradePercentage < 60) {
            letter = "F";
        } 
        else if(gradePercentage >= 60 && gradePercentage < 70) {
            letter = "D";
        }
        else if(gradePercentage >= 70 && gradePercentage < 80) {
            letter = "C";
        } else if(gradePercentage >= 80 && gradePercentage < 90) {
            letter = "B";
        }

        if(lastDigit < 3) {
            signal = "-";
        } else if(lastDigit >= 7) {
            signal = "+";
        }
        
        /** If grade is 'F' or it would be 'A+' dont set signal */
        if(gradePercentage < 60 || gradePercentage > 96) {
            signal = "";
        }

        if(gradePercentage < 70) {
            message = "Better luck next time!";
        }

        Console.WriteLine($"Your grade is: {letter}{signal}");
        Console.WriteLine(message);
    }
}